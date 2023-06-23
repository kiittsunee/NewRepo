﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class TodoItemDTO
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }

        public TodoItemDTO (TodoItem todoItem)
        {
            Id = todoItem.Id;
            Name = todoItem.Name;
            IsComplete = todoItem.IsComplete;
       }

        public TodoItemDTO()
        {
        }
    }
    public class TodoItem
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
        public string? Secret { get; set; }
    }
    
}
