namespace LedPráctica
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
            this.btnOn = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOn
            // 
            this.btnOn.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnOn.Location = new System.Drawing.Point(118, 75);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(147, 50);
            this.btnOn.TabIndex = 0;
            this.btnOn.Text = "Turn on";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnOff
            // 
            this.btnOff.ForeColor = System.Drawing.Color.DeepPink;
            this.btnOff.Location = new System.Drawing.Point(118, 194);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(147, 50);
            this.btnOff.TabIndex = 1;
            this.btnOff.Text = "Turn off";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 329);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnOn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnOff;
    }
}

