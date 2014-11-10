using System;
using System.Collections.Generic;
using System.Text;

namespace CommonMealManager.Model
{
    class Group
    {
        // Properties

        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public Person Administrator
        {
            get;
            set;
        }

        // Constructors

        public Group(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Group(int id, string name, Person admin) : this(id,name)
        {
            Administrator = admin;
        }

        

    }
}
