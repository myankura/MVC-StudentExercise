using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models
{
    public class Student
    {
        //Constructor for Student
        //public Student(int id, string firstName, string lastName, string slack, int cohortId)
        //{
        //    Id = id;
        //    FirstName = firstName;
        //    LastName = lastName;
        //    SlackHandle = slack;
        //    CohortId = cohortId;
        //}

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string SlackHandle { get; set; }

        public int CohortId { get; set; }

        public Cohort Cohort { get; set; }

        //Create a list of assignments the student is currently working on
        public List<Exercise> ExerciseList { get; set; } = new List<Exercise>();
    }
}
