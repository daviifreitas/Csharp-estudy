using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloAnemico1
{
    public sealed class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public Cliente(int id , string nome , string endereco)
        {
            Validar(id, nome, endereco);
            this.Id = id;
            this.Nome = nome;
            this.Endereco = endereco; 
        }

        public void Update(int id , string nome ,string endereco)
        {
            Validar(id, nome, endereco);
            this.Id = id;
            this.Nome = nome;
            this.Endereco = endereco; 
        }

        private void Validar(int id , string nome , string endereco)
        {
            if (id < 0)
                throw new InvalidOperationException("O id tem que ser maior que 0");

            if (nome.Length < 3)
                throw new InvalidOperationException("O nome tem que ter mais de 3 caracteres");

            if (endereco.Length < 10)
                throw new InvalidOperationException("O endereço deve ter mais de 10 caracteres");
        }
    }
}
