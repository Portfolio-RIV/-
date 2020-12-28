using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Логика взаимодействия для PageRedUser.xaml
    /// </summary>
    public partial class PageRedUser : Page
    {
        List<User> LUser = BaseConnect.BaseModel.User.ToList();
        public PageRedUser()
        {
            InitializeComponent();
            dgUserList.ItemsSource = LUser;
        }

        private void btnSaveChanges_Click(object sender, RoutedEventArgs e)
        {
            List<User> LUserDB = BaseConnect.BaseModel.User.ToList();
            var LUser1 = LUserDB.Except(LUser);
            foreach (User u1 in LUser1)
            {
                BaseConnect.BaseModel.User.Remove(u1);
            }
            foreach (User u in LUser)
            {
                BaseConnect.BaseModel.User.AddOrUpdate(u);
            }
            BaseConnect.BaseModel.SaveChanges();
            MessageBox.Show("Изменения сохранены");
            FrameLoad.FrameMain.Navigate(new PageRedUser());
        }
    }
}
