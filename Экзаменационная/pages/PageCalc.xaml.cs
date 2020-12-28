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
    /// Логика взаимодействия для PageCalc.xaml
    /// </summary>
    public partial class PageCalc : Page
    {
        public PageCalc()
        {
            InitializeComponent();
            cmbSistemaSchisleniya.Items.Add("Двоичная");
            cmbSistemaSchisleniya.Items.Add("Десятичная");
            cmbSistemaSchisleniya.Items.Add("16-ричная");
            cmbSistemaSchisleniya.SelectedIndex = 0;
            cmbOperation.Items.Add("MOV");
            cmbOperation.Items.Add("ADD");
            cmbOperation.Items.Add("SUB");
            cmbOperation.Items.Add("MUL");
            cmbOperation.Items.Add("DIV");
            cmbRegistrIstochnik.Items.Add("R0");
            cmbRegistrIstochnik.Items.Add("R1");
            cmbRegistrIstochnik.Items.Add("R2");
            cmbRegistrIstochnik.Items.Add("R3");
            cmbRegistrPriemnik.Items.Add("R0");
            cmbRegistrPriemnik.Items.Add("R1");
            cmbRegistrPriemnik.Items.Add("R2");
            cmbRegistrPriemnik.Items.Add("R3");
        }
    }
}
