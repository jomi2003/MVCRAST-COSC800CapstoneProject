using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCRAST.Models
{
    public enum UserRole
    {
        SystemOwner, ISSM, Assessor, SCATeam, AO, Admin
    }
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Boolean Contractor { get; set; }
        //Foreign key
        //public int OrganizationID { get; set; }
        public UserRole? UserType { get; set; }
        //public virtual Organization Organization { get; set; }
        //needs SystemID and an object from the class Systems
        //public virtual ICollection<Systems> System { get; set; }
        //Foreign key
        //public int SystemID { get; set; }
        //public virtual Systems Systems { get; set; }
    }
}