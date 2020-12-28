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
    /// Логика взаимодействия для PageAddUser.xaml
    /// </summary>
    public partial class PageAddUser : Page
    {
        public PageAddUser()
        {
            InitializeComponent();
            cmbSpisokRoley.ItemsSource = BaseConnect.BaseModel.RoleUser.ToList();
            cmbSpisokRoley.SelectedValuePath = "KeyRole";
            cmbSpisokRoley.DisplayMemberPath = "RoleName";
            cmbSpisokRoley.SelectedIndex = 2;
            /*lstKeysRole.ItemsSource = BaseConnect.BaseModel.RoleUser.ToList();
            lstKeysRole.SelectedValuePath = "KeyRole";
            lstKeysRole.DisplayMemberPath = "RoleName";*/
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            if (txbLogin.Text == "" || psbPassword.Password == "" )
            {
                MessageBox.Show("Заполоните все поля");
            }
            else
            {
                int pass = psbPassword.Password.GetHashCode();
                User UserObject1 = BaseConnect.BaseModel.User.FirstOrDefault(u => u.Login == txbLogin.Text);
                if (UserObject1 == null)
                {
                    User UserObject = new User()
                    {
                        Login = txbLogin.Text,
                        Password = pass,
                        KeyRole = cmbSpisokRoley.SelectedIndex + 1
                    };
                    BaseConnect.BaseModel.User.Add(UserObject);
                    BaseConnect.BaseModel.SaveChanges();
                    MessageBox.Show("Пользователь добавлен ");
                   
                    FrameLoad.FrameMain.Navigate(new PageAddUser());
                }
                else
                {
                    MessageBox.Show("Логин пользователя занят");
                }
            }
        }
    }
}
