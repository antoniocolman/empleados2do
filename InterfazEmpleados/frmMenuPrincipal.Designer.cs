namespace InterfazEmpleados
{
    partial class frmMenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSistemaParametros = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSistemaSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.matenimientoDePersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMantenimientoEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMantenimientoCargos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMantenimientoReposos = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRegistroMarcaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRegistroHorasExtras = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRegistroDiasLibres = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRegistrosCambiosCargo = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeCargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInformesVacaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInformesMarcaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInformesLlegadasTardias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInformesLiquidaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiosDeCargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.matenimientoDePersonalToolStripMenuItem,
            this.registrosToolStripMenuItem,
            this.mantenimientoDeCargosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(494, 25);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSistemaParametros,
            this.menuSistemaSalir});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // menuSistemaParametros
            // 
            this.menuSistemaParametros.Name = "menuSistemaParametros";
            this.menuSistemaParametros.Size = new System.Drawing.Size(152, 22);
            this.menuSistemaParametros.Text = "Parámetros";
            this.menuSistemaParametros.Click += new System.EventHandler(this.menuSistemaParametros_Click);
            // 
            // menuSistemaSalir
            // 
            this.menuSistemaSalir.Name = "menuSistemaSalir";
            this.menuSistemaSalir.Size = new System.Drawing.Size(152, 22);
            this.menuSistemaSalir.Text = "Salir";
            this.menuSistemaSalir.Click += new System.EventHandler(this.menuSistemaSalir_Click);
            // 
            // matenimientoDePersonalToolStripMenuItem
            // 
            this.matenimientoDePersonalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMantenimientoEmpleados,
            this.menuMantenimientoCargos,
            this.menuMantenimientoReposos});
            this.matenimientoDePersonalToolStripMenuItem.Name = "matenimientoDePersonalToolStripMenuItem";
            this.matenimientoDePersonalToolStripMenuItem.Size = new System.Drawing.Size(106, 21);
            this.matenimientoDePersonalToolStripMenuItem.Text = "Matenimientos";
            // 
            // menuMantenimientoEmpleados
            // 
            this.menuMantenimientoEmpleados.Name = "menuMantenimientoEmpleados";
            this.menuMantenimientoEmpleados.Size = new System.Drawing.Size(141, 22);
            this.menuMantenimientoEmpleados.Text = "Empleados";
            this.menuMantenimientoEmpleados.Click += new System.EventHandler(this.menuMantenimientoEmpleados_Click);
            // 
            // menuMantenimientoCargos
            // 
            this.menuMantenimientoCargos.Name = "menuMantenimientoCargos";
            this.menuMantenimientoCargos.Size = new System.Drawing.Size(141, 22);
            this.menuMantenimientoCargos.Text = "Cargos";
            this.menuMantenimientoCargos.Click += new System.EventHandler(this.menuMantenimientoCargos_Click);
            // 
            // menuMantenimientoReposos
            // 
            this.menuMantenimientoReposos.Name = "menuMantenimientoReposos";
            this.menuMantenimientoReposos.Size = new System.Drawing.Size(141, 22);
            this.menuMantenimientoReposos.Text = "Reposos";
            this.menuMantenimientoReposos.Click += new System.EventHandler(this.menuMantenimientoReposos_Click);
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRegistroMarcaciones,
            this.menuRegistroHorasExtras,
            this.menuRegistroDiasLibres,
            this.menuRegistrosCambiosCargo});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // menuRegistroMarcaciones
            // 
            this.menuRegistroMarcaciones.Name = "menuRegistroMarcaciones";
            this.menuRegistroMarcaciones.Size = new System.Drawing.Size(186, 22);
            this.menuRegistroMarcaciones.Text = "Marcaciones";
            this.menuRegistroMarcaciones.Click += new System.EventHandler(this.menuRegistroMarcaciones_Click);
            // 
            // menuRegistroHorasExtras
            // 
            this.menuRegistroHorasExtras.Name = "menuRegistroHorasExtras";
            this.menuRegistroHorasExtras.Size = new System.Drawing.Size(186, 22);
            this.menuRegistroHorasExtras.Text = "Horas Extras";
            this.menuRegistroHorasExtras.Click += new System.EventHandler(this.menuRegistroHorasExtras_Click);
            // 
            // menuRegistroDiasLibres
            // 
            this.menuRegistroDiasLibres.Name = "menuRegistroDiasLibres";
            this.menuRegistroDiasLibres.Size = new System.Drawing.Size(186, 22);
            this.menuRegistroDiasLibres.Text = "Dias Libres";
            this.menuRegistroDiasLibres.Click += new System.EventHandler(this.menuRegistroDiasLibres_Click);
            // 
            // menuRegistrosCambiosCargo
            // 
            this.menuRegistrosCambiosCargo.Name = "menuRegistrosCambiosCargo";
            this.menuRegistrosCambiosCargo.Size = new System.Drawing.Size(186, 22);
            this.menuRegistrosCambiosCargo.Text = "Cambios de Cargo";
            this.menuRegistrosCambiosCargo.Click += new System.EventHandler(this.menuRegistrosCambiosCargo_Click);
            // 
            // mantenimientoDeCargosToolStripMenuItem
            // 
            this.mantenimientoDeCargosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuInformesVacaciones,
            this.menuInformesMarcaciones,
            this.menuInformesLlegadasTardias,
            this.menuInformesLiquidaciones,
            this.cambiosDeCargoToolStripMenuItem});
            this.mantenimientoDeCargosToolStripMenuItem.Name = "mantenimientoDeCargosToolStripMenuItem";
            this.mantenimientoDeCargosToolStripMenuItem.Size = new System.Drawing.Size(71, 21);
            this.mantenimientoDeCargosToolStripMenuItem.Text = "Informes";
            // 
            // menuInformesVacaciones
            // 
            this.menuInformesVacaciones.Name = "menuInformesVacaciones";
            this.menuInformesVacaciones.Size = new System.Drawing.Size(186, 22);
            this.menuInformesVacaciones.Text = "Vacaciones";
            // 
            // menuInformesMarcaciones
            // 
            this.menuInformesMarcaciones.Name = "menuInformesMarcaciones";
            this.menuInformesMarcaciones.Size = new System.Drawing.Size(186, 22);
            this.menuInformesMarcaciones.Text = "Marcaciones";
            // 
            // menuInformesLlegadasTardias
            // 
            this.menuInformesLlegadasTardias.Name = "menuInformesLlegadasTardias";
            this.menuInformesLlegadasTardias.Size = new System.Drawing.Size(186, 22);
            this.menuInformesLlegadasTardias.Text = "Llegadas Tardias";
            // 
            // menuInformesLiquidaciones
            // 
            this.menuInformesLiquidaciones.Name = "menuInformesLiquidaciones";
            this.menuInformesLiquidaciones.Size = new System.Drawing.Size(186, 22);
            this.menuInformesLiquidaciones.Text = "Liquidaciones";
            // 
            // cambiosDeCargoToolStripMenuItem
            // 
            this.cambiosDeCargoToolStripMenuItem.Name = "cambiosDeCargoToolStripMenuItem";
            this.cambiosDeCargoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.cambiosDeCargoToolStripMenuItem.Text = "Cambios de Cargo";
            // 
            // frmMenuPrincipal
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMenuPrincipal";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Menu Principal";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem matenimientoDePersonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuMantenimientoEmpleados;
        private System.Windows.Forms.ToolStripMenuItem menuMantenimientoCargos;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeCargosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuInformesVacaciones;
        private System.Windows.Forms.ToolStripMenuItem menuInformesMarcaciones;
        private System.Windows.Forms.ToolStripMenuItem menuInformesLlegadasTardias;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuRegistroMarcaciones;
        private System.Windows.Forms.ToolStripMenuItem menuMantenimientoReposos;
        private System.Windows.Forms.ToolStripMenuItem menuRegistroHorasExtras;
        private System.Windows.Forms.ToolStripMenuItem menuRegistroDiasLibres;
        private System.Windows.Forms.ToolStripMenuItem menuInformesLiquidaciones;
        private System.Windows.Forms.ToolStripMenuItem menuRegistrosCambiosCargo;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSistemaParametros;
        private System.Windows.Forms.ToolStripMenuItem menuSistemaSalir;
        private System.Windows.Forms.ToolStripMenuItem cambiosDeCargoToolStripMenuItem;
    }
}