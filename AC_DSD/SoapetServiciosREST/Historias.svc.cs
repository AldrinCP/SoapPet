using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SoapetServiciosREST.Dominio;
using SoapetServiciosREST.Persistencia;
using System.ServiceModel.Web;
//PASO 3.1
namespace SoapetServiciosREST
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Historias" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Historias.svc o Historias.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Historias : IHistorias
    {
        private HistoriaDAO dao = new HistoriaDAO();

        public Historia CrearHistoria(Historia historiaACrear)
        {
             return   dao.Crear(historiaACrear); 
         }

        public Historia ObtenerHistoria(string  idMascota)
        {
            Historia dd = dao.Obtener(idMascota);
            //if(dd == null){
            //    throw new WebFaultException<string>("La historia no existe!",System.Net.HttpStatusCode.InternalServerError);
            //}
            return dd;
        }

        public Historia ModificarHistoria(Historia historiaModificar)
        {
            //TODO;
            throw new NotImplementedException();
        }

        public void EliminarHistoria(string idMascota)
        {
            Historia dd = dao.Obtener(idMascota);
            if (dd == null)
            {
                throw new WebFaultException<string>("La historia no existe!", System.Net.HttpStatusCode.InternalServerError);
            }
            else  {

                dao.Eliminar(idMascota);            
                }

            }

        
        public List<Historia> ListarHistorias()
        {
            throw new NotImplementedException();
        }
    }
}
