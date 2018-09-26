using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FriendlyPhoner.lib
{
    public partial class TwilioSettings : Form
    {
        public TwilioSettings()
        {
            InitializeComponent();
            loadKeys();
        }

        private void loadKeys()
        {
            accountSIDTextBox.Text = AuthSettings.Default.AccountSID;
            authTokenTextbox.Text = AuthSettings.Default.AuthToken;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            AuthSettings.Default.AccountSID = accountSIDTextBox.Text;
            AuthSettings.Default.AuthToken = authTokenTextbox.Text;
            AuthSettings.Default.Save();
            this.Close();
        }
    }
}
