using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloAnemicoVsEnrriquecido
{
    public sealed class Cliente
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }

        public Cliente(int id, string nome)
        {
            Validar(id, nome);
            Id = id;
            Nome = nome;
        }

        public void Update(int id, string nome)
        {
            Validar(id, nome);
            Nome = nome;
        }

        private void Validar(int id, string nome)
        {
            if (id <= 0) throw new InvalidOperationException("Id deve ser maior que 0");
            if (string.IsNullOrEmpty(nome)) throw new InvalidOperationException("Nome deve ser preenchido");
            if (nome.Length <= 3) throw new ArgumentException("Nome deve ter mais que 3 letras");
            if (nome.Length >= 100) throw new ArgumentException("Nome deve ter menos que 100 letras");
        }
    }
}
