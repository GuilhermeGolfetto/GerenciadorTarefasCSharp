using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorTarefas
{
    public class Tarefa
    {
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string Prazo { get; set; }

        public string Prioridade { get; set; }

        public string Concluida { get; set; }

        public Tarefa(string nome = "", string descricao = "",string prazo = "",string prioridade = "", string concluida = "")
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.Prazo = prazo;
            this.Prioridade = prioridade;
            this.Concluida = concluida;
        }

        public override string ToString()
        {
            return string.Format("{0} | {1} | {2} | Prioridade {3} | Concluida: {4}", this.Nome, this.Descricao, this.Prazo, this.Prioridade, this.Concluida);
        }
    }
}
