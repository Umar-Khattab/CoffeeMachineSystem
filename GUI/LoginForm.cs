using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeMachineSystem.GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            bool Condition = Admin.Validate(idTxtBx.Text, passTxtbx.Text);
            if (Condition)
            {
                new GUI.AdminForm().Show();
                this.Hide();
            }
        }

        private void SwitchIcon_Click(object sender, EventArgs e)
        {
            new GUI.UserForm().Show();
            this.Hide();
        }
    }
}
