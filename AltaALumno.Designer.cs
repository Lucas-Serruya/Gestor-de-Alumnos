namespace Gestor_De_Alumnos_V1._0
{
    partial class AltaALumno
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
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtDNI = new System.Windows.Forms.TextBox();
            this.BtnDirecc = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtCurso = new System.Windows.Forms.TextBox();
            this.TxtCelular = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Btnvolver = new System.Windows.Forms.Button();
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnosDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnosDBDataSet = new Gestor_De_Alumnos_V1._0.AlumnosDBDataSet();
            this.alumnoTableAdapter = new Gestor_De_Alumnos_V1._0.AlumnosDBDataSetTableAdapters.AlumnoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(78, 28);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(240, 20);
            this.TxtNombre.TabIndex = 0;
            this.TxtNombre.Text = "Ingrese aqui el nombre";
            this.TxtNombre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtNombre_MouseClick);
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(78, 54);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(240, 20);
            this.TxtApellido.TabIndex = 1;
            this.TxtApellido.Text = "Ingrese aqui el/los apellidos";
            this.TxtApellido.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtApellido_MouseClick);
            // 
            // TxtDNI
            // 
            this.TxtDNI.Location = new System.Drawing.Point(78, 80);
            this.TxtDNI.Name = "TxtDNI";
            this.TxtDNI.Size = new System.Drawing.Size(240, 20);
            this.TxtDNI.TabIndex = 2;
            this.TxtDNI.Text = "Ingrese aqui el DNI";
            this.TxtDNI.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtDNI_MouseClick);
            // 
            // BtnDirecc
            // 
            this.BtnDirecc.Location = new System.Drawing.Point(78, 106);
            this.BtnDirecc.Name = "BtnDirecc";
            this.BtnDirecc.Size = new System.Drawing.Size(240, 20);
            this.BtnDirecc.TabIndex = 3;
            this.BtnDirecc.Text = "Ingrese aqui la dirección";
            this.BtnDirecc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnDirecc_MouseClick);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(78, 132);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(240, 20);
            this.TxtTelefono.TabIndex = 4;
            this.TxtTelefono.Text = "Ingrese aqui el teléfono ";
            this.TxtTelefono.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtTelefono_MouseClick);
            // 
            // TxtCurso
            // 
            this.TxtCurso.Location = new System.Drawing.Point(78, 184);
            this.TxtCurso.Name = "TxtCurso";
            this.TxtCurso.Size = new System.Drawing.Size(240, 20);
            this.TxtCurso.TabIndex = 5;
            this.TxtCurso.Text = "Ingrese aqui el Curso";
            this.TxtCurso.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtCurso_MouseClick);
            this.TxtCurso.TextChanged += new System.EventHandler(this.TxtCurso_TextChanged);
            // 
            // TxtCelular
            // 
            this.TxtCelular.Location = new System.Drawing.Point(78, 158);
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.Size = new System.Drawing.Size(240, 20);
            this.TxtCelular.TabIndex = 6;
            this.TxtCelular.Text = "Ingrese aqui el Celular";
            this.TxtCelular.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtCelular_MouseClick);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(78, 210);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(100, 23);
            this.BtnGuardar.TabIndex = 7;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Teléfono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Celular";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Curso";
            // 
            // Btnvolver
            // 
            this.Btnvolver.Location = new System.Drawing.Point(206, 210);
            this.Btnvolver.Name = "Btnvolver";
            this.Btnvolver.Size = new System.Drawing.Size(100, 23);
            this.Btnvolver.TabIndex = 15;
            this.Btnvolver.Text = "Volver al menu principal";
            this.Btnvolver.UseVisualStyleBackColor = true;
            this.Btnvolver.Click += new System.EventHandler(this.Btnvolver_Click);
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.DataMember = "Alumno";
            this.alumnoBindingSource.DataSource = this.alumnosDBDataSetBindingSource;
            // 
            // alumnosDBDataSetBindingSource
            // 
            this.alumnosDBDataSetBindingSource.DataSource = this.alumnosDBDataSet;
            this.alumnosDBDataSetBindingSource.Position = 0;
            // 
            // alumnosDBDataSet
            // 
            this.alumnosDBDataSet.DataSetName = "AlumnosDBDataSet";
            this.alumnosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnoTableAdapter
            // 
            this.alumnoTableAdapter.ClearBeforeFill = true;
            // 
            // AltaALumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 264);
            this.Controls.Add(this.Btnvolver);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtCelular);
            this.Controls.Add(this.TxtCurso);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.BtnDirecc);
            this.Controls.Add(this.TxtDNI);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Name = "AltaALumno";
            this.Text = "AltaALumno";
            this.Load += new System.EventHandler(this.AltaALumno_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtDNI;
        private System.Windows.Forms.TextBox BtnDirecc;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtCurso;
        private System.Windows.Forms.TextBox TxtCelular;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btnvolver;
        private System.Windows.Forms.BindingSource alumnoBindingSource;
        private System.Windows.Forms.BindingSource alumnosDBDataSetBindingSource;
        private AlumnosDBDataSet alumnosDBDataSet;
        private AlumnosDBDataSetTableAdapters.AlumnoTableAdapter alumnoTableAdapter;
    }
}