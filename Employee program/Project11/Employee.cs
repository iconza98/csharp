using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Project11
{
    class Employee
    {
        const double FED_RATE = .20;
        const double STATE_RATE = .075;
        const double WEEKemployeeHours = 40;
        const double OVERTIME_RATE = 1.5;

        // Used property attributes to create getter and setter methods
        public int employeeNum { get; set; }
        public string empName { get; set; }
        public string employeeAdress { get; set; }
        public double employeeWage { get; set; }
        public double employeeHours { get; set; }
        public double overTime { get; set; }

        // Employee Default Constructor
        // Purpose: Initialize the member values to zero or null
        // Parameters: none
        // Returns: none
        public Employee()
        {
            this.employeeNum = 0;
            this.empName = null;
            this.employeeAdress = null;
            this.employeeWage = 0.0;
            this.employeeHours = 0.0;
            this.overTime = 0;
        }
        // Employee Parameterized Constructor
        // Purpose: Initialize the vales of all the members in the class
        // Parameters: one int, two stings, two doubles
        // Returns: none
        public Employee(int emNum, string name, string adress, double wage, double hours)
        {
            this.employeeNum = emNum;
            this.empName = name;
            this.employeeAdress = adress;
            this.employeeWage = wage;
            this.employeeHours = hours <= WEEKemployeeHours ? hours : WEEKemployeeHours;
            this.overTime = hours > WEEKemployeeHours ? (hours - WEEKemployeeHours) : 0;
        }

        // CalcSalary Method Prolouge
        //
        public double CalcSalary()
        {
            double grossPay = employeeWage * employeeHours + (overTime * (employeeWage * OVERTIME_RATE));
            return grossPay - (grossPay * STATE_RATE) - (grossPay * FED_RATE);
        }


    }
}
