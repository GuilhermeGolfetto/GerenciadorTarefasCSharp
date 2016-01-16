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
    public partial class frmTelaInicial : Form
    {
        public OperacaoEnum acao;

        public frmTelaInicial()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            TelaCadastrar telaCadastrar = new TelaCadastrar(this);
            telaCadastrar.Show();
        }

        public void CarregarLista()
        {
            lbxLista.Items.Clear();
            lbxLista.Items.AddRange(ManipuladorArquivo.LerArquivo().ToArray());
        }

        private void frmTelaInicial_Shown(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?","Pergunta",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lbxLista.Items.RemoveAt(lbxLista.SelectedIndex);
                List<Tarefa> listaTarefas = new List<Tarefa>();
                foreach(Tarefa t in lbxLista.Items)
                {
                    listaTarefas.Add(t);
                }
                ManipuladorArquivo.EscreverArquivo(listaTarefas);
                CarregarLista();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)lbxLista.Items[lbxLista.SelectedIndex];
            int index = lbxLista.SelectedIndex;
            TelaCadastrar telaEditar = new TelaCadastrar(this, tarefaSelecionada, index);
            telaEditar.Show();
        }
    }
}
