using System;
using System.Collections.Generic;

#nullable disable

namespace DoDARv1.Models
{
    public partial class User
    {
        public int Dodid { get; set; }
        public string Uic { get; set; }
        public string CommandName { get; set; }
        public bool? Ao { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Rank { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public virtual Request UicNavigation { get; set; }
    }
}
