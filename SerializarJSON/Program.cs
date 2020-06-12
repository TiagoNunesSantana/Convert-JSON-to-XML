using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Biblioteca;
using System.IO;

namespace SerializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Venda venda = new Venda() { Produto = "Aéreo", Qtd = 10, valor = 5999.99 };

            JavaScriptSerializer serializa = new JavaScriptSerializer();
            string strObjSerializado = serializa.Serialize(venda);

            StreamWriter sw = new StreamWriter(@"C:\Projetos\Convert JSON to XML\Convert JSON to XML\Arquivos\Venda.json");
            sw.WriteLine(strObjSerializado);
            sw.Close();
        }
    }
}
