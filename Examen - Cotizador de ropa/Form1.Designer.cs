
namespace Examen___Cotizador_de_ropa
{
    partial class Form1
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
            this.labelNombreTienda = new System.Windows.Forms.Label();
            this.labelDireccionTienda = new System.Windows.Forms.Label();
            this.labelNombreVendedor = new System.Windows.Forms.Label();
            this.linkCotizaciones = new System.Windows.Forms.LinkLabel();
            this.radioCamisa = new System.Windows.Forms.RadioButton();
            this.radioPantalon = new System.Windows.Forms.RadioButton();
            this.checkManga = new System.Windows.Forms.CheckBox();
            this.checkCuello = new System.Windows.Forms.CheckBox();
            this.checkChupin = new System.Windows.Forms.CheckBox();
            this.labelStock = new System.Windows.Forms.Label();
            this.radioStandard = new System.Windows.Forms.RadioButton();
            this.radioPremium = new System.Windows.Forms.RadioButton();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.buttonCotizar = new System.Windows.Forms.Button();
            this.labelPrecioCotizado = new System.Windows.Forms.Label();
            this.labelS = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelErrorPrecio = new System.Windows.Forms.Label();
            this.labelErrorCanti = new System.Windows.Forms.Label();
            this.LabelStockTextoDefault = new System.Windows.Forms.Label();
            this.linkLabelLimpiar = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNombreTienda
            // 
            this.labelNombreTienda.AutoSize = true;
            this.labelNombreTienda.Location = new System.Drawing.Point(12, 9);
            this.labelNombreTienda.Name = "labelNombreTienda";
            this.labelNombreTienda.Size = new System.Drawing.Size(80, 13);
            this.labelNombreTienda.TabIndex = 0;
            this.labelNombreTienda.Text = "Nombre Tienda";
            // 
            // labelDireccionTienda
            // 
            this.labelDireccionTienda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDireccionTienda.AutoSize = true;
            this.labelDireccionTienda.Location = new System.Drawing.Point(321, 9);
            this.labelDireccionTienda.Name = "labelDireccionTienda";
            this.labelDireccionTienda.Size = new System.Drawing.Size(114, 13);
            this.labelDireccionTienda.TabIndex = 1;
            this.labelDireccionTienda.Text = "Direccion de la Tienda";
            // 
            // labelNombreVendedor
            // 
            this.labelNombreVendedor.AutoSize = true;
            this.labelNombreVendedor.Location = new System.Drawing.Point(13, 51);
            this.labelNombreVendedor.Name = "labelNombreVendedor";
            this.labelNombreVendedor.Size = new System.Drawing.Size(231, 13);
            this.labelNombreVendedor.TabIndex = 2;
            this.labelNombreVendedor.Text = "Nombre y Apellido Vendedor | Codigo Vendedor";
            // 
            // linkCotizaciones
            // 
            this.linkCotizaciones.AutoSize = true;
            this.linkCotizaciones.Location = new System.Drawing.Point(326, 51);
            this.linkCotizaciones.Name = "linkCotizaciones";
            this.linkCotizaciones.Size = new System.Drawing.Size(107, 13);
            this.linkCotizaciones.TabIndex = 3;
            this.linkCotizaciones.TabStop = true;
            this.linkCotizaciones.Text = "Historial Cotizaciones";
            this.linkCotizaciones.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCotizaciones_LinkClicked);
            // 
            // radioCamisa
            // 
            this.radioCamisa.AutoSize = true;
            this.radioCamisa.Enabled = false;
            this.radioCamisa.Location = new System.Drawing.Point(16, 165);
            this.radioCamisa.Name = "radioCamisa";
            this.radioCamisa.Size = new System.Drawing.Size(59, 17);
            this.radioCamisa.TabIndex = 4;
            this.radioCamisa.TabStop = true;
            this.radioCamisa.Text = "Camisa";
            this.radioCamisa.UseVisualStyleBackColor = true;
            this.radioCamisa.CheckedChanged += new System.EventHandler(this.radioCamisa_CheckedChanged);
            // 
            // radioPantalon
            // 
            this.radioPantalon.AutoSize = true;
            this.radioPantalon.Enabled = false;
            this.radioPantalon.Location = new System.Drawing.Point(16, 188);
            this.radioPantalon.Name = "radioPantalon";
            this.radioPantalon.Size = new System.Drawing.Size(67, 17);
            this.radioPantalon.TabIndex = 5;
            this.radioPantalon.TabStop = true;
            this.radioPantalon.Text = "Pantalon";
            this.radioPantalon.UseVisualStyleBackColor = true;
            this.radioPantalon.CheckedChanged += new System.EventHandler(this.radioPantalon_CheckedChanged);
            // 
            // checkManga
            // 
            this.checkManga.AutoSize = true;
            this.checkManga.Enabled = false;
            this.checkManga.Location = new System.Drawing.Point(145, 165);
            this.checkManga.Name = "checkManga";
            this.checkManga.Size = new System.Drawing.Size(86, 17);
            this.checkManga.TabIndex = 6;
            this.checkManga.Text = "Manga corta";
            this.checkManga.UseVisualStyleBackColor = true;
            this.checkManga.CheckedChanged += new System.EventHandler(this.checkManga_CheckedChanged);
            // 
            // checkCuello
            // 
            this.checkCuello.AutoSize = true;
            this.checkCuello.Enabled = false;
            this.checkCuello.Location = new System.Drawing.Point(253, 165);
            this.checkCuello.Name = "checkCuello";
            this.checkCuello.Size = new System.Drawing.Size(79, 17);
            this.checkCuello.TabIndex = 7;
            this.checkCuello.Text = "Cuello Mao";
            this.checkCuello.UseVisualStyleBackColor = true;
            this.checkCuello.CheckedChanged += new System.EventHandler(this.checkCuello_CheckedChanged);
            // 
            // checkChupin
            // 
            this.checkChupin.AutoSize = true;
            this.checkChupin.Enabled = false;
            this.checkChupin.Location = new System.Drawing.Point(145, 189);
            this.checkChupin.Name = "checkChupin";
            this.checkChupin.Size = new System.Drawing.Size(59, 17);
            this.checkChupin.TabIndex = 8;
            this.checkChupin.Text = "Chupin";
            this.checkChupin.UseVisualStyleBackColor = true;
            this.checkChupin.CheckedChanged += new System.EventHandler(this.checkChupin_CheckedChanged);
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(121, 241);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(0, 13);
            this.labelStock.TabIndex = 9;
            // 
            // radioStandard
            // 
            this.radioStandard.AutoSize = true;
            this.radioStandard.Location = new System.Drawing.Point(47, 24);
            this.radioStandard.Name = "radioStandard";
            this.radioStandard.Size = new System.Drawing.Size(68, 17);
            this.radioStandard.TabIndex = 10;
            this.radioStandard.TabStop = true;
            this.radioStandard.Text = "Standard";
            this.radioStandard.UseVisualStyleBackColor = true;
            this.radioStandard.CheckedChanged += new System.EventHandler(this.radioStandard_CheckedChanged);
            // 
            // radioPremium
            // 
            this.radioPremium.AutoSize = true;
            this.radioPremium.Location = new System.Drawing.Point(177, 24);
            this.radioPremium.Name = "radioPremium";
            this.radioPremium.Size = new System.Drawing.Size(65, 17);
            this.radioPremium.TabIndex = 11;
            this.radioPremium.TabStop = true;
            this.radioPremium.Text = "Premium";
            this.radioPremium.UseVisualStyleBackColor = true;
            this.radioPremium.CheckedChanged += new System.EventHandler(this.radioPremium_CheckedChanged);
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(12, 303);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(76, 13);
            this.labelPrecio.TabIndex = 12;
            this.labelPrecio.Text = "Precio Unitario";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(209, 303);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(49, 13);
            this.labelCantidad.TabIndex = 13;
            this.labelCantidad.Text = "Cantidad";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Enabled = false;
            this.textBoxPrecio.Location = new System.Drawing.Point(92, 300);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecio.TabIndex = 14;
            this.textBoxPrecio.TextChanged += new System.EventHandler(this.textBoxPrecio_TextChanged);
            this.textBoxPrecio.Enter += new System.EventHandler(this.textBoxPrecio_Enter);
            this.textBoxPrecio.Leave += new System.EventHandler(this.textBoxPrecio_Leave);
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Enabled = false;
            this.textBoxCantidad.Location = new System.Drawing.Point(264, 300);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(100, 20);
            this.textBoxCantidad.TabIndex = 15;
            this.textBoxCantidad.TextChanged += new System.EventHandler(this.textBoxCantidad_TextChanged);
            this.textBoxCantidad.Enter += new System.EventHandler(this.textBoxCantidad_Enter);
            this.textBoxCantidad.Leave += new System.EventHandler(this.textBoxCantidad_Leave);
            // 
            // buttonCotizar
            // 
            this.buttonCotizar.Enabled = false;
            this.buttonCotizar.Location = new System.Drawing.Point(12, 376);
            this.buttonCotizar.Name = "buttonCotizar";
            this.buttonCotizar.Size = new System.Drawing.Size(137, 52);
            this.buttonCotizar.TabIndex = 16;
            this.buttonCotizar.Text = "Cotizar";
            this.buttonCotizar.UseVisualStyleBackColor = true;
            this.buttonCotizar.Click += new System.EventHandler(this.buttonCotizar_Click);
            // 
            // labelPrecioCotizado
            // 
            this.labelPrecioCotizado.AutoSize = true;
            this.labelPrecioCotizado.Location = new System.Drawing.Point(212, 391);
            this.labelPrecioCotizado.Name = "labelPrecioCotizado";
            this.labelPrecioCotizado.Size = new System.Drawing.Size(37, 13);
            this.labelPrecioCotizado.TabIndex = 17;
            this.labelPrecioCotizado.Text = "----------";
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Location = new System.Drawing.Point(193, 391);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(13, 13);
            this.labelS.TabIndex = 18;
            this.labelS.Text = "$";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioStandard);
            this.groupBox1.Controls.Add(this.radioPremium);
            this.groupBox1.Location = new System.Drawing.Point(16, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 54);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calidad de las prendas";
            // 
            // labelErrorPrecio
            // 
            this.labelErrorPrecio.AutoSize = true;
            this.labelErrorPrecio.ForeColor = System.Drawing.Color.Red;
            this.labelErrorPrecio.Location = new System.Drawing.Point(92, 327);
            this.labelErrorPrecio.Name = "labelErrorPrecio";
            this.labelErrorPrecio.Size = new System.Drawing.Size(98, 13);
            this.labelErrorPrecio.TabIndex = 20;
            this.labelErrorPrecio.Text = "Formato incorrecto.";
            this.labelErrorPrecio.Visible = false;
            // 
            // labelErrorCanti
            // 
            this.labelErrorCanti.AutoSize = true;
            this.labelErrorCanti.ForeColor = System.Drawing.Color.Red;
            this.labelErrorCanti.Location = new System.Drawing.Point(266, 327);
            this.labelErrorCanti.Name = "labelErrorCanti";
            this.labelErrorCanti.Size = new System.Drawing.Size(98, 13);
            this.labelErrorCanti.TabIndex = 21;
            this.labelErrorCanti.Text = "Formato incorrecto.";
            this.labelErrorCanti.Visible = false;
            // 
            // LabelStockTextoDefault
            // 
            this.LabelStockTextoDefault.AutoSize = true;
            this.LabelStockTextoDefault.Location = new System.Drawing.Point(13, 241);
            this.LabelStockTextoDefault.Name = "LabelStockTextoDefault";
            this.LabelStockTextoDefault.Size = new System.Drawing.Size(102, 13);
            this.LabelStockTextoDefault.TabIndex = 22;
            this.LabelStockTextoDefault.Text = "Unidades en stock: ";
            // 
            // linkLabelLimpiar
            // 
            this.linkLabelLimpiar.AutoSize = true;
            this.linkLabelLimpiar.Location = new System.Drawing.Point(332, 230);
            this.linkLabelLimpiar.Name = "linkLabelLimpiar";
            this.linkLabelLimpiar.Size = new System.Drawing.Size(103, 13);
            this.linkLabelLimpiar.TabIndex = 23;
            this.linkLabelLimpiar.TabStop = true;
            this.linkLabelLimpiar.Text = "Limpiar Cotizaciones";
            this.linkLabelLimpiar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLimpiar_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 49);
            this.button1.TabIndex = 24;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 444);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabelLimpiar);
            this.Controls.Add(this.LabelStockTextoDefault);
            this.Controls.Add(this.labelErrorCanti);
            this.Controls.Add(this.labelErrorPrecio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelS);
            this.Controls.Add(this.labelPrecioCotizado);
            this.Controls.Add(this.buttonCotizar);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.checkChupin);
            this.Controls.Add(this.checkCuello);
            this.Controls.Add(this.checkManga);
            this.Controls.Add(this.radioPantalon);
            this.Controls.Add(this.radioCamisa);
            this.Controls.Add(this.linkCotizaciones);
            this.Controls.Add(this.labelNombreVendedor);
            this.Controls.Add(this.labelDireccionTienda);
            this.Controls.Add(this.labelNombreTienda);
            this.Name = "Form1";
            this.Text = "Cotizador de ropa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombreTienda;
        private System.Windows.Forms.Label labelDireccionTienda;
        private System.Windows.Forms.Label labelNombreVendedor;
        private System.Windows.Forms.LinkLabel linkCotizaciones;
        private System.Windows.Forms.RadioButton radioCamisa;
        private System.Windows.Forms.RadioButton radioPantalon;
        private System.Windows.Forms.CheckBox checkManga;
        private System.Windows.Forms.CheckBox checkCuello;
        private System.Windows.Forms.CheckBox checkChupin;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.RadioButton radioStandard;
        private System.Windows.Forms.RadioButton radioPremium;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Button buttonCotizar;
        private System.Windows.Forms.Label labelPrecioCotizado;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelErrorPrecio;
        private System.Windows.Forms.Label labelErrorCanti;
        private System.Windows.Forms.Label LabelStockTextoDefault;
        private System.Windows.Forms.LinkLabel linkLabelLimpiar;
        private System.Windows.Forms.Button button1;
    }
}

