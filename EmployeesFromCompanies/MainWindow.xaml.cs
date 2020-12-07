using System.Data.Common;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Windows;


namespace EmployeesFromCompanies
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AppContext db;
        string selectedCompany;
        public MainWindow()
        {
            InitializeComponent();
            db = new AppContext();
            db.Employees.Load();
            UpdateCompanies();
        }
       private void Add_Click(object sender, RoutedEventArgs e)
        {
            EmployeeWindow employeeWindow = new EmployeeWindow(new Employee());
            if (employeeWindow.ShowDialog() == true)
            {
                Employee employee = employeeWindow.Employee;
                db.Employees.Add(employee);
                db.SaveChanges();
            }
            UpdateCompanies();
            if (!(selectedCompany is null))
            {
                this.DataContext = db.Employees.Local.ToBindingList().Where(em => em.WorkPlace == selectedCompany);
                Companies.SelectedValue = selectedCompany;
            }
        }
        public void UpdateCompanies()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=employees.db");
            SQLiteCommand command = new SQLiteCommand("select distinct WorkPlace from Employees", conn);
            conn.Open();
            Companies.Items.Clear();
            DbDataReader reader = command.ExecuteReader();
            while (reader.Read())
                Companies.Items.Add((string)reader["WorkPlace"]);
            conn.Close();    
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (employeesList.SelectedItem == null) return;           
            Employee employee = employeesList.SelectedItem as Employee;
            EmployeeWindow employeeWindow = new EmployeeWindow(new Employee
            {
                Id = employee.Id,
                FullName = employee.FullName,
                Address = employee.Address,
                PhoneNumber = employee.PhoneNumber,
                Position = employee.Position,
                WorkPlace = employee.WorkPlace
            });
            if (employeeWindow.ShowDialog() == true)
            {   
                employee = db.Employees.Find(employeeWindow.Employee.Id);
                if (employee != null)
                {
                    employee.FullName = employeeWindow.Employee.FullName;
                    employee.Address = employeeWindow.Employee.Address;
                    employee.PhoneNumber = employeeWindow.Employee.PhoneNumber;
                    employee.Position = employeeWindow.Employee.Position;
                    employee.WorkPlace = employeeWindow.Employee.WorkPlace;
                    db.Entry(employee).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            UpdateCompanies();   
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = db.Employees.Local.ToBindingList().Where(emp => emp.WorkPlace == selectedCompany);
            if (employeesList.SelectedItem == null) return;
            Employee employee = employeesList.SelectedItem as Employee;
            db.Employees.Remove(employee);
            this.DataContext = db.Employees.Local.ToBindingList().Where(em => em.WorkPlace == selectedCompany);
            db.SaveChanges();
            UpdateCompanies();
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            
            if (Companies.SelectedValue is null)
            {
                MessageBox.Show("Please, choose the company!");
            }
            else
            {
                db = new AppContext();
                db.Employees.Load();
                selectedCompany = Companies.SelectedValue.ToString();
                this.DataContext = db.Employees.Local.ToBindingList().Where(employee => employee.WorkPlace == selectedCompany);
            }
        }

        private void ClearCompanies_Click(object sender, RoutedEventArgs e)
        {
            listComanies.Items.Clear();
        }

        private void LoadCompanies_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=employees.db");
            SQLiteCommand command = new SQLiteCommand("select distinct WorkPlace from Employees", conn);
            conn.Open();
            DbDataReader reader = command.ExecuteReader();
            while (reader.Read())
                listComanies.Items.Add((string)reader["WorkPlace"]);
            conn.Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
               System.Windows.Application.Current.Shutdown(); 
        }

    }
}
