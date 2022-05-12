
namespace DashboardTarea.Controles_Usuario
{
    partial class HistorialUC
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
            this.dGVHistorial = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVHistorial
            // 
            this.dGVHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVHistorial.Location = new System.Drawing.Point(146, 50);
            this.dGVHistorial.Name = "dGVHistorial";
            this.dGVHistorial.Size = new System.Drawing.Size(563, 448);
            this.dGVHistorial.TabIndex = 0;
            this.dGVHistorial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVHistorial_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Historial de pedidos";
            // 
            // HistorialUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGVHistorial);
            this.Name = "HistorialUC";
            this.Size = new System.Drawing.Size(774, 534);
            ((System.ComponentModel.ISupportInitialize)(this.dGVHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVHistorial;
        private System.Windows.Forms.Label label1;
    }
}
