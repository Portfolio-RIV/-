using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Экзаменационная.pages
{
    /// <summary>
    /// Логика взаимодействия для PageCreate.xaml
    /// </summary>
    public partial class PageCreate : Page
    {
        public PageCreate()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (txbLogin.Text == "" || psbPassword.Password == "" || psbPassword2.Password == "")
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                if (psbPassword.Password == psbPassword2.Password)
                {
                    int pass = psbPassword.Password.GetHashCode();
                    User UserObject1 = BaseConnect.BaseModel.User.FirstOrDefault(u => u.Login == txbLogin.Text);
                    if (UserObject1 == null)
                    {
                        User UserObject = new User()
                        {
                            Login = txbLogin.Text,
                            Password = pass,
                            KeyRole = Global.KeyRoleNewUser,
                        };
                        BaseConnect.BaseModel.User.Add(UserObject);
                        BaseConnect.BaseModel.SaveChanges();
                        MessageBox.Show("Вы успешно зарегистрировались");
                        MessageBox.Show("Ваш логин: " + UserObject.Login + ", ваш пароль: " + psbPassword.Password);
                    }
                    else
                    {
                        MessageBox.Show("Логин пользователя занят");
                    }
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают");
                }
            }
        }
    }
}
