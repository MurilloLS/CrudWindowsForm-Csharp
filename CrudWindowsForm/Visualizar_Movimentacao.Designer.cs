namespace CrudWindowsForm
{
    partial class Visualizar_Movimentacao
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
            textBoxIdC = new TextBox();
            labelId = new Label();
            listView2 = new ListView();
            btnConsulltar = new Button();
            btnVoltar = new Button();
            btnAlterar = new Button();
            btnExibir = new Button();
            SuspendLayout();
            // 
            // textBoxIdC
            // 
            textBoxIdC.Cursor = Cursors.IBeam;
            textBoxIdC.Location = new Point(43, 75);
            textBoxIdC.Name = "textBoxIdC";
            textBoxIdC.Size = new Size(276, 27);
            textBoxIdC.TabIndex = 26;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(12, 75);
            labelId.Name = "labelId";
            labelId.Size = new Size(25, 20);
            labelId.TabIndex = 25;
            labelId.Text = "Id:";
            // 
            // listView2
            // 
            listView2.Cursor = Cursors.IBeam;
            listView2.Location = new Point(13, 116);
            listView2.Name = "listView2";
            listView2.Size = new Size(776, 331);
            listView2.TabIndex = 27;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // btnConsulltar
            // 
            btnConsulltar.Cursor = Cursors.Hand;
            btnConsulltar.Location = new Point(325, 75);
            btnConsulltar.Name = "btnConsulltar";
            btnConsulltar.Size = new Size(94, 29);
            btnConsulltar.TabIndex = 31;
            btnConsulltar.Text = "Consultar";
            btnConsulltar.UseVisualStyleBackColor = true;
            btnConsulltar.Click += btnConsultar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.Location = new Point(713, 81);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(76, 29);
            btnVoltar.TabIndex = 30;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Cursor = Cursors.Hand;
            btnAlterar.Location = new Point(549, 81);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(76, 29);
            btnAlterar.TabIndex = 28;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExibir
            // 
            btnExibir.Cursor = Cursors.Hand;
            btnExibir.Location = new Point(631, 81);
            btnExibir.Name = "btnExibir";
            btnExibir.Size = new Size(76, 29);
            btnExibir.TabIndex = 29;
            btnExibir.Text = "Exibir";
            btnExibir.UseVisualStyleBackColor = true;
            btnExibir.Click += btnExibir_Click;
            // 
            // Visualizar_Movimentacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView2);
            Controls.Add(btnConsulltar);
            Controls.Add(btnVoltar);
            Controls.Add(btnAlterar);
            Controls.Add(btnExibir);
            Controls.Add(textBoxIdC);
            Controls.Add(labelId);
            Name = "Visualizar_Movimentacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visualizar_Movimentacao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxIdC;
        private Label labelId;
        private ListView listView2;
        private Button btnConsulltar;
        private Button btnVoltar;
        private Button btnAlterar;
        private Button btnExibir;
    }
}