﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepJan25
{
    public abstract class Employee
    {
		protected int _baseSalary;

		public int BaseSalary
		{
			get { return _baseSalary; }
			set {
                if (value > 10000)
                {
                    throw new ArgumentException("Basesalary er for høj");
                }
                _baseSalary = value; }
		}

		private int _id;

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}

		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

        public string Mobile { get; set; }

        public Employee(int baseSalary, int id, string name, string mobile)
        {
			if (baseSalary >10000)
			{
				throw new ArgumentException("Basesalary er for høj");
			}
			_baseSalary = baseSalary;
			_id = id;
			_name = name;
			Mobile = mobile;
        }

		public virtual double CalculateSalary()
		{
			return _baseSalary;
		}


		public abstract double CalculatePension();

        public override string ToString()
        {
            return $"Basesalary {_baseSalary} ID {_id} Name {_name} Mobile {Mobile}";
        }
    }
}
