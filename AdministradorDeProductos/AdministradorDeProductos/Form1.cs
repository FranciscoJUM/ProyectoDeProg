using AdministradorDeProductos.Enum;
using Dominio;
using Estructura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministradorDeProductos
{
    public partial class Form1 : Form
    {
        public int id { get; set; }
        private ProductoModel em;
        public Form1()
        {
            em = new ProductoModel();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre, descripcion, caducidad, fecha;
            decimal precio, preciomin, preciomax;
            decimal  cantidad, tot;
          
            try
            {
                
                nombre = txtNom.Text;
                descripcion = txtDes.Text;
                caducidad = txtCad.Text;
                ValidateEmpleado(nombre, descripcion, txtCan.Text, txtPre.Text, txtCad.Text);
                precio = decimal.Parse(txtPre.Text);
               
                cantidad = decimal.Parse(txtCan.Text);
                tot = Valortotal(precio, cantidad);
                Producto emp = new Producto()
                {
                    ID = ++this.id,
                    Nombre = nombre,
                    Descripcion = descripcion,
                    Cantidad= cantidad,
                    Precio = precio,
                    Caducidad= caducidad,
                    Unidaddemedida= (UnidadDeMedida)UnidadMedida.SelectedIndex,
                   
                };
                


                Producto emp1 = emp;
                em.Add(emp1);




                MessageBox.Show($@"
                                ID: {emp.ID} {Environment.NewLine} 
                                Nombre: {emp.Nombre} {Environment.NewLine} 
                                Descripcion: {emp.Descripcion} {Environment.NewLine} 
                                Cantidad: {emp.Cantidad} {Environment.NewLine} 
                                Precio: {emp.Precio}{Environment.NewLine} 
                                Caducidad: {emp.Caducidad}{Environment.NewLine}
                                Unidad de medida: {emp.Unidaddemedida}{Environment.NewLine}
                                Valor total: {tot}{Environment.NewLine}
");
                 CleanTexbox();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                CleanTexbox();
            }
            

        }
        public void CleanTexbox()
        {
            TxtCaducidad.Text = string.Empty;
            txtNom.Text = string.Empty;
            txtDes.Text = string.Empty;
            txtCad.Text = string.Empty;
            txtPre.Text = string.Empty;
            txtPrecioMin.Text = string.Empty;
            txtPrecioMax.Text = string.Empty;
            txtCan.Text = string.Empty;

        }
        private void ValidateEmpleado(string nombre, string descripcion, string cantidad, string precio, string caducidad)
        {
            string patronfecha = @"\d[1-31]-\d[1-12]-\d{4}";
            
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion) ||
                string.IsNullOrWhiteSpace(cantidad) || string.IsNullOrWhiteSpace(precio) || string.IsNullOrWhiteSpace(caducidad))
            {
                throw new ArgumentException("Error, todos los datos son requeridos.");
            }
            if (!Regex.Match(caducidad, patronfecha).Success)
            {
                throw new ArgumentException("Error, Fecha  no tiene el formato correcto [00-00-0000]");
            }

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(descripcion))
            {
                throw new ArgumentException("Error, Nombre y Descripcion no pueden ser vacios");
            }

            if (nombre.Length > 20 || nombre.Length > 20)
            {
                throw new ArgumentException("Error, maximo de caracteres pemitido es 20");
            }

            if (!decimal.TryParse(txtPre.Text, out decimal salario))
            {
                throw new ArgumentException($"Error el salario: {txtPre.Text} no se pudo convertir");
            }


           
        }

        public decimal Valortotal(decimal precio, decimal cantidad)
        {
            decimal total;
            total = (cantidad * precio);

            return total;

        }
    }

}
