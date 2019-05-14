using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Logic.Helpers;

namespace Logic.Repository
{
    public class SeedDataBase
    {
        ManagerData con;

        private readonly string Salt;
        public SeedDataBase()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["BartTenderDB"].ConnectionString;
            Salt = ConfigurationManager.AppSettings["SecretKey"].ToString();
            con = new ManagerData(ConnectionString);
        }


        public async Task CreaBaseDatos()
        {
            string nombre = ConfigurationManager.AppSettings["UrlBaseDAtos"].ToString()+ ConfigurationManager.AppSettings["BaseDatosNombre"].ToString();
            con.CrearBaseDatos(nombre);
            await con.Execute(@"CREATE TABLE Imagenes (
    Id    INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    ProductoId INTEGER not null,
    Nombre    TEXT NOT NULL,
    Url TExt NOT null,
    FechaCreacion TEXT NOT NULL DEFAULT CURRENT_DATE,
    Principal INTEGER DEFAULT 0,
    Activo    INTEGER DEFAULT 1)");
            await con.Execute(@"CREATE TABLE Ingredientes (
    Id   INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    ProductoId    INTEGER NOT NULL,
    Nombre    TEXT NOT NULL,
    Unidad    TEXT NOT NULL,
    Cantidad  NUMERIC NOT NULL,
    Activo    INTEGER DEFAULT 1)");
            await con.Execute(@"CREATE TABLE Instrucciones (
    Id    INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    ProductoId INTEGER not null,
    Paso  TEXT NOT NULL,
    Activo    INTEGER DEFAULT 1)");
            await con.Execute(@"CREATE TABLE Productos (
     Id    INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    Nombre    TEXT NOT NULL,
    FechaCreacion TEXT NOT NULL DEFAULT CURRENT_DATE,
    ImagenPrincipal   TEXT,
    Clave INTEGER DEFAULT 0,
    SubGrupo  INTEGER DEFAULT 0,
    Activo    INTEGER DEFAULT 1,
    Guarnicion    TEXT,
    Grupo INTEGER DEFAULT 0)");
            await con.Execute(@"CREATE TABLE Unidad (
    Id    INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    Valor INTEGER not null,
    Nombre    TEXT NOT NULL,
    Activo    INTEGER DEFAULT 1)");


            await con.Execute(@"CREATE TABLE 'Usuarios' (

    'Id' INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    'Usuario'   TEXT NOT NULL,
    'Password'  TEXT NOT NULL,
    'Nombre'    TEXT,
    'Correo'    TEXT,
    'Telefono'  TEXT)");

            
        }

        public async Task AgregarUsuarioAdmin()
        {
            var saltArray = Encoding.UTF8.GetBytes(Salt);
            var passArray = Encoding.UTF8.GetBytes("SonoraTech");

            var ContraArray = PasswordHelper.GenerateSaltedHash(passArray, saltArray);
            var ContraString = Convert.ToBase64String(ContraArray);

            await con.Execute($@"Insert into Usuarios (Usuario,Password) values('ADMIN','{ContraString}')");
        }

        public async Task CargarCatalogos()
        {
            await con.Execute("insert into Unidad(valor,nombre)values('1','oz') ");
            await con.Execute("insert into Unidad(valor,nombre)values('2','ml') ");
            await con.Execute("insert into Unidad(valor,nombre)values('3','gr') ");
            await con.Execute("insert into Unidad(valor,nombre)values('4','pz') ");
            await con.Execute("insert into Unidad(valor,nombre)values('5','it') ");
            await con.Execute("insert into Unidad(valor,nombre)values('6','kg') ");
            await con.Execute("insert into Unidad(valor,nombre)values('7','cja') ");
            await con.Execute("insert into Unidad(valor,nombre)values('8','pqt') ");
        }
    }
}
