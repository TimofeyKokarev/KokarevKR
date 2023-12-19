using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kokarev_KR.DBModel;

namespace Kokarev_KR
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        public static Workers Enter_User;

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLogin.Text) ||
               string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            Enter_User = null;
            ModelEF model = new ModelEF();
            Enter_User = model.Workers.FirstOrDefault(x => x.Login == textBoxLogin.Text && x.Password == textBoxPassword.Text);
            if (Enter_User == null) MessageBox.Show("Пользователь не найден");
            else if (Enter_User != null)
            {
                switch (Enter_User.Role)
                {
                    case "Администратор":
                        MainMenuAdminForms formAdmin = new MainMenuAdminForms();
                        formAdmin.ShowDialog();
                        this.Close();
                        break;
                    case  "Менеджер А":
                        MainMenuManagerForm formManagerA = new MainMenuManagerForm();
                        formManagerA.ShowDialog();
                        this.Close();
                        break;
                    case "Менеджер С":
                        MainMenuManagerForm formManagerC = new MainMenuManagerForm();
                        formManagerC.ShowDialog();
                        this.Close();
                        break;
                    default:
                        MessageBox.Show("Пользователь удалён или роли не существует");
                        break;
                }
            }
        }
    }
}
