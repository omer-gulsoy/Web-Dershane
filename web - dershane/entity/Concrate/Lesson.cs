﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity.Concrate
{
    public class Lesson
    {
        [Key]
        public int Lesson_Id { get; set; }
        public string? Name { get; set; }
        public bool Status { get; set; }
    }
}
