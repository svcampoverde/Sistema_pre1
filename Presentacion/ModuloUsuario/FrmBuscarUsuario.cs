using LogicDeNegocio;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Interfaces;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

using Unity;

namespace Presentacion.ModuloUsuario
{
    public partial class FrmBuscarUsuario : Form
    {
        private FrmIPrincipal Frmdi;
        private IUnityContainer _container;
        private readonly IUsuarioService _service;
        private readonly IPersonaService _personaService;
         int Id;
        public FrmBuscarUsuario(IUnityContainer container, FrmIPrincipal mdip, IUsuarioService service, IPersonaService personaService)
        {
            InitializeComponent();
            this.Frmdi = mdip;
            this._container = container;
            this._service = service;
            this._personaService = personaService;
        }

        private void BuscarUsuario_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            llenarDatagrid("");
            txtBuscar.TextChanged += new EventHandler(txtBuscar_TextChanged);
        }
        private async void llenarDatagrid(string cedula)
        {
            try
            {
                List<UsuarioDto> list = await _service.ObtenerUsuarios(cedula);
                dtgUsuario.Rows.Clear();
                // dtgUsuario.DataSource = await _personaService.BuscarPersona(datos);
                int cont = 0;

                foreach (UsuarioDto usuario in list)
                {
                    dtgUsuario.Rows.Add(1);
                    dtgUsuario.Rows[cont].Cells[0].Value = usuario.Id.ToString();
                    dtgUsuario.Rows[cont].Cells[1].Value = usuario.Cedula.ToString();
                    dtgUsuario.Rows[cont].Cells[2].Value = usuario.Nombre.ToString();
                    dtgUsuario.Rows[cont].Cells[3].Value = usuario.Apellido.ToString();
                    dtgUsuario.Rows[cont].Cells[4].Value = usuario.Genero.ToString();
                    dtgUsuario.Rows[cont].Cells[5].Value = usuario.Telefono.ToString();
                    dtgUsuario.Rows[cont].Cells[6].Value = usuario.Celular.ToString();
                    dtgUsuario.Rows[cont].Cells[7].Value = usuario.NombreUsuario.ToString();
                    dtgUsuario.Rows[cont].Cells[8].Value = usuario.RolUsuario.ToString();
                    dtgUsuario.Rows[cont].Cells[9].Value = usuario.Correo.ToString();
                    dtgUsuario.Rows[cont].Cells[10].Value = usuario.Direccion.ToString();
                    dtgUsuario.Rows[cont].Cells[11].Value = usuario.CiudadDescripcion.ToString();
                    cont++;
                }
            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            llenarDatagrid(txtBuscar.Text);
        }
        private async void dtgUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dtgUsuario.Rows.Count &&
                    e.ColumnIndex >= 0 && e.ColumnIndex < dtgUsuario.Columns.Count)
                {
                    if (dtgUsuario.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
                        dtgUsuario.Rows[e.RowIndex].Cells["Id"].Value != null)
                    {
                        int id = Convert.ToInt32(dtgUsuario.Rows[e.RowIndex].Cells["Id"].Value);

                        // Si se hace clic en el botón de editar
                        if (dtgUsuario.Columns[e.ColumnIndex].Name == "btnEditar")
                        {
                            this.Close(); // Cerrar el formulario actual si es necesario

                            // Abrir el formulario para modificar el usuario
                            Frmdi.OpenChildForm<FrmModificarUsuario>(frm => frm.SetIdUsuario(id));
                        }
                        // Si se hace clic en el botón de eliminar
                        else if (dtgUsuario.Columns[e.ColumnIndex].Name == "dbtnEliminar")
                        {
                            // Aquí puedes implementar la lógica para eliminar el usuario
                            // Por ejemplo, mostrar un mensaje de confirmación y luego proceder con la eliminación
                            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar este usuario?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                // Lógica para eliminar el usuario
                                await EliminarUsuario(id);
                                llenarDatagrid(null);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("La celda 'Idusuario' no contiene un valor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show("Se produjo un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task EliminarUsuario(int id)
        {
            await _personaService.EliminarPersona(id);
            MessageBox.Show("Usuario eliminado correctamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CloseAllMdiChildren()
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            llenarDatagrid(txtBuscar.Text);
        }
    }
}
