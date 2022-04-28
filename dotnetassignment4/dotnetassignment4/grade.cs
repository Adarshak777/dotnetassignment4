using System;

namespace dotnetassignment4
{
    abstract class Grade
    {

        public interface IStudent
        {
            void ShowDetails(int studentid, string studname);
        }
        class Dayscholar : IStudent
        {
            public void ShowDetails(int studentid, string studname)
            {
                Console.WriteLine($"The person with {studentid} and {studname} belongs to DayScholars");
                Console.Read();
            }
        }
        class Resident : IStudent
        {
            public void ShowDetails(int studentid, string studname)
            {
                Console.WriteLine($"The person with {studentid} and {studname} belongs to Residental");
                Console.Read();
            }
        }


        static void Main (string[] args)

        {
            Dayscholar ds = new Dayscholar();
            ds.ShowDetails(123, "sree");
            Resident rs = new Resident();
            rs.ShowDetails(323, "pavan");
            Console.Read();
        }







    }
}

