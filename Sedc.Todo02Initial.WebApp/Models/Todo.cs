﻿using System;

namespace Sedc.Todo02Initial.WebApp.Models
{
    public class Todo
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }

        public Todo()
        {
            DueDate = DateTime.Now;
        }
    }
}