namespace Arrays
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
            this.lista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // exec
            // 
            this.exec.Location = new System.Drawing.Point(555, 586);
            this.exec.Name = "exec";
            this.exec.Size = new System.Drawing.Size(171, 87);
            this.exec.TabIndex = 0;
            this.exec.Text = "Executar";
            this.exec.UseVisualStyleBackColor = true;
            this.exec.Click += new System.EventHandler(this.exec_Click);
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 20;
            this.lista.Location = new System.Drawing.Point(12, 16);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(503, 644);
            this.lista.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 699);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.exec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exec;
        private System.Windows.Forms.ListBox lista;
    }
}

