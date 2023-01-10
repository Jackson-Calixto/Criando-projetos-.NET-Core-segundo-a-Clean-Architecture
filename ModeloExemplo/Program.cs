using Microsoft.Ajax.Utilities;
using System;
using System.Text.Json;
using System.Web.Helpers;

namespace ModeloAnemicoVsEnrriquecido
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            cliente.Id = 1;
            cliente.Nome = "Jackson";

            Console.WriteLine(JsonSerializer.Serialize(cliente));
        }
    }
}
