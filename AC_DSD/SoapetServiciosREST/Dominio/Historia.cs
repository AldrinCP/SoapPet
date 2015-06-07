using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
//PASO 1
namespace SoapetServiciosREST.Dominio
{
    [DataContract]

    public class Historia
    {
        [DataMember]
        public Int32 idHistoria { get; set; }
        [DataMember]
        public string Descripcion {get; set;}
        [DataMember]
        public Int32 idMascota { get; set; }
    }
}