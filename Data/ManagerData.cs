using Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ManagerData:IManagerData
    {
        SQLiteConnection conn;
        private readonly string _conString;

        public ManagerData(string conString)
        {
            _conString = conString;
            
        }

        public void CrearBaseDatos(string name)
        {
            SQLiteConnection.CreateFile(name+".db");
        }


        public async Task<bool> Connect()
        {
            conn = new SQLiteConnection(_conString);

            if (conn.State == ConnectionState.Open)
            {
                return true;
            }
            else
            {
                try
                {
                    await conn.OpenAsync();
                    return true;
                }
                catch (SQLiteException ex)
                {
                    Console.Write(ex.Message);
                    return false;
                }

            }
        }

        public async Task<bool> Execute(string storedProcedure, List<sqlParameters> List)
        {
            bool response = false;
            if (await Connect())
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = storedProcedure;
                    cmd.CommandTimeout = 100;

                    if (List != null || List.Count > 0)
                    {
                        foreach (sqlParameters p in List)
                        {
                            cmd.Parameters.AddWithValue(p.ParameterName, p.Value.ToString());
                        }
                    }
                    try
                    {
                        await cmd.ExecuteNonQueryAsync();

                        response = true;
                    }
                    catch (SQLiteException ex)
                    {
                        Console.Write(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

            return response;
        }

        public async Task<bool> Execute(string query)
        {
            bool response = false;
            if (await Connect())
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.CommandTimeout = 100;

                    try
                    {
                        await cmd.ExecuteNonQueryAsync();

                        response = true;
                    }
                    catch (SQLiteException ex)
                    {
                        Console.Write(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

            return response;
        }

        public async Task<DataTable> getTable(string query)
        {
            DataTable Dataset = new DataTable();

            if (await Connect())
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.CommandTimeout = 100;

                    try
                    {
                        dataAdapter.SelectCommand = cmd;
                        dataAdapter.Fill(Dataset);
                        conn.Close();
                        return Dataset;
                    }
                    catch (SQLiteException ex)
                    {
                        Console.Write(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            return null;
        }

        public async Task<DataTable> getTable(string storedProcedure, List<sqlParameters> List)
        {
            DataTable Dataset = new DataTable();

            if (await Connect())
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = storedProcedure;

                    cmd.CommandTimeout = 100;

                    if (List != null || List.Count > 0)
                    {
                        foreach (sqlParameters p in List)
                        {
                            cmd.Parameters.AddWithValue(p.ParameterName, p.Value.ToString());
                        }
                    }

                    try
                    {
                        dataAdapter.SelectCommand = cmd;
                        dataAdapter.Fill(Dataset);
                        conn.Close();
                        return Dataset;
                    }
                    catch (SQLiteException ex)
                    {
                        Console.Write(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            return null;

        }
    }
}
