using System;
using System.Text.Json;

namespace DependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RecuperarSenha recuperarSenha= new RecuperarSenha();
            Console.WriteLine(JsonSerializer.Serialize(recuperarSenha));
        }
    }
}
