using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRAST.Models
{
    public enum FindingResult
    {
        Pass, Fail
    }
    public class SystemControl
    {
        public int SystemControlID { get; set; }
        public int SystemID { get; set; }
        public int ControlID { get; set; }
        public int ArtifactID { get; set; }
        public string FindingResultDescription { get; set; }
        public string FindingRecommendation { get; set; }
        public FindingResult? FindingStatus { get; set; }
        public virtual Systems System { get; set; }
        public virtual Controls Control { get; set; }

    }
}