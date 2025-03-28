using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etapa9_aula2
{
    public class Aluno
    {
        private string _nome;
        private short _idade;

        public Aluno(string nome, short idade)
        {
            _nome = nome;
            _idade = idade; 
        }

        public override string ToString()
        {
            return $"Nome: {_nome}, Idade: {_idade}";
        }

        //get set nome e idade
        public string Nome { get { return _nome ; } }
        
        public short Idade { get { return _idade ; } }
    }
}
