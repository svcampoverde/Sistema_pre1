using Datos.Models;
using LogicDeNegocio;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Interfaces;
using LogicDeNegocio.Personas;
using LogicDeNegocio.Requests;
using LogicDeNegocio.Services;
using Microsoft.EntityFrameworkCore.Internal;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.ModuloProveedor
{
    public partial class FrmRegistroProveedor : Form
    {
        private readonly IProveedorService _proveedorService;
        private readonly ICiudadService _ciudadService;
        private readonly ITipoServicioService _ipoServicioService;
        private readonly IPersonaService _personaService;
        private readonly ICuentaService _cuentaService;
        private readonly IBancoService _bancoService;
        private readonly IEmpresaService _empresaService;
        private readonly ITipoCuentaService _ipoCuentaService;
        private readonly IFormaPagoService _formaPago;

        public FrmRegistroProveedor(IProveedorService proveedorService, ICiudadService ciudadService, 
            ITipoServicioService ipoServicioService, IPersonaService persona, ICuentaService cuenta, IBancoService banco,
            IEmpresaService empresaService,ITipoCuentaService tipoCuenta, IFormaPagoService formaPago)
        {
            InitializeComponent();
            _proveedorService = proveedorService ?? throw new ArgumentNullException(nameof(proveedorService)); 
            _ciudadService = ciudadService ?? throw new ArgumentNullException(nameof(ciudadService));
            _ipoServicioService = ipoServicioService ?? throw new ArgumentNullException(nameof(ipoServicioService));
            _cuentaService = cuenta;//?? throw new ArgumentNullException(nameof(cuenta));
            _bancoService= banco ?? throw new ArgumentNullException(nameof(banco));
            _empresaService=empresaService ?? throw new ArgumentNullException(nameof(ipoServicioService));
            _formaPago=formaPago ?? throw new ArgumentNullException(nameof(formaPago));
            _ipoCuentaService = tipoCuenta;
            _personaService = persona;
        }

        private async void FrmRegistroProveedor_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            await Task.WhenAll(LlenarComboBoxServicio(), LlenarComboBoxCiudades(), LlenarComboBoxTipoCuentas(),
               LlenarComboBoxBancos(), LlenarComboBoxEmpresas(), LlenarComboBoxFormaPago());
        }
        private async Task LlenarComboBoxServicio()
        {
            try
            {
                var tipoServicios = await _ipoServicioService.ObtenerTodasTipoServicios();//_rolService.ObtenerTodosLosRoles();
                if (tipoServicios.Any())
                {
                    cmbServiciopro.DataSource = tipoServicios;
                    cmbServiciopro.DisplayMember = "Descripcion";
                    cmbServiciopro.ValueMember = "Id";
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
        private async Task LlenarComboBoxTipoCuentas()
        {
            try
            {
                var cuenta = await _ipoCuentaService.ObtenerTodasTipoCuentas();
                if (cuenta.Any())
                {
                    cmbCuentaproveedor.DataSource = cuenta;
                    cmbCuentaproveedor.DisplayMember = "Descripcion";
                    cmbCuentaproveedor.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task LlenarComboBoxBancos()
        {
            try
            {
                var banco = await _bancoService.ObtenerBancos();
                if (banco.Any())
                {
                    cmbBancoProveedor.DataSource = banco;
                    cmbBancoProveedor.DisplayMember = "Nombre";
                    cmbBancoProveedor.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task LlenarComboBoxEmpresas()
        {
            try
            {
                var empresa = await _empresaService.ObtenerTodasEmpresas();
                if (empresa.Any())
                {
                    cmbEmpresap.DataSource = empresa;
                    cmbEmpresap.DisplayMember = "Descripcion";
                    cmbEmpresap.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task LlenarComboBoxFormaPago()
        {
            try
            {
                var forms = await _formaPago.ObtenerTodasFormaPagos();
                if (forms.Any())
                {
                    cmbFpagoproveedor.DataSource = forms;
                    cmbFpagoproveedor.DisplayMember = "Nombre";
                    cmbFpagoproveedor.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnGuardarprove_Click(object sender, EventArgs e)
        {
             // int idservicio = Convert.ToInt32(cmbServiciopro.Texts);
             //int idprovincia = Convert.ToInt32(cmbCiudad.Texts);
            try
            {
            string cedula = txtCedula.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string genero = cmbGeneropro.Texts;
            string telefono = txtTelefono.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            string numcuenta = txtnumCuenta.Text.Trim();
            int idBanco = cmbBancoProveedor.SelectedIndex;
            int idempresa = cmbEmpresap.SelectedIndex;
            int idtipocuenta = cmbCuentaproveedor.SelectedIndex;
            int idformapago =cmbFpagoproveedor.SelectedIndex;
            int idservicio = cmbServiciopro.SelectedIndex;
            int idciudad = cmbCiudad.SelectedIndex;
            PersonaRequest person = new PersonaRequest
            {
                Cedula = cedula,
                Nombre = nombre,
                Apellido = apellido,
                Telefono = telefono,
                Genero = genero,
                Celular = celular,
                Correo = correo,
                Direccion = direccion,
                IdCiudad= idciudad,
                
            };
            PersonaDto persona = await _personaService.RegistrarPersona(person);
           // PersonaDto p = new PersonaDto();
            int idperson = persona.Id;
            var request = new CuentaRequest
            {
                IdBanco = cmbBancoProveedor.SelectedIndex,
                IdTipoCuenta=cmbCuentaproveedor.SelectedIndex,
                NumCuenta = numcuenta,
            };
             CuentaDto cuentaid = await _cuentaService.RegistrarCuenta(request);
            
            int idcuenta = cuentaid.Id;

            var proved = new ProveedorRequest
            {
                IdPersona = idperson,
                IdCiudad=idciudad,
                //IdTipoServicio = idservicio,
                ServicioId=idservicio,
                //TipoServicio=txtCelular.Text,
                //Empresa = 
                IdEmpresa=idempresa,
                IdCuenta=idcuenta,
                IdFormaPago=idformapago,
 
            };
                await _proveedorService.RegistrarProveedor(proved);
                MessageBox.Show("Proveedor registrado con exitó.");
            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtEmpresa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
