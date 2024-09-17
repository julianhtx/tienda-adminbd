namespace proyectoTiendaBD
{
    partial class ModificarProductos
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBModificar = new System.Windows.Forms.TextBox();
            this.dtgvModProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvModProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(176)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(570, -36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(764, 108);
            this.label4.TabIndex = 14;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(76)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(425, -36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(764, 108);
            this.label3.TabIndex = 13;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(111)))), ((int)(((byte)(252)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(290, -36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(764, 108);
            this.label2.TabIndex = 12;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(-13, -36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(764, 108);
            this.label5.TabIndex = 11;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "MODIFICAR PRODUCTOS\r\n";
            // 
            // txtBModificar
            // 
            this.txtBModificar.Location = new System.Drawing.Point(14, 137);
            this.txtBModificar.Multiline = true;
            this.txtBModificar.Name = "txtBModificar";
            this.txtBModificar.Size = new System.Drawing.Size(1039, 44);
            this.txtBModificar.TabIndex = 15;
            this.txtBModificar.TextChanged += new System.EventHandler(this.txtBModificar_TextChanged);
            // 
            // dtgvModProductos
            // 
            this.dtgvModProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvModProductos.Location = new System.Drawing.Point(16, 196);
            this.dtgvModProductos.Name = "dtgvModProductos";
            this.dtgvModProductos.RowHeadersWidth = 51;
            this.dtgvModProductos.RowTemplate.Height = 24;
            this.dtgvModProductos.Size = new System.Drawing.Size(1037, 398);
            this.dtgvModProductos.TabIndex = 16;
            this.dtgvModProductos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvModProductos_CellEnter);
            // 
            // ModificarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 624);
            this.Controls.Add(this.dtgvModProductos);
            this.Controls.Add(this.txtBModificar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "ModificarProductos";
            this.Text = "ModificarProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvModProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBModificar;
        private System.Windows.Forms.DataGridView dtgvModProductos;
    }
}