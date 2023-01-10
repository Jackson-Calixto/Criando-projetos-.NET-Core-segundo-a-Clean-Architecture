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
            Cliente cliente = new Cliente(1, "Jackson");

            cliente.Update(1, "Jackson");

            Console.WriteLine(JsonSerializer.Serialize(cliente));
        }
    }
}
