﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Exercise_4.Models
{
    public class Cohort
    {
         public int Id { get; set; }
         public string Name { get; set; }
         public List<Student> Students { get; set; } = new List<Student>();
         public List<Instructor> Instructors { get; set; } = new List<Instructor>();
    }

}
