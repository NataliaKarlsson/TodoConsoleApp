using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;



namespace todoit
{
    internal class Program
    {
        static void Main(string[] args)
        { }




        //constructur to reach and ref to this


        //Method gets and sets properties


    }
    public class Person
    {
        readonly int userId;
        string? firstName;
        string? lastName;
        string? email;
        public Person(int userId, string? firstName, string? lastName)
        {
            this.userId = userId;
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public int UserId
        {
            get; private set;
        }
        public string? FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string? LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
    }


}





