using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRAST.Models
{
    public enum UserRole
    {
        SystemOwner, ISSM, Assessor, SCATeam, AO, Admin
    }
    public class Users
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string email { get; set; }
        public Boolean Contractor { get; set; }
        public UserRole? UserType { get; set; }
        public virtual Organization Organization { get; set; }
    }
}