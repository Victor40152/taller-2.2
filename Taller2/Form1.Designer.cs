namespace Taller2
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
            this.lbliva = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.lbliva1 = new System.Windows.Forms.Label();
            this.lbliva2 = new System.Windows.Forms.Label();
            this.lbliva3 = new System.Windows.Forms.Label();
            this.lbliva4 = new System.Windows.Forms.Label();
            this.btnenviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbliva
            // 
            this.lbliva.AutoSize = true;
            this.lbliva.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliva.Location = new System.Drawing.Point(275, 62);
            this.lbliva.Name = "lbliva";
            this.lbliva.Size = new System.Drawing.Size(199, 32);
            this.lbliva.TabIndex = 0;
            this.lbliva.Text = "Calculo del IVA";
            this.lbliva.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio.Location = new System.Drawing.Point(91, 157);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(171, 22);
            this.lblprecio.TabIndex = 1;
            this.lblprecio.Text = "Valor del Producto:";
            // 
            // txtprecio
            // 
            this.txtprecio.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.Location = new System.Drawing.Point(305, 157);
            this.txtprecio.Multiline = true;
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(143, 34);
            this.txtprecio.TabIndex = 2;
            // 
            // lbliva1
            // 
            this.lbliva1.AutoSize = true;
            this.lbliva1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliva1.Location = new System.Drawing.Point(95, 210);
            this.lbliva1.Name = "lbliva1";
            this.lbliva1.Size = new System.Drawing.Size(52, 24);
            this.lbliva1.TabIndex = 3;
            this.lbliva1.Text = " IVA:";
            // 
            // lbliva2
            // 
            this.lbliva2.AutoSize = true;
            this.lbliva2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliva2.Location = new System.Drawing.Point(305, 210);
            this.lbliva2.Name = "lbliva2";
            this.lbliva2.Size = new System.Drawing.Size(25, 27);
            this.lbliva2.TabIndex = 4;
            this.lbliva2.Text = "0";
            // 
            // lbliva3
            // 
            this.lbliva3.AutoSize = true;
            this.lbliva3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliva3.Location = new System.Drawing.Point(99, 297);
            this.lbliva3.Name = "lbliva3";
            this.lbliva3.Size = new System.Drawing.Size(128, 24);
            this.lbliva3.TabIndex = 5;
            this.lbliva3.Text = "Precio Final:";
            // 
            // lbliva4
            // 
            this.lbliva4.AutoSize = true;
            this.lbliva4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliva4.Location = new System.Drawing.Point(300, 297);
            this.lbliva4.Name = "lbliva4";
            this.lbliva4.Size = new System.Drawing.Size(25, 27);
            this.lbliva4.TabIndex = 6;
            this.lbliva4.Text = "0";
            // 
            // btnenviar
            // 
            this.btnenviar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenviar.Location = new System.Drawing.Point(502, 210);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(128, 49);
            this.btnenviar.TabIndex = 7;
            this.btnenviar.Text = "Calcular";
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.lbliva4);
            this.Controls.Add(this.lbliva3);
            this.Controls.Add(this.lbliva2);
            this.Controls.Add(this.lbliva1);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lbliva);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbliva;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label lbliva1;
        private System.Windows.Forms.Label lbliva2;
        private System.Windows.Forms.Label lbliva3;
        private System.Windows.Forms.Label lbliva4;
        private System.Windows.Forms.Button btnenviar;
    }
}

