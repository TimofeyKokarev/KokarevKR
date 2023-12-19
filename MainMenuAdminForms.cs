using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kokarev_KR.DBModel;

namespace Kokarev_KR
{
    public partial class MainMenuAdminForms : Form
    {
        public MainMenuAdminForms()
        {
            InitializeComponent();
        }

        private void MainMenuAdminForms_Load(object sender, EventArgs e)
        {
            ModelEF model = new ModelEF();
            labelAdminFIO.Text = AuthForm.Enter_User.First_Name + " " + 
                                 AuthForm.Enter_User.Second_Name + " " + 
                                 AuthForm.Enter_User.Middle_Name;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.ShowDialog();
            this.Close();
        }

        private void buttonShowArendators_Click(object sender, EventArgs e)
        {
            TenantsForm tenantsForm = new TenantsForm();
            tenantsForm.ShowDialog();
            this.Close();
        }
    }
}
