using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encadeamento
{
    internal class Pessoa
    {
        string Nome;
        int Idade;
        Endereco Endereco;

        public Pessoa(string nome, int idade, Endereco endereco)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Endereco = endereco;
        }

        public override string? ToString()
        {
            string valor = $"Dados da Pessoa:\nNome: {Nome};\nIdade: {Idade};";
            valor += Endereco.ToString();
            return valor;
        }
    }
}
