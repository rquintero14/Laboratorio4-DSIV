using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio4
{
    public partial class Form1 : Form
    {
        double montoBruto, montoNeto,interes=0;
        int cantidadCuota;
        public Form1()
        {
            InitializeComponent();
        }

        void DeterminarBruto() {
            if (cbProducto.SelectedIndex == 0)
                montoBruto = 160;
            else if (cbProducto.SelectedIndex == 1)
                montoBruto = 450;
            else if (cbProducto.SelectedIndex == 2)
                montoBruto = 250;
            else errorProvider1.SetError(cbProducto,"Debe seleccionar una opción para continuar");
            
        }

        void CalcularInteres() {
            
            if (cbCuotas.SelectedIndex == 0)
                interes = 0.05;
            else if (cbCuotas.SelectedIndex == 1)
                interes = 0.07;
            else if (cbCuotas.SelectedIndex == 2)
                interes = 0.1;
            else interes = 0;
        }

        void CalcularNeto() {
            montoNeto = montoBruto * (1.07 + interes);
            txtMontoF.Text = "El Monto final es de: " + Math.Round(montoNeto,2);
            txtMontoC.Text = "El monto por cuotas es de: " + Math.Round(montoNeto / cantidadCuota,2);

        }

        private void cbProducto_Validating(object sender, CancelEventArgs e)
        {
            if (cbProducto.SelectedItem == null)
            {
                errorProvider1.SetError(cbProducto, "Debe seleccionar una opción para continuar");
                e.Cancel = true;
            }
                
            
            else errorProvider1.SetError(cbProducto, string.Empty);
        }

        private void rbCuotas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCuotas.Checked) cbCuotas.Show();
            else
            {
                cbCuotas.SelectedIndex = -1;
                cbCuotas.Hide();
            }

            
        }

        private void cbCuotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCuotas.SelectedIndex != -1)
            {
                CalcularInteres();
                cantidadCuota = int.Parse(cbCuotas.SelectedItem.ToString());
                CalcularNeto();
                mostrarResultados();
            }
               
            else return;
                
        }

        void esconderResultados() {
            txtMontoC.Hide();
            txtMontoF.Hide();
        }

        private void rbContado_CheckedChanged(object sender, EventArgs e)
        {   
            CalcularInteres();
            esconderResultados();
            CalcularNeto();
            txtMontoF.Show();
        }

        void mostrarResultados() {
            txtMontoC.Show();
            txtMontoF.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.EnablePreventFocusChange;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            cbCuotas.Hide();
            esconderResultados();
        }

        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeterminarBruto();
            CalcularNeto();
        }
    }
}
