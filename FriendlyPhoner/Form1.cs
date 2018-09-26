using FriendlyPhoner.lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace FriendlyPhoner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fileToolStripMenuItemTwilioSettings_Click(object sender, EventArgs e)
        {
            TwilioSettings ts = new TwilioSettings();
            ts.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void callButton_Click(object sender, EventArgs e)
        {
            string accountSid = AuthSettings.Default.AccountSID;
            string authToken = AuthSettings.Default.AuthToken;
            TwilioClient.Init(accountSid, authToken);

            var call = CallResource.Create(
            url: new Uri("http://demo.twilio.com/docs/voice.xml"),
            to: new Twilio.Types.PhoneNumber(numberToCall.Text),
            from: new Twilio.Types.PhoneNumber(phoneNumberTextBox.Text)
        );

            Console.WriteLine(call.Sid);
        }
    }
}
