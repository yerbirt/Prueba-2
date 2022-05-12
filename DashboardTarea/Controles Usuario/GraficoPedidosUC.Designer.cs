
namespace DashboardTarea.Controles_Usuario
{
    partial class GraficoPedidosUC
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tB1 = new System.Windows.Forms.TextBox();
            this.tB2 = new System.Windows.Forms.TextBox();
            this.tB3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos destacados del cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tB1
            // 
            this.tB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB1.Location = new System.Drawing.Point(268, 141);
            this.tB1.Name = "tB1";
            this.tB1.Size = new System.Drawing.Size(329, 38);
            this.tB1.TabIndex = 1;
            this.tB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tB2
            // 
            this.tB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB2.Location = new System.Drawing.Point(268, 245);
            this.tB2.Name = "tB2";
            this.tB2.Size = new System.Drawing.Size(329, 38);
            this.tB2.TabIndex = 2;
            this.tB2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tB3
            // 
            this.tB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB3.Location = new System.Drawing.Point(268, 346);
            this.tB3.Name = "tB3";
            this.tB3.Size = new System.Drawing.Size(329, 38);
            this.tB3.TabIndex = 3;
            this.tB3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GraficoPedidosUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tB3);
            this.Controls.Add(this.tB2);
            this.Controls.Add(this.tB1);
            this.Controls.Add(this.label1);
            this.Name = "GraficoPedidosUC";
            this.Size = new System.Drawing.Size(756, 512);
            this.Load += new System.EventHandler(this.GraficoPedidosUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB1;
        private System.Windows.Forms.TextBox tB2;
        private System.Windows.Forms.TextBox tB3;
    }
}
