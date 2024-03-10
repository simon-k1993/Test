﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.DTOs
{
    public class NoteToReturnDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public string Category { get; set; }
    }
}
