namespace InterfazEmpleados
{
    partial class frmParametroSistema
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
            this.lstParametros = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTolerancia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaxVacaciones = new System.Windows.Forms.TextBox();
            this.rdbInactivo = new System.Windows.Forms.RadioButton();
            this.rdbActivo = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpHorarioEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpHorarioSalida = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lstParametros
            // 
            this.lstParametros.FormattingEnabled = true;
            this.lstParametros.Location = new System.Drawing.Point(300, 22);
            this.lstParametros.Name = "lstParametros";
            this.lstParametros.Size = new System.Drawing.Size(207, 173);
            this.lstParametros.TabIndex = 19;
            this.lstParametros.SelectedIndexChanged += new System.EventHandler(this.lstParametros_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(24, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Horario Salida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(23, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Horario Entrada";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(24, 201);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(80, 30);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(427, 201);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 30);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(337, 201);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(80, 30);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(247, 201);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 30);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(24, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tolerancia (minutos)";
            // 
            // txtTolerancia
            // 
            this.txtTolerancia.Location = new System.Drawing.Point(141, 115);
            this.txtTolerancia.Name = "txtTolerancia";
            this.txtTolerancia.Size = new System.Drawing.Size(130, 20);
            this.txtTolerancia.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(24, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Maximo Vacaciones";
            // 
            // txtMaxVacaciones
            // 
            this.txtMaxVacaciones.Location = new System.Drawing.Point(141, 146);
            this.txtMaxVacaciones.Name = "txtMaxVacaciones";
            this.txtMaxVacaciones.Size = new System.Drawing.Size(130, 20);
            this.txtMaxVacaciones.TabIndex = 17;
            // 
            // rdbInactivo
            // 
            this.rdbInactivo.AutoSize = true;
            this.rdbInactivo.BackColor = System.Drawing.Color.Transparent;
            this.rdbInactivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbInactivo.Location = new System.Drawing.Point(207, 177);
            this.rdbInactivo.Name = "rdbInactivo";
            this.rdbInactivo.Size = new System.Drawing.Size(63, 17);
            this.rdbInactivo.TabIndex = 22;
            this.rdbInactivo.Text = "Inactivo";
            this.rdbInactivo.UseVisualStyleBackColor = false;
            // 
            // rdbActivo
            // 
            this.rdbActivo.AutoSize = true;
            this.rdbActivo.BackColor = System.Drawing.Color.Transparent;
            this.rdbActivo.Checked = true;
            this.rdbActivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbActivo.Location = new System.Drawing.Point(141, 177);
            this.rdbActivo.Name = "rdbActivo";
            this.rdbActivo.Size = new System.Drawing.Size(55, 17);
            this.rdbActivo.TabIndex = 21;
            this.rdbActivo.TabStop = true;
            this.rdbActivo.Text = "Activo";
            this.rdbActivo.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(27, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Estado";
            // 
            // dtpHorarioEntrada
            // 
            this.dtpHorarioEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioEntrada.Location = new System.Drawing.Point(141, 53);
            this.dtpHorarioEntrada.Name = "dtpHorarioEntrada";
            this.dtpHorarioEntrada.Size = new System.Drawing.Size(129, 20);
            this.dtpHorarioEntrada.TabIndex = 23;
            // 
            // dtpHorarioSalida
            // 
            this.dtpHorarioSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioSalida.Location = new System.Drawing.Point(141, 84);
            this.dtpHorarioSalida.Name = "dtpHorarioSalida";
            this.dtpHorarioSalida.Size = new System.Drawing.Size(129, 20);
            this.dtpHorarioSalida.TabIndex = 23;
            // 
            // frmParametroSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 241);
            this.Controls.Add(this.dtpHorarioSalida);
            this.Controls.Add(this.dtpHorarioEntrada);
            this.Controls.Add(this.rdbInactivo);
            this.Controls.Add(this.rdbActivo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lstParametros);
            this.Controls.Add(this.txtMaxVacaciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTolerancia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmParametroSistema";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Parámetros del Sistema";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.frmParametroSistema_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstParametros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTolerancia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaxVacaciones;
        private System.Windows.Forms.RadioButton rdbInactivo;
        private System.Windows.Forms.RadioButton rdbActivo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpHorarioEntrada;
        private System.Windows.Forms.DateTimePicker dtpHorarioSalida;
    }
}