﻿// See https://aka.ms/new-console-template for more information

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