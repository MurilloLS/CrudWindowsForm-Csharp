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
    public partial class Alterar_Conteiner : Form
    {
        MySqlConnection conexao;
        MySqlCommand cmd;
        string data_source = "datasource=localhost;username=root;password=0101;database=agora_sim";
        public Alterar_Conteiner()
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
                cmd.CommandText = "SELECT * FROM tabela_dados WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", textBoxId.Text);


                // Estruturar os dados recebidos do mysql e mostrar ao usuário
                // reader = leitor
                MySqlDataReader reader = cmd.ExecuteReader();

                textBoxCliente.Clear();
                textBoxNumero.Clear();
                textBoxTipo.Clear();
                textBoxStatus.Clear();
                textBoxCategoria.Clear();

                while (reader.Read())
                {
                    textBoxCliente.Text = Convert.ToString(reader["cliente"]);
                    textBoxNumero.Text = Convert.ToString(reader["numero"]);
                    textBoxTipo.Text = Convert.ToString(reader["tipo"]);
                    textBoxStatus.Text = Convert.ToString(reader["status"]);
                    textBoxCategoria.Text = Convert.ToString(reader["categoria"]);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Deu errado, erro: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == "")
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

                    cmd.CommandText = "UPDATE tabela_dados SET cliente=@cliente, numero=@numero, tipo=@tipo, status=@status, categoria=@categoria WHERE id = @id";

                    cmd.Parameters.AddWithValue("@id", textBoxId.Text);
                    cmd.Parameters.AddWithValue("@cliente", textBoxCliente.Text);
                    cmd.Parameters.AddWithValue("@numero", textBoxNumero.Text);
                    cmd.Parameters.AddWithValue("@tipo", textBoxTipo.Text);
                    cmd.Parameters.AddWithValue("@status", textBoxStatus.Text);
                    cmd.Parameters.AddWithValue("@categoria", textBoxCategoria.Text);
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
            if (textBoxId.Text == "")
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
                    cmd.CommandText = "DELETE FROM tabela_dados WHERE id = @id";


                    cmd.Parameters.AddWithValue("@id", textBoxId.Text);
                    cmd.ExecuteNonQuery();



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
            Visualizar_Conteiner cont = new Visualizar_Conteiner();
            cont.Show();
        }

    }
}
