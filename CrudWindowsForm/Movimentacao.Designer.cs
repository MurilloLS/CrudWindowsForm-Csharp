namespace CrudWindowsForm
{
    partial class Movimentacao
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
            btnVoltar = new Button();
            maskedTextBoxFim = new MaskedTextBox();
            maskedTextBoxInicio = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            labelCategoria = new Label();
            labelIdconteiner = new Label();
            textBoxProcedimento = new ComboBox();
            textBoxIdC = new TextBox();
            btnCriar = new Button();
            btnVisualizar = new Button();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.Location = new Point(449, 335);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(94, 29);
            btnVoltar.TabIndex = 64;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // maskedTextBoxFim
            // 
            maskedTextBoxFim.Location = new Point(283, 276);
            maskedTextBoxFim.Mask = "0000/00/00     00:00";
            maskedTextBoxFim.Name = "maskedTextBoxFim";
            maskedTextBoxFim.Size = new Size(172, 27);
            maskedTextBoxFim.TabIndex = 63;
            maskedTextBoxFim.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBoxInicio
            // 
            maskedTextBoxInicio.Location = new Point(283, 243);
            maskedTextBoxInicio.Mask = "0000/00/00     00:00";
            maskedTextBoxInicio.Name = "maskedTextBoxInicio";
            maskedTextBoxInicio.Size = new Size(172, 27);
            maskedTextBoxInicio.TabIndex = 62;
            maskedTextBoxInicio.ValidatingType = typeof(DateTime);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 279);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 61;
            label3.Text = "Data e Hora do fim:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 246);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 60;
            label2.Text = "Data e Hora de início:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(217, 56);
            label1.Name = "label1";
            label1.Size = new Size(387, 59);
            label1.TabIndex = 59;
            label1.Text = "Movimentação";
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(123, 210);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(105, 20);
            labelCategoria.TabIndex = 56;
            labelCategoria.Text = "Procedimento:";
            // 
            // labelIdconteiner
            // 
            labelIdconteiner.AutoSize = true;
            labelIdconteiner.Location = new Point(123, 169);
            labelIdconteiner.Name = "labelIdconteiner";
            labelIdconteiner.Size = new Size(113, 20);
            labelIdconteiner.TabIndex = 55;
            labelIdconteiner.Text = "Id do contêiner:";
            // 
            // textBoxProcedimento
            // 
            textBoxProcedimento.FormattingEnabled = true;
            textBoxProcedimento.Items.AddRange(new object[] { "Embarque ", "Descarga", "Gate in", "Gate out", "Reposicionamento", "Pesagem", "Scanner" });
            textBoxProcedimento.Location = new Point(242, 202);
            textBoxProcedimento.Name = "textBoxProcedimento";
            textBoxProcedimento.Size = new Size(151, 28);
            textBoxProcedimento.TabIndex = 58;
            // 
            // textBoxIdC
            // 
            textBoxIdC.Cursor = Cursors.IBeam;
            textBoxIdC.Location = new Point(242, 169);
            textBoxIdC.Name = "textBoxIdC";
            textBoxIdC.Size = new Size(327, 27);
            textBoxIdC.TabIndex = 57;
            // 
            // btnCriar
            // 
            btnCriar.Cursor = Cursors.Hand;
            btnCriar.Location = new Point(250, 335);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(94, 29);
            btnCriar.TabIndex = 53;
            btnCriar.Text = "Criar";
            btnCriar.UseVisualStyleBackColor = true;
            btnCriar.Click += btnCriar_Click;
            // 
            // btnVisualizar
            // 
            btnVisualizar.Cursor = Cursors.Hand;
            btnVisualizar.Location = new Point(350, 335);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(94, 29);
            btnVisualizar.TabIndex = 54;
            btnVisualizar.Text = "Visualizar";
            btnVisualizar.UseVisualStyleBackColor = true;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // Movimentacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(maskedTextBoxFim);
            Controls.Add(maskedTextBoxInicio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelCategoria);
            Controls.Add(labelIdconteiner);
            Controls.Add(textBoxProcedimento);
            Controls.Add(textBoxIdC);
            Controls.Add(btnCriar);
            Controls.Add(btnVisualizar);
            Name = "Movimentacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Movimentacao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private MaskedTextBox maskedTextBoxFim;
        private MaskedTextBox maskedTextBoxInicio;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label labelCategoria;
        private Label labelIdconteiner;
        private ComboBox textBoxProcedimento;
        private TextBox textBoxIdC;
        private Button btnCriar;
        private Button btnVisualizar;
    }
}