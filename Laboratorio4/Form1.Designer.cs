namespace Laboratorio4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbBienvenida = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbCuotas = new System.Windows.Forms.ComboBox();
            this.rbCuotas = new System.Windows.Forms.RadioButton();
            this.rbContado = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMontoF = new System.Windows.Forms.Label();
            this.txtMontoC = new System.Windows.Forms.Label();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raenco";
            // 
            // lbBienvenida
            // 
            this.lbBienvenida.AutoSize = true;
            this.lbBienvenida.Location = new System.Drawing.Point(52, 71);
            this.lbBienvenida.Name = "lbBienvenida";
            this.lbBienvenida.Size = new System.Drawing.Size(10, 16);
            this.lbBienvenida.TabIndex = 0;
            this.lbBienvenida.Text = ".";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbCuotas);
            this.groupBox2.Controls.Add(this.rbCuotas);
            this.groupBox2.Controls.Add(this.rbContado);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMontoF);
            this.groupBox2.Controls.Add(this.txtMontoC);
            this.groupBox2.Controls.Add(this.cbProducto);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(44, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 369);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos personales";
            // 
            // cbCuotas
            // 
            this.cbCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCuotas.FormattingEnabled = true;
            this.cbCuotas.Items.AddRange(new object[] {
            "12",
            "18",
            "36"});
            this.cbCuotas.Location = new System.Drawing.Point(157, 192);
            this.cbCuotas.Name = "cbCuotas";
            this.cbCuotas.Size = new System.Drawing.Size(120, 33);
            this.cbCuotas.TabIndex = 7;
            this.cbCuotas.SelectedIndexChanged += new System.EventHandler(this.cbCuotas_SelectedIndexChanged);
            // 
            // rbCuotas
            // 
            this.rbCuotas.AutoSize = true;
            this.rbCuotas.Location = new System.Drawing.Point(26, 196);
            this.rbCuotas.Name = "rbCuotas";
            this.rbCuotas.Size = new System.Drawing.Size(96, 29);
            this.rbCuotas.TabIndex = 6;
            this.rbCuotas.TabStop = true;
            this.rbCuotas.Text = "Cuotas";
            this.rbCuotas.UseVisualStyleBackColor = true;
            this.rbCuotas.CheckedChanged += new System.EventHandler(this.rbCuotas_CheckedChanged);
            // 
            // rbContado
            // 
            this.rbContado.AutoSize = true;
            this.rbContado.Location = new System.Drawing.Point(26, 161);
            this.rbContado.Name = "rbContado";
            this.rbContado.Size = new System.Drawing.Size(126, 29);
            this.rbContado.TabIndex = 5;
            this.rbContado.TabStop = true;
            this.rbContado.Text = "Al contado";
            this.rbContado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Forma de pago";
            // 
            // txtMontoF
            // 
            this.txtMontoF.AutoSize = true;
            this.txtMontoF.Location = new System.Drawing.Point(6, 296);
            this.txtMontoF.Name = "txtMontoF";
            this.txtMontoF.Size = new System.Drawing.Size(118, 25);
            this.txtMontoF.TabIndex = 3;
            this.txtMontoF.Text = "Monto final: ";
            // 
            // txtMontoC
            // 
            this.txtMontoC.AutoSize = true;
            this.txtMontoC.Location = new System.Drawing.Point(6, 248);
            this.txtMontoC.Name = "txtMontoC";
            this.txtMontoC.Size = new System.Drawing.Size(164, 25);
            this.txtMontoC.TabIndex = 2;
            this.txtMontoC.Text = "Monto por cuota: ";
            // 
            // cbProducto
            // 
            this.cbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Items.AddRange(new object[] {
            "Lavadora",
            "Nevera",
            "Estufa"});
            this.cbProducto.Location = new System.Drawing.Point(11, 75);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(299, 33);
            this.cbProducto.TabIndex = 1;
            this.cbProducto.SelectedIndexChanged += new System.EventHandler(this.cbProducto_SelectedIndexChanged);
            this.cbProducto.Validating += new System.ComponentModel.CancelEventHandler(this.cbProducto_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(289, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "¿Que producto desea comprar?";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(560, 238);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(207, 73);
            this.btn.TabIndex = 3;
            this.btn.Text = "button1";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(837, 506);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lbBienvenida);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbBienvenida;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtMontoF;
        private System.Windows.Forms.Label txtMontoC;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbCuotas;
        private System.Windows.Forms.RadioButton rbContado;
        private System.Windows.Forms.ComboBox cbCuotas;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

