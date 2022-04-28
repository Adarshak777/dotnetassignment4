using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetassignment4
{
    internal class Program
    {

        public abstract class Student
        {
            public String Name;
            public int StudentId;
            public abstract void BooleanIspassed(int Grade);
        }

        public class Undergraduate : Student
        {
            public override void BooleanIspassed(int Grade)
            {
                try
                {

                    Console.WriteLine("Enter the undergraduate student Grade ");
                    Grade = Convert.ToInt32(Console.ReadLine());
                    if (Grade > 70)
                    {
                        Console.WriteLine("undergraduate student passed  ");
                    }
                    else
                    {
                        Console.WriteLine("undergraduate student failed  ");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("input mismatch  " + e.StackTrace);
                }
            }
        }
    }

    class Graduate : Student
    {
        public override void BooleanIspassed(int Grade)
        {
            try
            {
                Console.WriteLine("enter the graduate student Grade");
                Grade = Convert.ToInt32(Console.ReadLine());
                if (Grade > 80)
                {
                    Console.WriteLine("graduate student passed ");
                }
                else
                {
                    Console.WriteLine("graduate student failed ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("input missmatch " + e.StackTrace);
            }
        }
    }

    static void Main(string[] args)
    {
        Undergraduate ug = new Undergraduate();
        ug.BooleanIspassed(10);
        ug.Name = "Sunny";
        ug.StudentId = 15414;
        Console.WriteLine($"name is {ug.Name} & id is {ug.StudentId}");



        Graduate ag = new Graduate();
        ag.Name = "Adarsh kumar";
        ag.StudentId = 1523114176;
        ag.BooleanIspassed(20);
        Console.WriteLine($"name is {ag.Name} & id is {ag.StudentId}");

    }
    //**************************PARTTIME EMPLOYE********************************


    public class Employee
    {
        public int empId;
        public string empName;
        public float salary;

        public Employee(int empId, string empName, float salary)
        {
            this.empId = empId;
            this.empName = empName;
            this.salary = salary;
        }
        public void dispDetails()
        {
            Console.WriteLine($"empName {empName} with empid {empId} gets salary of {salary}");
        }
        public class PartTimeemployee
        {
            public int wages = 6000;

            public void showDetails()
            {
                Console.WriteLine($"the parttime employee gets " + wages);
            }

            static void Main(string[] args)
            {
                Employee employee = new Employee(1523114176, "Adarsh", 6000f);
                employee.dispDetails();
                PartTimeemployee ptemployee = new PartTimeemployee();
                ptemployee.showDetails();


            }
        }
    }
}
//**************************** STUDENT ************************************


public class Students
{
    public int st_Id;
    public string st_Name;
    public double exam_fee;


    public void displayDetails()
    {
        Console.WriteLine($"\nthe student {st_Name} with id {st_Id} paid {exam_fee}");
    }
    public void payFee()
    {
        Console.WriteLine("enter student id: ");
        st_Id = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the student name: ");
        st_Name = Console.ReadLine();
        Console.WriteLine("the exam fee: is" + 800);
        Console.WriteLine("enter the amount to pay examfee");
        exam_fee = int.Parse(Console.ReadLine());
        double rem_fee = 800 - exam_fee;
        if (exam_fee == 800)
        {
            Console.WriteLine("full fees paid no dues");
        }
        else
        {
            Console.WriteLine("the remaining fee: " + rem_fee);
        }
    }
}
class DayScholar
{
    public double transport_fees;

    public DayScholar(double transport_fees)
    {
        this.transport_fees = transport_fees;
        double rem1_fee = 35000 - transport_fees;

        Console.WriteLine("the transport fee: " + 35000 + "per year ");


        Console.WriteLine($"the dayscholar  paid {transport_fees} & remaining fee is {rem1_fee}");
        Console.ReadLine();
    }

}
public class Hosteller
{
    public double hostel_fee;

    public Hosteller(double hostel_fee)
    {

        this.hostel_fee = hostel_fee;

        double rem2_fee = 48000 - hostel_fee;
        Console.WriteLine("the hostel  fee: " + 48000 + "per year ");

        Console.WriteLine($"the dayscholar  paid {hostel_fee} & remaining fee is {rem2_fee} ");
        Console.ReadLine();
    }

    static void Main(string[] args)
    {
        Students students = new Students();
        students.payFee();
        students.displayDetails();
        Console.WriteLine("enter the tranport fee you want to pay: ");
        DayScholar dayScholar = new DayScholar(int.Parse(Console.ReadLine()));
        Console.WriteLine("enter the hostel fee you want to pay: ");
        Hosteller hosteller = new Hosteller(int.Parse(Console.ReadLine()));
    }
     


    
}

