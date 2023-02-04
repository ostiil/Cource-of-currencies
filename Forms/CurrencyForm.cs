using demo.Contexts;
using demo.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class CurrencyForm : Form
    {

        public CurrencyForm()
        {
            InitializeComponent();
            
        }

        private void AddCurrencyBtn_Click(object sender, EventArgs e)
        {
            AddCurrencyForm currencyForm = new AddCurrencyForm();
            currencyForm.Show();
        }

        private void CurrencyForm_Activated(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            dataGridView1.DataSource = userService.GetCurrency();
        }

        private void EditCurrencyBtn_Click(object sender, EventArgs e)
        {
            /*AddCurrencyForm currencyForm = new AddCurrencyForm();
            currencyForm.Show();
            var name = dataGridView1.CurrentRow.Cells[1].Value;
            var favorites = dataGridView1.CurrentRow.Cells[2].Value;
            currencyForm.NameCurrencyTb.Text = name.ToString();
            
            if ((int)favorites == 1)
                currencyForm.FavoritesCheckBox.Checked = true;
            else
                currencyForm.FavoritesCheckBox.Checked = false;*/
        }

        private void RemoveCurrencyBtn_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            
            int idRemove = (int)dataGridView1.CurrentRow.Cells[0].Value;
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить эту валюту?", "Предупреждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {    
                userService.RemoveCurrency(idRemove);
                dataGridView1.DataSource = userService.GetCurrency();
            }
            else { return; }
            
        }
    }
}
