using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._28_CollectionViewSource
{
    public class Employee
    {
        public int Number { get; set; } //工号
        public string Name { get; set; } //姓名
        public string Sex { get; set; } //性别
        public int BirthYear { get; set; } //出生年份
    }

    public class Department : ObservableCollection<Employee>
    {
        public string DepName { get; set; }
        public ObservableCollection<Employee> Employees { get; set; }
    }

    public class DepartmentList : ObservableCollection<Department>
    {
        public ObservableCollection<Department> MyDepartmentList { get; set; }
        public DepartmentList()
        {
            ObservableCollection<Employee> employee1 = new ObservableCollection<Employee>
            {
                new Employee{Number=2012,Name="netboy",Sex="boy",BirthYear=1992},
                new Employee{Number=2013,Name="dandan",Sex="girl",BirthYear=2000},
                new Employee{Number=2014,Name="xiaobai",Sex="girl",BirthYear=2012}
            };

            ObservableCollection<Employee> employee2 = new ObservableCollection<Employee>
            {
                new Employee{Number=2020,Name="kaizi",Sex="girl",BirthYear=2011},
                new Employee{Number=2021,Name="yangzai",Sex="gril",BirthYear=2010}
            };


            MyDepartmentList = new ObservableCollection<Department>();
            MyDepartmentList.Add(new Department { DepName = "技术部", Employees = employee1 });
            MyDepartmentList.Add(new Department { DepName = "商务部", Employees = employee2 });
        }
    }
}
