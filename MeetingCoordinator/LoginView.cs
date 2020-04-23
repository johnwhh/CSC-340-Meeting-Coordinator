using System;
using System.Windows.Forms;

namespace MeetingCoordinator
{
    public partial class LoginView : UserControl
    {
        private MainForm parentForm;
        public LoginView(MainForm parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginManager loginManager = new LoginManager();
            User user = loginManager.GetUser(UsernameTextBox.Text);

            if(user == null)
            {
                ErrorLabel.Visible = true;
            } else
            {
                parentForm.SetCurrentUser(user);
                parentForm.Controls.Remove(this);
            }
        }
    }
}
