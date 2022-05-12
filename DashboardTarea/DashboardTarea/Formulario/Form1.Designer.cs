
namespace DashboardTarea
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCiudad = new System.Windows.Forms.ComboBox();
            this.cBoxSeleccion = new System.Windows.Forms.ComboBox();
            this.tLPInfo = new System.Windows.Forms.TableLayoutPanel();
            this.btInfo1 = new System.Windows.Forms.Button();
            this.btInfo2 = new System.Windows.Forms.Button();
            this.btInfo3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonInforme = new System.Windows.Forms.Button();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tLPInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.29825F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.70175F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tLPInfo, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.92925F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.07075F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1290, 725);
            this.tableLayoutPanel3.TabIndex = 0;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::DashboardTarea.Properties.Resources.Logotipo_empresa;
            this.pictureBox2.Location = new System.Drawing.Point(43, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.comboBoxCiudad, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.cBoxSeleccion, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(251, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(996, 118);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 118);
            this.label2.TabIndex = 0;
            this.label2.Text = "Seleccione el cliente";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(501, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 118);
            this.label3.TabIndex = 2;
            this.label3.Text = "Filtrar ciudad";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxCiudad
            // 
            this.comboBoxCiudad.FormattingEnabled = true;
            this.comboBoxCiudad.Location = new System.Drawing.Point(807, 50);
            this.comboBoxCiudad.Margin = new System.Windows.Forms.Padding(60, 50, 50, 50);
            this.comboBoxCiudad.Name = "comboBoxCiudad";
            this.comboBoxCiudad.Size = new System.Drawing.Size(120, 21);
            this.comboBoxCiudad.TabIndex = 3;
            this.comboBoxCiudad.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // cBoxSeleccion
            // 
            this.cBoxSeleccion.FormattingEnabled = true;
            this.cBoxSeleccion.Location = new System.Drawing.Point(309, 50);
            this.cBoxSeleccion.Margin = new System.Windows.Forms.Padding(60, 50, 50, 50);
            this.cBoxSeleccion.Name = "cBoxSeleccion";
            this.cBoxSeleccion.Size = new System.Drawing.Size(120, 21);
            this.cBoxSeleccion.TabIndex = 1;
            this.cBoxSeleccion.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // tLPInfo
            // 
            this.tLPInfo.ColumnCount = 1;
            this.tLPInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPInfo.Controls.Add(this.btInfo1, 0, 1);
            this.tLPInfo.Controls.Add(this.btInfo2, 0, 2);
            this.tLPInfo.Controls.Add(this.btInfo3, 0, 3);
            this.tLPInfo.Controls.Add(this.button1, 0, 4);
            this.tLPInfo.Controls.Add(this.buttonInforme, 0, 5);
            this.tLPInfo.Location = new System.Drawing.Point(3, 140);
            this.tLPInfo.Name = "tLPInfo";
            this.tLPInfo.RowCount = 6;
            this.tLPInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.8517F));
            this.tLPInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.180003F));
            this.tLPInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.46503F));
            this.tLPInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.59357F));
            this.tLPInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tLPInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tLPInfo.Size = new System.Drawing.Size(233, 529);
            this.tLPInfo.TabIndex = 2;
            this.tLPInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.tLPInfo_Paint);
            // 
            // btInfo1
            // 
            this.btInfo1.BackColor = System.Drawing.SystemColors.Info;
            this.btInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btInfo1.Location = new System.Drawing.Point(3, 148);
            this.btInfo1.Name = "btInfo1";
            this.btInfo1.Size = new System.Drawing.Size(227, 32);
            this.btInfo1.TabIndex = 3;
            this.btInfo1.Text = "Ampliar información";
            this.btInfo1.UseVisualStyleBackColor = false;
            this.btInfo1.Visible = false;
            this.btInfo1.Click += new System.EventHandler(this.btInfo1_Click);
            // 
            // btInfo2
            // 
            this.btInfo2.BackgroundImage = global::DashboardTarea.Properties.Resources.productos;
            this.btInfo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btInfo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btInfo2.Location = new System.Drawing.Point(3, 186);
            this.btInfo2.Name = "btInfo2";
            this.btInfo2.Size = new System.Drawing.Size(227, 118);
            this.btInfo2.TabIndex = 4;
            this.btInfo2.UseVisualStyleBackColor = true;
            this.btInfo2.Visible = false;
            this.btInfo2.Click += new System.EventHandler(this.btInfo2_Click);
            // 
            // btInfo3
            // 
            this.btInfo3.BackColor = System.Drawing.SystemColors.Control;
            this.btInfo3.BackgroundImage = global::DashboardTarea.Properties.Resources.facturaImagen;
            this.btInfo3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btInfo3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btInfo3.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.btInfo3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btInfo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInfo3.ForeColor = System.Drawing.Color.Black;
            this.btInfo3.Location = new System.Drawing.Point(3, 310);
            this.btInfo3.Name = "btInfo3";
            this.btInfo3.Size = new System.Drawing.Size(227, 156);
            this.btInfo3.TabIndex = 5;
            this.btInfo3.UseVisualStyleBackColor = false;
            this.btInfo3.Visible = false;
            this.btInfo3.Click += new System.EventHandler(this.btInfo3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Gráfica de Productos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonInforme
            // 
            this.buttonInforme.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonInforme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonInforme.Location = new System.Drawing.Point(3, 501);
            this.buttonInforme.Name = "buttonInforme";
            this.buttonInforme.Size = new System.Drawing.Size(227, 25);
            this.buttonInforme.TabIndex = 7;
            this.buttonInforme.Text = "Generar informe";
            this.buttonInforme.UseVisualStyleBackColor = false;
            this.buttonInforme.Visible = false;
            this.buttonInforme.Click += new System.EventHandler(this.buttonInforme_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1290, 725);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "Form1";
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tLPInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dG1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxSeleccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCiudad;
        private System.Windows.Forms.TableLayoutPanel tLPInfo;
        private System.Windows.Forms.Button btInfo1;
        private System.Windows.Forms.Button btInfo2;
        private System.Windows.Forms.Button btInfo3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonInforme;
    }
}

