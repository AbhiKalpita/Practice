using Basic_of_Oops;
using System;
namespace Basic_of_Oops
{
    public class E_Details
    {
        int emp_id;
        string? emp_name;
        double salary;
        string? address;
        double contact_num;
        string blood_group;


        public void employee_Info(int emp_id, string emp_name, double salary, string address, double contact_num, string blood_group)
        {
            this.emp_id = emp_id;
            this.emp_name = emp_name;
            this.salary = salary;
            this.address = address;
            this.contact_num = contact_num;
            this.blood_group = blood_group;

        }

        public void get_Details()
        {
            Console.WriteLine("Name of the employee is : {0}", emp_name);
            Console.WriteLine("Id number of the Employee : {0}", emp_id);
            Console.WriteLine("Employee Salary is : {0}", salary);
            Console.WriteLine("Employee Adress is : {0}", address);
            Console.WriteLine("Employee Contact number is : {0}", contact_num);
            Console.WriteLine("Employee BloodGroup is : " + blood_group);

        }
    }

}

class Employee_Tester
{
    public static void Main(string[] args)
    {
        E_Details details = new E_Details();
        details.employee_Info(1, "Sagar", 7854699999, "Belgum", 7894645, "O +ve");
        details.get_Details();
        Console.ReadLine();

    }

}