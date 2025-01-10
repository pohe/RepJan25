using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepJan25
{
    public class EmployeeRepositoryDictionary : IEmployeeRepository
    {
        private Dictionary<int, Employee> _employees;

        public EmployeeRepositoryDictionary()
        {
            _employees = new Dictionary<int, Employee>();
        }
        public int Count => throw new NotImplementedException();

        public void AddEmployee(Employee emp)
        {
            throw new NotImplementedException();
        }

        public double CalculateTotalSalarySum()
        {
            double total = 0;
            //foreach (Employee emp in _employees.Values)
            //{
            //    total += emp.CalculateSalary();
            //}
            List<Employee> empList= _employees.Values.ToList();
            //for (int i =0; i< _employees.Count; i++)
            //{
            //    total += empList[i].CalculateSalary();
            //}
            int i = 0;
            while(i <empList.Count)
            {
                total += empList[i].CalculateSalary();
                i++;
            }
            return total;
        }

        public List<Employee> GetAllEmployee()
        {
            throw new NotImplementedException();
        }

        public Employee? GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(Employee newEmployee)
        {
            throw new NotImplementedException();
        }
    }
}
