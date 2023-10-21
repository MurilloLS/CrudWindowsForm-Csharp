namespace CrudWindowsForm
{
    partial class Visualizar_Conteiner
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
            textBoxId = new TextBox();
            labelId = new Label();
            listView1 = new ListView();
            buttonConsultar = new Button();
            buttonVoltar = new Button();
            buttonAlterar = new Button();
            buttonExibir = new Button();
            SuspendLayout();
            // 
            // textBoxId
            // 
            textBoxId.Cursor = Cursors.IBeam;
            textBoxId.Location = new Point(44, 70);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(276, 27);
            textBoxId.TabIndex = 18;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(13, 70);
            labelId.Name = "labelId";
            labelId.Size = new Size(25, 20);
            labelId.TabIndex = 17;
            labelId.Text = "Id:";
            // 
            // listView1
            // 
            listView1.Cursor = Cursors.IBeam;
            listView1.Location = new Point(12, 107);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 331);
            listView1.TabIndex = 19;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // buttonConsultar
            // 
            buttonConsultar.Cursor = Cursors.Hand;
            buttonConsultar.Location = new Point(324, 66);
            buttonConsultar.Name = "buttonConsultar";
            buttonConsultar.Size = new Size(94, 29);
            buttonConsultar.TabIndex = 23;
            buttonConsultar.Text = "Consultar";
            buttonConsultar.UseVisualStyleBackColor = true;
            buttonConsultar.Click += buttonConsultar_Click;
            // 
            // buttonVoltar
            // 
            buttonVoltar.Cursor = Cursors.Hand;
            buttonVoltar.Location = new Point(712, 72);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(76, 29);
            buttonVoltar.TabIndex = 22;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = true;
            buttonVoltar.Click += buttonVoltar_Click;
            // 
            // buttonAlterar
            // 
            buttonAlterar.Cursor = Cursors.Hand;
            buttonAlterar.Location = new Point(548, 72);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(76, 29);
            buttonAlterar.TabIndex = 20;
            buttonAlterar.Text = "Alterar";
            buttonAlterar.UseVisualStyleBackColor = true;
            buttonAlterar.Click += buttonAlterar_Click;
            // 
            // buttonExibir
            // 
            buttonExibir.Cursor = Cursors.Hand;
            buttonExibir.Location = new Point(630, 72);
            buttonExibir.Name = "buttonExibir";
            buttonExibir.Size = new Size(76, 29);
            buttonExibir.TabIndex = 21;
            buttonExibir.Text = "Exibir";
            buttonExibir.UseVisualStyleBackColor = true;
            buttonExibir.Click += buttonExibir_Click;
            // 
            // Visualizar_Conteiner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxId);
            Controls.Add(labelId);
            Controls.Add(listView1);
            Controls.Add(buttonConsultar);
            Controls.Add(buttonVoltar);
            Controls.Add(buttonAlterar);
            Controls.Add(buttonExibir);
            Name = "Visualizar_Conteiner";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visualizar_Conteiner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxId;
        private Label labelId;
        private ListView listView1;
        private Button buttonConsultar;
        private Button buttonVoltar;
        private Button buttonAlterar;
        private Button buttonExibir;
    }
}