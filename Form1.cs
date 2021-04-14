using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaBBDD
{
    public partial class Form1 : Form
    {
        Conexion miConexion = new Conexion(); //esta variable es del tipo que hemos creado
                                                //para conectarnos a la BBDD MySql

        DataTable misPokemons = new DataTable(); //variable que almacena el array de dos 
                                                   //dimensiones resultado de la consulta
        public Form1()
        {
            InitializeComponent();
            misPokemons = miConexion.getPokemons();
            dataGridView1.DataSource = misPokemons;
        }
    }
}
