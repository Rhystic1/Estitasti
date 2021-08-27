namespace Estitasti
{
    partial class Estitasti
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
            this.estiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // estiButton
            // 
            this.estiButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.estiButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.estiButton.Image = global::Estitasti.Properties.Resources.hqdefault;
            this.estiButton.Location = new System.Drawing.Point(12, 12);
            this.estiButton.Name = "estiButton";
            this.estiButton.Size = new System.Drawing.Size(473, 350);
            this.estiButton.TabIndex = 1;
            this.estiButton.Text = "ESTI...";
            this.estiButton.UseVisualStyleBackColor = true;
            this.estiButton.Click += new System.EventHandler(this.estiButton_Click);
            // 
            // Estitasti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(494, 374);
            this.Controls.Add(this.estiButton);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(512, 421);
            this.MinimumSize = new System.Drawing.Size(512, 421);
            this.Name = "Estitasti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estitasti";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button estiButton;
    }
}

