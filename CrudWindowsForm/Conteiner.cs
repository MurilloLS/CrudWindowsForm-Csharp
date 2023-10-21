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
    public partial class Conteiner : Form
    {
        MySqlConnection conexao;
        MySqlCommand cmd;
        string data_source = "datasource=localhost;username=root;password=0101;database=agora_sim";
        public Conteiner()
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

                string sql = String.Format("INSERT INTO tabela_dados (cliente, numero, tipo, status, categoria) " +
                    "                       VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                                            textBoxCliente.Text, textBoxNumero.Text, textBoxTipo.Text, textBoxStatus.Text, textBoxCategoria.Text);
                cmd = new MySqlCommand(sql, conexao);
                cmd.ExecuteNonQuery();


                MessageBox.Show("Contêiner inserido com sucesso.",
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

        private void btnConteiner_Click(object sender, EventArgs e)
        {
            Visualizar_Conteiner cont = new Visualizar_Conteiner();
            cont.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
        }
    }
}
