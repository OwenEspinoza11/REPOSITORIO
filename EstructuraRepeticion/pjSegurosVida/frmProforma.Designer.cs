namespace pjSegurosVida
{
    partial class frmProforma
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvProforma = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.label5 = new System.Windows.Forms.Label();
            this.lvEstadisticas = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE PROFORMA DE SEGURO DE VIDA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Razón social";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(102, 46);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(261, 23);
            this.txtRazonSocial.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.cboTipo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(24, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de seguros";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(486, 39);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(231, 58);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 23);
            this.txtCantidad.TabIndex = 3;
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Inversión Clásica",
            "Inversión Platino",
            "Inversión Oro"});
            this.cboTipo.Location = new System.Drawing.Point(33, 58);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(121, 23);
            this.cboTipo.TabIndex = 2;
            this.cboTipo.Text = "(Seleccione tipo)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cantidad de empleados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tipo de seguros";
            // 
            // lvProforma
            // 
            this.lvProforma.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvProforma.GridLines = true;
            this.lvProforma.Location = new System.Drawing.Point(24, 181);
            this.lvProforma.Name = "lvProforma";
            this.lvProforma.Size = new System.Drawing.Size(604, 97);
            this.lvProforma.TabIndex = 4;
            this.lvProforma.UseCompatibleStateImageBehavior = false;
            this.lvProforma.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tipo de seguro";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cant. empleados";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pago mensual";
            this.columnHeader3.Width = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Estadísticas";
            // 
            // lvEstadisticas
            // 
            this.lvEstadisticas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.lvEstadisticas.GridLines = true;
            this.lvEstadisticas.Location = new System.Drawing.Point(24, 317);
            this.lvEstadisticas.Name = "lvEstadisticas";
            this.lvEstadisticas.Size = new System.Drawing.Size(454, 97);
            this.lvEstadisticas.TabIndex = 6;
            this.lvEstadisticas.UseCompatibleStateImageBehavior = false;
            this.lvEstadisticas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Concepto";
            this.columnHeader4.Width = 300;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Total";
            this.columnHeader5.Width = 150;
            // 
            // btnGeneral
            // 
            this.btnGeneral.Location = new System.Drawing.Point(24, 438);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(75, 23);
            this.btnGeneral.TabIndex = 7;
            this.btnGeneral.Text = "General";
            this.btnGeneral.UseVisualStyleBackColor = true;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(105, 438);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(75, 23);
            this.btnAnular.TabIndex = 8;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(553, 438);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmProforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 479);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnGeneral);
            this.Controls.Add(this.lvEstadisticas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvProforma);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmProforma";
            this.Text = "Control de  proformas de seguro de vida";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtRazonSocial;
        private GroupBox groupBox1;
        private Button btnRegistrar;
        private TextBox txtCantidad;
        private ComboBox cboTipo;
        private Label label4;
        private Label label3;
        private ListView lvProforma;
        private Label label5;
        private ListView lvEstadisticas;
        private Button btnGeneral;
        private Button btnAnular;
        private Button btnSalir;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}