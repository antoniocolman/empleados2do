namespace Empleados
{
    partial class FormPrincipal
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
            this.btnAbout = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.matenimientoDePersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeCargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(818, 522);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 49);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matenimientoDePersonalToolStripMenuItem,
            this.mantenimientoDeCargosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(905, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // matenimientoDePersonalToolStripMenuItem
            // 
            this.matenimientoDePersonalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaEmpleadoToolStripMenuItem,
            this.bajaEmpleadoToolStripMenuItem,
            this.modificarEmpleadoToolStripMenuItem});
            this.matenimientoDePersonalToolStripMenuItem.Name = "matenimientoDePersonalToolStripMenuItem";
            this.matenimientoDePersonalToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.matenimientoDePersonalToolStripMenuItem.Text = "Matenimiento de Personal";
            // 
            // mantenimientoDeCargosToolStripMenuItem
            // 
            this.mantenimientoDeCargosToolStripMenuItem.Name = "mantenimientoDeCargosToolStripMenuItem";
            this.mantenimientoDeCargosToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.mantenimientoDeCargosToolStripMenuItem.Text = "Mantenimiento de Cargos";
            // 
            // altaEmpleadoToolStripMenuItem
            // 
            this.altaEmpleadoToolStripMenuItem.Name = "altaEmpleadoToolStripMenuItem";
            this.altaEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.altaEmpleadoToolStripMenuItem.Text = "Alta Empleado";
            // 
            // bajaEmpleadoToolStripMenuItem
            // 
            this.bajaEmpleadoToolStripMenuItem.Name = "bajaEmpleadoToolStripMenuItem";
            this.bajaEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.bajaEmpleadoToolStripMenuItem.Text = "Baja Empleado";
            // 
            // modificarEmpleadoToolStripMenuItem
            // 
            this.modificarEmpleadoToolStripMenuItem.Name = "modificarEmpleadoToolStripMenuItem";
            this.modificarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.modificarEmpleadoToolStripMenuItem.Text = "Modificar Empleado";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 583);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem matenimientoDePersonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeCargosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarEmpleadoToolStripMenuItem;
    }
}