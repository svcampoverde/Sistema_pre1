
using LogicDeNegocio;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Interfaces;
using LogicDeNegocio.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.ModuloUsuario
{
    public partial class FrmUsuario : Form
    {
        private readonly IUsuarioService _service;
        private readonly ICiudadService _ciudadService;
        private readonly IRolService _rolService;
        private readonly IPersonaService _personaService;
        //Ciudad ciud = new Ciudad();
        //Rol r = new Rol();
        //Usuario u = new Usuario();
        int Id;
        public FrmUsuario(IUsuarioService usuarioService, ICiudadService ciudadService, IRolService olService, IPersonaService personaService)
        {

            _service = usuarioService;// ?? throw new ArgumentNullException(nameof(usuarioService));
            _personaService = personaService;
            _ciudadService = ciudadService ?? throw new ArgumentNullException(nameof(ciudadService));
            _rolService = olService ?? throw new ArgumentNullException(nameof(olService));

            InitializeComponent();
            llenarDatagrid("");
        }
        private async Task LlenarComboBoxRoles()
        {
            try
            {
                var roles = await _rolService.ObtenerTodosLosRoles();
                if (roles.Any())
                {
                    cbRol.DataSource = roles;
                    cbRol.DisplayMember = "Descripcion";
                    cbRol.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LlenarComboBoxCiudades()
        {
            try
            {
                var ciudades = await _ciudadService.obtenerCiudades();
                if (ciudades.Any())
                {
                    cmbCiudad.DataSource = ciudades;
                    cmbCiudad.DisplayMember = "Nombre";
                    cmbCiudad.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void llenarDatagrid(string cedula)
        {
            try
            {
                pnlLisUss.Visible = true;
                pnlRegUss.Visible = false;
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

        private async void FrmUsuario_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            await Task.WhenAll(LlenarComboBoxRoles(), LlenarComboBoxCiudades());
            llenarDatagrid("");
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                btnGuardar.Enabled = false;
                int idCiudad = Convert.ToInt32(cmbCiudad.SelectedValue);
                int idRol = Convert.ToInt32(cbRol.SelectedValue);
                string cedula = txtCedula.Text.Trim();
                string nombre = txtNombre.Text.Trim();
                string apellido = txtApellido.Text.Trim();
                string genero = cmbGenero.Texts;
                string telefono = txtTelefono.Text.Trim();
                string celular = txtCelular.Text.Trim();
                string correo = txtCorreo.Text.Trim();
                string direccion = txtDireccion.Text.Trim();
                string usuario = txtUsuario.Text.Trim();
                string clave = txtClave.Text.Trim();

                var request = new UsuarioRequest
                {
                    IdCiudad = idCiudad,
                    IdRol = idRol,
                    Cedula = cedula,
                    Nombre = nombre,
                    Apellido = apellido,
                    Genero = genero,
                    Telefono = telefono,
                    Celular = celular,
                    Correo = correo,
                    Direccion = direccion,
                    NombreUsuario = usuario,
                    Clave = clave,
                };

                await _service.RegistrarUsuarioAsync(request);
                MessageBox.Show("Usuario registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGuardar.Enabled = true;
            }
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtCedula.Text)
                || string.IsNullOrEmpty(txtNombre.Text)
                || string.IsNullOrEmpty(txtApellido.Text)
                || string.IsNullOrEmpty(txtTelefono.Text)
                || string.IsNullOrEmpty(txtCelular.Text)
                || string.IsNullOrEmpty(txtCorreo.Text)
                || string.IsNullOrEmpty(txtDireccion.Text)
                || string.IsNullOrEmpty(txtUsuario.Text)
                || string.IsNullOrEmpty(txtClave.Text))
            {
                return false;
            }
            return true;
        }

        private void LimpiarCampos()
        {
            txtCedula.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            cmbGenero.SelectedIndex = -1;
            txtTelefono.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtClave.Text = string.Empty;
        }

        //private bool validar()
        //{
        //    Validacionp valida = new Validacionp();
        //    bool campo = true;
        //    if (valida.ValidarCedula(txtCedula.Text) != true)
        //    {
        //        campo = false;
        //        errorProvider1.SetError(txtCedula, "Se esperaba 10 numeros.");
        //    }
        //    if (txtNombre.Text == "")
        //    {
        //        campo = false;
        //        errorProvider1.SetError(txtNombre, "Ingrese un nombre completo.");
        //    }
        //    if (txtApellido.Text == "")
        //    {
        //        campo = false;
        //        errorProvider1.SetError(txtNombre, "Ingrese un apellido completo.");
        //    }
        //    if (valida.ValidarTelefono(txtTelefono.Text) != true)
        //    {
        //        campo = false;
        //        errorProvider1.SetError(txtTelefono, "Se esperaba 10 numeros.");
        //    }
        //    if (valida.ValidarCelular(txtCelular.Text) != true)
        //    {
        //        campo = false;
        //        errorProvider1.SetError(txtCelular, "Se esperaba 10 numeros");
        //    }
        //    if (cmbGenero.SelectedIndex < 0)
        //    {
        //        campo = false;
        //        errorProvider1.SetError(cmbGenero, "Selecione un tipo de genero.");
        //    }
        //    if (cmbCiudad.SelectedIndex < 0)
        //    {
        //        campo = false;
        //        errorProvider1.SetError(cmbCiudad, "Selecione una ciudad.");
        //    }
        //    if (cbRol.SelectedIndex < 0)
        //    {
        //        campo = false;
        //        errorProvider1.SetError(cbRol, "Selecione un tipo de rol.");
        //    }
        //    if (valida.validarEmail(txtCorreo.Text) != true)
        //    {
        //        campo = false;
        //        errorProvider1.SetError(txtCorreo, "Ingrese su correo electronico.");
        //    }
        //    if (txtClave.Text == "")
        //    {
        //        campo = false;
        //        errorProvider1.SetError(txtClave, "Ingrese una contraseña.");
        //    }
        //    if (txtDireccion.Text == "")
        //    {
        //        campo = false;
        //        errorProvider1.SetError(txtDireccion, "Ingrese una direccion.");
        //    }
        //    if (txtUsuario.Text == "")
        //    {
        //        campo = false;
        //        errorProvider1.SetError(txtUsuario, "Ingrese un usuario.");
        //    }
        //    if (!campo)
        //    {
        //        throw new ExceptionSistema("Datos no validos!");
        //    }
        //    return campo;
        //}
        private void BorrarAlerta()
        {
            errorProvider1.SetError(txtCedula, "");
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtApellido, "");
            errorProvider1.SetError(cmbGenero, "");
            errorProvider1.SetError(txtTelefono, "");
            errorProvider1.SetError(txtCelular, "");
            errorProvider1.SetError(cmbCiudad, "");
            errorProvider1.SetError(cbRol, "");
            errorProvider1.SetError(txtCorreo, "");
            errorProvider1.SetError(txtDireccion, "");
            errorProvider1.SetError(txtUsuario, "");
            errorProvider1.SetError(txtClave, "");
        }
        public void Limpiar()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtCelular.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtUsuario.Text = "";
            txtClave.Text = "";
        }


        private void ptbaddU_Click(object sender, EventArgs e)
        {
            pnlRegUss.Visible = true;
            pnlMuser.Visible = false;
            pnlLisUss.Visible = false;
        }

        private void ptbvolver_Click(object sender, EventArgs e)
        {
            pnlRegUss.Visible = false;
            pnlMuser.Visible = false;
            pnlLisUss.Visible = true;
        }

        private void ptbMvolver_Click(object sender, EventArgs e)
        {
            pnlRegUss.Visible = false;
            pnlMuser.Visible = false;
            pnlLisUss.Visible = true;
        }

        private async void btnActualizarus_Click(object sender, EventArgs e)
        {
            UsuarioDto us = await _service.ObtenerUsuarioPorId(Id);
            String cedula = txtMcedula.Text, nombre = txtMnombre.Text, apellido = txtMapellido.Text, telefono = txtMtelefono.Text,
                celular = txtMCelular.Text, correo = txtMcorreo.Text, user = txtMusuario.Text, direccion = txtMdireccion.Text;
            if (!String.IsNullOrEmpty(txtMcedula.Text))
            {
                PersonaRequest request = new PersonaRequest()
                {
                    Cedula = cedula,
                    Nombre = nombre,
                    Apellido = apellido,
                    Telefono = telefono,
                    Celular = celular,
                    Correo = correo,
                    Direccion = direccion,
                };
                await _personaService.ActualizarPersona(us.IdPersona, request);
                UsuarioRequest empl = new UsuarioRequest
                {
                    NombreUsuario = user,
                };
                await _service.ActualizarUsuarioAsync(us.Id, empl);
                MessageBox.Show("Datos actualizados");
                llenarDatagrid("");
                pnlRegUss.Visible = false;
                pnlMuser.Visible = false;
                pnlLisUss.Visible = true;

            }
        }

        private void txtBuscarUs_TextChanged(object sender, EventArgs e)
        {
            llenarDatagrid(txtBuscarUs.Text);
        }

        private async void dtgUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verificar que el índice de la columna y la fila estén dentro del rango
                if (e.RowIndex >= 0 && e.RowIndex < dtgUsuario.Rows.Count &&
                    e.ColumnIndex >= 0 && e.ColumnIndex < dtgUsuario.Columns.Count)
                {
                    if (dtgUsuario.Columns[e.ColumnIndex].Name == "btnEditar")
                    {
                        // Verificar si la columna es de tipo DataGridViewImageColumn
                        if (dtgUsuario.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                        {
                            // Verificar que la celda tenga un valor válido
                            if (dtgUsuario.Rows[e.RowIndex].Cells["idusuario"].Value != null)
                            {
                                Id = Convert.ToInt32(dtgUsuario.Rows[e.RowIndex].Cells["idusuario"].Value);
                                txtMcedula.Text = dtgUsuario.Rows[e.RowIndex].Cells["cedula"].Value.ToString();
                                txtMnombre.Text = dtgUsuario.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                                txtMapellido.Text = dtgUsuario.Rows[e.RowIndex].Cells["apellido"].Value.ToString();
                                txtMtelefono.Text = dtgUsuario.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
                                txtMCelular.Text = dtgUsuario.Rows[e.RowIndex].Cells["celular"].Value.ToString();
                                txtMusuario.Text = dtgUsuario.Rows[e.RowIndex].Cells["usuario"].Value.ToString();
                                cmbMrol.Texts = dtgUsuario.Rows[e.RowIndex].Cells["rolusuario"].Value.ToString();
                                txtMcorreo.Text = dtgUsuario.Rows[e.RowIndex].Cells["correo"].Value.ToString();
                                cmbMciudad.Texts = dtgUsuario.Rows[e.RowIndex].Cells["ciudad"].Value.ToString();
                                txtMdireccion.Text = dtgUsuario.Rows[e.RowIndex].Cells["direccion"].Value.ToString();
                                pnlRegUss.Visible = false;
                                pnlMuser.Visible = true;
                                pnlLisUss.Visible = false;
                                //  cmbMtipemp.Click += new EventHandler(cmbMtipemp_Click_1);

                            }
                            else
                            {
                                MessageBox.Show("La celda no contiene un valor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    if (e.ColumnIndex == dtgUsuario.Columns["btnEliminar"].Index)
                    {
                        DialogResult result = MessageBox.Show("Se eliminara el registro de forma permanete. ¿Desea continuar?", "Eliminar registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            Id = Convert.ToInt32(dtgUsuario.Rows[e.RowIndex].Cells["idusuario"].Value);
                            UsuarioDto dto = await _service.ObtenerUsuarioPorId(Id);
                            await _personaService.EliminarPersona(dto.IdPersona);
                            await _service.EliminarUsuario(dto.Id);
                            llenarDatagrid("");
                        }

                    }
                }
            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show("Se produjo un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
