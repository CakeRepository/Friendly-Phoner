namespace FriendlyPhoner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.fileToolStripMenuItemTwilioSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.callButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numberToCall = new System.Windows.Forms.TextBox();
            this.richPhoneNumberFrom = new System.Windows.Forms.RichTextBox();
            this.twilioLogging = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(775, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItemTwilioSettings,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // fileToolStripMenuItemTwilioSettings
            // 
            this.fileToolStripMenuItemTwilioSettings.Name = "fileToolStripMenuItemTwilioSettings";
            this.fileToolStripMenuItemTwilioSettings.Size = new System.Drawing.Size(150, 22);
            this.fileToolStripMenuItemTwilioSettings.Text = "Twilio Settings";
            this.fileToolStripMenuItemTwilioSettings.Click += new System.EventHandler(this.fileToolStripMenuItemTwilioSettings_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phone Number";
            // 
            // callButton
            // 
            this.callButton.Location = new System.Drawing.Point(13, 278);
            this.callButton.Name = "callButton";
            this.callButton.Size = new System.Drawing.Size(355, 60);
            this.callButton.TabIndex = 3;
            this.callButton.Text = "Call Button";
            this.callButton.UseVisualStyleBackColor = true;
            this.callButton.Click += new System.EventHandler(this.callButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number To Call";
            // 
            // numberToCall
            // 
            this.numberToCall.Location = new System.Drawing.Point(13, 252);
            this.numberToCall.Name = "numberToCall";
            this.numberToCall.Size = new System.Drawing.Size(286, 20);
            this.numberToCall.TabIndex = 4;
            // 
            // richPhoneNumberFrom
            // 
            this.richPhoneNumberFrom.Location = new System.Drawing.Point(13, 31);
            this.richPhoneNumberFrom.Name = "richPhoneNumberFrom";
            this.richPhoneNumberFrom.Size = new System.Drawing.Size(286, 215);
            this.richPhoneNumberFrom.TabIndex = 6;
            this.richPhoneNumberFrom.Text = "";
            this.richPhoneNumberFrom.TextChanged += new System.EventHandler(this.richPhoneNumberFrom_TextChanged);
            // 
            // twilioLogging
            // 
            this.twilioLogging.Location = new System.Drawing.Point(477, 31);
            this.twilioLogging.Name = "twilioLogging";
            this.twilioLogging.Size = new System.Drawing.Size(286, 307);
            this.twilioLogging.TabIndex = 7;
            this.twilioLogging.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 350);
            this.Controls.Add(this.twilioLogging);
            this.Controls.Add(this.richPhoneNumberFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberToCall);
            this.Controls.Add(this.callButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Friendly Phoner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItemTwilioSettings;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button callButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numberToCall;
        private System.Windows.Forms.RichTextBox richPhoneNumberFrom;
        private System.Windows.Forms.RichTextBox twilioLogging;
    }
}

