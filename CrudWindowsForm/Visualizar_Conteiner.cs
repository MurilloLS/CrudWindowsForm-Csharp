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
using System.Xml.Linq;

namespace CrudWindowsForm
{
    public partial class Visualizar_Conteiner : Form
    {
        MySqlConnection conexao;
        MySqlCommand cmd;
        string data_source = "datasource=localhost;username=root;password=0101;database=agora_sim";
        public Visualizar_Conteiner()
        {
            InitializeComponent();
            listView1.GridLines = true;
            listView1.View = View.Details; 
            listView1.FullRowSelect = true;

            listView1.Columns.Add("id", 30, HorizontalAlignment.Left);
            listView1.Columns.Add("cliente", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("numero", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("tipo", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("status", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("categoria", 150, HorizontalAlignment.Left);
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                // Abrindo a conexão com o MySQL.
                conexao = new MySqlConnection(data_source);
                conexao.Open();


                // Executando o comando pata retornar registros do MySQL com Preparated Statement
                cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT * FROM tabela_dados WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", textBoxId.Text);


                // Estruturar os dados recebidos do mysql e mostrar ao usuário
                // reader = leitor
                MySqlDataReader reader = cmd.ExecuteReader();

                listView1.Items.Clear();

                while (reader.Read())
                {
                    string[] linha = { reader.GetString(0), //pega a id
                                       reader.GetString(1), // pega o cliente
                                       reader.GetString(2), // pega o numero
                                       reader.GetString(3), // pega o tipo
                                       reader.GetString(4), // pega o status
                                       reader.GetString(5), // pega a categoria
                                     };

                    ListViewItem estrutura_da_linha = new ListViewItem(linha);

                    listView1.Items.Add(estrutura_da_linha);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Deu errado, erro: " + ex.Message);
            }
        }

        private void buttonExibir_Click(object sender, EventArgs e)
        {
            try
            {
                // Abrindo a conexão com o MySQL.
                conexao = new MySqlConnection(data_source);
                conexao.Open();


                // Executando o comando pata retornar registros do MySQL com Preparated Statement
                cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT id, cliente, numero, tipo, status, categoria FROM tabela_dados ORDER BY id DESC";


                // Estruturar os dados recebidos do mysql e mostrar ao usuário
                // reader = leitor
                MySqlDataReader reader = cmd.ExecuteReader();

                listView1.Items.Clear();

                while (reader.Read())
                {
                    string[] linha = { reader.GetString(0), //pega a id
                                       reader.GetString(1), // pega o cliente
                                       reader.GetString(2), // pega o numero
                                       reader.GetString(3), // pega o tipo
                                       reader.GetString(4), // pega o status
                                       reader.GetString(5), // pega a categoria
                                     };

                    ListViewItem estrutura_da_linha = new ListViewItem(linha);

                    listView1.Items.Add(estrutura_da_linha);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Deu errado, erro: " + ex.Message);
            }
            finally { conexao.Close(); }
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Conteiner voltar = new Conteiner();
            voltar.Show();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            Alterar_Conteiner alterar = new Alterar_Conteiner();
            alterar.Show();
        }
    }
}
