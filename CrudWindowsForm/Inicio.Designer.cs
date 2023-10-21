namespace CrudWindowsForm
{
    partial class Inicio
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
            btnConteiner = new Button();
            btnMovimentacao = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnConteiner
            // 
            btnConteiner.Cursor = Cursors.Hand;
            btnConteiner.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnConteiner.Location = new Point(215, 259);
            btnConteiner.Name = "btnConteiner";
            btnConteiner.Size = new Size(170, 44);
            btnConteiner.TabIndex = 22;
            btnConteiner.Text = "Contêiner";
            btnConteiner.UseVisualStyleBackColor = true;
            btnConteiner.Click += btnConteiner_Click;
            // 
            // btnMovimentacao
            // 
            btnMovimentacao.Cursor = Cursors.Hand;
            btnMovimentacao.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnMovimentacao.Location = new Point(391, 259);
            btnMovimentacao.Name = "btnMovimentacao";
            btnMovimentacao.Size = new Size(181, 44);
            btnMovimentacao.TabIndex = 21;
            btnMovimentacao.Text = "Movimentação";
            btnMovimentacao.UseVisualStyleBackColor = true;
            btnMovimentacao.Click += btnMovimentacao_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(303, 138);
            label1.Name = "label1";
            label1.Size = new Size(171, 59);
            label1.TabIndex = 20;
            label1.Text = "Início";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConteiner);
            Controls.Add(btnMovimentacao);
            Controls.Add(label1);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConteiner;
        private Button btnMovimentacao;
        private Label label1;
    }
}