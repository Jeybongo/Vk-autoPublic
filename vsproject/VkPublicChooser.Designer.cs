namespace VkPoster
{
    partial class VkPublicChooser
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
            this.communitiesComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // communitiesComboBox
            // 
            this.communitiesComboBox.FormattingEnabled = true;
            this.communitiesComboBox.Location = new System.Drawing.Point(105, 31);
            this.communitiesComboBox.Name = "communitiesComboBox";
            this.communitiesComboBox.Size = new System.Drawing.Size(245, 33);
            this.communitiesComboBox.TabIndex = 0;
            // 
            // VkPublicChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 532);
            this.Controls.Add(this.communitiesComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VkPublicChooser";
            this.Text = "Выберите группу";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox communitiesComboBox;
    }
}