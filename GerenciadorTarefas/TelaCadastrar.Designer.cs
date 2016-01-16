namespace GerenciadorTarefas
{
    partial class TelaCadastrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastrar));
            this.label1 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbxDescricao = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbAlta = new System.Windows.Forms.RadioButton();
            this.rdbMedia = new System.Windows.Forms.RadioButton();
            this.rdbBaixa = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbConcluida = new System.Windows.Forms.CheckBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txbPrazo = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarefa:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(15, 28);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(317, 20);
            this.txbNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prazo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição";
            // 
            // rtbxDescricao
            // 
            this.rtbxDescricao.Location = new System.Drawing.Point(15, 69);
            this.rtbxDescricao.Name = "rtbxDescricao";
            this.rtbxDescricao.Size = new System.Drawing.Size(317, 70);
            this.rtbxDescricao.TabIndex = 4;
            this.rtbxDescricao.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prioridade";
            // 
            // rdbAlta
            // 
            this.rdbAlta.AutoSize = true;
            this.rdbAlta.Location = new System.Drawing.Point(15, 209);
            this.rdbAlta.Name = "rdbAlta";
            this.rdbAlta.Size = new System.Drawing.Size(43, 17);
            this.rdbAlta.TabIndex = 6;
            this.rdbAlta.Text = "Alta";
            this.rdbAlta.UseVisualStyleBackColor = true;
            // 
            // rdbMedia
            // 
            this.rdbMedia.AutoSize = true;
            this.rdbMedia.Location = new System.Drawing.Point(15, 232);
            this.rdbMedia.Name = "rdbMedia";
            this.rdbMedia.Size = new System.Drawing.Size(54, 17);
            this.rdbMedia.TabIndex = 7;
            this.rdbMedia.Text = "Média";
            this.rdbMedia.UseVisualStyleBackColor = true;
            // 
            // rdbBaixa
            // 
            this.rdbBaixa.AutoSize = true;
            this.rdbBaixa.Checked = true;
            this.rdbBaixa.Location = new System.Drawing.Point(15, 255);
            this.rdbBaixa.Name = "rdbBaixa";
            this.rdbBaixa.Size = new System.Drawing.Size(51, 17);
            this.rdbBaixa.TabIndex = 8;
            this.rdbBaixa.TabStop = true;
            this.rdbBaixa.Text = "Baixa";
            this.rdbBaixa.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(15, 204);
            this.label5.MaximumSize = new System.Drawing.Size(0, 2);
            this.label5.MinimumSize = new System.Drawing.Size(0, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 2);
            this.label5.TabIndex = 9;
            // 
            // cbConcluida
            // 
            this.cbConcluida.AutoSize = true;
            this.cbConcluida.Location = new System.Drawing.Point(15, 304);
            this.cbConcluida.Name = "cbConcluida";
            this.cbConcluida.Size = new System.Drawing.Size(73, 17);
            this.cbConcluida.TabIndex = 9;
            this.cbConcluida.Text = "Concluida";
            this.cbConcluida.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(257, 330);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Uma produção Guilherme Golfetto";
            // 
            // txbPrazo
            // 
            this.txbPrazo.Location = new System.Drawing.Point(12, 160);
            this.txbPrazo.Mask = "##/##/####";
            this.txbPrazo.Name = "txbPrazo";
            this.txbPrazo.Size = new System.Drawing.Size(76, 20);
            this.txbPrazo.TabIndex = 5;
            this.txbPrazo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // TelaCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(344, 364);
            this.Controls.Add(this.txbPrazo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cbConcluida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdbBaixa);
            this.Controls.Add(this.rdbMedia);
            this.Controls.Add(this.rdbAlta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbxDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Tarefa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbxDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbAlta;
        private System.Windows.Forms.RadioButton rdbMedia;
        private System.Windows.Forms.RadioButton rdbBaixa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbConcluida;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txbPrazo;
    }
}