using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRAST.Models
{
    public enum  Categorization
    {
        Low, Medium, High
    }
    public class Systems
    {
        public int ID { get; set; }
        public string SystemName { get; set; }
        public Categorization? Confidentiality { get; set; }
        public Categorization? Integrity { get; set; }
        public Categorization? Availability { get; set; }
        public DateTime AssessmentStartDate { get; set; }
        public DateTime AssessmentEndDate { get; set; }
        public int AssessmentPriority { get; set; }
        public virtual ICollection<SystemControl> SystemControls { get; set; }

    }
}