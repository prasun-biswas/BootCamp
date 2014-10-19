namespace VarsityAdmission
{
    partial class MainUI
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
            this.enrollButton = new System.Windows.Forms.Button();
            this.enterResultButton = new System.Windows.Forms.Button();
            this.showResultSheetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enrollButton
            // 
            this.enrollButton.Location = new System.Drawing.Point(23, 56);
            this.enrollButton.Name = "enrollButton";
            this.enrollButton.Size = new System.Drawing.Size(177, 60);
            this.enrollButton.TabIndex = 0;
            this.enrollButton.Text = "ENROLL";
            this.enrollButton.UseVisualStyleBackColor = true;
            this.enrollButton.Click += new System.EventHandler(this.enrollButton_Click);
            // 
            // enterResultButton
            // 
            this.enterResultButton.Location = new System.Drawing.Point(23, 134);
            this.enterResultButton.Name = "enterResultButton";
            this.enterResultButton.Size = new System.Drawing.Size(177, 64);
            this.enterResultButton.TabIndex = 1;
            this.enterResultButton.Text = "Enter Result";
            this.enterResultButton.UseVisualStyleBackColor = true;
            this.enterResultButton.Click += new System.EventHandler(this.enterResultButton_Click);
            // 
            // showResultSheetButton
            // 
            this.showResultSheetButton.Location = new System.Drawing.Point(23, 216);
            this.showResultSheetButton.Name = "showResultSheetButton";
            this.showResultSheetButton.Size = new System.Drawing.Size(177, 71);
            this.showResultSheetButton.TabIndex = 2;
            this.showResultSheetButton.Text = "Show Result Sheet";
            this.showResultSheetButton.UseVisualStyleBackColor = true;
            this.showResultSheetButton.Click += new System.EventHandler(this.showResultSheetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Your Task";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showResultSheetButton);
            this.Controls.Add(this.enterResultButton);
            this.Controls.Add(this.enrollButton);
            this.Name = "MainUI";
            this.Text = "MainUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enrollButton;
        private System.Windows.Forms.Button enterResultButton;
        private System.Windows.Forms.Button showResultSheetButton;
        private System.Windows.Forms.Label label1;
    }
}

