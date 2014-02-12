namespace Gestor_De_Alumnos_V1._0
{
    partial class ModificarAlumno
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
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TxtIngreso = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(12, 219);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(83, 45);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.Text = "Guardar cambios";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Ingrese DNI del alumno";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nombre/s",
            "Apellido/s",
            "Celular",
            "Telefono",
            "Dirección",
            "Curso"});
            this.comboBox1.Location = new System.Drawing.Point(23, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "¿Qué desea modificar?";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(190, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(261, 259);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "MOSTRAR ACA LOS DATOS DEL ALUMNO PARA QUE SEA MAS COMODO AL USUARIO";
            // 
            // TxtIngreso
            // 
            this.TxtIngreso.Location = new System.Drawing.Point(23, 160);
            this.TxtIngreso.Name = "TxtIngreso";
            this.TxtIngreso.Size = new System.Drawing.Size(143, 20);
            this.TxtIngreso.TabIndex = 4;
            this.TxtIngreso.Text = "Ingrese aqui el nuevo valor";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // BtnVolver
            // 
            this.BtnVolver.Location = new System.Drawing.Point(101, 219);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(83, 45);
            this.BtnVolver.TabIndex = 5;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = true;
            // 
            // ModificarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 341);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.TxtIngreso);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnGuardar);
            this.Name = "ModificarAlumno";
            this.Text = "ModificarAlumno";
            this.Load += new System.EventHandler(this.ModificarAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox TxtIngreso;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button BtnVolver;
    }
}