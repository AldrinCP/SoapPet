using SoapetServiciosREST.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
//PASO 3
namespace SoapetServiciosREST
{
    
    [ServiceContract]
    public interface IHistorias
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Historias", ResponseFormat = WebMessageFormat.Json)]
        Historia CrearHistoria(Historia historiaACrear) ;
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Historias/{idMascota}", ResponseFormat = WebMessageFormat.Json)]
        Historia ObtenerHistoria(string idMascota);
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Historias", ResponseFormat = WebMessageFormat.Json)]
        Historia ModificarHistoria(Historia historiaModificar);
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "Historias/{idMascota}", ResponseFormat = WebMessageFormat.Json)]
        void EliminarHistoria(string idMascota);
        [OperationContract]
        List<Historia> ListarHistorias();

    }
}
