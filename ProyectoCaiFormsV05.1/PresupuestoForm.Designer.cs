namespace ProyectoCaiFormsV05._1
{
    partial class PresupuestoForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnQuitarProducto;

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnQuitarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // dataGridView1
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 438);
            this.dataGridView1.TabIndex = 0;

            // btnConfirmar
            this.btnConfirmar.Location = new System.Drawing.Point(12, 456);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(120, 30);
            this.btnConfirmar.Text = "Confirmar presupuesto";
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.UseVisualStyleBackColor = true;

            // btnQuitarProducto
            this.btnQuitarProducto.Location = new System.Drawing.Point(150, 456);
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Size = new System.Drawing.Size(120, 30);
            this.btnQuitarProducto.Text = "Quitar producto";
            this.btnQuitarProducto.Click += new System.EventHandler(this.btnQuitarProducto_Click);
            this.btnQuitarProducto.TabIndex = 2;
            this.btnQuitarProducto.UseVisualStyleBackColor = true;

            // PresupuestoForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 700);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnQuitarProducto);
            this.Name = "PresupuestoForm";
            this.Text = "Presupuesto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
