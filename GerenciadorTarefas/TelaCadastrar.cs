using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorTarefas
{
    public partial class TelaCadastrar : Form
    {
        private frmTelaInicial parent = null;
        int indice = -1;

        public TelaCadastrar(frmTelaInicial _parent)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.parent = _parent;
            InitializeComponent();
        }

        public TelaCadastrar(frmTelaInicial _parent, Tarefa t, int index)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.parent = _parent;
            InitializeComponent();

            txbNome.Text = t.Nome;
            rtbxDescricao.Text = t.Descricao;
            txbPrazo.Text = t.Prazo;

            indice = index;
        }


        private string SelecionarPrioridade()
        {
            string prioridade = "";
            if(rdbAlta.Checked == true)
            {
                prioridade = "Alta";
            }
            if(rdbMedia.Checked == true)
            {
                prioridade = "Média";
            }
            if(rdbBaixa.Checked == true)
            {
                prioridade = "Baixa";
            }
            return prioridade;
        }

        private string FoiConcluida()
        {
            if(cbConcluida.Checked == true)
            {
                return "Sim";
            }
            else
            {
                return "Não";
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            List<Tarefa> listaTarefas = new List<Tarefa>();

            listaTarefas = ManipuladorArquivo.LerArquivo();

            if (indice > -1)
            {
                //ALTERAR
                listaTarefas.RemoveAt(indice);
            }

            Tarefa tarefa = new Tarefa
            {
                Nome = txbNome.Text,
                Descricao = rtbxDescricao.Text,
                Prazo = txbPrazo.Text,
                Prioridade = SelecionarPrioridade(),
                Concluida = FoiConcluida()
            };
            
            listaTarefas.Add(tarefa);
            ManipuladorArquivo.EscreverArquivo(listaTarefas);
            parent.CarregarLista();
            this.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
