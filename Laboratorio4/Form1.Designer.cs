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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raenco";
            // 
            // lbBienvenida
            // 
            this.lbBienvenida.AutoSize = true;
            this.lbBienvenida.Location = new System.Drawing.Point(39, 58);
            this.lbBienvenida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBienvenida.Name = "lbBienvenida";
            this.lbBienvenida.Size = new System.Drawing.Size(10, 13);
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
            this.groupBox2.Location = new System.Drawing.Point(81, 58);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(359, 291);
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
            this.cbCuotas.Location = new System.Drawing.Point(118, 156);
            this.cbCuotas.Margin = new System.Windows.Forms.Padding(2);
            this.cbCuotas.Name = "cbCuotas";
            this.cbCuotas.Size = new System.Drawing.Size(91, 28);
            this.cbCuotas.TabIndex = 7;
            this.cbCuotas.SelectedIndexChanged += new System.EventHandler(this.cbCuotas_SelectedIndexChanged);
            // 
            // rbCuotas
            // 
            this.rbCuotas.AutoSize = true;
            this.rbCuotas.Location = new System.Drawing.Point(20, 159);
            this.rbCuotas.Margin = new System.Windows.Forms.Padding(2);
            this.rbCuotas.Name = "rbCuotas";
            this.rbCuotas.Size = new System.Drawing.Size(78, 24);
            this.rbCuotas.TabIndex = 6;
            this.rbCuotas.TabStop = true;
            this.rbCuotas.Text = "Cuotas";
            this.rbCuotas.UseVisualStyleBackColor = true;
            this.rbCuotas.CheckedChanged += new System.EventHandler(this.rbCuotas_CheckedChanged);
            // 
            // rbContado
            // 
            this.rbContado.AutoSize = true;
            this.rbContado.Location = new System.Drawing.Point(20, 131);
            this.rbContado.Margin = new System.Windows.Forms.Padding(2);
            this.rbContado.Name = "rbContado";
            this.rbContado.Size = new System.Drawing.Size(103, 24);
            this.rbContado.TabIndex = 5;
            this.rbContado.TabStop = true;
            this.rbContado.Text = "Al contado";
            this.rbContado.UseVisualStyleBackColor = true;
            this.rbContado.CheckedChanged += new System.EventHandler(this.rbContado_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Forma de pago";
            // 
            // txtMontoF
            // 
            this.txtMontoF.AutoSize = true;
            this.txtMontoF.Location = new System.Drawing.Point(16, 240);
            this.txtMontoF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtMontoF.Name = "txtMontoF";
            this.txtMontoF.Size = new System.Drawing.Size(95, 20);
            this.txtMontoF.TabIndex = 3;
            this.txtMontoF.Text = "Monto final: ";
            // 
            // txtMontoC
            // 
            this.txtMontoC.AutoSize = true;
            this.txtMontoC.Location = new System.Drawing.Point(16, 208);
            this.txtMontoC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtMontoC.Name = "txtMontoC";
            this.txtMontoC.Size = new System.Drawing.Size(133, 20);
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
            this.cbProducto.Location = new System.Drawing.Point(8, 61);
            this.cbProducto.Margin = new System.Windows.Forms.Padding(2);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(225, 28);
            this.cbProducto.TabIndex = 1;
            this.cbProducto.SelectedIndexChanged += new System.EventHandler(this.cbProducto_SelectedIndexChanged);
            this.cbProducto.Validating += new System.ComponentModel.CancelEventHandler(this.cbProducto_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "¿Que producto desea comprar?";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(543, 379);
            this.Controls.Add(this.lbBienvenida);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbCuotas;
        private System.Windows.Forms.RadioButton rbContado;
        private System.Windows.Forms.ComboBox cbCuotas;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

