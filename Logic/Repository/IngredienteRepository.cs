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
    public class IngredienteRepository : IRepository<Ingrediente>
    {
        ManagerData managerData;
        public IngredienteRepository()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["BartTenderDB"].ConnectionString;
            managerData = new ManagerData(ConnectionString);
        }
        public async Task<bool> Add(Ingrediente entity)
        {
            bool result = false;
            try
            {
                string query = $@"Insert into Ingredientes(ProductoId,Nombre,Unidad,Cantidad)values('{entity.ProductoId}','{entity.Nombre}','{entity.Unidad}','{entity.Cantidad}')";
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
                string query = $@"Delete from Ingredientes  where Id = {Id}";
                result = await managerData.Execute(query);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return result;
        }

        public async Task<IEnumerable<Ingrediente>> Get(int Id)
        {
            var Ingredientes = new List<Ingrediente>();
            try
            {
                string query = $@"Select Id,ProductoId,Nombre,Unidad,Cantidad from  Ingredientes where Activo = 1 and Id = {Id}";
                var dt = await managerData.getTable(query);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        Ingredientes.Add(new Ingrediente
                        {
                            Id = Convert.ToInt32(r["Id"]),
                            ProductoId = Convert.ToInt32(r["ProductoId"]),
                            Nombre = r["Nombre"].ToString(),
                            Unidad = r["Unidad"].ToString(),
                            Cantidad = Convert.ToDecimal(r["Cantidad"])

                        });
                    }

                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return Ingredientes;
        }

        public async Task<IEnumerable<Ingrediente>> GetWithProduct(int ProductId)
        {
            var Ingredientes = new List<Ingrediente>();
            try
            {
                string query = $@"Select Id,ProductoId,Nombre,Unidad,Cantidad from  Ingredientes where Activo = 1 and ProductoId = {ProductId}";
                var dt = await managerData.getTable(query);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        Ingredientes.Add(new Ingrediente
                        {
                            Id = Convert.ToInt32(r["Id"]),
                            ProductoId = Convert.ToInt32(r["ProductoId"]),
                            Nombre = r["Nombre"].ToString(),
                            Unidad = r["Unidad"].ToString(),
                            Cantidad = Convert.ToDecimal(r["Cantidad"])

                        });
                    }

                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return Ingredientes;
        }

        public async Task<IEnumerable<Ingrediente>> GetAll()
        {
            var Ingredientes = new List<Ingrediente>();
            try
            {
                string query = $@"Select Id,ProductoId,Nombre,Unidad,Cantidad from  Ingredientes where Activo = 1";
                var dt = await managerData.getTable(query);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        Ingredientes.Add(new Ingrediente
                        {
                            Id =Convert.ToInt32(r["Id"]),
                            ProductoId = Convert.ToInt32(r["ProductoId"]),
                            Nombre = r["Nombre"].ToString(),
                            Unidad = r["Unidad"].ToString(),
                            Cantidad = Convert.ToDecimal(r["Cantidad"])

                        });
                    }

                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return Ingredientes;
        }

        public async Task<bool> Save(Ingrediente entity)
        {
            bool result = false;
            try
            {
                string query = $@"Update Ingredientes set Nombre = '{entity.Nombre}',Unidad = '{entity.Unidad}',Cantidad = '{entity.Cantidad}' where Id = {entity.Id}";
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
