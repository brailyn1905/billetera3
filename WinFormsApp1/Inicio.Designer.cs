namespace WinFormsApp1
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            BarraTitulo = new Panel();
            btnCerrar = new PictureBox();
            panelVertical = new Panel();
            btnGasto = new Button();
            btnFiltrar = new Button();
            btnIngreso = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            PanelCentral = new Panel();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            panelVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.DarkBlue;
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1005, 37);
            BarraTitulo.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Location = new Point(963, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(30, 31);
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panelVertical
            // 
            panelVertical.BackColor = Color.FromArgb(26, 32, 40);
            panelVertical.Controls.Add(btnGasto);
            panelVertical.Controls.Add(btnFiltrar);
            panelVertical.Controls.Add(btnIngreso);
            panelVertical.Controls.Add(button1);
            panelVertical.Controls.Add(pictureBox1);
            panelVertical.Dock = DockStyle.Left;
            panelVertical.Location = new Point(0, 37);
            panelVertical.Name = "panelVertical";
            panelVertical.Size = new Size(215, 524);
            panelVertical.TabIndex = 1;
            // 
            // btnGasto
            // 
            btnGasto.FlatAppearance.BorderSize = 0;
            btnGasto.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 62, 99);
            btnGasto.FlatStyle = FlatStyle.Flat;
            btnGasto.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGasto.ForeColor = SystemColors.Info;
            btnGasto.Location = new Point(10, 343);
            btnGasto.Name = "btnGasto";
            btnGasto.Size = new Size(194, 73);
            btnGasto.TabIndex = 4;
            btnGasto.Text = "Registrar Gastos";
            btnGasto.UseVisualStyleBackColor = true;
            btnGasto.Click += btnGasto_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.FlatAppearance.BorderSize = 0;
            btnFiltrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 62, 99);
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltrar.ForeColor = SystemColors.Info;
            btnFiltrar.Location = new Point(10, 439);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(194, 73);
            btnFiltrar.TabIndex = 3;
            btnFiltrar.Text = "Filtar por Fecha";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnIngreso
            // 
            btnIngreso.FlatAppearance.BorderSize = 0;
            btnIngreso.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 62, 99);
            btnIngreso.FlatStyle = FlatStyle.Flat;
            btnIngreso.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngreso.ForeColor = SystemColors.Info;
            btnIngreso.Location = new Point(10, 226);
            btnIngreso.Name = "btnIngreso";
            btnIngreso.Size = new Size(194, 73);
            btnIngreso.TabIndex = 2;
            btnIngreso.Text = "Registrar Ingreso";
            btnIngreso.UseVisualStyleBackColor = true;
            btnIngreso.Click += btnIngreso_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 62, 99);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Info;
            button1.Location = new Point(10, 133);
            button1.Name = "button1";
            button1.Size = new Size(194, 73);
            button1.TabIndex = 1;
            button1.Text = "Ultimas Transacciones";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 105);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PanelCentral
            // 
            PanelCentral.BackColor = Color.FromArgb(29, 62, 99);
            PanelCentral.BackgroundImage = (Image)resources.GetObject("PanelCentral.BackgroundImage");
            PanelCentral.BackgroundImageLayout = ImageLayout.Stretch;
            PanelCentral.Dock = DockStyle.Fill;
            PanelCentral.Location = new Point(215, 37);
            PanelCentral.Name = "PanelCentral";
            PanelCentral.Size = new Size(790, 524);
            PanelCentral.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 561);
            Controls.Add(PanelCentral);
            Controls.Add(panelVertical);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            panelVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BarraTitulo;
        private Panel panelVertical;
        private PictureBox btnCerrar;
        private Panel PanelCentral;
        private Button button1;
        private PictureBox pictureBox1;
        private Button btnGasto;
        private Button btnFiltrar;
        private Button btnIngreso;
    }
}
