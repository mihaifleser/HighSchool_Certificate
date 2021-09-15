namespace Atestat_Info
{
    partial class FormNume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNume));
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelTitlu = new System.Windows.Forms.Label();
            this.labelP1 = new System.Windows.Forms.Label();
            this.labelP2 = new System.Windows.Forms.Label();
            this.textBoxP1 = new System.Windows.Forms.TextBox();
            this.textBoxP2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.Silver;
            this.buttonOK.Font = new System.Drawing.Font("Harrington", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(272, 206);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(102, 32);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            this.buttonOK.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonOK_MouseDown);
            this.buttonOK.MouseEnter += new System.EventHandler(this.buttonOK_MouseEnter);
            this.buttonOK.MouseLeave += new System.EventHandler(this.buttonOK_MouseLeave);
            this.buttonOK.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonOK_MouseUp);
            // 
            // labelTitlu
            // 
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.BackColor = System.Drawing.Color.Silver;
            this.labelTitlu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTitlu.Font = new System.Drawing.Font("Harrington", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTitlu.Location = new System.Drawing.Point(96, 9);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(362, 31);
            this.labelTitlu.TabIndex = 1;
            this.labelTitlu.Text = "Introduceti numele jucatorilor";
            // 
            // labelP1
            // 
            this.labelP1.AutoSize = true;
            this.labelP1.BackColor = System.Drawing.Color.Silver;
            this.labelP1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelP1.Font = new System.Drawing.Font("Harrington", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelP1.Location = new System.Drawing.Point(41, 74);
            this.labelP1.Name = "labelP1";
            this.labelP1.Size = new System.Drawing.Size(94, 26);
            this.labelP1.TabIndex = 2;
            this.labelP1.Text = "Player 1:";
            // 
            // labelP2
            // 
            this.labelP2.AutoSize = true;
            this.labelP2.BackColor = System.Drawing.Color.Silver;
            this.labelP2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelP2.Font = new System.Drawing.Font("Harrington", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelP2.Location = new System.Drawing.Point(37, 131);
            this.labelP2.Name = "labelP2";
            this.labelP2.Size = new System.Drawing.Size(98, 26);
            this.labelP2.TabIndex = 3;
            this.labelP2.Text = "Player 2:";
            this.labelP2.Click += new System.EventHandler(this.labelP2_Click);
            // 
            // textBoxP1
            // 
            this.textBoxP1.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxP1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxP1.Location = new System.Drawing.Point(141, 75);
            this.textBoxP1.Name = "textBoxP1";
            this.textBoxP1.Size = new System.Drawing.Size(183, 26);
            this.textBoxP1.TabIndex = 4;
            this.textBoxP1.TextChanged += new System.EventHandler(this.textBoxP1_TextChanged);
            this.textBoxP1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxP1_KeyDown);
            // 
            // textBoxP2
            // 
            this.textBoxP2.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxP2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxP2.Location = new System.Drawing.Point(141, 132);
            this.textBoxP2.Name = "textBoxP2";
            this.textBoxP2.Size = new System.Drawing.Size(183, 26);
            this.textBoxP2.TabIndex = 5;
            this.textBoxP2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxP2_KeyDown);
            // 
            // FormNume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(628, 261);
            this.Controls.Add(this.textBoxP2);
            this.Controls.Add(this.textBoxP1);
            this.Controls.Add(this.labelP2);
            this.Controls.Add(this.labelP1);
            this.Controls.Add(this.labelTitlu);
            this.Controls.Add(this.buttonOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNume";
            this.Text = "Player Names";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.Label labelP1;
        private System.Windows.Forms.Label labelP2;
        private System.Windows.Forms.TextBox textBoxP1;
        private System.Windows.Forms.TextBox textBoxP2;
    }
}