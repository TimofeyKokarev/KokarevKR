using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kokarev_KR.DBModel;

namespace Kokarev_KR
{
    public partial class TenantsAdd : Form
    {
        public TenantsAdd()
        {
            InitializeComponent();
        }

        Tenants tenants = new Tenants();
        ModelEF model = new ModelEF();
        int id = 0;

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBoxPhone.Text) ||
                string.IsNullOrWhiteSpace(textBoxAdress.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            else
            {
                int max = 0;
                foreach (Tenants T in model.Tenants.ToList())
                {
                    if (max < T.ID) max = T.ID;
                    ++max;
                }
                tenants.ID = max;
                tenants.Name = textBoxName.Text;
                tenants.Phone = maskedTextBoxPhone.Text;
                tenants.Adress = textBoxAdress.Text;
                model.Tenants.Add(tenants);
                model.SaveChanges(); 
                MessageBox.Show("Новый объект добавлен");
                Close();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
