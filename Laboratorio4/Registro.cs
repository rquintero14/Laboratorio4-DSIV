using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Laboratorio4
{
    public partial class Registro : Form
    {
        private bool showPassword = false;
        public Registro()
        {
            InitializeComponent();
            bLimpiar.CausesValidation = false;
        }


        private void btRegistrar_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {

                MessageBox.Show("Usuario registrado correctamente");
            }
        }



        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;

            bool letra = char.IsLetter(e.KeyChar);
            bool espacio = char.IsWhiteSpace(e.KeyChar);

            if (!(letra || espacio))
            {
                e.Handled = true;
            }
        }

        private void tbNombre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNombre.Text))
            {
                errorProvider1.SetError(tbNombre, "El nombre no puede estar vacío.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbNombre, string.Empty);
            }
        }

        private void tbedad_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbedad.Text) || !int.TryParse(tbedad.Text.Trim(), out int cantidad) || cantidad < 13 || cantidad > 120)
            {
                errorProvider1.SetError(tbedad, "Ingrese una edad válida");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbedad, string.Empty);
            }
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            string email = tbEmail.Text.Trim();
            try
            {
                var _ = new MailAddress(email);
                errorProvider1.SetError(tbEmail, string.Empty);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(tbEmail, "Correo electrónico inválido.");
                e.Cancel = true;
            }
        }

        private void LimpiarControles(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox tb)
                {
                    tb.Clear();
                }
                else if (c is ComboBox cb)
                {
                    cb.SelectedIndex = -1;
                }
                else if (c.HasChildren)
                {
                    LimpiarControles(c);
                }
            }
        }
        private void bLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles(this);
            errorProvider1.Clear();
            tbNombre.Focus();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            string password = tbPassword.Text;
            string errorMessage = string.Empty;

            if (password.Length < 16)
            {
                errorMessage = "La contraseña debe tener un mínimo de 16 caracteres.";
            }
            else if (!Regex.IsMatch(password, @"[A-Z]"))
            {
                errorMessage = "La contraseña debe contener al menos una letra mayúscula (A-Z).";
            }
            else if (!Regex.IsMatch(password, @"[0-9]"))
            {
                errorMessage = "La contraseña debe contener al menos un dígito (0-9).";
            }
            else if (!Regex.IsMatch(password, @"[^a-zA-Z0-9\s]"))
            {
                errorMessage = "La contraseña debe contener al menos un carácter no alfanumérico (ej: #, $, %, etc.).";
            }
            // Mostrar o borrar error
            if (!string.IsNullOrEmpty(errorMessage))
            {
                errorProvider1.SetError(tbPassword, errorMessage);
            }
            else
            {
                errorProvider1.SetError(tbPassword, string.Empty);
            }


        }


        private void pbPassword_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;
            if (showPassword)
            {
                tbPassword.PasswordChar = '\0';
                pbPassword.Image = Laboratorio4.Properties.Resources.hide;
            }
            else
            {
                tbPassword.PasswordChar = '*';
                pbPassword.Image = Laboratorio4.Properties.Resources.show;
            }
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (errorProvider1.GetError(tbPassword) != string.Empty)
            {
                errorProvider1.SetError(tbPassword, "Contraseña inválida.");
                e.Cancel = true;
            }
            else if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                errorProvider1.SetError(tbPassword, "La contraseña no puede estar vacía.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbPassword, string.Empty);
            }
        }

        private void tbNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V || e.KeyCode == Keys.X))
            {
                e.SuppressKeyPress = true; // Bloquea la tecla
            }
        }

        private void btSiguiente_Click(object sender, EventArgs e)
        {
            Form1 compraForm = new Form1(tbNombre.Text);
            compraForm.Show();
            this.Hide();
        }

        private void Registro_Load_1(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.EnablePreventFocusChange;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            this.AcceptButton = btRegistrar; // Enter dispara validar

        }

       
    }
}
