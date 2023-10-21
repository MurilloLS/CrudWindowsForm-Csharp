namespace CrudWindowsForm
{
    partial class Conteiner
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
            label1 = new Label();
            labelStatus = new Label();
            labelTipo = new Label();
            labelCategoria = new Label();
            labelNumero = new Label();
            labelCliente = new Label();
            btnVoltar = new Button();
            textBoxCategoria = new ComboBox();
            textBoxStatus = new ComboBox();
            textBoxTipo = new ComboBox();
            btnCriar = new Button();
            btnConteiner = new Button();
            textBoxNumero = new TextBox();
            textBoxCliente = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(238, 50);
            label1.Name = "label1";
            label1.Size = new Size(279, 59);
            label1.TabIndex = 27;
            label1.Text = "Contêiner";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(113, 257);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(52, 20);
            labelStatus.TabIndex = 24;
            labelStatus.Text = "Status:";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(113, 221);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(42, 20);
            labelTipo.TabIndex = 23;
            labelTipo.Text = "Tipo:";
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(113, 290);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(77, 20);
            labelCategoria.TabIndex = 22;
            labelCategoria.Text = "Categoria:";
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Location = new Point(113, 188);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(154, 20);
            labelNumero.TabIndex = 21;
            labelNumero.Text = "Número do contêiner:";
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Location = new Point(113, 155);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(58, 20);
            labelCliente.TabIndex = 20;
            labelCliente.Text = "Cliente:";
            // 
            // btnVoltar
            // 
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.Location = new Point(452, 341);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(94, 29);
            btnVoltar.TabIndex = 31;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // textBoxCategoria
            // 
            textBoxCategoria.FormattingEnabled = true;
            textBoxCategoria.Items.AddRange(new object[] { "Importação", "Exportação" });
            textBoxCategoria.Location = new Point(372, 289);
            textBoxCategoria.Name = "textBoxCategoria";
            textBoxCategoria.Size = new Size(151, 28);
            textBoxCategoria.TabIndex = 30;
            // 
            // textBoxStatus
            // 
            textBoxStatus.FormattingEnabled = true;
            textBoxStatus.Items.AddRange(new object[] { "Cheio", "Vazio" });
            textBoxStatus.Location = new Point(372, 256);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.Size = new Size(151, 28);
            textBoxStatus.TabIndex = 29;
            // 
            // textBoxTipo
            // 
            textBoxTipo.FormattingEnabled = true;
            textBoxTipo.Items.AddRange(new object[] { "20", "40" });
            textBoxTipo.Location = new Point(372, 222);
            textBoxTipo.Name = "textBoxTipo";
            textBoxTipo.Size = new Size(151, 28);
            textBoxTipo.TabIndex = 28;
            // 
            // btnCriar
            // 
            btnCriar.Cursor = Cursors.Hand;
            btnCriar.Location = new Point(252, 341);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(94, 29);
            btnCriar.TabIndex = 18;
            btnCriar.Text = "Criar";
            btnCriar.UseVisualStyleBackColor = true;
            btnCriar.Click += btnCriar_Click;
            // 
            // btnConteiner
            // 
            btnConteiner.Cursor = Cursors.Hand;
            btnConteiner.Location = new Point(352, 341);
            btnConteiner.Name = "btnConteiner";
            btnConteiner.Size = new Size(94, 29);
            btnConteiner.TabIndex = 19;
            btnConteiner.Text = "Visualizar";
            btnConteiner.UseVisualStyleBackColor = true;
            btnConteiner.Click += btnConteiner_Click;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Cursor = Cursors.IBeam;
            textBoxNumero.Location = new Point(375, 188);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(327, 27);
            textBoxNumero.TabIndex = 26;
            // 
            // textBoxCliente
            // 
            textBoxCliente.Cursor = Cursors.IBeam;
            textBoxCliente.Location = new Point(375, 155);
            textBoxCliente.Name = "textBoxCliente";
            textBoxCliente.Size = new Size(327, 27);
            textBoxCliente.TabIndex = 25;
            // 
            // Conteiner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(labelStatus);
            Controls.Add(labelTipo);
            Controls.Add(labelCategoria);
            Controls.Add(labelNumero);
            Controls.Add(labelCliente);
            Controls.Add(btnVoltar);
            Controls.Add(textBoxCategoria);
            Controls.Add(textBoxStatus);
            Controls.Add(textBoxTipo);
            Controls.Add(btnCriar);
            Controls.Add(btnConteiner);
            Controls.Add(textBoxNumero);
            Controls.Add(textBoxCliente);
            Name = "Conteiner";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conteiner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelStatus;
        private Label labelTipo;
        private Label labelCategoria;
        private Label labelNumero;
        private Label labelCliente;
        private Button btnVoltar;
        private ComboBox textBoxCategoria;
        private ComboBox textBoxStatus;
        private ComboBox textBoxTipo;
        private Button btnCriar;
        private Button btnConteiner;
        private TextBox textBoxNumero;
        private TextBox textBoxCliente;
    }
}