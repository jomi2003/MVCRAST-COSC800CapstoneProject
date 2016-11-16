using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCRAST.Models
{
    public enum ApprovalResult
    {
        Pass, Fail
    }
    public class SAP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SAPID { get; set; }
        public Status? SAPStatus { get; set; }
        ApprovalResult? Approved { get; set; }
       // System.Web.HttpPostedFileBase file { get; set; }
       //Foreign key
        public int FileTemplateID { get; set; }
        public virtual FileTemplate FileTemplate { get; set; }
        //Foreing key
        //public int SystemsID { get; set; }
        //public virtual Systems Systems { get; set; }
    }
}