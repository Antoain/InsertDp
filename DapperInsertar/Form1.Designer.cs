namespace DapperInsertar
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
            this.DgvCategorias = new System.Windows.Forms.DataGridView();
            this.btnCargarTods = new System.Windows.Forms.Button();
            this.btnBuscarID = new System.Windows.Forms.Button();
            this.txtBBuscarID = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.txtBCategoryName = new System.Windows.Forms.TextBox();
            this.txtBDescripcion = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvCategorias
            // 
            this.DgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCategorias.Location = new System.Drawing.Point(12, 12);
            this.DgvCategorias.Name = "DgvCategorias";
            this.DgvCategorias.RowHeadersWidth = 51;
            this.DgvCategorias.RowTemplate.Height = 24;
            this.DgvCategorias.Size = new System.Drawing.Size(1119, 574);
            this.DgvCategorias.TabIndex = 0;
            // 
            // btnCargarTods
            // 
            this.btnCargarTods.Location = new System.Drawing.Point(157, 608);
            this.btnCargarTods.Name = "btnCargarTods";
            this.btnCargarTods.Size = new System.Drawing.Size(138, 23);
            this.btnCargarTods.TabIndex = 1;
            this.btnCargarTods.Text = "Cargar Todas";
            this.btnCargarTods.UseVisualStyleBackColor = true;
            this.btnCargarTods.Click += new System.EventHandler(this.btnCargarTods_Click);
            // 
            // btnBuscarID
            // 
            this.btnBuscarID.Location = new System.Drawing.Point(263, 666);
            this.btnBuscarID.Name = "btnBuscarID";
            this.btnBuscarID.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarID.TabIndex = 2;
            this.btnBuscarID.Text = "BuscarID";
            this.btnBuscarID.UseVisualStyleBackColor = true;
            this.btnBuscarID.Click += new System.EventHandler(this.btnBuscarID_Click);
            // 
            // txtBBuscarID
            // 
            this.txtBBuscarID.Location = new System.Drawing.Point(157, 666);
            this.txtBBuscarID.Name = "txtBBuscarID";
            this.txtBBuscarID.Size = new System.Drawing.Size(100, 22);
            this.txtBBuscarID.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(107, 666);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(20, 16);
            this.ID.TabIndex = 4;
            this.ID.Text = "ID";
            // 
            // txtBCategoryName
            // 
            this.txtBCategoryName.Location = new System.Drawing.Point(499, 636);
            this.txtBCategoryName.Name = "txtBCategoryName";
            this.txtBCategoryName.Size = new System.Drawing.Size(100, 22);
            this.txtBCategoryName.TabIndex = 6;
            // 
            // txtBDescripcion
            // 
            this.txtBDescripcion.Location = new System.Drawing.Point(499, 663);
            this.txtBDescripcion.Name = "txtBDescripcion";
            this.txtBDescripcion.Size = new System.Drawing.Size(100, 22);
            this.txtBDescripcion.TabIndex = 7;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(410, 704);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 8;
            this.btnInsertar.Text = "insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 642);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "CatName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 669);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descripccion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 810);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtBDescripcion);
            this.Controls.Add(this.txtBCategoryName);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txtBBuscarID);
            this.Controls.Add(this.btnBuscarID);
            this.Controls.Add(this.btnCargarTods);
            this.Controls.Add(this.DgvCategorias);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvCategorias;
        private System.Windows.Forms.Button btnCargarTods;
        private System.Windows.Forms.Button btnBuscarID;
        private System.Windows.Forms.TextBox txtBBuscarID;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox txtBCategoryName;
        private System.Windows.Forms.TextBox txtBDescripcion;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

