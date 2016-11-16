using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace MVCRAST.Models
{
    public class Artifact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArtifactID { get; set; }
        public string ArtifactName { get; set; }
        public string Description { get; set; }
        //Foreing key
        public int FileTemplateID { get; set; }
        public virtual FileTemplate FileTemplate { get; set; }
        //Foreign key
       // public int SystemControlID { get; set; }
       // public virtual SystemControl SystemControl { get; set; }
    }
}