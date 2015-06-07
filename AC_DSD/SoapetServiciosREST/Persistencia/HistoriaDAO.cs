using SoapetServiciosREST.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MySql.Data;
using MySql.Data.MySqlClient;

//PASO 2
namespace SoapetServiciosREST.Persistencia
{
    public class HistoriaDAO
    {
        public Historia Crear(Historia historiaCrear)
        {
            Historia historiaCreado = null;
            string sql = "INSERT INTO historiaclinica(Descripcion,idMascota) VALUES (@descrip, @idM)";
            using (MySqlConnection con =  new MySqlConnection(ConexionUtil.cnn))
            {
                con.Open();
                using (MySqlCommand com = new MySqlCommand(sql, con))
                {
                    
                    com.Parameters.Add(new MySqlParameter("@descrip", historiaCrear.Descripcion));
                    com.Parameters.Add(new MySqlParameter("@idM", historiaCrear.idMascota));
                    com.ExecuteNonQuery();
                }
                historiaCreado = Obtener(Convert.ToString(ObtenerUltimoId()));
                return historiaCreado;
            }
        }

        private int ObtenerUltimoId()
        {

            int ultimoId = 0;
            string sql = "SELECT max(idMascota) as id FROM historiaclinica";
            using (MySqlConnection con = new MySqlConnection(ConexionUtil.cnn))
            {
                con.Open();
                using (MySqlCommand com = new MySqlCommand(sql, con))
                {

                    using (MySqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            ultimoId = (int)resultado["id"];
                        }
                    }
                }
            }
            return ultimoId;
        }


        public Historia Obtener(string codigo)
        {
           Historia historiaExistente = null;

            string sql = "SELECT idHistoria, Descripcion, idMascota FROM historiaclinica WHERE idMascota=@idM";
            using (MySqlConnection con =  new MySqlConnection(ConexionUtil.cnn))
            {
                con.Open();
                using (MySqlCommand com = new MySqlCommand(sql, con))
                {
                    com.Parameters.Add(new MySqlParameter("@idM", Int32.Parse(codigo)));
                    using (MySqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                             historiaExistente = new Historia()
                            {
                                idHistoria  = (Int32)resultado["idHistoria"],
                                Descripcion = (string)resultado["Descripcion"],
                                idMascota = (Int32)resultado["idMascota"]
                            };
                        }
                    }
                }
            }
            return historiaExistente;
        }
        public Historia Modificar(Historia historiaAModificar)
        {
            return null;
        }

        public void Eliminar(string codigoMascota)
        {
            string sql = "DELETE historiaclinica WHERE idMascota=@idM";
            using (MySqlConnection con = new MySqlConnection(ConexionUtil.cnn))
            {
                con.Open(); 
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.Add(new MySqlParameter("@idM", codigoMascota));
                    cmd.ExecuteNonQuery(); 
                }
            }
            
        }
        
        
        public List<Historia> ListarTodos()
        {
            return null;
        }
    }
}
