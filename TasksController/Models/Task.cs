using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TasksController.Models
{
    public enum Priority
    {
        Urgent,
        NotUrgent
    }
    public class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public Priority TaskPriority { get; set; }

        public string TitlePer { get; set; }
        public string DescriptionPer { get; set; }
        public bool IsCompletedPer { get; set; }
        public DateTime CreatedAtPer { get; set; }
        public Priority TaskPriorityPer { get; set; }
    }
}