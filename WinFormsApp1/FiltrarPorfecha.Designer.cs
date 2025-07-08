namespace Capa_Presentacion
{
    partial class FiltrarPorfecha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiltrarPorfecha));
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePickerDesde = new DateTimePicker();
            dateTimePickerHasta = new DateTimePicker();
            comboBoxFiltro = new ComboBox();
            dataGridViewTransacciones = new DataGridView();
            btnFiltrar = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransacciones).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(540, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 524);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(29, 62, 99);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(540, 125);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(70, 43);
            label1.Name = "label1";
            label1.Size = new Size(366, 45);
            label1.TabIndex = 0;
            label1.Text = "Filtrar Por Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(30, 144);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 2;
            label2.Text = "Desde :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Info;
            label3.Location = new Point(50, 258);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 3;
            label3.Text = "tipo :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Info;
            label4.Location = new Point(30, 202);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 4;
            label4.Text = "Hasta :";
            label4.Click += label4_Click;
            // 
            // dateTimePickerDesde
            // 
            dateTimePickerDesde.Location = new Point(159, 144);
            dateTimePickerDesde.Name = "dateTimePickerDesde";
            dateTimePickerDesde.Size = new Size(250, 27);
            dateTimePickerDesde.TabIndex = 5;
            // 
            // dateTimePickerHasta
            // 
            dateTimePickerHasta.Location = new Point(159, 202);
            dateTimePickerHasta.Name = "dateTimePickerHasta";
            dateTimePickerHasta.Size = new Size(250, 27);
            dateTimePickerHasta.TabIndex = 6;
            // 
            // comboBoxFiltro
            // 
            comboBoxFiltro.FormattingEnabled = true;
            comboBoxFiltro.Location = new Point(159, 260);
            comboBoxFiltro.Name = "comboBoxFiltro";
            comboBoxFiltro.Size = new Size(193, 28);
            comboBoxFiltro.TabIndex = 7;
            // 
            // dataGridViewTransacciones
            // 
            dataGridViewTransacciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransacciones.Location = new Point(30, 364);
            dataGridViewTransacciones.Name = "dataGridViewTransacciones";
            dataGridViewTransacciones.RowHeadersWidth = 51;
            dataGridViewTransacciones.Size = new Size(490, 124);
            dataGridViewTransacciones.TabIndex = 8;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(70, 317);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(113, 29);
            btnFiltrar.TabIndex = 9;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // FiltrarPorfecha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 62, 99);
            ClientSize = new Size(790, 524);
            Controls.Add(btnFiltrar);
            Controls.Add(dataGridViewTransacciones);
            Controls.Add(comboBoxFiltro);
            Controls.Add(dateTimePickerHasta);
            Controls.Add(dateTimePickerDesde);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FiltrarPorfecha";
            Text = "FiltrarPorfecha";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransacciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePickerDesde;
        private DateTimePicker dateTimePickerHasta;
        private ComboBox comboBoxFiltro;
        private DataGridView dataGridViewTransacciones;
        private Button btnFiltrar;
    }
}