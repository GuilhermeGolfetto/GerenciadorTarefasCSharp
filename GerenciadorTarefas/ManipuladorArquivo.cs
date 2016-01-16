using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GerenciadorTarefas
{
    public class ManipuladorArquivo
    {
        public static string endereco = AppDomain.CurrentDomain.BaseDirectory + "tarefas.txt";

        public static List<Tarefa> LerArquivo()
        {
            List<Tarefa> listaTarefas = new List<Tarefa>();
            if (File.Exists(@endereco))
            {
                using (StreamReader sr = File.OpenText(@endereco))
                {
                    while (sr.Peek() >= 0)
                    {
                        string linha = sr.ReadLine();
                        string[] linhaSplit = linha.Split(';');
                        if (linhaSplit.Count() == 5)
                        {
                            Tarefa tarefa = new Tarefa
                            {
                                Nome = linhaSplit[0],
                                Descricao = linhaSplit[1],
                                Prazo = linhaSplit[2],
                                Prioridade = linhaSplit[3],
                                Concluida = linhaSplit[4]
                            };
                            listaTarefas.Add(tarefa);
                        }
                    }
                }
            }
            return listaTarefas;
        }

        public static void EscreverArquivo(List<Tarefa> listaTarefas)
        {
            using (StreamWriter sw = new StreamWriter(@endereco, false))
            {
                foreach(Tarefa t in listaTarefas)
                {
                    string linha = string.Format("{0};{1};{2};{3};{4}", t.Nome, t.Descricao, t.Prazo, t.Prioridade, t.Concluida);
                    sw.WriteLine(linha);
                }
                sw.Flush();
            }
        }

    }
}
