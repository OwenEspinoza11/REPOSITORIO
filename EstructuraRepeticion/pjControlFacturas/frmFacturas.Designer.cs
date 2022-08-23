namespace pjControlFacturas
{
    partial class frmFacturas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.btnNuevaFact = new System.Windows.Forms.Button();
            this.btnRegistrarItem = new System.Windows.Forms.Button();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumFact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lvRegistro = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lvEstadistica = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(239, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE REGISTRO DE FACTURAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del vendedor";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(12, 52);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(278, 23);
            this.txtVendedor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(361, 55);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(38, 15);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "label4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTipo);
            this.groupBox1.Controls.Add(this.btnNuevaFact);
            this.groupBox1.Controls.Add(this.btnRegistrarItem);
            this.groupBox1.Controls.Add(this.txtUnidades);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNumFact);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(18, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 107);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de factura";
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Cobre",
            "Bronce",
            "Silver",
            "Gold"});
            this.cboTipo.Location = new System.Drawing.Point(178, 59);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(121, 23);
            this.cboTipo.TabIndex = 7;
            this.cboTipo.Text = "(Seleccione tipo)";
            // 
            // btnNuevaFact
            // 
            this.btnNuevaFact.Location = new System.Drawing.Point(502, 69);
            this.btnNuevaFact.Name = "btnNuevaFact";
            this.btnNuevaFact.Size = new System.Drawing.Size(117, 23);
            this.btnNuevaFact.TabIndex = 6;
            this.btnNuevaFact.Text = "OTRA FACTURA";
            this.btnNuevaFact.UseVisualStyleBackColor = true;
            this.btnNuevaFact.Click += new System.EventHandler(this.btnNuevaFact_Click);
            // 
            // btnRegistrarItem
            // 
            this.btnRegistrarItem.Location = new System.Drawing.Point(502, 24);
            this.btnRegistrarItem.Name = "btnRegistrarItem";
            this.btnRegistrarItem.Size = new System.Drawing.Size(117, 23);
            this.btnRegistrarItem.TabIndex = 5;
            this.btnRegistrarItem.Text = "REGISTRAR ITEM";
            this.btnRegistrarItem.UseVisualStyleBackColor = true;
            this.btnRegistrarItem.Click += new System.EventHandler(this.btnRegistrarItem_Click);
            // 
            // txtUnidades
            // 
            this.txtUnidades.Location = new System.Drawing.Point(331, 59);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(100, 23);
            this.txtUnidades.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Unidades";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tipo de licencia";
            // 
            // txtNumFact
            // 
            this.txtNumFact.Location = new System.Drawing.Point(37, 59);
            this.txtNumFact.Name = "txtNumFact";
            this.txtNumFact.Size = new System.Drawing.Size(100, 23);
            this.txtNumFact.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Número factura";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Listado de registro";
            // 
            // lvRegistro
            // 
            this.lvRegistro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvRegistro.GridLines = true;
            this.lvRegistro.Location = new System.Drawing.Point(12, 224);
            this.lvRegistro.Name = "lvRegistro";
            this.lvRegistro.Size = new System.Drawing.Size(645, 123);
            this.lvRegistro.TabIndex = 7;
            this.lvRegistro.UseCompatibleStateImageBehavior = false;
            this.lvRegistro.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Num. Fac";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tipo de licencia";
            this.columnHeader2.Width = 240;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unidades";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Subtotal";
            this.columnHeader4.Width = 150;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(407, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Monto total";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(483, 360);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(44, 15);
            this.lblMonto.TabIndex = 9;
            this.lblMonto.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 379);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Estadísticas de venta";
            // 
            // lvEstadistica
            // 
            this.lvEstadistica.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvEstadistica.GridLines = true;
            this.lvEstadistica.Location = new System.Drawing.Point(12, 397);
            this.lvEstadistica.Name = "lvEstadistica";
            this.lvEstadistica.Size = new System.Drawing.Size(548, 97);
            this.lvEstadistica.TabIndex = 11;
            this.lvEstadistica.UseCompatibleStateImageBehavior = false;
            this.lvEstadistica.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tipo de licencia";
            this.columnHeader5.Width = 240;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total unidades";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Monto total";
            this.columnHeader7.Width = 150;
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 525);
            this.Controls.Add(this.lvEstadistica);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lvRegistro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFacturas";
            this.Text = "Control de registro de factura";
            this.Load += new System.EventHandler(this.frmFacturas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtVendedor;
        private Label label3;
        private Label lblFecha;
        private GroupBox groupBox1;
        private Button btnNuevaFact;
        private Button btnRegistrarItem;
        private TextBox txtUnidades;
        private Label label7;
        private Label label6;
        private TextBox txtNumFact;
        private Label label5;
        private Label label8;
        private ListView lvRegistro;
        private Label label9;
        private Label lblMonto;
        private Label label11;
        private ListView lvEstadistica;
        private ComboBox cboTipo;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}