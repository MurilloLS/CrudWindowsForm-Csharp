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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnConteiner_Click(object sender, EventArgs e)
        {
            Conteiner cont = new Conteiner();
            cont.Show();
        }

        private void btnMovimentacao_Click(object sender, EventArgs e)
        {
            Movimentacao move = new Movimentacao();
            move.Show();
        }
    }
}
