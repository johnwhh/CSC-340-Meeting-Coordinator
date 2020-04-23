using System;
using System.Windows.Forms;

namespace MeetingCoordinator
{
    public partial class ErrorView : UserControl
    {
        private MainForm parentForm;
        public ErrorView(MainForm parent)
        {
            parentForm = parent;
            InitializeComponent();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            parentForm.ToggleButtons(true);
            parentForm.Controls.Remove(this);
        }

        public void SetDescriptionText(string text)
        {
            DescriptionTextBox.Text = text;
        }
    }
}
