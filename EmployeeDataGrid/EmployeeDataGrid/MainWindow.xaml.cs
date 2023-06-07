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

namespace EmployeeDataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Create New Employee Record
            // Add new employee object and give it information
            Employee jackJones = new Employee();

            // Add details about "Jack Jones"
            jackJones.employeeID = "001";
            jackJones.employeeName = "Jack Jones";
            jackJones.employeeAddress = "175 Elm Street";
            jackJones.employeeCity = "York";
            jackJones.employeeCountry = "England";

            DataGridXAML.Items.Add(jackJones);

            Employee sallyMae = new Employee();

            sallyMae.employeeID = "002";
            sallyMae.employeeName = "Sally Mae";
            sallyMae.employeeAddress = "Jazz Town";
            sallyMae.employeeCity = "Tokyo";
            sallyMae.employeeCountry = "Japan";

            DataGridXAML.Items.Add(sallyMae);

        }

        public class Employee 
        {
            public string employeeID { get; set; }
            public string employeeName { get; set; }
            public string employeeAddress { get; set; }
            public string employeeCity { get; set; }
            public string employeeCountry { get; set; }
        }

        //Add NE Button Clicked
        private void ADDNEWEMPLOYEEBN_Clicked(object sender, RoutedEventArgs e)
        {
            Employee tempEmployee = new Employee();
            tempEmployee.employeeID = IDTB.Text;
            tempEmployee.employeeName = NameTB.Text;
            tempEmployee.employeeAddress = AddrTB.Text;
            tempEmployee.employeeCity = CityTB.Text;
            tempEmployee.employeeCountry = CountryTB.Text;

            DataGridXAML.Items.Add(tempEmployee);
            
        }
    }
}
