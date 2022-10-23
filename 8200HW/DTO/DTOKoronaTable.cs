using System;

namespace DTO
{
    public class DTOKoronaTable
    {
        public string memberID { get; set; }

        public DateTime Vaccination1Date { get; set; }
        public DateTime Vaccination2Date { get; set; }
        public DateTime Vaccination3Date { get; set; }
        public DateTime Vaccination4Date { get; set; }

        public string Vaccination1manufacturer { get; set; }
        public string Vaccination2manufacturer { get; set; }
        public string Vaccination3manufacturer { get; set; }
        public string Vaccination4manufacturer { get; set; }

        public DateTime memberSickDate { get; set; }
        public DateTime memberRecoveryDate { get; set; }
        public string imge { get; set; }

        public DTOKoronaTable()
        {
                
        }
    }
}
