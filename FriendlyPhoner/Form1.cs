using FriendlyPhoner.lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.TwiML;
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
            callLoopLoopverAsync();
        }

        private async Task callLoopLoopverAsync()
        {
            await loopcaller();
        }

         

        async Task loopcaller()
        {
            string accountSid = AuthSettings.Default.AccountSID;
            string authToken = AuthSettings.Default.AuthToken;
            TwilioClient.Init(accountSid, authToken);

            for (int i = 1000; i <= 1000; i++)
            {
                
                var call = CallResource.Create(
                record: true,
                url: new Uri("https://drive.google.com/file/d/1kIH81J_4cSq-xS5rio1l8sXdvvooNhii/view?usp=sharing"),
                to: new Twilio.Types.PhoneNumber(numberToCall.Text),
                from: new Twilio.Types.PhoneNumber(phoneNumberTextBox.Text)
            );

                Console.WriteLine(call.Sid);
                Thread.Sleep(30000);
            }
        }
   
    }
}
