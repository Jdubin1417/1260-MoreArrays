///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InClass-MoreArrays
//	File Name:         Classroom.cs
//	Description:       Defines a classroom with students, an instructor, and a room name.
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
    /// Defines a classroom with students, an instructor, and a room name.
    /// </summary>
    public class Classroom
    {
        //Attributes
        public Person[] Students { get; set; }
        public Person Instructor { get; set; }
        public string RoomName { get; set; }

        //Constructors
        /// <summary>
        /// Default constructor - sets the attributes to default values
        /// </summary>
        public Classroom()
        {
            RoomName = "";
            Instructor = new Person();

            Students = new Person[30]; //makes a new array of Person objects with 30 empty slots
            for(int i = 0; i < Students.Length; i++)
            {
                Students[i] = new Person(); //fill each slot in the array with a default Person
            }
        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="roomName">the name of the classroom</param>
        /// <param name="instructor">the person object corresponding to the instructor</param>
        /// <param name="numStudents">the number of students in the class</param>
        public Classroom(string roomName, Person instructor, int numStudents)
        {
            //Set the room name and instructor to the passed in values
            RoomName = roomName;
            Instructor = instructor;

            //In this constructor, we are given the number of students (size for the array),
            //but no other information about the students, so they can be made using the default
            //constructor
            Students = new Person[numStudents]; //makes a new array of Person objects with numStudents amount of empty slots
            for (int i = 0; i < Students.Length; i++)
            {
                Students[i] = new Person(); //fill each slot in the array with a default Person
            }
        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="roomName">the name of the classroom</param>
        /// <param name="instructor">the person object corresponding to the instructor</param>
        /// <param name="students">an array of person objects corresponding to the students</param>
        public Classroom(string roomName, Person instructor, Person[] students)
        {
            //Set the room name and instructor to the passed in values
            RoomName = roomName;
            Instructor = instructor;

            //In this case, we are given the array of Person objects for the students
            //Students = students; //SHALLOW COPY - BAD

            //Deep copy
            Students = new Person[students.Length]; //make the Students array as a new array of the same size as the one passed in
            for (int i = 0; i < Students.Length; i++)
            {
                Students[i] = students[i]; //copy each element over from the passed in array
            }
        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="roomName">the name of the classroom</param>
        /// <param name="instructor">the person object corresponding to the instructor</param>
        /// <param name="names">an array of strings with the names of the students in the class</param>
        /// <param name="ages">an array of integers with the ages of the students in the class</param>
        public Classroom(string roomName, Person instructor, string[] names, int[] ages)
        {
            //Set the room name and instructor to the passed in values
            RoomName = roomName;
            Instructor = instructor;

            //We assume and expect the names and ages to be the same size
            //e.g., names = {"Bob", "Bill", "Joe"}, ages = {22, 67, 43}

            Students = new Person[names.Length]; //makes a new array of Person objects with the same amount of empty slots as the names array, in example, size 3
            for (int i = 0; i < Students.Length; i++)
            {
                //fill each slot in the array with a Person made with the parameterized constructor, using the names and ages arrays
                Students[i] = new Person(names[i], ages[i]); 
            }
        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="existing">an existing classroom</param>
        public Classroom(Classroom existing)
        {
            //Copy all of existing's attributes' values into our new Classroom object we are making's attributes
            RoomName = existing.RoomName;
            Instructor = existing.Instructor;
            Students = new Person[existing.Students.Length]; //deep copy
            for (int i = 0; i < Students.Length; i++)
            {
                Students[i] = existing.Students[i];
            }
        }

        //Methods
        /// <summary>
        /// Formats the classroom in an easy-to-read format for display
        /// </summary>
        /// <returns>the information about a classroom in an easy-to-read format</returns>
        public override string ToString()
        {
            string info = "";

            info += $"\nRoom Name: {RoomName}";
            info += $"\nInstructor: {Instructor}";

            info += $"\nStudents:";
            for(int i = 0; i < Students.Length; i++)
            {
                info += $"{Students[i]}"; //Students[i] is a Person object, so we are calling the Person ToString here
            }

            return info;
        }
    }
}
