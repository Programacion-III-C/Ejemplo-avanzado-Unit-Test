using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CapaDeDatos
{
    public class Modelo
    {
        public string IpDb;
        public string NombreDb;
        public string UsuarioDb;
        public string PasswordDb;
        public string PortDB;
        public MySqlConnection conexion;
        public MySqlCommand comando;
        public MySqlDataReader lector;


        public Modelo()
        {
            this.incializarConexion();
            conexion = new MySqlConnection(
                "server=" + this.IpDb + ";" +
                "userid=" + this.UsuarioDb + ";" +
                "password=" + this.PasswordDb + ";" +
                "database=" + this.NombreDb + ";" +
                "port=" + this.PortDB + ";"
            );

            conexion.Open();
            this.comando = new MySqlCommand();
            this.comando.Connection = this.conexion;

        }

        public void incializarConexion()
        {
            this.IpDb = "localhost";
            this.NombreDb = "base";
            this.UsuarioDb = "root";
            this.PasswordDb = "1234";
            this.PortDB = "3306";
        }
    }
}