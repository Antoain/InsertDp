using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace DapperInsertar
{
    public partial class Form1 : Form
    {
        CategoryRepo categR = new CategoryRepo();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargarTods_Click(object sender, EventArgs e)
        {
            var categ = categR.ObtenerTodo();
            DgvCategorias.DataSource = categ;
        }

        private void btnBuscarID_Click(object sender, EventArgs e)// un Tryparse salvaje aparecio!, lo ponemos ya que no podemos poner un int en un txtBox
        {
            if (int.TryParse(txtBBuscarID.Text, out int id))
            {

                var categ = categR.ObtenerPoeID(id);
                DgvCategorias.DataSource = new List<Categoria> { categ };


            }
            else
            {

                MessageBox.Show("Por favor, ingrese un ID válido.");
            }
        }
        private void btnInsertar_Click(object sender, EventArgs e)  
        {
            var nuevaCate = CrearCate();
            var insertado = categR.InsertarCat(nuevaCate);
            MessageBox.Show($"Filas Insertadas: {insertado}");

        }

        private Categoria CrearCate() 
        {
            var nueva = new Categoria
            {
                
                CategoryName = txtBCategoryName.Text,
                Description = txtBDescripcion.Text
            };    
            return nueva;
        }

    }
}
