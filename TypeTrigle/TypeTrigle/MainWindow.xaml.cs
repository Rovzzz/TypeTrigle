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

namespace TypeTrigle
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int ab, bc, ca;
        public MainWindow()
        {
            InitializeComponent();

        }

        public void AB_TextChanged(object sender, TextChangedEventArgs e)
        {
            
           
        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                try
                {
                    ab = Convert.ToInt32(AB.Text);
                    bc = Convert.ToInt32(BC.Text);
                    ca = Convert.ToInt32(CA.Text);
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Проверьте введенные данные");
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Проверьте введенные данные");
            }
                if (ab <= 0 || bc <= 0 || ca <= 0 || ab + bc <= ca || ab + ca <= bc || bc + ca <= ab)
                {
                    MessageBox.Show("Треугольника с такими сторонами не существует!");
                }
                else if (ab == bc && ab == ca && bc == ca)
                {
                    MessageBox.Show("Треугольник равносторонний!");
                }
                else if (((ab * ab) == (bc * bc) + (ca * ca)) || ((bc * bc) == ((ab * ab) + (ca * ca)) || ((ca * ca) == (bc * bc) + (ab * ab))))
                {
                    MessageBox.Show("Треугольник прямоугольный!");
                }
                else if ((ab == bc && ab != ca) || (bc == ca && bc != ab) || (ab == ca && ab != bc))
                {
                    MessageBox.Show("Треугольник равнобедренный!");
                }
                else
                {
                    MessageBox.Show("Треугольник неравносторонний!");
                }
                AB.Clear();
                BC.Clear();
                CA.Clear();
            }

        public void BC_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        public void CA_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
