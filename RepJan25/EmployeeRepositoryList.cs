using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepJan25
{
    public class EmployeeRepositoryList : IEmployeeRepository
    {
        private List<Employee> _employees;


        public int Count {
            get { return _employees.Count; }
        }

        public EmployeeRepositoryList()
        {
            _employees = new List<Employee>();
        }


        public void AddEmployee(Employee emp)
        {
            if ( GetEmployee(emp.Id) == null )
                 _employees.Add(emp);
        }

        public double CalculateTotalSalarySum()
        {
            double total =0;
            foreach(Employee emp in _employees)
            {
                total += emp.CalculateSalary();
            }
            return total;
        }

        public List<Employee> GetAllEmployee()
        {
            throw new NotImplementedException();
        }

        public Employee? GetEmployee(int id)
        {
            foreach(Employee em in _employees)
            {
                if (em.Id == id)
                    return em;
            }
            return null;
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
