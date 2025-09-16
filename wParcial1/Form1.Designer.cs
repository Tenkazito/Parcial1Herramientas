namespace wParcial1
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
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.txtHorasExtra = new System.Windows.Forms.TextBox();
            this.txtPorcDeducciones = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblSalarioBase = new System.Windows.Forms.Label();
            this.lblHorasExtra = new System.Windows.Forms.Label();
            this.lblPorcDeducciones = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstNomina = new System.Windows.Forms.ListBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtBuscarDocumento = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscarDocumento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(10, 255);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(171, 22);
            this.txtDocumento.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(10, 310);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(171, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.Location = new System.Drawing.Point(203, 310);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.Size = new System.Drawing.Size(171, 22);
            this.txtSalarioBase.TabIndex = 2;
            // 
            // cboCargo
            // 
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Location = new System.Drawing.Point(203, 252);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(171, 24);
            this.cboCargo.TabIndex = 3;
            // 
            // txtHorasExtra
            // 
            this.txtHorasExtra.Location = new System.Drawing.Point(398, 251);
            this.txtHorasExtra.Name = "txtHorasExtra";
            this.txtHorasExtra.Size = new System.Drawing.Size(171, 22);
            this.txtHorasExtra.TabIndex = 4;
            // 
            // txtPorcDeducciones
            // 
            this.txtPorcDeducciones.Location = new System.Drawing.Point(398, 310);
            this.txtPorcDeducciones.Name = "txtPorcDeducciones";
            this.txtPorcDeducciones.Size = new System.Drawing.Size(171, 22);
            this.txtPorcDeducciones.TabIndex = 5;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(7, 236);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(76, 16);
            this.lblDocumento.TabIndex = 6;
            this.lblDocumento.Text = "Documento";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 291);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(200, 233);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(44, 16);
            this.lblCargo.TabIndex = 8;
            this.lblCargo.Text = "Cargo";
            // 
            // lblSalarioBase
            // 
            this.lblSalarioBase.AutoSize = true;
            this.lblSalarioBase.Location = new System.Drawing.Point(200, 291);
            this.lblSalarioBase.Name = "lblSalarioBase";
            this.lblSalarioBase.Size = new System.Drawing.Size(84, 16);
            this.lblSalarioBase.TabIndex = 9;
            this.lblSalarioBase.Text = "Salario base";
            // 
            // lblHorasExtra
            // 
            this.lblHorasExtra.AutoSize = true;
            this.lblHorasExtra.Location = new System.Drawing.Point(395, 232);
            this.lblHorasExtra.Name = "lblHorasExtra";
            this.lblHorasExtra.Size = new System.Drawing.Size(76, 16);
            this.lblHorasExtra.TabIndex = 10;
            this.lblHorasExtra.Text = "Horas extra";
            // 
            // lblPorcDeducciones
            // 
            this.lblPorcDeducciones.AutoSize = true;
            this.lblPorcDeducciones.Location = new System.Drawing.Point(395, 291);
            this.lblPorcDeducciones.Name = "lblPorcDeducciones";
            this.lblPorcDeducciones.Size = new System.Drawing.Size(153, 16);
            this.lblPorcDeducciones.TabIndex = 11;
            this.lblPorcDeducciones.Text = "Porcentaje deducciones";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(203, 353);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(171, 37);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstNomina
            // 
            this.lstNomina.FormattingEnabled = true;
            this.lstNomina.ItemHeight = 16;
            this.lstNomina.Location = new System.Drawing.Point(12, 27);
            this.lstNomina.Name = "lstNomina";
            this.lstNomina.Size = new System.Drawing.Size(1155, 180);
            this.lstNomina.TabIndex = 13;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(717, 363);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(10, 16);
            this.lblResultado.TabIndex = 14;
            this.lblResultado.Text = ".";
            // 
            // txtBuscarDocumento
            // 
            this.txtBuscarDocumento.Location = new System.Drawing.Point(705, 251);
            this.txtBuscarDocumento.Name = "txtBuscarDocumento";
            this.txtBuscarDocumento.Size = new System.Drawing.Size(166, 22);
            this.txtBuscarDocumento.TabIndex = 15;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(705, 291);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(166, 41);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBuscarDocumento
            // 
            this.lblBuscarDocumento.AutoSize = true;
            this.lblBuscarDocumento.Location = new System.Drawing.Point(702, 232);
            this.lblBuscarDocumento.Name = "lblBuscarDocumento";
            this.lblBuscarDocumento.Size = new System.Drawing.Size(144, 16);
            this.lblBuscarDocumento.TabIndex = 17;
            this.lblBuscarDocumento.Text = "Buscar por Documento";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 450);
            this.Controls.Add(this.lblBuscarDocumento);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscarDocumento);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lstNomina);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblPorcDeducciones);
            this.Controls.Add(this.lblHorasExtra);
            this.Controls.Add(this.lblSalarioBase);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.txtPorcDeducciones);
            this.Controls.Add(this.txtHorasExtra);
            this.Controls.Add(this.cboCargo);
            this.Controls.Add(this.txtSalarioBase);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDocumento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.TextBox txtHorasExtra;
        private System.Windows.Forms.TextBox txtPorcDeducciones;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblSalarioBase;
        private System.Windows.Forms.Label lblHorasExtra;
        private System.Windows.Forms.Label lblPorcDeducciones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstNomina;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtBuscarDocumento;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBuscarDocumento;
    }
}

