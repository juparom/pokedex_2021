using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PruebaBBDD
{
    public partial class PokedexBasica : Form
    {
        Conexion miConexion = new Conexion();
        int idActual = 1;
        public PokedexBasica()
        {
            InitializeComponent();
            asignaPokemon();
         }
  
        private void button2_Click(object sender, EventArgs e)
        {//boton derecha
            idActual++;
            if (idActual > 151) {
                idActual = 1;
            }
            asignaPokemon();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            idActual--;
            if (idActual < 1)
            {
                idActual = 151;
            }
            asignaPokemon();
        }

        private void asignaPokemon() {
            DataTable pokemonElegido = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = pokemonElegido.Rows[0]["nombre"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])pokemonElegido.Rows[0]["imagen"]);
            informacion.Text = pokemonElegido.Rows[0]["descripcion"].ToString();
            movimiento_1.Text = pokemonElegido.Rows[0]["movimiento1"].ToString();
            movimiento_2.Text = pokemonElegido.Rows[0]["movimiento2"].ToString();
            movimiento_3.Text = pokemonElegido.Rows[0]["movimiento3"].ToString();
            movimiento_4.Text = pokemonElegido.Rows[0]["movimiento4"].ToString();
            tipo_1.Text = pokemonElegido.Rows[0]["tipo1"].ToString();
            tipo_2.Text = pokemonElegido.Rows[0]["tipo2"].ToString();
            Especie.Text = pokemonElegido.Rows[0]["especie"].ToString();
            Habitat.Text = pokemonElegido.Rows[0]["habitat"].ToString();
            Altura.Text = pokemonElegido.Rows[0]["altura"].ToString();
            Peso.Text = pokemonElegido.Rows[0]["peso"].ToString();

        }

        private Image convierteBlobAImagen(byte[] img) {
            return (Image.FromStream(new System.IO.MemoryStream(img)));
        }

        private void PokedexBasica_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void movimiento_4_Click(object sender, EventArgs e)
        {

        }

        private void tipo_1_Click(object sender, EventArgs e)
        {
            
        }

        private void tipo_2_Click(object sender, EventArgs e)
        {

        }
    }
}
