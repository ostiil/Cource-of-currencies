using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo.Forms
{
    public partial class AddCurrencyForm : Form
    {
        public AddCurrencyForm()
        {
            InitializeComponent();
        }

        private void AddCurrencyBtn_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            int favorites = 0;
            try
            {
                
                if (FavoritesCheckBox.Checked)
                {
                    favorites = 1;
                }
                userService.AddCurrency(NameCurrencyTb.Text, favorites);
                MessageBox.Show("Валюта добавлена");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
