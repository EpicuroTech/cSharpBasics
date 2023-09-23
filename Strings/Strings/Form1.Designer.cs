namespace Strings
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
            this.exec = new System.Windows.Forms.Button();
            this.cx_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exec
            // 
            this.exec.Location = new System.Drawing.Point(656, 350);
            this.exec.Name = "exec";
            this.exec.Size = new System.Drawing.Size(111, 62);
            this.exec.TabIndex = 0;
            this.exec.Text = "EXECUTAR";
            this.exec.UseVisualStyleBackColor = true;
            this.exec.Click += new System.EventHandler(this.exec_Click);
            // 
            // cx_txt
            // 
            this.cx_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cx_txt.Location = new System.Drawing.Point(12, 18);
            this.cx_txt.Name = "cx_txt";
            this.cx_txt.Size = new System.Drawing.Size(767, 166);
            this.cx_txt.TabIndex = 1;
            this.cx_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cx_txt);
            this.Controls.Add(this.exec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exec;
        private System.Windows.Forms.Label cx_txt;
    }
}

