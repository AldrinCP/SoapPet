using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
namespace SoapetServiciosRestTest
{
    [TestClass]
    public class HistoriasTest
    {
        [TestMethod]
        public void crearTest()
        {

            string postdata = "{\"Descripcion\":\"Rambo2\",\"idMascota\":\"75\"}";
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:54453/Historias.svc/Historias");
            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();

            reqStream.Write(data, 0, data.Length);
            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string historiaJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
   
            Historia historiaCreado = js.Deserialize<Historia>(historiaJson);
            Assert.AreEqual("Rambo2", historiaCreado.Descripcion);
            Assert.AreEqual(75, historiaCreado.idMascota);
           
        }

        [TestMethod]
        public void buscarTEST()
        {
            // Prueba de obtención de Doctor vía HTTP GET
           
            HttpWebRequest req2 = (HttpWebRequest)WebRequest.Create("http://localhost:54453/Historias.svc/Historias/55");
            req2.Method = "GET";
            
            try
            {
                HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
                StreamReader reader2 = new StreamReader(res2.GetResponseStream());
                string historiaJson2 = reader2.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Historia historiaObtenida = js.Deserialize<Historia>(historiaJson2);
                Assert.AreEqual("1", historiaObtenida.idHistoria);
                Assert.AreEqual("Historia de Suco", historiaObtenida.Descripcion);
            }
            catch (WebException ex)
            {
                StreamReader reader = new StreamReader(ex.Response.GetResponseStream());
                string error = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                string mensaje = js.Deserialize<string>(error);
                Assert.AreEqual("¡La historia no existe!", mensaje);
            }
        }


    }

}