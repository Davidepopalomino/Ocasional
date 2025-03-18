using BLL;
using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class MainForm: Form
    {
        private readonly SalarioService salarioService = new SalarioService();
        private readonly List<Profesor> profesores = new List<Profesor>();
        private Timer timer;
        
        public MainForm()
        {
            InitializeComponent();
            InicializarDataGridView();
        }

        private void InicializarDataGridView()
        {
            dgvResultados.ColumnCount = 7;
            dgvResultados.Columns[0].Name = "Nombre";
            dgvResultados.Columns[1].Name = "Salario Base";
            dgvResultados.Columns[2].Name = "Bonificación Posgrado";
            dgvResultados.Columns[3].Name = "Bonificación Investigación";
            dgvResultados.Columns[4].Name = "Salario Total Mensual";
            dgvResultados.Columns[5].Name = "Proyección Anual";
            dgvResultados.Columns[6].Name = "Fecha de Cálculo";

            // Configuraciones adicionales
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultados.AllowUserToAddRows = false;
            dgvResultados.ReadOnly = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación básica
                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtSMMLV.Text))
                {
                    MessageBox.Show("Por favor, completa todos los campos requeridos.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear el objeto Profesor con los datos ingresados
                var profesor = new Profesor
                {
                    Nombre = txtNombre.Text,
                    Tipo = cmbTipo.Text,
                    Categoria = cmb_Categoria.Text,
                    Dedicacion = cmbDedicacion.Text,
                    NivelPosgrado = cmbPosgrado.Text,
                    GrupoInvestigacion = cmbGrupoInvestigacion.Text,
                    SMMLV = int.Parse(txtSMMLV.Text)
                };

                // Realizar los cálculos utilizando los métodos de la capa de servicios
                var salarioBase = salarioService.CalcularSalarioBase(profesor);
                var bonificacionPosgrado = salarioService.CalcularBonificacionPosgrado(profesor.NivelPosgrado, profesor.SMMLV);
                var bonificacionInvestigacion = salarioService.CalcularBonificacionInvestigacion(profesor.GrupoInvestigacion, profesor.SMMLV);
                var salarioTotalMensual = salarioBase + bonificacionPosgrado + bonificacionInvestigacion;
                var proyeccionAnual = salarioTotalMensual * 12;

                // Agregar los datos calculados al DataGridView
                dgvResultados.Rows.Add(
                    profesor.Nombre,
                    salarioBase.ToString("C"),
                    bonificacionPosgrado.ToString("C"),
                    bonificacionInvestigacion.ToString("C"),
                    salarioTotalMensual.ToString("C"),
                    proyeccionAnual.ToString("C"),
                    DateTime.Now.ToString("yyyy-MM-dd") // Fecha del cálculo
                );

                // Mensaje de confirmación en el Label
                MostrarMensaje($"Cálculo realizado para {profesor.Nombre}.", true);
                LimpiarCampos();
            }
            catch (FormatException)
            {
                MessageBox.Show("El campo SMMLV debe ser un número válido.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void MostrarMensaje(string mensaje, bool esExito)
        {
            lblResultado.Text = mensaje;
            lblResultado.ForeColor = esExito ? System.Drawing.Color.Green : System.Drawing.Color.Red;
            lblResultado.BackColor = System.Drawing.Color.LightYellow;
            lblResultado.Visible = true;

            
            timer = new Timer();
            timer.Interval = 3000; 
            timer.Tick += (s, e) =>
            {
                lblResultado.Visible = false;
                timer.Stop();
            };
            timer.Start();
        }

        private void LimpiarCampos()
        {
            
            txtNombre.Clear();
            txtSMMLV.Clear();

            
            cmbTipo.SelectedIndex = -1;
            cmb_Categoria.SelectedIndex = -1;
            cmbDedicacion.SelectedIndex = -1;
            cmbPosgrado.SelectedIndex = -1;
            cmbGrupoInvestigacion.SelectedIndex = -1;

            
            txtNombre.Focus();
        }

        private void btnCalcularNomina_Click(object sender, EventArgs e)
        {
            decimal nominaTotalAnual = 0;

            foreach (DataGridViewRow row in dgvResultados.Rows)
            {
                if (row.Cells[5].Value != null) // Columna "Proyección Anual"
                {
                    decimal proyeccionAnual;
                    if (decimal.TryParse(row.Cells[5].Value.ToString(), System.Globalization.NumberStyles.Currency, null, out proyeccionAnual))
                    {
                        nominaTotalAnual += proyeccionAnual;
                    }
                }
            }

            lblNominaTotal.Text = $"Nómina Total Anual: {nominaTotalAnual:C}";
            lblNominaTotal.Visible = true;
        }
    }
}
