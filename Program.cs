using System;

namespace Salary
{
    class Employee
    {
        public string emp_id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public char gender { get; set; }
        public string position { get; set; }
        public string emp_type { get; set; }
        public double gross_salary { get; set; }
        public double net_salary { get; set; }

        public Employee()
        {
            Console.WriteLine("Employee ID: ");
            this.emp_id = Console.ReadLine();
            Console.WriteLine("First Name: ");
            this.firstname = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            this.lastname = Console.ReadLine();
            Console.WriteLine("Gender: ");
            this.gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Position: ");
            this.position = Console.ReadLine();
            Console.WriteLine("Employee type: Monthly|Hourly|One-Time");
            this.emp_type = Console.ReadLine();
            Console.WriteLine("Employee Gross EmpSalaryApp: ");
            this.gross_salary = Convert.ToDouble(Console.ReadLine());
        }

        public Employee(string emp_id, string firstname, string lastname, char gender, string position, string emp_type,
            double gross_salary, double net_salary)
        {
            this.emp_id = emp_id;
            this.firstname = firstname;
            this.gender = gender;
            this.position = position;
            this.emp_type = emp_type;
            this.gross_salary = gross_salary;
            this.net_salary = net_salary;
        }

        public string empInfo()
        {
            return string.Format(
                "Employere ID: {0} \nFirst Name: {1} \nLast Name: {2} \nGender: {3} \nEmployee Position: {4} \nEmployee Category: {5} \nEmployee Gross EmpSalaryApp: {6} \n",
                emp_id, firstname, lastname, gender, position, emp_type, gross_salary);
        }

        public double netSalary()
        {
            double tax, rssb, insurance, rate;
            if (emp_type == "Monthly")
            {
                tax = (30 * gross_salary) / 100;
                rssb = (5 * gross_salary) / 100;
                insurance = (3 * gross_salary) / 100;
                net_salary = gross_salary- (tax + rssb + insurance);
            }
            else if (emp_type == "Hourly")
            {
                double hrs;
                Console.WriteLine("Number of Hours Worked: ");
                hrs = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Rate Per Hour: ");
                rate = Convert.ToDouble(Console.ReadLine());
                rssb = (5 * gross_salary) / 100;
                insurance = (3 * gross_salary) / 100;
                net_salary = (hrs * rate) - (rssb + insurance);
            }
            else if (emp_type == "One-Time")
            {
                tax = (30 * gross_salary) / 100;
                net_salary = gross_salary - tax;
            }
            return net_salary;
        }
        static void Main(string[] args)
        {
            Employee employ = new Employee();
            
            Console.WriteLine("Calculate Net EmpSalaryApp: Yes| No ");
            
            string check = Console.ReadLine();
            
            if (check == "Yes")
            {
                Console.WriteLine("Net EmpSalaryApp: "+employ.netSalary());
            }
            else
            {
                Console.WriteLine("That's All");
            }
        }
    }
}