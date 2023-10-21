using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudWindowsForm
{
    public partial class Movimentacao : Form
    {
        MySqlConnection conexao;
        MySqlCommand cmd;
        string data_source = "datasource=localhost;username=root;password=0101;database=agora_sim";

        public Movimentacao()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            try
            {
                // Abrindo a conexão com o MySQL.
                conexao = new MySqlConnection(data_source);
                conexao.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conexao;

                string sql = String.Format("INSERT INTO tabela_move (idcont, procedimento, dtinicio, dtfim) " +
                "                       VALUES ('{0}', '{1}', '{2}', '{3}')",
                                            textBoxIdC.Text, textBoxProcedimento.Text, maskedTextBoxInicio.Text, maskedTextBoxFim.Text);
                cmd = new MySqlCommand(sql, conexao);
                cmd.ExecuteNonQuery();


                MessageBox.Show("Movimentação inserida com sucesso.",
                                "Deu certo!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                cmd = null;
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            Visualizar_Movimentacao visualizar = new Visualizar_Movimentacao();
            visualizar.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
        }
    }
}
