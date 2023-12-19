using Kokarev_KR.DBModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kokarev_KR
{
    public partial class MainMenuManagerForm : Form
    {
        public MainMenuManagerForm()
        {
            InitializeComponent();
        }

        private void MainMenuManagerForm_Load(object sender, EventArgs e)
        {
            ModelEF model = new ModelEF();
            labelManagerFIO.Text = AuthForm.Enter_User.First_Name + " " +
                                 AuthForm.Enter_User.Second_Name + " " +
                                 AuthForm.Enter_User.Middle_Name;
            labelRole.Text = AuthForm.Enter_User.Role;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.ShowDialog();
            this.Close();
        }

        private void buttonShowTC_Click(object sender, EventArgs e)
        {
            MallForm mallForm = new MallForm();
            mallForm.ShowDialog();
            this.Close();
        }
    }
}
