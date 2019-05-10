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
    public class InstruccionRepository : IRepository<Instruccion>
    {
        ManagerData managerData;
        public InstruccionRepository()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["BartTenderDB"].ConnectionString;
            managerData = new ManagerData(ConnectionString);
        }
        public async Task<bool> Add(Instruccion entity)
        {
            bool result = false;
            try
            {
                string query = $@"Insert into Instrucciones(ProductoId,Paso)values('{entity.ProductoId}','{entity.Paso}')";
                result = await managerData.Execute(query);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return result;
        }

        public async Task<bool> Delete(int Id)
        {
            bool result = false;
            try
            {
                string query = $@"Delete from Instrucciones where Id = {Id}";
                result = await managerData.Execute(query);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return result;
        }

        public async Task<IEnumerable<Instruccion>> Get(int Id)
        {
            var Instrucciones = new List<Instruccion>();
            try
            {
                string query = $@"Select Id,ProductoId,Paso from  Instrucciones where Activo = 1 and Id = {Id}";
                var dt = await managerData.getTable(query);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        Instrucciones.Add(new Instruccion
                        {
                            Id = Convert.ToInt32(r["Id"]),
                            ProductoId = Convert.ToInt32(r["ProductoId"]),
                            Paso = r["Paso"].ToString()
                        });
                    }

                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return Instrucciones;
        }

        public async Task<IEnumerable<Instruccion>> GetWithProduct(int ProductId)
        {
            var Instrucciones = new List<Instruccion>();
            try
            {
                string query = $@"Select Id,ProductoId,Paso,Activo from  Instrucciones where Activo = 1 and ProductoId = {ProductId}";
                var dt = await managerData.getTable(query);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        Instrucciones.Add(new Instruccion
                        {
                            Id = Convert.ToInt32(r["Id"]),
                            ProductoId = Convert.ToInt32(r["ProductoId"]),
                            Paso = r["Paso"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return Instrucciones;
        }

        public async Task<IEnumerable<Instruccion>> GetAll()
        {
            var Instrucciones = new List<Instruccion>();
            try
            {
                string query = $@"Select Id,ProductoId,Paso,Activo from  Instrucciones where Activo = 1";
                var dt = await managerData.getTable(query);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        Instrucciones.Add(new Instruccion
                        {
                            Id = Convert.ToInt32(r["Id"]),
                            ProductoId = Convert.ToInt32(r["ProductoId"]),
                            Paso = r["Paso"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return Instrucciones;
        }

        public async Task<bool> Save(Instruccion entity)
        {
            bool result = false;
            try
            {
                string query = $@"Update Instrucciones set ProductoId = '{entity.ProductoId}',Paso= '{entity.Paso}' where Id = {entity.Id}";
                result = await managerData.Execute(query);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return result;
        }
    }
}
