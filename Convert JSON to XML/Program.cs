using System;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Convert_JSON_to_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = new StreamReader(@"C:\Projetos\Convert JSON to XML\Convert JSON to XML\Arquivos\Venda.json");
            string arquivoJson = stream.ReadToEnd();

            XNode docXML = JsonConvert.DeserializeXNode(arquivoJson, "Venda");

            Console.WriteLine(docXML.ToString());

            Console.ReadKey();
        }
    }
}
