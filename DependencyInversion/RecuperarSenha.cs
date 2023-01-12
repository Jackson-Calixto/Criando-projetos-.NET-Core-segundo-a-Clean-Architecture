using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    class RecuperarSenha
    {
        private IDataBaseConnection conexaoBanco;

        public RecuperarSenha(IDataBaseConnection _connection)
        {
            conexaoBanco = _connection;
            //código para recuperar senha
        }
    }
}
