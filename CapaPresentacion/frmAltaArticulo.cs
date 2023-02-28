using capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaDominio;
using Helper;

namespace CapaPresentacion
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        public frmAltaArticulo(Articulo articulo)
        {
            
            InitializeComponent();
            this.articulo = articulo;
             lblAltaArticulo.Text = "Modificar Articulo";
        }

        public frmAltaArticulo()
        {
            InitializeComponent();
            lblAltaArticulo.Text = "Agregar Articulo";
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                cmbCategoria.DataSource = categoriaNegocio.listar();
                cmbCategoria.ValueMember = "Id";
                cmbCategoria.DisplayMember = "Descripcion";

                cmbMarca.DataSource = marcaNegocio.listar();
                cmbMarca.ValueMember = "Id";
                cmbMarca.DisplayMember = "Descripcion";

                if(articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtImagen.Text = articulo.ImagenUrl;
                    cargarImagenUrl(articulo.ImagenUrl);
                    cmbMarca.SelectedValue = articulo.Marca.Id;
                    cmbCategoria.SelectedValue = articulo.Categoria.Id;
                    txtPrecio.Text = articulo.Precio.ToString();
                }


            }
            catch (Exception)
            {
                
                MessageBox.Show("Fallo al cargar el programa... contacte a su programador","Error critico",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            ArticuloNegocio negocio = new ArticuloNegocio();
            
            try
            {
                if (validarArticulo())
                    return;

                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Categoria = (Categoria)cmbCategoria.SelectedItem;
                articulo.Marca = (Marca)cmbMarca.SelectedItem;
                articulo.ImagenUrl = txtImagen.Text;
                articulo.Precio = Convert.ToDecimal(txtPrecio.Text);

                if(articulo.Id != 0)
                {
                    negocio.modificarArticulo(articulo);
                    MessageBox.Show("Modificado exitosamente","Modificar Articulo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {

                    negocio.agregarArticulo(articulo);
                    MessageBox.Show("Agregado exitosamente","Agrear Articulo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

                Close();
                
            }
            catch (Exception)
            {
                
                MessageBox.Show("Error al intentar agregar o modificar un articulo...","Error critico",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                
            }
        }

        private bool validarArticulo()
        {
            if (!(Validacion.soloLetrasYnumeros(txtCodigo.Text)))
            {
                erpAltaArticulo.SetError(txtCodigo, "Solo ingresar letras y numeros");
                return true;
            }else if(txtCodigo.Text.Trim() == "")
            {
                erpAltaArticulo.SetError(txtCodigo, "Este campo es oblgatorio, por favor ingrese el codigo");
                return true;
            }
            else erpAltaArticulo.Clear();
            if (!(Validacion.soloLetrasYnumeros(txtNombre.Text)))
            {
                erpAltaArticulo.SetError(txtNombre, "Solo ingresar letras y numeros");
                return true;
            }
            else if (txtNombre.Text.Trim() == "")
            {
                erpAltaArticulo.SetError(txtNombre, "Este campo es oblgatorio, por favor ingrese el nombre");
                return true;
            }
            else erpAltaArticulo.Clear();
            if (!(Validacion.soloLetrasYnumeros(txtDescripcion.Text)))
            {
                erpAltaArticulo.SetError(txtDescripcion, "Solo ingresar letras y numeros");
                return true;
            }
            else if (txtDescripcion.Text.Trim() == "")
            {
                erpAltaArticulo.SetError(txtDescripcion, "Este campo es oblgatorio, por favor ingrese el descripcion");
                return true;
            }
            else erpAltaArticulo.Clear();
            
            if (txtPrecio.Text == "")
            {
                erpAltaArticulo.SetError(txtPrecio, "Este campo es oblgatorio, por favor ingrese el precio");
                return true;
            }
            
            else if (Convert.ToDecimal(txtPrecio.Text) == 0)
            {
                erpAltaArticulo.SetError(txtPrecio, "El Precio no puede ser 0");
                return true;

            }
           
            

            else erpAltaArticulo.Clear();



            return false;
        }
        
 
        private void txtImagen_Leave(object sender, EventArgs e)
        {
            cargarImagenUrl(txtImagen.Text);
        }
        public void cargarImagenUrl(string imagen)
        {
            try
            {
                pcbImagenUrl.Load(imagen);
            }
            catch (Exception)
            {

                pcbImagenUrl.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQoNaLFFSdD4YhW8mqgDBSWY8nHnte6ANHQWz6Lsl37yA&s");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        bool m = false;
        int mx, my;

        private void pnlSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            m = true; mx = e.X; my = e.Y;
        }

        private void pnlSuperior_MouseUp(object sender, MouseEventArgs e)
        {
            m = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.UnaComa(e, txtPrecio.Text);
        }

        private void pnlSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == true)
            {
                this.SetDesktopLocation(MousePosition.X - mx - 0, MousePosition.Y - my);

            }
        }
    }
}
