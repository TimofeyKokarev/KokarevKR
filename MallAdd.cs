using Kokarev_KR.DBModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kokarev_KR
{
    public partial class MallAdd : Form
    {
        public MallAdd()
        {
            InitializeComponent();
        }

        Mall mall = new Mall();
        ModelEF model = new ModelEF();
        int id = 0;

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string Pic_Name;

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxStatus.Text) ||
                string.IsNullOrWhiteSpace(textBoxAmount.Text)||
                string.IsNullOrWhiteSpace(textBoxTown.Text) ||
                string.IsNullOrWhiteSpace(textBoxCost.Text) ||
                string.IsNullOrWhiteSpace(textBoxCoeff.Text) ||
                string.IsNullOrWhiteSpace(textBoxFloor.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            else
            {
                int max = 0;
                foreach (Mall M in model.Mall.ToList())
                {
                    if (max < M.ID) max = M.ID;
                    ++max;
                }
                mall.ID = max;
                mall.Name = textBoxName.Text;
                mall.Status = textBoxStatus.Text;
                mall.Amount_P = Convert.ToInt32(textBoxAmount.Text);
                mall.Town = textBoxTown.Text;
                mall.Cost = Convert.ToDecimal(textBoxCost.Text);
                mall.Coeff_cost = Convert.ToDouble(textBoxCoeff.Text);
                mall.Floor = Convert.ToInt32(textBoxFloor.Text);
                model.Mall.Add(mall);
                model.SaveChanges();
                Close();
            }
        }

        private int GetID()
        {
            int max = 0;
            foreach (Mall M in model.Mall.ToList())
                if (max < M.ID) max = M.ID;
             return ++max;
        }
    }
}
