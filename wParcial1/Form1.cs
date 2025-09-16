using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wParcial1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cboCargo.Items.Add("Gerente");
            cboCargo.Items.Add("Recepcionista");
            cboCargo.Items.Add("Contratista");
            cboCargo.Items.Add("Personal de aseo");
            cboCargo.Items.Add("Camionero");
            cboCargo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        List<clsEmpleado> Empleados = new List<clsEmpleado>();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtDocumento.Text, out int documento))
                {
                    throw new ArgumentException("El documento debe ser un valor numerico.");
                }
                string nombre = txtNombre.Text.Trim() ?? "";
                string cargo = cboCargo.Text;
                if (!double.TryParse(txtSalarioBase.Text, out double salario))
                {
                    throw new ArgumentException("El salario debe ser un valor numerico.");
                }
                if (!int.TryParse(txtHorasExtra.Text, out int horasExtras))
                {
                    throw new ArgumentException("Las horas extras deben ser un valor numerico.");
                }
                if (!int.TryParse(txtPorcDeducciones.Text, out int porcentaje))
                {
                    throw new ArgumentException("El porcentaje de deducciones debe ser un valor numerico.");
                }
                foreach (clsEmpleado persona in Empleados)
                {
                    if (persona.Documento == documento)
                    {
                        throw new ArgumentException("Ya existe un empleado con este documento.");
                    }
                }

                clsEmpleado empleado = new clsEmpleado(documento, nombre, cargo, salario, horasExtras, porcentaje);
                string resultado = empleado.Validar();

                if (resultado != "OK")
                {
                    throw new ArgumentException(resultado);
                }

                Empleados.Add(empleado);
                lstNomina.Items.Add(empleado.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtBuscarDocumento.Text, out int documento))
                {
                    throw new ArgumentException("El documento no puede estar vacio y debe ser un valor numerico.");
                }
                for (int x = 0; x < Empleados.Count; x++)
                {
                    if (Empleados[x].Documento == documento)
                    {
                        lblResultado.Text = Empleados[x].ToString();
                        return;
                    }
                }
                throw new ArgumentException("Empleado no encontrado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
