namespace VkPoster
{
    partial class MainForm
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
            this.nextPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.postButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.regularIntervalBox = new System.Windows.Forms.NumericUpDown();
            this.regularCheckBox = new System.Windows.Forms.CheckBox();
            this.randomCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.commLabel = new System.Windows.Forms.Label();
            this.folderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nextPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regularIntervalBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nextPictureBox
            // 
            this.nextPictureBox.Location = new System.Drawing.Point(422, 58);
            this.nextPictureBox.Name = "nextPictureBox";
            this.nextPictureBox.Size = new System.Drawing.Size(400, 400);
            this.nextPictureBox.TabIndex = 0;
            this.nextPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Следующее фото:";
            // 
            // postButton
            // 
            this.postButton.Location = new System.Drawing.Point(422, 464);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(400, 69);
            this.postButton.TabIndex = 2;
            this.postButton.Text = "Запостить сейчас";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Период постинга:";
            // 
            // regularIntervalBox
            // 
            this.regularIntervalBox.Location = new System.Drawing.Point(231, 191);
            this.regularIntervalBox.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.regularIntervalBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.regularIntervalBox.Name = "regularIntervalBox";
            this.regularIntervalBox.Size = new System.Drawing.Size(91, 31);
            this.regularIntervalBox.TabIndex = 5;
            this.regularIntervalBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // regularCheckBox
            // 
            this.regularCheckBox.AutoSize = true;
            this.regularCheckBox.Checked = true;
            this.regularCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.regularCheckBox.Location = new System.Drawing.Point(27, 193);
            this.regularCheckBox.Name = "regularCheckBox";
            this.regularCheckBox.Size = new System.Drawing.Size(198, 29);
            this.regularCheckBox.TabIndex = 6;
            this.regularCheckBox.Text = "с интервалом в";
            this.regularCheckBox.UseVisualStyleBackColor = true;
            this.regularCheckBox.CheckedChanged += new System.EventHandler(this.regularCheckBox_CheckedChanged);
            // 
            // randomCheckBox
            // 
            this.randomCheckBox.AutoSize = true;
            this.randomCheckBox.Location = new System.Drawing.Point(27, 228);
            this.randomCheckBox.Name = "randomCheckBox";
            this.randomCheckBox.Size = new System.Drawing.Size(233, 29);
            this.randomCheckBox.TabIndex = 7;
            this.randomCheckBox.Text = "в случайное время";
            this.randomCheckBox.UseVisualStyleBackColor = true;
            this.randomCheckBox.CheckedChanged += new System.EventHandler(this.randomCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "ч.";
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(27, 281);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(296, 69);
            this.applyButton.TabIndex = 9;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // commLabel
            // 
            this.commLabel.AutoSize = true;
            this.commLabel.Location = new System.Drawing.Point(22, 464);
            this.commLabel.Name = "commLabel";
            this.commLabel.Size = new System.Drawing.Size(82, 25);
            this.commLabel.TabIndex = 10;
            this.commLabel.Text = "vk path";
            this.commLabel.Click += new System.EventHandler(this.commLabel_Click);
            // 
            // folderLabel
            // 
            this.folderLabel.AutoSize = true;
            this.folderLabel.Location = new System.Drawing.Point(22, 508);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(114, 25);
            this.folderLabel.TabIndex = 11;
            this.folderLabel.Text = "folder path";
            this.folderLabel.Click += new System.EventHandler(this.folderLabel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(852, 560);
            this.Controls.Add(this.folderLabel);
            this.Controls.Add(this.commLabel);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.randomCheckBox);
            this.Controls.Add(this.regularCheckBox);
            this.Controls.Add(this.regularIntervalBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nextPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фото постер";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.nextPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regularIntervalBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox nextPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown regularIntervalBox;
        private System.Windows.Forms.CheckBox regularCheckBox;
        private System.Windows.Forms.CheckBox randomCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label commLabel;
        private System.Windows.Forms.Label folderLabel;
    }
}

