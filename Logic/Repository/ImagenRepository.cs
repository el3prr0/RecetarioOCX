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
    public class ImagenRepository : IRepository<Imagen>
    {
        ManagerData managerData;
        public ImagenRepository()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["BartTenderDB"].ConnectionString;
            managerData = new ManagerData(ConnectionString);
        }
        public async Task<bool> Add(Imagen entity)
        {
            bool result = false;
            try
            {
                string query = $@"Insert into Imagenes(ProductoId,Url,Principal,Nombre)values('{entity.ProductoId}','{entity.Url}','{entity.Principal}','{entity.Nombre}')";
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
                string query = $@"Delete from Imagenes where Id='{Id}'";
                result = await managerData.Execute(query);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return result;
        }

        public async Task<IEnumerable<Imagen>> Get(int Id)
        {
            var Imagenes = new List<Imagen>();
            try
            {
                string query = $@"Select Id,ProductoId,Url,FechaCreacion,Principal from  Imagenes where Activo = 1 and Id = {Id}";
                var dt = await managerData.getTable(query);
                if(dt.Rows.Count > 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        Imagenes.Add(new Imagen
                        {
                            Id = Convert.ToInt32(r["Id"]),
                            ProductoId = Convert.ToInt32(r["ProductoId"]),
                            Url = r["Url"].ToString(),
                            fechaCreacion = Convert.ToDateTime(r["FechaCreacion"]),
                            Principal = Convert.ToBoolean(r["Principal"]),
                            Nombre = r["Nombre"].ToString()
                        });
                    }
                }
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);
            }
            return Imagenes;
        }

        public async Task<IEnumerable<Imagen>> GetWithProduct(int ProductoId)
        {
            var Imagenes = new List<Imagen>();
            try
            {
                string query = $@"Select Id,ProductoId,Url,Nombre,FechaCreacion,Principal from Imagenes where Activo = 1 and ProductoId = {ProductoId}";
                var dt = await managerData.getTable(query);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        Imagenes.Add(new Imagen
                        {
                            Id = Convert.ToInt32(r["Id"]),
                            ProductoId = Convert.ToInt32(r["ProductoId"]),
                            Url = r["Url"].ToString(),
                            fechaCreacion  = Convert.ToDateTime(r["FechaCreacion"]),
                            Principal = Convert.ToBoolean(r["Principal"]),
                            Nombre = r["Nombre"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return Imagenes;
        }

        public async  Task<IEnumerable<Imagen>> GetAll()
        {
            var Imagenes = new List<Imagen>();
            try
            {
                string query = $@"Select Id,ProductoId,Url,FechaCreacion,Principal from Imagenes where Activo = 1";
                var dt = await managerData.getTable(query);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        Imagenes.Add(new Imagen
                        {
                            Id = Convert.ToInt32(r["Id"]),
                            ProductoId = Convert.ToInt32(r["ProductoId"]),
                            Url = r["Url"].ToString(),
                            fechaCreacion = Convert.ToDateTime(r["FechaCreacion"]),
                            Principal = Convert.ToBoolean(r["Principal"]),
                            Nombre = r["Nombre"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return Imagenes;
        }

        public async Task<bool> Save(Imagen entity)
        {
            bool result = false;
            try
            {
                string query = $@"Update Imagenes set ProductoId = '{entity.ProductoId}',Url = '{entity.Url}',Principal = '{entity.Principal}' where Id = '{entity.Id}'";
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
