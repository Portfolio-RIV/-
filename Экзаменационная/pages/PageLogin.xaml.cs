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
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }


         private void BtnLogin_Click(object sender, RoutedEventArgs e)
         {
            int pass = psbPassword.Password.GetHashCode();
            User UserObject = BaseConnect.BaseModel.User.FirstOrDefault(u => u.Login == txbLogin.Text && u.Password == pass);
            if(txbLogin.Text=="" || psbPassword.Password == "")
            {
               MessageBox.Show("Заполните все поля");
            }
            else
            {
                if (UserObject == null)
                {
                    MessageBox.Show("Пользователя с таким логином и паролем нет");
                }
                else
                {
                    Global.UserID = UserObject.KeyUser;
                    switch (UserObject.KeyRole)
                    {
                        
                        case 1:
                            MessageBox.Show("Вы вошли без роли");
                            break;
                        case 2:
                           
                            MessageBox.Show("Вы вошли как администратор, ваш ID: " + " " + Global.UserID);
                            FrameLoad.FrameMain.Navigate(new PageAdminMenu());
                            break;
                        case 3:
                            MessageBox.Show("Вы вошли как пользователь, ваш ID: " + " " + Global.UserID);
                            FrameLoad.FrameMain.Navigate(new PageCalc());
                            break;
                        default:
                            MessageBox.Show("Системная ошибка");
                            break;
                    }
                }
            }
         }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            FrameLoad.FrameMain.Navigate(new PageCreate());
        }
    }
}
