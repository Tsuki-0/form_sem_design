using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Windows.Forms;
using System.Drawing;
using form_sem_design;
using System.IO;

namespace Poo
{
    internal class Apresentacao : Form
    {
        automovel carro01 = new automovel();
        Button btobj01 = new Button();
        Label labelMarca = new Label();
        Label labelModelo = new Label();
        Label labelAno = new Label();
        Label labelVelocidade = new Label();
        PictureBox img = new PictureBox();

        public Apresentacao()
        {
            this.Text = "Titulo";
            this.Size = new Size(600, 600);
            btobj01.Location = new Point(50, 50);
            btobj01.Text = "Clica, imundo";
            btobj01.Click += btobj01Click;
            this.Controls.Add(btobj01);
            carro01.Marca = "FIAT";
            labelMarca.Text = carro01.Marca;
            this.Controls.Add(labelMarca);
            labelMarca.Location = new Point(150, 150);
            this.Controls.AddRange(new Control[] { labelMarca,labelModelo, labelAno, labelVelocidade ,btobj01 });
            carro01.Marca = "FIAT";
        }
        // método de evento
        private void btobj01Click(object sender , EventArgs e) 
        {
            MessageBox.Show("Método de Evento");
            carro01.Marca = "Fiat";
            carro01.Ano = 2020;
            carro01.Modelo = "Uno";
            carro01.Velocidade = "20 km/h";

            labelMarca.Text = "Marca: " + carro01.Marca;
            labelModelo.Text = "Modelo: " + carro01.Modelo;
            labelAno.Text = "Ano: " + carro01.Ano;
            labelVelocidade.Text = "Velocidade: " + carro01.Ano;



            labelMarca.Location = new Point(132, 123);
            labelModelo.Location = new Point(132, 123);
            labelAno.Location = new Point(132, 123);
            labelVelocidade.Location = new Point(132, 123);

            img.Imagem = Image.FromFile("./img/UNOOOOO.jpg");


        }
    }

}