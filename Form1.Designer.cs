namespace Gestor_De_Alumnos_V1._0
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCargarAlumnos = new System.Windows.Forms.Button();
            this.BtnListar = new System.Windows.Forms.Button();
            this.Btnborrar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCargarAlumnos
            // 
            this.BtnCargarAlumnos.Enabled = false;
            this.BtnCargarAlumnos.Location = new System.Drawing.Point(142, 56);
            this.BtnCargarAlumnos.Name = "BtnCargarAlumnos";
            this.BtnCargarAlumnos.Size = new System.Drawing.Size(130, 23);
            this.BtnCargarAlumnos.TabIndex = 0;
            this.BtnCargarAlumnos.Text = "alta";
            this.BtnCargarAlumnos.UseVisualStyleBackColor = true;
            this.BtnCargarAlumnos.Click += new System.EventHandler(this.BtnCargarAlumnos_Click);
            // 
            // BtnListar
            // 
            this.BtnListar.Location = new System.Drawing.Point(30, 56);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(89, 54);
            this.BtnListar.TabIndex = 1;
            this.BtnListar.Text = "Mostrar Listado Completo";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btnborrar
            // 
            this.Btnborrar.Enabled = false;
            this.Btnborrar.Location = new System.Drawing.Point(30, 116);
            this.Btnborrar.Name = "Btnborrar";
            this.Btnborrar.Size = new System.Drawing.Size(75, 23);
            this.Btnborrar.TabIndex = 2;
            this.Btnborrar.Text = "baja";
            this.Btnborrar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(142, 116);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(130, 23);
            this.BtnModificar.TabIndex = 3;
            this.BtnModificar.Text = "modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 37);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Bienvenido al gestor de Alumnos, por ser BETA se aplica a un solo curso. Que dese" +
    "a hacer?";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.Btnborrar);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.BtnCargarAlumnos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCargarAlumnos;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button Btnborrar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.TextBox textBox1;
    }
}

