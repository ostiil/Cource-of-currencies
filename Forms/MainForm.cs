using demo.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SignUp sign_In = new SignUp();
            sign_In.Show();
            Hide();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            try
            {
                userService.AuthorizeUser(loginTextBox.Text, passwordTextBox.Text);
                CurrencyForm currencyForm = new CurrencyForm();
                currencyForm.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
