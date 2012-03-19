using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Site.Models
{
    public class Trainer
    {
        public string Name { get; set; }

    }

    public class TrainingSession
    {
        public DateTime SessionStart { get; set; }
        public DateTime SessionEnd { get; set; }
        public Trainer trainer { get; set; }
        public IEnumerable<Activity> Activities { get; set; }
    }

    public class Activity
    {
        public string name { get; set; }
        public int DifficultyLevel { get; set; }
    }
}