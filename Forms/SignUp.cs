using System.Windows.Forms;

namespace demo
{
    public partial class SignUp : Form
    {
        //private UserService userService;
        public SignUp()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                UserService userService = new UserService();
                userService.RegisterUser(fioTextBox.Text, logintextBox.Text, passwordTextBox.Text);
                MessageBox.Show("Пользователь зарегистрирован");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    } 
}