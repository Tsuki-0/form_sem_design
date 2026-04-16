using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Windows.Forms;
using System.Drawing;

namespace Poo
{
    internal class Apresentacao : Form
    {
        Button btobj01 = new Button();
        public Apresentacao()
        {
            this.Text = "Titulo";
            this.Size = new Size(600, 600);
            btobj01.Location = new Point(50, 50);
            btobj01.Text = "Clica, imundo";
            btobj01.Click += btobj01Click; 
            this.Controls.Add(btobj01);

        }
        // método de evento bigga
        private void btobj01Click(object sender , EventArgs e) 
        {
            MessageBox.Show("Método de Evento");

        }
    }

}