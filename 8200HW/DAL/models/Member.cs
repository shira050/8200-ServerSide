using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class Member
    {
        public string MemberName { get; set; }
        public string MemberLastName { get; set; }
        public string MemberId { get; set; }
        public string MemberAdress { get; set; }
        public string MemberCity { get; set; }
        public DateTime? MemberBirthDate { get; set; }
        public string MemberTel { get; set; }
        public string MemberPhone { get; set; }

        public virtual KoronaTable MemberNavigation { get; set; }
    }
}
