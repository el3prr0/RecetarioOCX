using Data;
using Logic.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Repository
{
    public class UnidadRepository : IRepository<Unidad>
    {
        ManagerData managerData;
        public UnidadRepository()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["BartTenderDB"].ConnectionString;
            managerData = new ManagerData(ConnectionString);
        }
        public async Task<bool> Add(Unidad entity)
        { 
            bool response = false;
            try {
                string query = $"insert into Unidad(Nombre,Valor) values ('{entity.Nombre}','{entity.Valor}')";
                response = await managerData.Execute(query);
            } catch(Exception ex)
            {
                Console.Write(ex.Message);
            }
            return response;
        }

        public async Task<bool> Delete(int Id)
        {
            bool response = false;
            try
            {
                string query = $"Delete from Unidad where Id = {Id}";
                response = await managerData.Execute(query);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return response;
        }

        public async Task<IEnumerable<Unidad>> Get(int Id)
        {
            var Unidades = new List<Unidad>();
            try
            {
                string query = $"select Nombre,Valor from Unidad where Id={Id}  Activo = 1";
                var dt = await managerData.getTable(query);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        Unidades.Add(new Unidad { Nombre = r["Nombre"].ToString(), Valor = Convert.ToInt32(r["Valor"]) });

                    }
                }
            }
            catch (Exception ex)
            { Console.Write(ex.Message); }
            return Unidades;
        }

        public async Task<IEnumerable<Unidad>> Get(string Nombre)
        {
            var Unidades = new List<Unidad>();
            try
            {
                string query = $"select Id,Nombre,Valor from Unidad where Nombre like '{Nombre}%' Activo = 1";
                var dt = await managerData.getTable(query);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        Unidades.Add(new Unidad { Id = Convert.ToInt32(r["Id"]), Nombre = r["Nombre"].ToString(), Valor = Convert.ToInt32(r["Valor"]) });

                    }
                }
            }
            catch (Exception ex)
            { Console.Write(ex.Message); }
            return Unidades;
        }

        public async Task<IEnumerable<Unidad>> GetAll()
        {
            var Unidades = new List<Unidad>();
            try
            {
                string query = "select Id, Nombre,Valor from Unidad where Activo = 1";
                var dt = await managerData.getTable(query);
                if(dt.Rows.Count > 0)
                {
                    foreach(DataRow r in dt.Rows)
                    {
                        Unidades.Add(new Unidad { Id = Convert.ToInt32(r["Id"]), Nombre = r["Nombre"].ToString(), Valor = Convert.ToInt32(r["Valor"]) });

                    }
                }
            }
            catch (Exception ex)
            { Console.Write(ex.Message); }
            return Unidades;
        }

        

        public async Task<bool> Save(Unidad entity)
        {
            bool response = false;
            try
            {
                string query = $"Update Unidad set Nombre='{entity.Nombre}',Valor='{entity.Valor}' where Id = {entity.Id}";
                response = await managerData.Execute(query);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return response;
        }
    }
}
