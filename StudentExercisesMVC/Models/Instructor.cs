using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models
{
    public class Instructor
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Speciality { get; set; }

        public int CohortId { get; set; }

        //ceate a method for assigning students exercises
        public void AssignExercise(Student student, Exercise exercise)
        {
            exercise.StudentList.Add(student);
            student.ExerciseList.Add(exercise);
        }
    }
}
