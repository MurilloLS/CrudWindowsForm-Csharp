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
    public partial class Visualizar_Movimentacao : Form
    {
        MySqlConnection conexao;
        MySqlCommand cmd;
        string data_source = "datasource=localhost;username=root;password=0101;database=agora_sim";
        public Visualizar_Movimentacao()
        {
            InitializeComponent();
            listView2.GridLines = true;
            listView2.View = View.Details;
            listView2.FullRowSelect = true;

            listView2.Columns.Add("idcont", 30, HorizontalAlignment.Left);
            listView2.Columns.Add("procedimento", 150, HorizontalAlignment.Left);
            listView2.Columns.Add("dtinicio", 150, HorizontalAlignment.Left);
            listView2.Columns.Add("dtfim", 150, HorizontalAlignment.Left);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                // Abrindo a conexão com o MySQL.
                conexao = new MySqlConnection(data_source);
                conexao.Open();


                // Executando o comando pata retornar registros do MySQL com Preparated Statement
                cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT * FROM tabela_move WHERE idcont = @idcont";
                cmd.Parameters.AddWithValue("@idcont", textBoxIdC.Text);


                // Estruturar os dados recebidos do mysql e mostrar ao usuário
                // reader = leitor
                MySqlDataReader reader = cmd.ExecuteReader();

                listView2.Items.Clear();

                while (reader.Read())
                {
                    string[] linha = { reader.GetString(0), //pega a id
                                       reader.GetString(1), // pega o idcont
                                       reader.GetString(2), // pega o procedimento
                                       reader.GetString(3), // pega o dtinicio
                                        // pega o dtfim
                                     };

                    ListViewItem estrutura_da_linha = new ListViewItem(linha);

                    listView2.Items.Add(estrutura_da_linha);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Deu errado, erro: " + ex.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar_Movimentacao alterar = new Alterar_Movimentacao();
            alterar.Show();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                // Abrindo a conexão com o MySQL.

                conexao = new MySqlConnection(data_source);
                conexao.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT idcont, procedimento, dtinicio, dtfim FROM tabela_move ORDER BY idcont DESC";

                // Estruturar os dados recebidos do mysql e mostrar ao usuário
                // reader = leitor
                MySqlDataReader reader = cmd.ExecuteReader();

                listView2.Items.Clear();

                while (reader.Read())
                {
                    string[] linha = { reader.GetString(0), //pega a id
                                       reader.GetString(1), // pega o idcont
                                       reader.GetString(2), // pega o procedimento
                                       reader.GetString(3), // pega o dtinicio
                                       // pega o dtfim
                                     };

                    ListViewItem estrutura_da_linha = new ListViewItem(linha);

                    listView2.Items.Add(estrutura_da_linha);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deu errado, erro: " + ex.Message);
            }
            finally { conexao.Close(); }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Movimentacao move = new Movimentacao();
            move.Show();
        }
    }
}
