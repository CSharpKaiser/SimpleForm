namespace SimpleForm
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
            this.bMyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bMyButton
            // 
            this.bMyButton.Location = new System.Drawing.Point(12, 12);
            this.bMyButton.Name = "bMyButton";
            this.bMyButton.Size = new System.Drawing.Size(243, 61);
            this.bMyButton.TabIndex = 0;
            this.bMyButton.Text = "My Button";
            this.bMyButton.UseVisualStyleBackColor = true;
            this.bMyButton.Click += new System.EventHandler(this.bMyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bMyButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bMyButton;
    }
}

