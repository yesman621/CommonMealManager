using System;
using System.Collections.Generic;
using System.Text;

namespace CommonMealManager.Model
{
    class Person
    {
        // Properties
        
        public int Id
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public Group Group
        {
            get;
            set;
        }

        // Constructors

        public Person(int id, string firstName, string lastName, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public Person(int id, string firstName, string lastName, string email, Group group) : this(id, firstName, lastName, email)
        {
            Group = group;
        }


    }
}
