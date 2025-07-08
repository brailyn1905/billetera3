namespace Capa_Presentacion
{
    partial class UltimasTrasacciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UltimasTrasacciones));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textSaldoActual = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(522, 178);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 421);
            label1.Name = "label1";
            label1.Size = new Size(181, 28);
            label1.TabIndex = 1;
            label1.Text = "Saldo Actual:";
            // 
            // textSaldoActual
            // 
            textSaldoActual.BackColor = SystemColors.ScrollBar;
            textSaldoActual.Location = new Point(223, 421);
            textSaldoActual.Name = "textSaldoActual";
            textSaldoActual.ReadOnly = true;
            textSaldoActual.Size = new Size(248, 27);
            textSaldoActual.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(540, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 524);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(540, 125);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(501, 45);
            label2.TabIndex = 0;
            label2.Text = "Ultimas Transacciones ";
            // 
            // UltimasTrasacciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 62, 99);
            ClientSize = new Size(790, 524);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textSaldoActual);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UltimasTrasacciones";
            Text = "UltimasTrasacciones";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textSaldoActual;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
    }
}