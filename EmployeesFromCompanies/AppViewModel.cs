using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;

namespace EmployeesFromCompanies
{
    public class AppViewModel
    {
        MainWindow Form = Application.Current.Windows[0] as MainWindow;
        AppContext db;
        RelayCommand addCommand;
        RelayCommand editCommand;
        RelayCommand deleteCommand;
        RelayCommand loadCommand;
        RelayCommand exitCommand;
        RelayCommand loadCompaniesCommand;
        RelayCommand clearCompaniesCommand;
        IEnumerable<Employee> employees;

        public IEnumerable<Employee> Employees
        {
            get { return employees; }
            set
            {
                employees = value;
                OnPropertyChanged("Employees");
            }
        }

        public AppViewModel()
        {
            db = new AppContext();
            db.Employees.Load();
            UpdateCompanies();
            Employees = db.Employees.Local.ToBindingList();
        }

        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand((o) =>
                  {
                      EmployeeWindow employeeWindow = new EmployeeWindow(new Employee());
                      if (employeeWindow.ShowDialog() == true)
                      {
                          Employee employee = employeeWindow.Employee;
                          db.Employees.Add(employee);
                          db.SaveChanges();
                      }
                  }));
            }
        }
        public void UpdateCompanies()
        {
            db = new AppContext();
            db.Employees.Load();
            SQLiteConnection conn = new SQLiteConnection("Data Source=employees.db");
            SQLiteCommand command = new SQLiteCommand("select distinct WorkPlace from Employees", conn);
            conn.Open();
            Form.Companies.Items.Clear();
            DbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            Form.Companies.Items.Add((string)reader["WorkPlace"]);
            conn.Close();
        }
        public RelayCommand EditCommand
        {
            get
            {
                return editCommand ??
                  (editCommand = new RelayCommand((selectedItem) =>
                  {
                      if (selectedItem == null) return;
                     
                      Employee employee = selectedItem as Employee;

                      Employee emp = new Employee()
                      {
                          Id = employee.Id,
                          FullName = employee.FullName,
                          Address = employee.Address,
                          PhoneNumber = employee.PhoneNumber,
                          Position = employee.Position,
                          WorkPlace = employee.WorkPlace
                      };
                      EmployeeWindow employeeWindow = new EmployeeWindow(emp);
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
                  }));
                
            }
        }
        public RelayCommand DeleteCommand
        {
            get
            {
                return deleteCommand ??
                  (deleteCommand = new RelayCommand((selectedItem) =>
                  {
                      //Employees = db.Employees.Local.ToBindingList().Where(emp => emp.WorkPlace == Form.Companies.SelectedValue.ToString());
                      if (selectedItem == null) return;
                      Employee employee = selectedItem as Employee;
                      db.Employees.Remove(employee);
                     // Employees = db.Employees.Local.ToBindingList().Where(em => em.WorkPlace == Form.Companies.SelectedValue.ToString());
                      db.SaveChanges();
                      UpdateCompanies();
                  }));
            }
        }
        public RelayCommand LoadCommand
        {
            get
            {
                return loadCommand ?? (loadCommand = new RelayCommand((o) =>
                {
                    if (Form.Companies.SelectedValue is null)
                    {
                        MessageBox.Show("Please, choose the company!");
                    }
                    else
                    {
                        this.Employees = db.Employees.Local.ToBindingList().Where(em => em.WorkPlace == "Тензор");
                    }
                }));
            }
        }
        public RelayCommand ExitCommand
        {
            get
            {
                return exitCommand ?? (exitCommand = new RelayCommand((o) =>
                {
                    System.Windows.Application.Current.Shutdown();
                }));
            }
        }

        public RelayCommand LoadCompaniesCommand
        {
            get
            {
                return loadCompaniesCommand ?? (loadCompaniesCommand = new RelayCommand((o) =>
                {
                    SQLiteConnection conn = new SQLiteConnection("Data Source=employees.db");
                    SQLiteCommand command = new SQLiteCommand("select distinct WorkPlace from Employees", conn);
                    conn.Open();
                    DbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                        Form.listComanies.Items.Add((string)reader["WorkPlace"]);
                    conn.Close();
                }));
            }
        }
        public RelayCommand ClearCompaniesCommand
        {
            get
            {
                return clearCompaniesCommand ?? (clearCompaniesCommand = new RelayCommand((o) =>
                {
                    Form.listComanies.Items.Clear();
                }));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
