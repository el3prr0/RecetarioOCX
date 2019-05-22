using Data;
using Logic.Helpers;
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
    public class UsuarioRepository : IRepository<Login>
    {
        ManagerData managerData;
        private readonly string Salt;
        public UsuarioRepository()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["BartTenderDB"].ConnectionString;
            Salt = ConfigurationManager.AppSettings["SecretKey"].ToString();
            managerData = new ManagerData(ConnectionString);
        }
        public async Task<bool> Add(Login entity)
        {
            bool result = false;
            try
            {
                var saltArray = Encoding.UTF8.GetBytes(Salt);
                var passArray = Encoding.UTF8.GetBytes(entity.Password);

                var ContraArray = PasswordHelper.GenerateSaltedHash(passArray, saltArray);


                var Password = Convert.ToBase64String(ContraArray);


                string query = $@"Insert into Usuarios (Usuario,Password,Nombre,Correo,Telefono,Nivel)values('{entity.Usuario}','{Password}','{entity.Nombre}','{entity.Correo}','{entity.Telefono}','{entity.Nivel}')";
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
                string query = $@"Delete from Usuarios where Id = {Id}";
                result = await managerData.Execute(query);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return result;
        }

        public async Task<IEnumerable<Login>> Get(int Id)
        {
            var Usuarios = new List<Login>();
            try
            {
                string query = $@"Select Usuario,Nombre,Password,Correo,Telefono,Nivel from Usuarios where Id > 1 and Id = {Id}";
                var dt = await managerData.getTable(query);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        Usuarios.Add(new Login
                        {
                            Id = Convert.ToInt32(r["Id"]),
                            Nombre = r["Nombre"].ToString(),
                            Usuario = r["Usuario"].ToString(),
                            Password = r["Password"].ToString(),
                            Correo = r["Correo"].ToString(),
                            Telefono = r["Telefono"].ToString(),
                            Nivel = r["Nivel"].ToString()
                        });
                    }

                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return Usuarios;
        }

        public async Task<Login> GetUsuario(string Usuario)
        {
            var usuario = new Login();
            try
            {
                string query = $@"Select Id,Usuario,Nombre,Password,Correo,Telefono,Nivel from Usuarios where Usuario = '{Usuario}'";
                var dt = await managerData.getTable(query);
                if (dt.Rows.Count > 0)
                {
                    usuario.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                    usuario.Nombre = dt.Rows[0]["Nombre"].ToString();
                    usuario.Usuario = dt.Rows[0]["Usuario"].ToString();
                    usuario.Password = dt.Rows[0]["Password"].ToString();
                    usuario.Correo = dt.Rows[0]["Correo"].ToString();
                    usuario.Telefono = dt.Rows[0]["Telefono"].ToString();
                    usuario.Nivel = dt.Rows[0]["Nivel"].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return usuario;
        }

        public async Task<IEnumerable<Login>> GetAll()
        {
            var Usuarios = new List<Login>();
            try
            {
                string query = $@"Select Id,Usuario,Nombre,Password,Correo,Telefono,Nivel from Usuarios where Id > 1";
                var dt = await managerData.getTable(query);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        Usuarios.Add(new Login
                        {
                            Id = Convert.ToInt32(r["Id"]),
                            Nombre = r["Nombre"].ToString(),
                            Usuario = r["Usuario"].ToString(),
                            Password = r["Password"].ToString(),
                            Correo = r["Correo"].ToString(),
                            Telefono = r["Telefono"].ToString(),
                            Nivel = r["Nivel"].ToString()
                        });
                    }

                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return Usuarios;
        }

        public async Task<bool> Save(Login entity)
        {
            bool result = false;
            try
            {
                var saltArray = Encoding.UTF8.GetBytes(Salt);
                var passArray = Encoding.UTF8.GetBytes(entity.Password);

                var ContraArray = PasswordHelper.GenerateSaltedHash(passArray, saltArray);


                var Password = Convert.ToBase64String(ContraArray);
                string query = $@"Update Usuarios set Usuario = '{entity.Usuario}',Password='{Password}',Nombre='{entity.Nombre}',Correo='{entity.Correo}',Telefono='{entity.Telefono}',Nivel ='{entity.Nivel}' where Id = {entity.Id}";
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
