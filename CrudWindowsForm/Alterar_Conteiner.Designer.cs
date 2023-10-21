namespace CrudWindowsForm
{
    partial class Alterar_Conteiner
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
            btnExcluir = new Button();
            btnEditar = new Button();
            textBoxTipo = new TextBox();
            labelTipo = new Label();
            labelCategoria = new Label();
            labelCliente = new Label();
            label1 = new Label();
            btnVoltar = new Button();
            labelStatus = new Label();
            labelNumero = new Label();
            btnConsultar = new Button();
            textBoxNumero = new TextBox();
            textBoxStatus = new TextBox();
            textBoxCategoria = new TextBox();
            textBoxCliente = new TextBox();
            textBoxId = new TextBox();
            SuspendLayout();
            // 
            // btnExcluir
            // 
            btnExcluir.Cursor = Cursors.Hand;
            btnExcluir.Location = new Point(390, 323);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 41;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Location = new Point(290, 322);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 40;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // textBoxTipo
            // 
            textBoxTipo.Cursor = Cursors.IBeam;
            textBoxTipo.Location = new Point(368, 198);
            textBoxTipo.Name = "textBoxTipo";
            textBoxTipo.Size = new Size(327, 27);
            textBoxTipo.TabIndex = 38;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(106, 198);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(94, 20);
            labelTipo.TabIndex = 33;
            labelTipo.Text = "Tipo (20/40):";
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(106, 267);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(249, 20);
            labelCategoria.TabIndex = 32;
            labelCategoria.Text = "Categoria (Importação/Exportação):";
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Location = new Point(106, 132);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(58, 20);
            labelCliente.TabIndex = 30;
            labelCliente.Text = "Cliente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 98);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 42;
            label1.Text = "Id:";
            // 
            // btnVoltar
            // 
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.Location = new Point(490, 323);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(94, 29);
            btnVoltar.TabIndex = 43;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(106, 234);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(146, 20);
            labelStatus.TabIndex = 34;
            labelStatus.Text = "Status (Cheio/Vazio):";
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Location = new Point(106, 165);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(154, 20);
            labelNumero.TabIndex = 31;
            labelNumero.Text = "Número do contêiner:";
            // 
            // btnConsultar
            // 
            btnConsultar.Cursor = Cursors.Hand;
            btnConsultar.Location = new Point(190, 322);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(94, 29);
            btnConsultar.TabIndex = 45;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Cursor = Cursors.IBeam;
            textBoxNumero.Location = new Point(368, 165);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(327, 27);
            textBoxNumero.TabIndex = 39;
            // 
            // textBoxStatus
            // 
            textBoxStatus.Cursor = Cursors.IBeam;
            textBoxStatus.Location = new Point(368, 234);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.Size = new Size(327, 27);
            textBoxStatus.TabIndex = 37;
            // 
            // textBoxCategoria
            // 
            textBoxCategoria.Cursor = Cursors.IBeam;
            textBoxCategoria.Location = new Point(368, 267);
            textBoxCategoria.Name = "textBoxCategoria";
            textBoxCategoria.Size = new Size(327, 27);
            textBoxCategoria.TabIndex = 36;
            // 
            // textBoxCliente
            // 
            textBoxCliente.Cursor = Cursors.IBeam;
            textBoxCliente.Location = new Point(368, 132);
            textBoxCliente.Name = "textBoxCliente";
            textBoxCliente.Size = new Size(327, 27);
            textBoxCliente.TabIndex = 35;
            // 
            // textBoxId
            // 
            textBoxId.Cursor = Cursors.IBeam;
            textBoxId.Location = new Point(368, 98);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(327, 27);
            textBoxId.TabIndex = 44;
            // 
            // Alterar_Conteiner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(textBoxTipo);
            Controls.Add(labelTipo);
            Controls.Add(labelCategoria);
            Controls.Add(labelCliente);
            Controls.Add(label1);
            Controls.Add(btnVoltar);
            Controls.Add(labelStatus);
            Controls.Add(labelNumero);
            Controls.Add(btnConsultar);
            Controls.Add(textBoxNumero);
            Controls.Add(textBoxStatus);
            Controls.Add(textBoxCategoria);
            Controls.Add(textBoxCliente);
            Controls.Add(textBoxId);
            Name = "Alterar_Conteiner";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alterar_Conteiner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExcluir;
        private Button btnEditar;
        private TextBox textBoxTipo;
        private Label labelTipo;
        private Label labelCategoria;
        private Label labelCliente;
        private Label label1;
        private Button btnVoltar;
        private Label labelStatus;
        private Label labelNumero;
        private Button btnConsultar;
        private TextBox textBoxNumero;
        private TextBox textBoxStatus;
        private TextBox textBoxCategoria;
        private TextBox textBoxCliente;
        private TextBox textBoxId;
    }
}