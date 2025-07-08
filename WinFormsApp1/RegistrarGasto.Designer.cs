namespace Capa_Presentacion
{
    partial class RegistrarGasto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarGasto));
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Fecha = new Label();
            textmonto = new TextBox();
            textmotivo = new TextBox();
            dateTimefecha = new DateTimePicker();
            button1 = new Button();
            panel2.SuspendLayout();
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
            label1.Location = new Point(28, 46);
            label1.Name = "label1";
            label1.Size = new Size(409, 45);
            label1.TabIndex = 0;
            label1.Text = "Registro De Gasto ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(28, 178);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 2;
            label2.Text = "Monto :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Info;
            label3.Location = new Point(28, 354);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 3;
            label3.Text = "Motivo :";
            // 
            // Fecha
            // 
            Fecha.AutoSize = true;
            Fecha.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Fecha.ForeColor = SystemColors.Info;
            Fecha.Location = new Point(28, 265);
            Fecha.Name = "Fecha";
            Fecha.Size = new Size(92, 25);
            Fecha.TabIndex = 4;
            Fecha.Text = "Fecha :";
            // 
            // textmonto
            // 
            textmonto.Location = new Point(177, 176);
            textmonto.Name = "textmonto";
            textmonto.Size = new Size(250, 27);
            textmonto.TabIndex = 5;
            // 
            // textmotivo
            // 
            textmotivo.Location = new Point(177, 352);
            textmotivo.Name = "textmotivo";
            textmotivo.Size = new Size(250, 27);
            textmotivo.TabIndex = 6;
            // 
            // dateTimefecha
            // 
            dateTimefecha.Location = new Point(177, 265);
            dateTimefecha.Name = "dateTimefecha";
            dateTimefecha.Size = new Size(250, 27);
            dateTimefecha.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(155, 440);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RegistrarGasto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 62, 99);
            ClientSize = new Size(790, 524);
            Controls.Add(button1);
            Controls.Add(dateTimefecha);
            Controls.Add(textmotivo);
            Controls.Add(textmonto);
            Controls.Add(Fecha);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrarGasto";
            Text = "RegistrarGasto";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label Fecha;
        private TextBox textmonto;
        private TextBox textmotivo;
        private DateTimePicker dateTimefecha;
        private Button button1;
    }
}