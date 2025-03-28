using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etapa9_aula2
{
    public  class CadastroAlunoMemoria
    {
        private List<Aluno> memoria;
    
        public CadastroAlunoMemoria() 
        { 
            memoria = new List<Aluno>();   
        }

        public void AdicionarAluno(Aluno aluno)
        {
            memoria.Add(aluno);
        }

        public List<Aluno> ListarAlunos()
        {
            return memoria;
        }
    }
}
