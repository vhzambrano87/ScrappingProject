namespace ScrappingProject
{
    partial class frmScrapping
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnScrapping = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioOferta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecioOfertaTarjeta = new System.Windows.Forms.TextBox();
            this.rdbFalabella = new System.Windows.Forms.RadioButton();
            this.rdbRipley = new System.Windows.Forms.RadioButton();
            this.btnScrappingHtml = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(132, 46);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(294, 20);
            this.txtURL.TabIndex = 1;
            // 
            // btnScrapping
            // 
            this.btnScrapping.Location = new System.Drawing.Point(432, 44);
            this.btnScrapping.Name = "btnScrapping";
            this.btnScrapping.Size = new System.Drawing.Size(78, 42);
            this.btnScrapping.TabIndex = 2;
            this.btnScrapping.Text = "Scrapping Selenium";
            this.btnScrapping.UseVisualStyleBackColor = true;
            this.btnScrapping.Click += new System.EventHandler(this.btnScrapping_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(132, 118);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(167, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(132, 159);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(167, 20);
            this.txtPrecio.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Precio Oferta";
            // 
            // txtPrecioOferta
            // 
            this.txtPrecioOferta.Location = new System.Drawing.Point(132, 197);
            this.txtPrecioOferta.Name = "txtPrecioOferta";
            this.txtPrecioOferta.Size = new System.Drawing.Size(167, 20);
            this.txtPrecioOferta.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Precio Oferta Tarjeta";
            // 
            // txtPrecioOfertaTarjeta
            // 
            this.txtPrecioOfertaTarjeta.Location = new System.Drawing.Point(132, 235);
            this.txtPrecioOfertaTarjeta.Name = "txtPrecioOfertaTarjeta";
            this.txtPrecioOfertaTarjeta.Size = new System.Drawing.Size(167, 20);
            this.txtPrecioOfertaTarjeta.TabIndex = 10;
            // 
            // rdbFalabella
            // 
            this.rdbFalabella.AutoSize = true;
            this.rdbFalabella.Checked = true;
            this.rdbFalabella.Location = new System.Drawing.Point(132, 13);
            this.rdbFalabella.Name = "rdbFalabella";
            this.rdbFalabella.Size = new System.Drawing.Size(67, 17);
            this.rdbFalabella.TabIndex = 11;
            this.rdbFalabella.TabStop = true;
            this.rdbFalabella.Text = "Falabella";
            this.rdbFalabella.UseVisualStyleBackColor = true;
            // 
            // rdbRipley
            // 
            this.rdbRipley.AutoSize = true;
            this.rdbRipley.Location = new System.Drawing.Point(224, 13);
            this.rdbRipley.Name = "rdbRipley";
            this.rdbRipley.Size = new System.Drawing.Size(54, 17);
            this.rdbRipley.TabIndex = 12;
            this.rdbRipley.Text = "Ripley";
            this.rdbRipley.UseVisualStyleBackColor = true;
            // 
            // btnScrappingHtml
            // 
            this.btnScrappingHtml.Location = new System.Drawing.Point(529, 46);
            this.btnScrappingHtml.Name = "btnScrappingHtml";
            this.btnScrappingHtml.Size = new System.Drawing.Size(75, 40);
            this.btnScrappingHtml.TabIndex = 13;
            this.btnScrappingHtml.Text = "Scrapping HTML";
            this.btnScrappingHtml.UseVisualStyleBackColor = true;
            this.btnScrappingHtml.Click += new System.EventHandler(this.btnScrappingHtml_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "SKU";
            // 
            // txtSKU
            // 
            this.txtSKU.Location = new System.Drawing.Point(132, 82);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(167, 20);
            this.txtSKU.TabIndex = 15;
            // 
            // frmScrapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 304);
            this.Controls.Add(this.txtSKU);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnScrappingHtml);
            this.Controls.Add(this.rdbRipley);
            this.Controls.Add(this.rdbFalabella);
            this.Controls.Add(this.txtPrecioOfertaTarjeta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrecioOferta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnScrapping);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label1);
            this.Name = "frmScrapping";
            this.Text = "Web Scrapping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnScrapping;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioOferta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecioOfertaTarjeta;
        private System.Windows.Forms.RadioButton rdbFalabella;
        private System.Windows.Forms.RadioButton rdbRipley;
        private System.Windows.Forms.Button btnScrappingHtml;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSKU;
    }
}

