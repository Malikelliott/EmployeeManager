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

namespace Quiz3_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Employee> _employees;
        public MainWindow()
        {
            InitializeComponent();

            _employees = new List<Employee>()
            {
                new Employee (0, "Ted", "Quahog", "1234567890","Part-Time"),
                new Employee (1, "Todd", "Jackson", "0987654321","Full-Time"),
                new Employee (2, "Rob", "Milton", "1111111111","Internship"),
                new Employee (3, "John", "Lakewood", "1010101010","Part-Time"),
                new Employee (4, "Bill", "Compton", "2121216767","Internship"),
                new Employee (5, "Dan", "Toronto", "4164161986","Full-Time")
            };
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshListBox();
        }

        private void RefreshListBox()
        {
            var names = from emp in _employees
                        select emp.Name;

            lstEmployees.ItemsSource = names;
        }

        private void lstEmployees_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = lstEmployees.SelectedIndex;

            var selectedEmp = (from emp in _employees
                              where emp.Id == index
                              select emp).FirstOrDefault();

            if (selectedEmp != null)
            {
                txtName.Text = selectedEmp.Name;
                txtCity.Text = selectedEmp.City;
                txtPhone.Text = selectedEmp.Phone;
                cbx.Text = selectedEmp.EType;
            }
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Employee emp = new Employee (_employees.Count, txtName.Text, txtCity.Text, txtPhone.Text, cbx.Text);
            _employees.Add(emp);

            RefreshListBox();
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            int index = lstEmployees.SelectedIndex;
            Employee emp = _employees[index];
            emp.Name = txtName.Text;
            emp.City = txtCity.Text;
            emp.Phone = txtPhone.Text;
            emp.EType = cbx.Text;

            RefreshListBox();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            int index = lstEmployees.SelectedIndex;
            _employees.RemoveAt(index);

            for (int i = 0; i < _employees.Count; i++)
            {
                _employees[i].Id = i;
            }

            RefreshListBox();
        }

    }
}
