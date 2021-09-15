namespace Atestat_Info
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            this.buttonOK = new System.Windows.Forms.Button();
            this.richTextBoxHelp = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonOK.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.ForeColor = System.Drawing.Color.Turquoise;
            this.buttonOK.Location = new System.Drawing.Point(297, 280);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(126, 29);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            this.buttonOK.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonOK_MouseDown);
            this.buttonOK.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonOK_MouseUp);
            // 
            // richTextBoxHelp
            // 
            this.richTextBoxHelp.BackColor = System.Drawing.Color.Teal;
            this.richTextBoxHelp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxHelp.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBoxHelp.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxHelp.ForeColor = System.Drawing.Color.Turquoise;
            this.richTextBoxHelp.Location = new System.Drawing.Point(12, 29);
            this.richTextBoxHelp.Name = "richTextBoxHelp";
            this.richTextBoxHelp.ReadOnly = true;
            this.richTextBoxHelp.Size = new System.Drawing.Size(698, 245);
            this.richTextBoxHelp.TabIndex = 1;
            this.richTextBoxHelp.Text = resources.GetString("richTextBoxHelp.Text");
            this.richTextBoxHelp.TextChanged += new System.EventHandler(this.richTextBoxHelp_TextChanged);
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(712, 321);
            this.Controls.Add(this.richTextBoxHelp);
            this.Controls.Add(this.buttonOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHelp";
            this.Text = "Help";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.RichTextBox richTextBoxHelp;
    }
}