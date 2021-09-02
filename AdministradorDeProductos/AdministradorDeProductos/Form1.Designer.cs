
namespace AdministradorDeProductos
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCad = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtCan = new System.Windows.Forms.TextBox();
            this.txtPre = new System.Windows.Forms.TextBox();
            this.UnidadMedida = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecioMin = new System.Windows.Forms.TextBox();
            this.txtPrecioMax = new System.Windows.Forms.TextBox();
            this.TxtCaducidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(21, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(21, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unidad de medida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(21, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(21, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(21, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Caducidad:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(354, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCad
            // 
            this.txtCad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCad.Location = new System.Drawing.Point(173, 211);
            this.txtCad.Name = "txtCad";
            this.txtCad.Size = new System.Drawing.Size(121, 22);
            this.txtCad.TabIndex = 7;
            // 
            // txtNom
            // 
            this.txtNom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNom.Location = new System.Drawing.Point(173, 22);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(121, 22);
            this.txtNom.TabIndex = 8;
            // 
            // txtDes
            // 
            this.txtDes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDes.Location = new System.Drawing.Point(173, 71);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(121, 22);
            this.txtDes.TabIndex = 9;
            // 
            // txtCan
            // 
            this.txtCan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCan.Location = new System.Drawing.Point(173, 119);
            this.txtCan.Name = "txtCan";
            this.txtCan.Size = new System.Drawing.Size(121, 22);
            this.txtCan.TabIndex = 10;
            // 
            // txtPre
            // 
            this.txtPre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPre.Location = new System.Drawing.Point(173, 165);
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(121, 22);
            this.txtPre.TabIndex = 11;
            // 
            // UnidadMedida
            // 
            this.UnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnidadMedida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UnidadMedida.FormattingEnabled = true;
            this.UnidadMedida.Items.AddRange(new object[] {
            "Unidad.",
            "Lt.",
            "Ml.",
            "Lbr.",
            "Gr.",
            "Kg."});
            this.UnidadMedida.Location = new System.Drawing.Point(173, 267);
            this.UnidadMedida.Name = "UnidadMedida";
            this.UnidadMedida.Size = new System.Drawing.Size(121, 24);
            this.UnidadMedida.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(337, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Precio Min:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(337, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Precio Max:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(337, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Fecha de caducidad:";
            // 
            // txtPrecioMin
            // 
            this.txtPrecioMin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPrecioMin.Location = new System.Drawing.Point(496, 27);
            this.txtPrecioMin.Name = "txtPrecioMin";
            this.txtPrecioMin.Size = new System.Drawing.Size(121, 22);
            this.txtPrecioMin.TabIndex = 16;
            // 
            // txtPrecioMax
            // 
            this.txtPrecioMax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPrecioMax.Location = new System.Drawing.Point(496, 76);
            this.txtPrecioMax.Name = "txtPrecioMax";
            this.txtPrecioMax.Size = new System.Drawing.Size(121, 22);
            this.txtPrecioMax.TabIndex = 17;
            // 
            // TxtCaducidad
            // 
            this.TxtCaducidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtCaducidad.Location = new System.Drawing.Point(496, 124);
            this.TxtCaducidad.Name = "TxtCaducidad";
            this.TxtCaducidad.Size = new System.Drawing.Size(121, 22);
            this.TxtCaducidad.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(629, 340);
            this.Controls.Add(this.TxtCaducidad);
            this.Controls.Add(this.txtPrecioMax);
            this.Controls.Add(this.txtPrecioMin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UnidadMedida);
            this.Controls.Add(this.txtPre);
            this.Controls.Add(this.txtCan);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtCad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Administrade de productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCad;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.TextBox txtCan;
        private System.Windows.Forms.TextBox txtPre;
        private System.Windows.Forms.ComboBox UnidadMedida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrecioMin;
        private System.Windows.Forms.TextBox txtPrecioMax;
        private System.Windows.Forms.TextBox TxtCaducidad;
    }
}

