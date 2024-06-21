namespace ArduinoCsharp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnLigar = new ControlesPersonalizados.CMControles.CMButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.btnDesligar = new ControlesPersonalizados.CMControles.CMButton();
            this.btnFechar = new ControlesPersonalizados.CMControles.CMButton();
            this.PortaSerial = new System.IO.Ports.SerialPort(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbPortas = new ControlesPersonalizados.CMControles.CMComboBox();
            this.btnConetar = new ControlesPersonalizados.CMControles.CMButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLigar
            // 
            this.btnLigar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(138)))), ((int)(((byte)(186)))));
            this.btnLigar.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(138)))), ((int)(((byte)(186)))));
            this.btnLigar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(197)))), ((int)(((byte)(204)))));
            this.btnLigar.BorderRadius = 130;
            this.btnLigar.BorderSize = 1;
            this.btnLigar.Enabled = false;
            this.btnLigar.FlatAppearance.BorderSize = 0;
            this.btnLigar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnLigar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLigar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLigar.ForeColor = System.Drawing.Color.White;
            this.btnLigar.Location = new System.Drawing.Point(29, 166);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(130, 130);
            this.btnLigar.TabIndex = 0;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.TextColor = System.Drawing.Color.White;
            this.btnLigar.UseVisualStyleBackColor = false;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(45, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ligar e Acender uma lampada no Arduino";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(54)))), ((int)(((byte)(102)))));
            this.panel.Location = new System.Drawing.Point(0, 79);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(369, 10);
            this.panel.TabIndex = 2;
            // 
            // btnDesligar
            // 
            this.btnDesligar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(138)))), ((int)(((byte)(186)))));
            this.btnDesligar.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(138)))), ((int)(((byte)(186)))));
            this.btnDesligar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDesligar.BorderRadius = 130;
            this.btnDesligar.BorderSize = 1;
            this.btnDesligar.Enabled = false;
            this.btnDesligar.FlatAppearance.BorderSize = 0;
            this.btnDesligar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnDesligar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesligar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesligar.ForeColor = System.Drawing.Color.White;
            this.btnDesligar.Location = new System.Drawing.Point(203, 166);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(130, 130);
            this.btnDesligar.TabIndex = 3;
            this.btnDesligar.Text = "Desligar";
            this.btnDesligar.TextColor = System.Drawing.Color.White;
            this.btnDesligar.UseVisualStyleBackColor = false;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(54)))), ((int)(((byte)(102)))));
            this.btnFechar.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(54)))), ((int)(((byte)(102)))));
            this.btnFechar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFechar.BorderRadius = 38;
            this.btnFechar.BorderSize = 0;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(310, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(38, 38);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "x";
            this.btnFechar.TextColor = System.Drawing.Color.White;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnFechar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 73);
            this.panel2.TabIndex = 5;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // cmbPortas
            // 
            this.cmbPortas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.cmbPortas.BorderColor = System.Drawing.Color.Silver;
            this.cmbPortas.BorderSize = 1;
            this.cmbPortas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbPortas.ForeColor = System.Drawing.Color.DimGray;
            this.cmbPortas.IconColor = System.Drawing.Color.Silver;
            this.cmbPortas.ItemHeight = 16;
            this.cmbPortas.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(54)))), ((int)(((byte)(102)))));
            this.cmbPortas.ListFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbPortas.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbPortas.Location = new System.Drawing.Point(29, 95);
            this.cmbPortas.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbPortas.Name = "cmbPortas";
            this.cmbPortas.Padding = new System.Windows.Forms.Padding(1);
            this.cmbPortas.Size = new System.Drawing.Size(200, 30);
            this.cmbPortas.TabIndex = 6;
            this.cmbPortas.Texts = "";
            // 
            // btnConetar
            // 
            this.btnConetar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(54)))), ((int)(((byte)(102)))));
            this.btnConetar.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(54)))), ((int)(((byte)(102)))));
            this.btnConetar.BorderColor = System.Drawing.Color.Silver;
            this.btnConetar.BorderRadius = 0;
            this.btnConetar.BorderSize = 1;
            this.btnConetar.FlatAppearance.BorderSize = 0;
            this.btnConetar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConetar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConetar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConetar.ForeColor = System.Drawing.Color.White;
            this.btnConetar.Location = new System.Drawing.Point(239, 95);
            this.btnConetar.Name = "btnConetar";
            this.btnConetar.Size = new System.Drawing.Size(109, 30);
            this.btnConetar.TabIndex = 7;
            this.btnConetar.Text = "Conectar";
            this.btnConetar.TextColor = System.Drawing.Color.White;
            this.btnConetar.UseVisualStyleBackColor = false;
            this.btnConetar.Click += new System.EventHandler(this.btnConetar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(369, 336);
            this.Controls.Add(this.btnConetar);
            this.Controls.Add(this.cmbPortas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnDesligar);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnLigar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlesPersonalizados.CMControles.CMButton btnLigar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private ControlesPersonalizados.CMControles.CMButton btnDesligar;
        private ControlesPersonalizados.CMControles.CMButton btnFechar;
        private System.IO.Ports.SerialPort PortaSerial;
        private System.Windows.Forms.Panel panel2;
        private ControlesPersonalizados.CMControles.CMComboBox cmbPortas;
        private ControlesPersonalizados.CMControles.CMButton btnConetar;
    }
}

