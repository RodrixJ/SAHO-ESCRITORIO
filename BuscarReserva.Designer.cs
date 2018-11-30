namespace SAHO
{
    partial class BuscarReserva
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
            this.pantalla = new System.Windows.Forms.DataGridView();
            this.historial = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.numero = new System.Windows.Forms.TextBox();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.nume = new System.Windows.Forms.TextBox();
            this.desocupar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pantalla)).BeginInit();
            this.SuspendLayout();
            // 
            // pantalla
            // 
            this.pantalla.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.pantalla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pantalla.Location = new System.Drawing.Point(152, 108);
            this.pantalla.Name = "pantalla";
            this.pantalla.Size = new System.Drawing.Size(821, 273);
            this.pantalla.TabIndex = 53;
            // 
            // historial
            // 
            this.historial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.historial.FlatAppearance.BorderSize = 0;
            this.historial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.historial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.historial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historial.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historial.ForeColor = System.Drawing.Color.LightGray;
            this.historial.Location = new System.Drawing.Point(683, 44);
            this.historial.Name = "historial";
            this.historial.Size = new System.Drawing.Size(237, 36);
            this.historial.TabIndex = 59;
            this.historial.Text = "Ver historial";
            this.historial.UseVisualStyleBackColor = false;
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.buscar.FlatAppearance.BorderSize = 0;
            this.buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.ForeColor = System.Drawing.Color.LightGray;
            this.buscar.Location = new System.Drawing.Point(417, 44);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(237, 36);
            this.buscar.TabIndex = 58;
            this.buscar.Text = "Buscar Reserva";
            this.buscar.UseVisualStyleBackColor = false;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // numero
            // 
            this.numero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.numero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numero.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero.ForeColor = System.Drawing.Color.LightGray;
            this.numero.Location = new System.Drawing.Point(217, 52);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(170, 24);
            this.numero.TabIndex = 57;
            this.numero.Text = "Numero de cuarto";
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.Black;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 436;
            this.lineShape4.X2 = 605;
            this.lineShape4.Y1 = 254;
            this.lineShape4.Y2 = 253;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1,
            this.lineShape4});
            this.shapeContainer1.Size = new System.Drawing.Size(1040, 506);
            this.shapeContainer1.TabIndex = 60;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Black;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 179;
            this.lineShape2.X2 = 392;
            this.lineShape2.Y1 = 444;
            this.lineShape2.Y2 = 444;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Black;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 223;
            this.lineShape1.X2 = 393;
            this.lineShape1.Y1 = 87;
            this.lineShape1.Y2 = 87;
            // 
            // nume
            // 
            this.nume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.nume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nume.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nume.ForeColor = System.Drawing.Color.LightGray;
            this.nume.Location = new System.Drawing.Point(175, 413);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(214, 24);
            this.nume.TabIndex = 61;
            this.nume.Text = "Numero de habitacion";
            // 
            // desocupar
            // 
            this.desocupar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.desocupar.FlatAppearance.BorderSize = 0;
            this.desocupar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.desocupar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.desocupar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.desocupar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desocupar.ForeColor = System.Drawing.Color.LightGray;
            this.desocupar.Location = new System.Drawing.Point(417, 408);
            this.desocupar.Name = "desocupar";
            this.desocupar.Size = new System.Drawing.Size(237, 36);
            this.desocupar.TabIndex = 62;
            this.desocupar.Text = "Desocupar habitacion";
            this.desocupar.UseVisualStyleBackColor = false;
            // 
            // BuscarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(1040, 506);
            this.Controls.Add(this.desocupar);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.historial);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.pantalla);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarReserva";
            this.Text = "BuscarReserva";
            this.Load += new System.EventHandler(this.BuscarReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pantalla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView pantalla;
        private System.Windows.Forms.Button historial;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TextBox numero;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.TextBox nume;
        private System.Windows.Forms.Button desocupar;
    }
}