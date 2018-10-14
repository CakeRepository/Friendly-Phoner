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
using System.Timers;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.TwiML;
using Twilio.Types;

namespace FriendlyPhoner
{
    public partial class Form1 : Form
    {
        private static System.Timers.Timer aTimer;
        List<string> currentList;
        public Form1()
        {
            InitializeComponent();
            currentList = new List<string>();
        }

        private void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(30000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += GetCallLogsTimesEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private void GetCallLogsTimesEvent(object sender, ElapsedEventArgs e)
        {
            var calls = CallResource.Read();
            List<string> tmpList = new List<string>();
            foreach (var record in calls)
            {
                tmpList.Add(record.To.ToString() + " " + record.Status + " " + record.EndTime);
            }
            if(!tmpList.All(currentList.Contains))
            {
                currentList = tmpList;
                foreach(var item in currentList)
                {
                    twilioLogging.Invoke((MethodInvoker)delegate {
                        // Running on the UI thread
                        twilioLogging.Text += item + Environment.NewLine;
                    });
                }
            }
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
            
            if(AuthSettings.Default.AccountSID == "" || AuthSettings.Default.AuthToken == "")
            {
                TwilioSettings ts = new TwilioSettings();
                ts.Show();
            }
            string accountSid = AuthSettings.Default.AccountSID;
            string authToken = AuthSettings.Default.AuthToken;
            TwilioClient.Init(accountSid, authToken);

            SetTimer();
        }

        private void callButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < richPhoneNumberFrom.Lines.Count();i++)
            {
                var fromCall = richPhoneNumberFrom.Lines[i];
                var toCall = numberToCall.Text;
                Task.Run(() =>
                {
                    loopcaller(fromCall, toCall);
                });
            }
        }

        async Task loopcaller(string fromCall, string toCall)
        {
            string accountSid = AuthSettings.Default.AccountSID;
            string authToken = AuthSettings.Default.AuthToken;
            

            for (int i = 0; i <= 1000; i++)
            {

                var call = CallResource.Create(
                record: true,
                url: new Uri("http://demo.twilio.com/docs/voice.xml"),
                from: new Twilio.Types.PhoneNumber(fromCall),
                to: new Twilio.Types.PhoneNumber(toCall)
                
            );

                Console.WriteLine(call.Sid);
                Thread.Sleep(60000);
            }
        }

        private void richPhoneNumberFrom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
