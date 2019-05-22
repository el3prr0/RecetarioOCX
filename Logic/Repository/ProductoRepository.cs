using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.Configuration;
using Logic.Models;
using System.Data;

namespace Logic.Repository
{
    public class ProductoRepository : IRepository<Producto>
    {
        ManagerData managerData;
        public ProductoRepository()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["BartTenderDB"].ConnectionString;
            managerData = new ManagerData(ConnectionString);
        }
        public async Task<bool> Add(Producto entity)
        {
            bool result = false;
            try
            {
                string query = $@"Insert into Productos(Nombre,Guarnicion,ImagenPrincipal,Clave,Grupo,SubGrupo,Precio,Descripcion)
values('{entity.Nombre}','{entity.Guarnicion}','{entity.ImagenPrincipal}','{entity.Clave}','{entity.Grupo}','{entity.SubGrupo}','{entity.Precio}','{entity.Descripcion}')";
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
                string query = $"Delete From Productos  where Id = {Id}";
                result = await managerData.Execute(query);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return result;
        }

        public async Task<IEnumerable<Producto>> Get(int Id)
        {
            var productos = new List<Producto>();
            try
            {
                string query = $@"Select Id,Nombre,FechaCreacion, Guarnicion,ImagenPrincipal,Clave,Grupo,SubGrupo,Precio,Descripcion from Productos where Activo = 1 and Id={Id}";
                var dt  = await managerData.getTable(query);
                if(dt.Rows.Count > 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        productos.Add(new Producto
                        {
                            Id = Convert.ToInt32(r["Id"]),
                            Nombre = r["Nombre"].ToString(),
                            Guarnicion = r["Guarnicion"].ToString(),
                            ImagenPrincipal = r["ImagenPrincipal"].ToString(),
                            FechaCreacion = Convert.ToDateTime(r["FechaCreacion"]),
                            Clave = Convert.ToInt32(r["Clave"]),
                            Grupo = Convert.ToInt32(r["Grupo"]),
                            SubGrupo = Convert.ToInt32(r["SubGrupo"])
                        });
                    }

                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return productos;
        }

        public async Task<IEnumerable<Producto>> Get(string Nombre)
        {
            var productos = new List<Producto>();
            try
            {
                string query = $@"Select Id,Nombre,FechaCreacion, Guarnicion,ImagenPrincipal,Clave,Grupo,SubGrupo,Precio,Descripcion from Productos where Activo = 1 and Nombre like '{Nombre}%'";
                var dt = await managerData.getTable(query);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        productos.Add(new Producto
                        {
                            Id = Convert.ToInt32(r["Id"]),
                            Nombre = r["Nombre"].ToString(),
                            Guarnicion = r["Guarnicion"].ToString(),
                            ImagenPrincipal = r["ImagenPrincipal"].ToString(),
                            FechaCreacion = Convert.ToDateTime(r["FechaCreacion"]),
                            Clave = Convert.ToInt32(r["Clave"]),
                            Grupo = Convert.ToInt32(r["Grupo"]),
                            SubGrupo = Convert.ToInt32(r["SubGrupo"])
                        });
                    }

                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return productos;
        }

        public async Task<IEnumerable<Producto>> GetAll()
        {
            var productos = new List<Producto>();
            try
            {
                string query = $@"Select Id,Nombre,FechaCreacion, Guarnicion,ImagenPrincipal,Clave,Grupo,SubGrupo,Precio,Descripcion from Productos where Activo = 1 order by Nombre asc";
                var dt = await managerData.getTable(query);
                if (dt.Rows.Count > 0)
                {
                    foreach(DataRow r in dt.Rows)
                    {
                        productos.Add(new Producto
                        {
                            Id = Convert.ToInt32(r["Id"]),
                            Nombre = r["Nombre"].ToString(),
                            Guarnicion = r["Guarnicion"].ToString(),
                            ImagenPrincipal = r["ImagenPrincipal"].ToString(),
                            FechaCreacion = Convert.ToDateTime(r["FechaCreacion"]),
                            Clave = Convert.ToInt32(r["Clave"]),
                            Grupo = Convert.ToInt32(r["Grupo"]),
                            Descripcion = r["Descripcion"].ToString(),
                            Precio = Convert.ToDecimal(r["Precio"]),
                            SubGrupo = Convert.ToInt32(r["SubGrupo"])
                        });
                    }

                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return productos;
        }

        public async Task<bool> Save(Producto entity)
        {
            bool result = false;
            try
            {
                string query = $@"update Productos set Nombre = '{entity.Nombre}',Guarnicion='{entity.Guarnicion}',ImagenPrincipal='{entity.ImagenPrincipal}',Clave='{entity.Clave}',Grupo='{entity.Grupo}',SubGrupo='{entity.SubGrupo}',Precio = '{entity.Precio}',Descripcion = '{entity.Descripcion}' where Id= {entity.Id}";
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
