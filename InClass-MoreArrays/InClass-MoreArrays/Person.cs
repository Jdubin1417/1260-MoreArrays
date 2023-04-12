///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InClass-MoreArrays
//	File Name:         Person.cs
//	Description:       Defines a Person who has a name and age.
//	Course:            CSCI-1260
//	Author:            Katie Wilson, wilsonkl4@etsu.edu, East Tennessee State University
//	Created:           09/19/2022
//	Copyright:         Katie Wilson, 2022
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_MoreArrays
{
    /// <summary>
    /// Defines a Person who has a name and age
    /// </summary>
    public class Person
    {
        //Attributes
        public string Name { get; set; }
        public int Age { get; set; }

        //Constructors
        /// <summary>
        /// Default constructor - sets attributes to default values
        /// </summary>
        public Person()
        {
            Name = "";
            Age = 0;
        }

        /// <summary>
        /// Fully parameterized constructor - sets attributes to passed in values
        /// </summary>
        /// <param name="name">the name of the person</param>
        /// <param name="age">the age of the person, in years</param>
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        //Methods
        /// <summary>
        /// Increases the person's age by one
        /// </summary>
        public void HaveBirthday()
        {
            Age++;
        }

        /// <summary>
        /// Formats the person in an easy-to-read format for display
        /// </summary>
        /// <returns>the information about a person in an easy-to-read format</returns>
        public override string ToString()
        {
            string info = "";

            info += $"\nName: {Name}";
            info += $"\n Age: {Age}";

            return info;
        }
    }
}
