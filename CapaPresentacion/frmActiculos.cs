using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;
using capaDominio;
using Helper;

namespace CapaPresentacion
{
    public partial class frmActiculos : Form
    {
        private List<Articulo> listaArticulos;

        public frmActiculos()
        {
            InitializeComponent();
        }

        private void frmActiculos_Load(object sender, EventArgs e)
        {
            tmrHora.Enabled = true;

            try
            {
               
                cargar();
                ocultarColumnas();
                cmbCampo.Items.Add("Nombre");
                cmbCampo.Items.Add("Descripcion");
                cmbCampo.Items.Add("Precio");
                


            }
            catch (Exception )
            {

                MessageBox.Show("Fallo al cargar el programa... contacte a su programador", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagenUrl(seleccionado.ImagenUrl);

            }
        }

        public void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                DataTable tabla = new DataTable();
                listaArticulos = negocio.listar();             
                dgvArticulos.DataSource = listaArticulos;
                pcbImagen.Load(listaArticulos[0].ImagenUrl);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void cargarImagenUrl(string imagen)
        {
            try
            {
                pcbImagen.Load(imagen);
            }
            catch (Exception)
            {

                pcbImagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQoNaLFFSdD4YhW8mqgDBSWY8nHnte6ANHQWz6Lsl37yA&s");
            }
        }

        public void ocultarColumnas()
        {
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo agregarArticulo = new frmAltaArticulo();
            agregarArticulo.ShowDialog();     
            cargar();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulos.CurrentRow != null)
                {
                    Articulo seleccionado;
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                    frmAltaArticulo modificarArticulo = new frmAltaArticulo(seleccionado);
                    modificarArticulo.ShowDialog();
                    cargar();

                }
                else MessageBox.Show("Para modificar un articulo debe seleccionarlo de la lista", "Error de seleccion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception)
            {

                MessageBox.Show("Fallo al intentar modificar un articulo", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            
            try
            {

                DialogResult resultado = MessageBox.Show("Esta seguro que desea eliminar este articulo de el sistema??", "Eliminar articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    if(dgvArticulos.CurrentRow != null)
                    {
                        seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                        negocio.eliminarArticulo(seleccionado.Id);
                        cargar();

                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un articulo para eliminarlo", "Error de seleccion", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                    }
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Fallo al intentar elminiar un articulo", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFiltroPorNombre_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltroPorNombre.Text;
            if(filtro != "")
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }
        int mx, my;
        bool m = false;

        private void pnSuperior_MouseUp(object sender, MouseEventArgs e)
        {
            m = false;
        }

        private void pnSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            m = true; mx = e.X; my = e.Y;
        }

       

        private void pnSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if(m == true)
            {
                this.SetDesktopLocation(MousePosition.X - mx - 0, MousePosition.Y - my);

            }
        }

       

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cmbCampo.SelectedItem.ToString();
            if(opcion == "Precio")
            {
                cmbCriterio.Items.Clear();
                cmbCriterio.Items.Add("Mayor a");
                cmbCriterio.Items.Add("Menor a");
                cmbCriterio.Items.Add("Igual a");
                
            }
            else
            {
                cmbCriterio.Items.Clear();
                cmbCriterio.Items.Add("Empieza con");
                cmbCriterio.Items.Add("Termine con");
                cmbCriterio.Items.Add("Contiene");

            }
        }

        private bool validarFiltro()
        {
            if (cmbCampo.SelectedIndex < 0)
            {
                erpArticulos.SetError(cmbCampo, "Por favor seleccione el campo para filtrar");
                return true;
            }
            else erpArticulos.Clear();
            if(cmbCriterio.SelectedIndex < 0)
            {
                erpArticulos.SetError(cmbCriterio, "Por favor seleccione el criterio para filtrar");
                return true;
            }else erpArticulos.Clear();
            if (cmbCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltro.Text))
                {
                    erpArticulos.SetError(txtFiltro, "Debes cargar el filtro para numeros");
                    return true;
                }else erpArticulos.Clear();
                if (!(Validacion.soloNumeros(txtFiltro.Text)))
                {
                    erpArticulos.SetError(txtFiltro, "Solo numeros para filtrar por el campo numérico");
                    return true;
                }else erpArticulos.Clear();
            }


                
            
            return false;
        }

       

        private void btnFiltroAvanzado_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                    return;

                string campo = cmbCampo.SelectedItem.ToString();
                string criterio = cmbCriterio.SelectedItem.ToString();
                string filtro = txtFiltro.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);


            }
            catch (Exception)
            {

                MessageBox.Show("Fallo al intentar filtrar en la busqueda contacte a su programador", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        
    }
}
