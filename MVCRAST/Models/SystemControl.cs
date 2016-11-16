using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SystemControlID { get; set; }
        //Foreign key
        public int SystemID { get; set; }
        public int ControlID { get; set; }
        public int ArtifactID { get; set; }
        public string FindingResultDescription { get; set; }
        public string FindingRecommendation { get; set; }
        public FindingResult? FindingStatus { get; set; }
        public virtual Systems System { get; set; }
        public virtual Controls Controls { get; set; }
        public virtual Artifact Artifacts { get; set; }
        //public virtual ICollection<Artifact> Artifact { get; set;}

        //needs an object to be made of this class 
        public int POAMID { get; set; }
        public virtual POAM POAM { get; set; }
        //needs an POAMItemID
        public int POAMItemID { get; set; }
        public virtual POAMItem POAMItem { get; set; }


    }
}