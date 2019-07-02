﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models
{
    public class Exercise
    {

        public int Id { get; set; }
        public string ExerciseName { get; set; }

        public string Language { get; set; }

        public List<Student> StudentList { get; set; } = new List<Student>();
    }
}
