using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    class RecuperarSenha
    {
        private MySqlConnection conexaoBanco;

        public RecuperarSenha()
        {
            conexaoBanco = new MySqlConnection();
            //código para recuperar senha
        }
    }
}
