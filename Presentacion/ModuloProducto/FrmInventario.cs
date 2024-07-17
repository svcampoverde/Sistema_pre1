using LogicDeNegocio.Interfaces;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Internal;
using DevComponents.DotNetBar.Validator;
using LogicDeNegocio;
using LogicDeNegocio.Requests;
using LogicDeNegocio.Dtos;
using Datos.Models;

namespace Presentacion.ModuloProducto
{
    public partial class FrmInventario : Form
    {
        private readonly ITipoProductoService _tipoProducto;
        private readonly IProductoService _productoService;
        private readonly ICategoriaProductoService _categoriaProductoService;
        private readonly ICategoriaAtributoService _categoriaAtributoService;
        private readonly IAtributoProductoService _atributoProductoService;
        private readonly IInventarioService _inventarioService;
        private readonly IAtributoService _atributo;
        public FrmInventario(ITipoProductoService tipo, IProductoService producto, ICategoriaAtributoService atributoService,
            ICategoriaProductoService productoService, IInventarioService inventario, IAtributoProductoService atributoProductoService, IAtributoService atributo)
        {
            _tipoProducto = tipo;
            _productoService = producto;
            _categoriaProductoService = productoService;
            _categoriaAtributoService = atributoService;
            _inventarioService = inventario;
            _atributoProductoService = atributoProductoService;
            _atributo = atributo;
            InitializeComponent();
            
        }
        private async Task LlenarComboTipoProducto()
        {
            try
            {
                var tipos = await _tipoProducto.ObtenerTodasTipoProductos();
                if (tipos.Any())
                {
                    cmbtipoProducto.DataSource = tipos;
                    cmbtipoProducto.DisplayMember = "Descripcion";
                    cmbtipoProducto.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task LlenarComboCategoria()
        {
            try
            {
                var categorias = await _categoriaProductoService.ObtenerTodasCategoriaProductos();
                if (categorias.Any())
                {
                    cmbCatproducto.DataSource = categorias;
                    cmbCatproducto.DisplayMember = "Descripcion";
                    cmbCatproducto.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void FrmInventario_Load(object sender, System.EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            await Task.WhenAll(LlenarComboTipoProducto(), LlenarComboCategoria());
        }

        private async void btnedpecificaciones_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    var productoexist = await _productoService.ObtenerProductoName(txtProducto.Text);
                    AtributoDto dto = new AtributoDto();
                    int idatributo = dto.Id;
                if (productoexist != null && idatributo > 0)
                {
                    var idproducto = productoexist.Id;

                        productoexist.Descripcion = txtDescripcionproducto.Text;
                        productoexist.Precio = Convert.ToDecimal(txtpreciovent.Text);
                        productoexist.IdCategoriaProducto = cmbCatproducto.SelectedIndex;
                        productoexist.IdTipoProducto = cmbtipoProducto.SelectedIndex;
               
                    await _productoService.ActualizarProducto(idproducto, productoexist);
                        dto.Nombre= txtTamanio.Text; 
                        dto.Unidades= txtPeso.Text;
                        await _atributo.ActualizarAtributo(dto.Id, dto);
                }
                else
                {
                    ProductoRequest pro = new ProductoRequest()
                    {
                        Nombre = txtProducto.Text,
                        Descripcion = txtDescripcionproducto.Text,
                        Precio = Convert.ToDecimal(txtpreciovent.Text),
                        IdCategoriaProducto = cmbCatproducto.SelectedIndex,
                        IdTipoProducto = cmbtipoProducto.SelectedIndex
                    };

                    ProductoDto Idproducto = await _productoService.RegistrarProducto(pro);
                    int idpro = Idproducto.Id;

                    AtributoRequest request = new AtributoRequest()
                    {
                        Nombre = txtPeso.Text,
                        Unidades = txtTamanio.Text,
                        IdCategoriaAtributo = idpro,
                        
                    };
                    AtributoDto atribut = await _atributo.RegistrarAtributo(request);

                        InventarioRequest inv = new InventarioRequest()
                        {
                            Digitador = txtUsmodificado.Text,
                            TipoMaterial = cmbTipomaterial.Text,
                            Ubicacion = txtUbicacion.Text,
                            Cantidad = Convert.ToInt32(txtCantidad.Text),
                            EstadoProducto = cmbEstproducto.Text,
                            PrecioCompra = Convert.ToDecimal(txtprecosto.Text),
                            PrecioVenta = Convert.ToDecimal(txtpreciovent.Text),
                            ProductoId = idpro
                            
                        };

                        await _inventarioService.RegistrarInventario(inv);

                        
                        int atributoId = atribut.Id;
                        // Crear el objeto AtributoProductoRequest
                        AtributoProductoRequest atributoRequest = new AtributoProductoRequest()
                        {
                            IdProducto = idpro,
                            IdAtributo = atributoId,
                            Valor = txtEspecificacion.Text
                        };

                        await _atributoProductoService.RegistrarAtributoProducto(atributoRequest);
                        MessageBox.Show("Producto y atributos registrados con éxito.");

                        MessageBox.Show("registro guardado con exito");
                }
                }
            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private async void btnGuardarprove_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (!String.IsNullOrEmpty(txtUsmodificado.Text))
                {
                    var productoExist = await _productoService.ObtenerProductoName(txtProducto.Text);

                    if (productoExist != null)
                    {
                        int productoId = productoExist.Id;
                        InventarioRequest inv = new InventarioRequest()
                        {
                            Digitador = txtUsmodificado.Text,
                            TipoMaterial = cmbTipomaterial.Text,
                            Ubicacion = txtUbicacion.Text,
                            Cantidad = Convert.ToInt32(txtCantidad.Text),
                            EstadoProducto = cmbEstproducto.Text,
                            PrecioCompra = Convert.ToDecimal(txtprecosto.Text),
                            PrecioVenta = Convert.ToDecimal(txtpreciovent.Text),
                            ProductoId = productoId
                        };

                        await _inventarioService.RegistrarInventario(inv);

                        AtributoDto dto = new AtributoDto();
                        int atributoId = dto.Id;
                        MessageBox.Show("valor id" + dto);
                        // Crear el objeto AtributoProductoRequest
                        AtributoProductoRequest atributoRequest = new AtributoProductoRequest()
                        {
                            IdProducto = productoId,
                            IdAtributo = atributoId,
                            Valor = txtEspecificacion.Text
                        };

                        await _atributoProductoService.RegistrarAtributoProducto(atributoRequest);
                        MessageBox.Show("Producto y atributos registrados con éxito.");
                    }
                    else
                    {
                        throw new ExceptionSistema("Error al registrar el producto. ID no válido.");
                    }

                }
            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private bool Validar()
        {
            bool campo = true;
            if (txtProducto.Text == "")
            {
                campo = false;
                errorProvider1.SetError(txtProducto, "Ingrese un nombre de producto");
            }
            if (txtDescripcionproducto.Text == "")
            {
                campo = false;
                errorProvider1.SetError(txtDescripcionproducto, "Ingrese una descripción de producto");
            }
            return campo;
        }

        private void txtDescripcionproducto_TextChanged(object sender, EventArgs e)
        {
           // MessageBox.Show("edita");
        }

        private async void txtProducto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtProducto.Text))
                {
                    var productoExist = await _productoService.ObtenerProductoName(txtProducto.Text);
                    if (productoExist != null)
                    {
                        txtDescripcionproducto.Text = productoExist.Descripcion;
                        txtpreciovent.Text = productoExist.Precio.ToString();
                        cmbCatproducto.SelectedIndex = productoExist.IdCategoriaProducto;
                      //  Convert.ToInt32(cmbtipoProducto.SelectedIndex) = productoExist.IdTipoProducto;
                     
                    }
                    else
                    {
                        txtDescripcionproducto.Text="";
                        txtpreciovent.Text="";
                        cmbCatproducto.SelectedIndex = -1;
                        cmbtipoProducto.SelectedIndex = -1;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
