namespace ETIQUETAS_LPS_23
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
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CBO_EMPALME = new System.Windows.Forms.ComboBox();
            this.CBO_SELECTOR = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_INIFIN = new AltoControls.AltoTextBox();
            this.txt_opcion = new AltoControls.AltoTextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_IMPRIMIR = new System.Windows.Forms.Button();
            this.LBL_FECHA = new System.Windows.Forms.Label();
            this.cbo_impresoras = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(1, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1748, 78);
            this.panel3.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 28.17391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(224, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(873, 52);
            this.label5.TabIndex = 13;
            this.label5.Text = "SISTEMA IMPRESION DE ETIQUETAS LPS";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(1, 973);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1748, 87);
            this.panel4.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ETIQUETAS_LPS_23.Properties.Resources.logosinfondo;
            this.pictureBox1.Location = new System.Drawing.Point(1188, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.CBO_EMPALME);
            this.panel2.Controls.Add(this.CBO_SELECTOR);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(25, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1470, 216);
            this.panel2.TabIndex = 16;
            // 
            // CBO_EMPALME
            // 
            this.CBO_EMPALME.DropDownHeight = 250;
            this.CBO_EMPALME.Font = new System.Drawing.Font("Consolas", 40.06956F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBO_EMPALME.FormattingEnabled = true;
            this.CBO_EMPALME.IntegralHeight = false;
            this.CBO_EMPALME.Location = new System.Drawing.Point(414, 18);
            this.CBO_EMPALME.Name = "CBO_EMPALME";
            this.CBO_EMPALME.Size = new System.Drawing.Size(1049, 83);
            this.CBO_EMPALME.TabIndex = 5;
            this.CBO_EMPALME.SelectedIndexChanged += new System.EventHandler(this.CBO_EMPALME_SelectedIndexChanged);
            this.CBO_EMPALME.SelectedValueChanged += new System.EventHandler(this.CBO_EMPALME_SelectedValueChanged);
            // 
            // CBO_SELECTOR
            // 
            this.CBO_SELECTOR.DropDownHeight = 250;
            this.CBO_SELECTOR.Font = new System.Drawing.Font("Consolas", 40.06956F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBO_SELECTOR.FormattingEnabled = true;
            this.CBO_SELECTOR.IntegralHeight = false;
            this.CBO_SELECTOR.Location = new System.Drawing.Point(414, 117);
            this.CBO_SELECTOR.Name = "CBO_SELECTOR";
            this.CBO_SELECTOR.Size = new System.Drawing.Size(1049, 83);
            this.CBO_SELECTOR.TabIndex = 1;
            this.CBO_SELECTOR.SelectedIndexChanged += new System.EventHandler(this.CBO_SELECTOR_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 40.06956F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 75);
            this.label2.TabIndex = 2;
            this.label2.Text = "SELECTOR:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 40.06956F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMPALME:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_INIFIN);
            this.panel1.Controls.Add(this.txt_opcion);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(25, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1470, 212);
            this.panel1.TabIndex = 15;
            // 
            // txt_INIFIN
            // 
            this.txt_INIFIN.BackColor = System.Drawing.Color.Transparent;
            this.txt_INIFIN.Br = System.Drawing.Color.White;
            this.txt_INIFIN.Enabled = false;
            this.txt_INIFIN.Font = new System.Drawing.Font("Consolas", 40.06956F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_INIFIN.ForeColor = System.Drawing.Color.DimGray;
            this.txt_INIFIN.Location = new System.Drawing.Point(414, 111);
            this.txt_INIFIN.Name = "txt_INIFIN";
            this.txt_INIFIN.Size = new System.Drawing.Size(1049, 85);
            this.txt_INIFIN.TabIndex = 17;
            // 
            // txt_opcion
            // 
            this.txt_opcion.BackColor = System.Drawing.Color.Transparent;
            this.txt_opcion.Br = System.Drawing.Color.White;
            this.txt_opcion.Enabled = false;
            this.txt_opcion.Font = new System.Drawing.Font("Consolas", 40.06956F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_opcion.ForeColor = System.Drawing.Color.DimGray;
            this.txt_opcion.Location = new System.Drawing.Point(414, 18);
            this.txt_opcion.Name = "txt_opcion";
            this.txt_opcion.Size = new System.Drawing.Size(1049, 85);
            this.txt_opcion.TabIndex = 16;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Consolas", 40.06956F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(390, -199);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(396, 83);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Consolas", 40.06956F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(390, -100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(396, 83);
            this.comboBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 40.06956F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(312, 75);
            this.label4.TabIndex = 4;
            this.label4.Text = "INI-FIN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 40.06956F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 75);
            this.label3.TabIndex = 3;
            this.label3.Text = "OPCION:";
            // 
            // BTN_IMPRIMIR
            // 
            this.BTN_IMPRIMIR.Font = new System.Drawing.Font("Consolas", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_IMPRIMIR.Image = global::ETIQUETAS_LPS_23.Properties.Resources._1475623484_Print;
            this.BTN_IMPRIMIR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_IMPRIMIR.Location = new System.Drawing.Point(668, 693);
            this.BTN_IMPRIMIR.Name = "BTN_IMPRIMIR";
            this.BTN_IMPRIMIR.Size = new System.Drawing.Size(252, 162);
            this.BTN_IMPRIMIR.TabIndex = 14;
            this.BTN_IMPRIMIR.Text = "IMPRIMIR";
            this.BTN_IMPRIMIR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_IMPRIMIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTN_IMPRIMIR.UseVisualStyleBackColor = true;
            this.BTN_IMPRIMIR.Click += new System.EventHandler(this.BTN_IMPRIMIR_Click);
            // 
            // LBL_FECHA
            // 
            this.LBL_FECHA.AutoSize = true;
            this.LBL_FECHA.Font = new System.Drawing.Font("Consolas", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_FECHA.Location = new System.Drawing.Point(154, 605);
            this.LBL_FECHA.Name = "LBL_FECHA";
            this.LBL_FECHA.Size = new System.Drawing.Size(70, 22);
            this.LBL_FECHA.TabIndex = 19;
            this.LBL_FECHA.Text = "label6";
            // 
            // cbo_impresoras
            // 
            this.cbo_impresoras.Font = new System.Drawing.Font("Consolas", 18.15652F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_impresoras.FormattingEnabled = true;
            this.cbo_impresoras.Location = new System.Drawing.Point(484, 98);
            this.cbo_impresoras.Name = "cbo_impresoras";
            this.cbo_impresoras.Size = new System.Drawing.Size(613, 42);
            this.cbo_impresoras.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 18.15652F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(280, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 34);
            this.label6.TabIndex = 6;
            this.label6.Text = "IMPRESORA:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Font = new System.Drawing.Font("Consolas", 23.7913F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.Location = new System.Drawing.Point(806, 609);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(114, 52);
            this.txt_cantidad.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 23.7913F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(561, 612);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 45);
            this.label7.TabIndex = 22;
            this.label7.Text = "CANTIDAD:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1747, 1057);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbo_impresoras);
            this.Controls.Add(this.LBL_FECHA);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTN_IMPRIMIR);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CBO_EMPALME;
        private System.Windows.Forms.ComboBox CBO_SELECTOR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_IMPRIMIR;
        private AltoControls.AltoTextBox txt_INIFIN;
        private AltoControls.AltoTextBox txt_opcion;
        private System.Windows.Forms.Label LBL_FECHA;
        private System.Windows.Forms.ComboBox cbo_impresoras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label7;
    }
}

