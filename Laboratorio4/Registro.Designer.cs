namespace Laboratorio4
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btSiguiente = new System.Windows.Forms.Button();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bLimpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.tbedad = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // btSiguiente
            // 
            this.btSiguiente.BackColor = System.Drawing.Color.AliceBlue;
            this.btSiguiente.Location = new System.Drawing.Point(419, 329);
            this.btSiguiente.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btSiguiente.Name = "btSiguiente";
            this.btSiguiente.Size = new System.Drawing.Size(113, 30);
            this.btSiguiente.TabIndex = 14;
            this.btSiguiente.Text = "Siguiente";
            this.btSiguiente.UseVisualStyleBackColor = false;
            this.btSiguiente.Click += new System.EventHandler(this.btSiguiente_Click);
            // 
            // btRegistrar
            // 
            this.btRegistrar.BackColor = System.Drawing.Color.AliceBlue;
            this.btRegistrar.Location = new System.Drawing.Point(251, 263);
            this.btRegistrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(129, 38);
            this.btRegistrar.TabIndex = 13;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = false;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bLimpiar
            // 
            this.bLimpiar.BackColor = System.Drawing.Color.AliceBlue;
            this.bLimpiar.Location = new System.Drawing.Point(23, 263);
            this.bLimpiar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(129, 38);
            this.bLimpiar.TabIndex = 15;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = false;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.pbPassword);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.Label7);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.Label6);
            this.groupBox1.Controls.Add(this.tbedad);
            this.groupBox1.Controls.Add(this.Label5);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(369, 212);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Usuario";
            // 
            // pbPassword
            // 
            this.pbPassword.Image = global::Laboratorio4.Properties.Resources.show;
            this.pbPassword.Location = new System.Drawing.Point(279, 187);
            this.pbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(27, 20);
            this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPassword.TabIndex = 27;
            this.pbPassword.TabStop = false;
            this.pbPassword.Click += new System.EventHandler(this.pbPassword_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(157, 157);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbPassword.MaxLength = 16;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(149, 26);
            this.tbPassword.TabIndex = 26;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbPassword_Validating);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(64, 157);
            this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(93, 20);
            this.Label7.TabIndex = 25;
            this.Label7.Text = "contraseña:";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(157, 116);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbEmail.MaxLength = 50;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(149, 26);
            this.tbEmail.TabIndex = 24;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(15, 116);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(142, 20);
            this.Label6.TabIndex = 23;
            this.Label6.Text = "Correo electronico:";
            // 
            // tbedad
            // 
            this.tbedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbedad.Location = new System.Drawing.Point(157, 78);
            this.tbedad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbedad.MaxLength = 3;
            this.tbedad.Name = "tbedad";
            this.tbedad.Size = new System.Drawing.Size(149, 26);
            this.tbedad.TabIndex = 22;
            this.tbedad.Validating += new System.ComponentModel.CancelEventHandler(this.tbedad_Validating);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(102, 78);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(51, 20);
            this.Label5.TabIndex = 21;
            this.Label5.Text = "Edad:";
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(157, 42);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbNombre.MaxLength = 40;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(149, 26);
            this.tbNombre.TabIndex = 18;
            this.tbNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNombre_KeyDown);
            this.tbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombre_KeyPress);
            this.tbNombre.Validating += new System.ComponentModel.CancelEventHandler(this.tbNombre_Validating);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(7, 44);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(150, 20);
            this.Label2.TabIndex = 17;
            this.Label2.Text = "Nombre de Usuario:";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Laboratorio4.Properties.Resources.loginjpg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(553, 380);
            this.Controls.Add(this.btSiguiente);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btSiguiente;
        internal System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        internal System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbPassword;
        internal System.Windows.Forms.TextBox tbPassword;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox tbEmail;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox tbedad;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox tbNombre;
        internal System.Windows.Forms.Label Label2;
    }
}