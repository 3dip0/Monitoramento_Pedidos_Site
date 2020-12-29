
namespace Monitoramento_Pedidos_Site
{
    partial class Monitor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.aceitarPedido = new System.Windows.Forms.Button();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // aceitarPedido
            // 
            this.aceitarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aceitarPedido.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceitarPedido.Location = new System.Drawing.Point(234, 402);
            this.aceitarPedido.Name = "aceitarPedido";
            this.aceitarPedido.Size = new System.Drawing.Size(258, 36);
            this.aceitarPedido.TabIndex = 163;
            this.aceitarPedido.Text = "Aceitar Pedido";
            this.aceitarPedido.UseVisualStyleBackColor = true;
            this.aceitarPedido.Visible = false;
            this.aceitarPedido.Click += new System.EventHandler(this.aceitarPedido_Click);
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AllowUserToDeleteRows = false;
            this.dgvVendas.AllowUserToResizeColumns = false;
            this.dgvVendas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvVendas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVendas.BackgroundColor = System.Drawing.Color.White;
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVendas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvVendas.Location = new System.Drawing.Point(0, 0);
            this.dgvVendas.MultiSelect = false;
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.RowHeadersVisible = false;
            this.dgvVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendas.Size = new System.Drawing.Size(747, 396);
            this.dgvVendas.TabIndex = 164;
            this.dgvVendas.TabStop = false;
            this.dgvVendas.DoubleClick += new System.EventHandler(this.dgvVendas_DoubleClick);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.dgvVendas);
            this.Controls.Add(this.aceitarPedido);
            this.Name = "Monitor";
            this.Text = "Monitoramento de Pedidos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button aceitarPedido;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

