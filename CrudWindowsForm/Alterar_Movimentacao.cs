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
    public partial class Alterar_Movimentacao : Form
    {
        MySqlConnection conexao;
        MySqlCommand cmd;
        string data_source = "datasource=localhost;username=root;password=0101;database=agora_sim";
        public Alterar_Movimentacao()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                // Abrindo a conexão com o MySQL.

                conexao = new MySqlConnection(data_source);
                conexao.Open();


                // Executando o comando pata retornar registros do MySQL com Preparated Statement
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT * FROM tabela_move WHERE idcont = @idcont";
                cmd.Parameters.AddWithValue("@idcont", textBoxIdC.Text);


                // Estruturar os dados recebidos do mysql e mostrar ao usuário
                // reader = leitor
                MySqlDataReader reader = cmd.ExecuteReader();

                textBoxIdC.Clear();
                textBoxProcedimento.Items.Clear();
                maskedTextBoxInicio.Clear();
                maskedTextBoxFim.Clear();

                while (reader.Read())
                {
                    textBoxIdC.Text = Convert.ToString(reader["idcont"]);
                    textBoxProcedimento.Text = Convert.ToString(reader["procedimento"]);
                    maskedTextBoxInicio.Text = Convert.ToString(reader["dtinicio"]);
                    maskedTextBoxFim.Text = Convert.ToString(reader["dtfim"]);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Deu errado, erro: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (textBoxIdC.Text == "")
            {
                MessageBox.Show("Selecione um registro antes.",
                                "Ops!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }


            DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja editar?",
                                                       "Cuidado",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Warning);
            if (confirmacao == DialogResult.Yes)
            {
                try
                {
                    // Abrindo a conexão com o MySQL.
                    conexao = new MySqlConnection(data_source);
                    conexao.Open();
                    cmd = new MySqlCommand();
                    cmd.Connection = conexao;

                    cmd.CommandText = "UPDATE tabela_dados SET procedimento=@procedimento, dtinicio=@dtinicio, dtfim WHERE idcont = @idcont";

                    cmd.Parameters.AddWithValue("@idcont", textBoxIdC.Text);
                    cmd.Parameters.AddWithValue("@procedimento", textBoxProcedimento.Text);
                    cmd.Parameters.AddWithValue("@dtinicio", maskedTextBoxInicio.Text);
                    cmd.Parameters.AddWithValue("@dtfim", maskedTextBoxFim.Text);
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Contêiner atualizado com sucesso.",
                                    "Deu certo!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                                   "Deu errado!",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                }
                finally
                {
                    conexao.Close();
                    conexao = null;
                    cmd = null;
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (textBoxIdC.Text == "")
            {
                MessageBox.Show("Selecione um registro antes.",
                                "Ops!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }


            DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja excluir?",
                                                       "Cuidado",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Warning);
            if (confirmacao == DialogResult.Yes)
            {
                try
                {
                    // Abrindo a conexão com o MySQL.

                    conexao = new MySqlConnection(data_source);
                    conexao.Open();

                    // Preparando para Executar o comando de Deleção no BD
                    cmd = new MySqlCommand();
                    cmd.Connection = conexao;
                    cmd.CommandText = "DELETE FROM tabela_move WHERE idcont = @idcont";


                    cmd.Parameters.AddWithValue("@idcont", textBoxIdC.Text);
                    cmd.ExecuteNonQuery();

                    zerar_formulario();

                    MessageBox.Show("Contato excluído com sucesso.",
                                    "Deu certo!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                                    "Deu errado!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                }
                finally
                {
                    conexao.Close();
                    conexao = null;
                    cmd = null;
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Visualizar_Movimentacao visualizar = new Visualizar_Movimentacao();
            visualizar.Show();
        }
        private void zerar_formulario()
        {
            textBoxIdC.Text = "";
            textBoxProcedimento.Text = "";
            maskedTextBoxInicio.Text = "";
            maskedTextBoxFim.Text = "";
        }
    }
}
