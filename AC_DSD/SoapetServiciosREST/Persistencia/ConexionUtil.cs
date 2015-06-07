using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapetServiciosREST.Persistencia
{
    public class ConexionUtil
    {
        public static string cnn
        {
            get
            {
                return "Server=localhost;Database=soapet;Uid=root;Pwd=;";
            }
        }
    }
}