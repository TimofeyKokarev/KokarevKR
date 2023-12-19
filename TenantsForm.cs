using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kokarev_KR.DBModel;
using System.IO;

namespace Kokarev_KR
{
    public partial class TenantsForm : Form
    {
        public TenantsForm()
        {
            InitializeComponent();
        }

        ModelEF model = new ModelEF();

        private void TenantsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = model.Tenants.ToList();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainMenuAdminForms adminForm = new MainMenuAdminForms();
            adminForm.ShowDialog();
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            TenantsAdd tenantsAdd = new TenantsAdd();
            tenantsAdd.ShowDialog();
            dataGridView1.Refresh();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        { 
            if (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                model.SaveChanges();
                dataGridView1.Refresh();
                MessageBox.Show("Объект обновлен");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Tenants tenants = model.Tenants.Find(id);
                model.Tenants.Remove(tenants);
                model.SaveChanges();

                MessageBox.Show("Объект удален");
            }
        }
    }
}
