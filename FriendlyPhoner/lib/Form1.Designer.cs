namespace FriendlyPhoner.lib
{
    partial class TwilioSettings
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
            this.saveButton = new System.Windows.Forms.Button();
            this.accountSIDTextBox = new System.Windows.Forms.TextBox();
            this.authTokenTextbox = new System.Windows.Forms.TextBox();
            this.AuthLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(140, 124);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(129, 45);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // accountSIDTextBox
            // 
            this.accountSIDTextBox.Location = new System.Drawing.Point(84, 34);
            this.accountSIDTextBox.Name = "accountSIDTextBox";
            this.accountSIDTextBox.Size = new System.Drawing.Size(347, 20);
            this.accountSIDTextBox.TabIndex = 1;
            // 
            // authTokenTextbox
            // 
            this.authTokenTextbox.Location = new System.Drawing.Point(84, 84);
            this.authTokenTextbox.Name = "authTokenTextbox";
            this.authTokenTextbox.Size = new System.Drawing.Size(347, 20);
            this.authTokenTextbox.TabIndex = 2;
            // 
            // AuthLabel
            // 
            this.AuthLabel.AutoSize = true;
            this.AuthLabel.Location = new System.Drawing.Point(12, 87);
            this.AuthLabel.Name = "AuthLabel";
            this.AuthLabel.Size = new System.Drawing.Size(66, 13);
            this.AuthLabel.TabIndex = 3;
            this.AuthLabel.Text = "Auth. Token";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Account SID";
            // 
            // TwilioSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 181);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AuthLabel);
            this.Controls.Add(this.authTokenTextbox);
            this.Controls.Add(this.accountSIDTextBox);
            this.Controls.Add(this.saveButton);
            this.Name = "TwilioSettings";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox accountSIDTextBox;
        private System.Windows.Forms.TextBox authTokenTextbox;
        private System.Windows.Forms.Label AuthLabel;
        private System.Windows.Forms.Label label2;
    }
}