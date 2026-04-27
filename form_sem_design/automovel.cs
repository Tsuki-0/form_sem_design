using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form_sem_design
{
    internal class automovel
    { 
        public string Modelo { get; set; }
        public string Velocidade { get; set; }
        public int Ano { get; set; }
        public string Imagem { get; set; }

        public string Marca{ get; set; }
        /*public void SetMarca(string marca) 
        {
            Marca = marca;
        }
        public string GetMarca() 
        {
            return Marca; 
        }*/
        public automovel() 
        {

        }
        public automovel(string marca)
        {
            this.Marca = marca;
        }
    }
}