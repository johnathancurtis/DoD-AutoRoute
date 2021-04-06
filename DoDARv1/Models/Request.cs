using System;
using System.Collections.Generic;

#nullable disable

namespace DoDARv1.Models
{
    public partial class Request
    {
        public Request()
        {
            Users = new HashSet<User>();
        }

        public string Uic { get; set; }
        public string Serial { get; set; }
        public bool? SpecialType { get; set; }
        public bool? RegularType { get; set; }
        public DateTime? DateIn { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
