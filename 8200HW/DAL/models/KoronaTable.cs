using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class KoronaTable
    {
        public string MemberId { get; set; }
        public DateTime? Vaccination1Date { get; set; }
        public DateTime? Vaccination2Date { get; set; }
        public DateTime? Vaccination3Date { get; set; }
        public DateTime? Vaccination4Date { get; set; }
        public string Vaccination1manufacturer { get; set; }
        public string Vaccination2manufacturer { get; set; }
        public string Vaccination3manufacturer { get; set; }
        public string Vaccination4manufacturer { get; set; }
        public DateTime? MemberSickDate { get; set; }
        public DateTime? MemberRecoveryDate { get; set; }
        public string imge { get; set; }

        public virtual Member Member { get; set; }
    }
}
