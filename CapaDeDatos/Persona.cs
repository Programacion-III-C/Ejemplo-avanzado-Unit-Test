using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class PersonaModelo : Modelo
    {
        public string Id;
        public string Nombre;
        public string Apellido;
        public string Mail;

        public void Guardar()
        {
            PrepararQuery();
            EjecutarQuery();
        }
        public void PrepararQuery()
        {

            this.comando.CommandText = "INSERT INTO persona(nombre,apellido,mail) values " +
                "(@nombre,@apellido,@mail)";
            this.comando.Parameters.AddWithValue("@nombre", this.Nombre);
            this.comando.Parameters.AddWithValue("@apellido", this.Apellido);

            this.comando.Parameters.AddWithValue("@mail", this.Mail);
            this.comando.Prepare();

        }

        private void EjecutarQuery()
        {
            this.comando.ExecuteNonQuery();
        }

        public void Obtener() { }

        public void Obtener(int id) {
            this.comando.CommandText = "SELECT id,nombre,apellido,mail FROM persona WHERE id = @id";
            this.comando.Parameters.AddWithValue("@id", id);
            this.comando.Prepare();
            this.lector = this.comando.ExecuteReader();

            this.lector.Read();

            this.Id = lector.GetInt32(0).ToString();
            this.Nombre = lector.GetString(1);
            this.Apellido = lector.GetString(2);
            this.Mail = lector.GetString(3);
            


        }

        public int GetLastId()
        {
            this.comando.CommandText = "SELECT MAX(id) FROM persona";
            return Int32.Parse(this.comando.ExecuteScalar().ToString());

        }

    }

   
}
