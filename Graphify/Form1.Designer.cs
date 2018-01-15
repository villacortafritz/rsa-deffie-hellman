namespace Graphify
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SideBar = new System.Windows.Forms.Panel();
            this.btnPlayfair = new System.Windows.Forms.Button();
            this.btnCeasar = new System.Windows.Forms.Button();
            this.panelArea = new System.Windows.Forms.Panel();
            this.ceasar1 = new Graphify.ceasar();
            this.playfair1 = new Graphify.playfair();
            this.panel1.SuspendLayout();
            this.panelArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.SideBar);
            this.panel1.Controls.Add(this.btnPlayfair);
            this.panel1.Controls.Add(this.btnCeasar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 550);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.Maroon;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(475, 5);
            this.SideBar.TabIndex = 3;
            // 
            // btnPlayfair
            // 
            this.btnPlayfair.FlatAppearance.BorderSize = 0;
            this.btnPlayfair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayfair.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayfair.ForeColor = System.Drawing.Color.White;
            this.btnPlayfair.Location = new System.Drawing.Point(476, 5);
            this.btnPlayfair.Name = "btnPlayfair";
            this.btnPlayfair.Size = new System.Drawing.Size(474, 50);
            this.btnPlayfair.TabIndex = 4;
            this.btnPlayfair.Text = "Rivest-Shamir-Adleman";
            this.btnPlayfair.UseVisualStyleBackColor = true;
            this.btnPlayfair.Click += new System.EventHandler(this.btnPlayfair_Click);
            // 
            // btnCeasar
            // 
            this.btnCeasar.FlatAppearance.BorderSize = 0;
            this.btnCeasar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCeasar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCeasar.ForeColor = System.Drawing.Color.White;
            this.btnCeasar.Location = new System.Drawing.Point(0, 5);
            this.btnCeasar.Name = "btnCeasar";
            this.btnCeasar.Size = new System.Drawing.Size(475, 50);
            this.btnCeasar.TabIndex = 3;
            this.btnCeasar.Text = "Diffie-Hellman ";
            this.btnCeasar.UseVisualStyleBackColor = true;
            this.btnCeasar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelArea
            // 
            this.panelArea.Controls.Add(this.ceasar1);
            this.panelArea.Controls.Add(this.playfair1);
            this.panelArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelArea.Location = new System.Drawing.Point(0, 60);
            this.panelArea.Name = "panelArea";
            this.panelArea.Size = new System.Drawing.Size(950, 490);
            this.panelArea.TabIndex = 7;
            this.panelArea.Paint += new System.Windows.Forms.PaintEventHandler(this.panelArea_Paint);
            // 
            // ceasar1
            // 
            this.ceasar1.Location = new System.Drawing.Point(0, 0);
            this.ceasar1.Name = "ceasar1";
            this.ceasar1.Size = new System.Drawing.Size(750, 550);
            this.ceasar1.TabIndex = 1;
            // 
            // playfair1
            // 
            this.playfair1.Location = new System.Drawing.Point(0, 0);
            this.playfair1.Name = "playfair1";
            this.playfair1.Size = new System.Drawing.Size(750, 550);
            this.playfair1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.panelArea);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCeasar;
        private System.Windows.Forms.Button btnPlayfair;
        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel panelArea;
        private ceasar ceasar1;
        private playfair playfair1;
    }
}

