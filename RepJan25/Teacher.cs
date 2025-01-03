using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RepJan25
{
    public class Teacher:Employee
    {

		private string _subject;

		public string Subject
		{
			get { return _subject; }
			set { _subject = value; }
		}

        public Teacher(string subject, int baseSalary, int id, string name, string mobile) :base(baseSalary, id, name, mobile)
        {
            _subject = subject;
        }

        public override double CalculateSalary()
        {
            if ( _subject =="Systemudvikling")
            {
                return 2 * _baseSalary;
            }
            else
            {
                return _baseSalary;
            }
        }

        public override string ToString()
        {
            //return $"Subject {_subject} " + base.ToString();
            return $"Subject {_subject}  Basesalary {_baseSalary} ID {Id} Name {Name} Mobile {Mobile}";
        }

    }
}
