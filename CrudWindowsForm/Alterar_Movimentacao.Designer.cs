namespace CrudWindowsForm
{
    partial class Alterar_Movimentacao
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
            btnConsultar = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnVoltar = new Button();
            maskedTextBoxFim = new MaskedTextBox();
            maskedTextBoxInicio = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            labelCategoria = new Label();
            labelIdconteiner = new Label();
            textBoxProcedimento = new ComboBox();
            textBoxIdC = new TextBox();
            SuspendLayout();
            // 
            // btnConsultar
            // 
            btnConsultar.Cursor = Cursors.Hand;
            btnConsultar.Location = new Point(172, 286);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(94, 29);
            btnConsultar.TabIndex = 63;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Cursor = Cursors.Hand;
            btnExcluir.Location = new Point(372, 287);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 61;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Location = new Point(272, 286);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 60;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.Location = new Point(472, 287);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(94, 29);
            btnVoltar.TabIndex = 62;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // maskedTextBoxFim
            // 
            maskedTextBoxFim.Location = new Point(319, 215);
            maskedTextBoxFim.Mask = "0000/00/00     00:00";
            maskedTextBoxFim.Name = "maskedTextBoxFim";
            maskedTextBoxFim.Size = new Size(173, 27);
            maskedTextBoxFim.TabIndex = 59;
            maskedTextBoxFim.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBoxInicio
            // 
            maskedTextBoxInicio.Location = new Point(319, 182);
            maskedTextBoxInicio.Mask = "0000/00/00     00:00";
            maskedTextBoxInicio.Name = "maskedTextBoxInicio";
            maskedTextBoxInicio.Size = new Size(173, 27);
            maskedTextBoxInicio.TabIndex = 58;
            maskedTextBoxInicio.ValidatingType = typeof(DateTime);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(159, 218);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 57;
            label3.Text = "Data e Hora do fim:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 185);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 56;
            label2.Text = "Data e Hora de início:";
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(159, 149);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(105, 20);
            labelCategoria.TabIndex = 53;
            labelCategoria.Text = "Procedimento:";
            // 
            // labelIdconteiner
            // 
            labelIdconteiner.AutoSize = true;
            labelIdconteiner.Location = new Point(159, 108);
            labelIdconteiner.Name = "labelIdconteiner";
            labelIdconteiner.Size = new Size(113, 20);
            labelIdconteiner.TabIndex = 52;
            labelIdconteiner.Text = "Id do contêiner:";
            // 
            // textBoxProcedimento
            // 
            textBoxProcedimento.FormattingEnabled = true;
            textBoxProcedimento.Items.AddRange(new object[] { "Embarque ", "Descarga", "Gate in", "Gate out", "Reposicionamento", "Pesagem", "Scanner" });
            textBoxProcedimento.Location = new Point(278, 141);
            textBoxProcedimento.Name = "textBoxProcedimento";
            textBoxProcedimento.Size = new Size(151, 28);
            textBoxProcedimento.TabIndex = 55;
            // 
            // textBoxIdC
            // 
            textBoxIdC.Cursor = Cursors.IBeam;
            textBoxIdC.Location = new Point(278, 108);
            textBoxIdC.Name = "textBoxIdC";
            textBoxIdC.Size = new Size(327, 27);
            textBoxIdC.TabIndex = 54;
            // 
            // Alterar_Movimentacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConsultar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnVoltar);
            Controls.Add(maskedTextBoxFim);
            Controls.Add(maskedTextBoxInicio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelCategoria);
            Controls.Add(labelIdconteiner);
            Controls.Add(textBoxProcedimento);
            Controls.Add(textBoxIdC);
            Name = "Alterar_Movimentacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alterar_Movimentacao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConsultar;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnVoltar;
        private MaskedTextBox maskedTextBoxFim;
        private MaskedTextBox maskedTextBoxInicio;
        private Label label3;
        private Label label2;
        private Label labelCategoria;
        private Label labelIdconteiner;
        private ComboBox textBoxProcedimento;
        private TextBox textBoxIdC;
    }
}