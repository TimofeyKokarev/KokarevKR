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
    public partial class MallForm : Form
    {
        public MallForm()
        {
            InitializeComponent();
        }

        ModelEF model = new ModelEF();

        private void MallForm_Load(object sender, EventArgs e)
        {
            ModelEF model = new ModelEF();
            dataGridView1.DataSource = model.Mall.ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MallAdd mallAdd = new MallAdd();
            mallAdd.ShowDialog();
            dataGridView1.Refresh();
            MessageBox.Show("Новый объект добавлен");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainMenuManagerForm managerForm = new MainMenuManagerForm();
            managerForm.ShowDialog();
            this.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Mall mall = model.Mall.Find(id);

                MallForm plForm = new MallForm();

                DialogResult result = plForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;
                model.SaveChanges();
                dataGridView1.Refresh(); // обновляем грид
                MessageBox.Show("Объект обновлен");
            }
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

                Mall mall = model.Mall.Find(id);
                model.Mall.Remove(mall);
                model.SaveChanges();
                MessageBox.Show("Объект удален");
            }
        }
    }
}
