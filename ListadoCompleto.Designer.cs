namespace Gestor_De_Alumnos_V1._0
{
    partial class ListadoCompleto
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
            this.alumnosDBDataSet = new Gestor_De_Alumnos_V1._0.AlumnosDBDataSet();
            this.alumnosDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.alumnoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnoTableAdapter = new Gestor_De_Alumnos_V1._0.AlumnosDBDataSetTableAdapters.AlumnoTableAdapter();
            this.BtnRetorno = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnFiltrarId = new System.Windows.Forms.Button();
            this.BtnFiltrarCurso = new System.Windows.Forms.Button();
            this.TxtBorrar = new System.Windows.Forms.TextBox();
            this.LblHora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // alumnosDBDataSet
            // 
            this.alumnosDBDataSet.DataSetName = "AlumnosDBDataSet";
            this.alumnosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnosDBDataSetBindingSource
            // 
            this.alumnosDBDataSetBindingSource.DataSource = this.alumnosDBDataSet;
            this.alumnosDBDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alumnoidDataGridViewTextBoxColumn,
            this.dniDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.direcionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.cursoidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alumnoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 136);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // alumnoidDataGridViewTextBoxColumn
            // 
            this.alumnoidDataGridViewTextBoxColumn.DataPropertyName = "alumnoid";
            this.alumnoidDataGridViewTextBoxColumn.HeaderText = "alumnoid";
            this.alumnoidDataGridViewTextBoxColumn.Name = "alumnoidDataGridViewTextBoxColumn";
            this.alumnoidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "dni";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // direcionDataGridViewTextBoxColumn
            // 
            this.direcionDataGridViewTextBoxColumn.DataPropertyName = "direcion";
            this.direcionDataGridViewTextBoxColumn.HeaderText = "direcion";
            this.direcionDataGridViewTextBoxColumn.Name = "direcionDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            // 
            // cursoidDataGridViewTextBoxColumn
            // 
            this.cursoidDataGridViewTextBoxColumn.DataPropertyName = "cursoid";
            this.cursoidDataGridViewTextBoxColumn.HeaderText = "cursoid";
            this.cursoidDataGridViewTextBoxColumn.Name = "cursoidDataGridViewTextBoxColumn";
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.DataMember = "Alumno";
            this.alumnoBindingSource.DataSource = this.alumnosDBDataSetBindingSource;
            // 
            // alumnoTableAdapter
            // 
            this.alumnoTableAdapter.ClearBeforeFill = true;
            // 
            // BtnRetorno
            // 
            this.BtnRetorno.Location = new System.Drawing.Point(757, 189);
            this.BtnRetorno.Name = "BtnRetorno";
            this.BtnRetorno.Size = new System.Drawing.Size(99, 48);
            this.BtnRetorno.TabIndex = 1;
            this.BtnRetorno.Text = "Volver al menu principal";
            this.BtnRetorno.UseVisualStyleBackColor = true;
            this.BtnRetorno.Click += new System.EventHandler(this.BtnRetorno_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(341, 189);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(99, 48);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Borrar un Alumno";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnFiltrarId
            // 
            this.BtnFiltrarId.Location = new System.Drawing.Point(550, 189);
            this.BtnFiltrarId.Name = "BtnFiltrarId";
            this.BtnFiltrarId.Size = new System.Drawing.Size(99, 48);
            this.BtnFiltrarId.TabIndex = 5;
            this.BtnFiltrarId.Text = "Filtrar un alumno por su Id";
            this.BtnFiltrarId.UseVisualStyleBackColor = true;
            this.BtnFiltrarId.Click += new System.EventHandler(this.BtnFiltrarId_Click);
            // 
            // BtnFiltrarCurso
            // 
            this.BtnFiltrarCurso.Location = new System.Drawing.Point(123, 189);
            this.BtnFiltrarCurso.Name = "BtnFiltrarCurso";
            this.BtnFiltrarCurso.Size = new System.Drawing.Size(99, 48);
            this.BtnFiltrarCurso.TabIndex = 6;
            this.BtnFiltrarCurso.Text = "Listado Completo";
            this.BtnFiltrarCurso.UseVisualStyleBackColor = true;
            this.BtnFiltrarCurso.Click += new System.EventHandler(this.BtnFiltrarCurso_Click);
            // 
            // TxtBorrar
            // 
            this.TxtBorrar.Location = new System.Drawing.Point(306, 163);
            this.TxtBorrar.Name = "TxtBorrar";
            this.TxtBorrar.Size = new System.Drawing.Size(182, 20);
            this.TxtBorrar.TabIndex = 14;
            this.TxtBorrar.Text = "Id del alumno ya sea para borrar o filtrar";
            this.TxtBorrar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtBorrar_MouseClick);
            this.TxtBorrar.TextChanged += new System.EventHandler(this.TxtBorrar_TextChanged);
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Location = new System.Drawing.Point(730, 156);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(68, 13);
            this.LblHora.TabIndex = 15;
            this.LblHora.Text = "Mostrar Hora";
            this.LblHora.Click += new System.EventHandler(this.LblHora_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Id del alumno>>";
            // 
            // ListadoCompleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 339);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblHora);
            this.Controls.Add(this.TxtBorrar);
            this.Controls.Add(this.BtnFiltrarCurso);
            this.Controls.Add(this.BtnFiltrarId);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnRetorno);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListadoCompleto";
            this.Text = "ListadoCompleto";
            this.Load += new System.EventHandler(this.ListadoCompleto_Load);
            this.MouseEnter += new System.EventHandler(this.ListadoCompleto_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource alumnosDBDataSetBindingSource;
        private AlumnosDBDataSet alumnosDBDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource alumnoBindingSource;
        private AlumnosDBDataSetTableAdapters.AlumnoTableAdapter alumnoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn alumnoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnRetorno;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnFiltrarId;
        private System.Windows.Forms.Button BtnFiltrarCurso;
        private System.Windows.Forms.TextBox TxtBorrar;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Label label1;
    }
}