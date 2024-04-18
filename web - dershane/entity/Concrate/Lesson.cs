﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public List<Teacher>? Teachers { get; set; }
    }
}
