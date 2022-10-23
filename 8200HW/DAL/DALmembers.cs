using System;
using System.Collections.Generic;
using System.Linq;
using DAL.models;

namespace DAL
{
    public class DALmembers
    {
        DBContext DB = new DBContext();

        public Member GetMember(string id)
        {
            Member currentMember = DB.Members.Where(x => x.MemberId.Equals(id)).FirstOrDefault();
            return currentMember;
        }
        public KoronaTable GetMemberDetails(string id)
        {
            KoronaTable currentMember = DB.KoronaTables.Where(x => x.MemberId.Equals(id)).FirstOrDefault();
            return currentMember;
        }

        public List<Member> GetAllMembers()
        {
            List<Member> members = DB.Members.ToList();
            return members;
        }
        public List<Member> AddMember(Member member)
        {
            try {
                KoronaTable k = new KoronaTable();
                k.MemberId = member.MemberId;
               

                DB.KoronaTables.Add(k);
                DB.SaveChanges();

                DB.Members.Add(member);
                DB.SaveChanges();
                return DB.Members.ToList();
            }
            catch (Exception) {
                throw;
            }
        }

        public List<Member> UppdateMember(Member member, string id)
        {
            try {
                Member m = DB.Members.First(x => x.MemberId.Equals(id));
                if (m != null) {

                    m.MemberName = member.MemberName;
                    m.MemberLastName = member.MemberLastName;
                    m.MemberCity = member.MemberCity;
                    m.MemberAdress = member.MemberAdress;
                    m.MemberPhone = member.MemberPhone;
                    m.MemberTel = member.MemberTel;
                    m.MemberBirthDate = member.MemberBirthDate;



                    DB.SaveChanges();
                }
                return DB.Members.ToList();
            }
            catch (Exception) {
                throw;
            }
        }

        public void UppdateMemberProfile(string id, string img)
        {
            try {
                DB.KoronaTables.First(x => x.MemberId.Equals(id)).imge = img;
                DB.SaveChanges();
            }
            catch {
                throw;

            }
        }

        public void UppdateMemberKoronaDetails(string id, KoronaTable kMember)
        {
            try {
              KoronaTable k=  DB.KoronaTables.First(x => x.MemberId.Equals(id));
                if (k != null) {
                    if(kMember.MemberSickDate.Value.Year!=1970)
                    k.MemberSickDate = kMember.MemberSickDate;
                    if(kMember.MemberRecoveryDate.Value.Year!=1970)
                    k.MemberRecoveryDate = kMember.MemberRecoveryDate;
                    if (kMember.Vaccination1Date .Value.Year!=1970)
                    k.Vaccination1Date = kMember.Vaccination1Date;
                    if (kMember.Vaccination2Date .Value.Year!=1970)
                    k.Vaccination2Date = kMember.Vaccination2Date;
                    if (kMember.Vaccination3Date .Value.Year!=1970)
                    k.Vaccination3Date = kMember.Vaccination3Date;
                    if (kMember.Vaccination4Date  .Value.Year!=1970)
                    k.Vaccination4Date = kMember.Vaccination4Date;
                    if (kMember.Vaccination1manufacturer != "")
                    k.Vaccination1manufacturer = kMember.Vaccination1manufacturer;
                    if (kMember.Vaccination2manufacturer != "")
                    k.Vaccination2manufacturer = kMember.Vaccination2manufacturer;
                    if (kMember.Vaccination3manufacturer != "")
                    k.Vaccination3manufacturer = kMember.Vaccination3manufacturer;
                    if (kMember.Vaccination4manufacturer != "")
                    k.Vaccination4manufacturer = kMember.Vaccination4manufacturer;

                


                }
              DB.SaveChanges();

            }
            catch (Exception e){
                throw;

            }
        }

        public List<Member> RemoveMember(string id)
        {
            try {
                this.DB.Remove(DB.Members.FirstOrDefault(x => x.MemberId.Equals(id)));
                this.DB.Remove(DB.KoronaTables.FirstOrDefault(x => x.MemberId.Equals(id)));


                this.DB.SaveChanges();
                return DB.Members.ToList();
            }
            catch (Exception) {
                throw;
            }

        }

        public List<Member> GetAllMembersDoV1()
        {
            List<Member> l=new List<Member>();
            List<KoronaTable> members = DB.KoronaTables.Where(x => x.Vaccination1Date != null).ToList();
            foreach (var item in members) {
                Member m = DB.Members.FirstOrDefault(x => x.MemberId.Equals(item.MemberId));
                if (m.MemberId != null)
                    l.Add(m);
            }
            return l;
        }
        public List<Member> GetAllMembersDoV2()
        {
            List<Member> l = new List<Member>();
            List<KoronaTable> members = DB.KoronaTables.Where(x => x.Vaccination2Date != null).ToList();
            foreach (var item in members) {
                Member m = DB.Members.FirstOrDefault(x => x.MemberId.Equals(item.MemberId));
                if (m.MemberId != null)
                    l.Add(m);
            }
            return l;
        }
        public List<Member> GetAllMembersDoV3()
        {
            List<Member> l = new List<Member>();
            List<KoronaTable> members = DB.KoronaTables.Where(x => x.Vaccination3Date != null).ToList();
            foreach (var item in members) {
                Member m = DB.Members.FirstOrDefault(x => x.MemberId.Equals(item.MemberId));
                if (m.MemberId != null)
                    l.Add(m);
            }
            return l;
        }
        public List<Member> GetAllMembersDoV4()
        {
            List<Member> l = new List<Member>();
            List<KoronaTable> members = DB.KoronaTables.Where(x => x.Vaccination4Date != null).ToList();
            foreach (var item in members) {
                Member m = DB.Members.FirstOrDefault(x => x.MemberId.Equals(item.MemberId));
                if (m.MemberId != null)
                    l.Add(m);
            }
            return l;
        }
        //כמות החברים שלא מחוסנים
        public int GetCountNotV()
        {
            return DB.KoronaTables.Where(x => x.Vaccination1Date == null).Count();
        }

        public List<int> AveragePos()
        {
            List<int> pos = new List<int>();
            for (int i = 1; i <32; i++) {
                int Avgpos = 0;

                List<KoronaTable> arr = DB.KoronaTables.Where(x => x.MemberSickDate.Value.Month == DateTime.Today.Month && x.MemberSickDate.Value.Year == DateTime.Today.Year && x.MemberSickDate.Value.Day ==i).ToList();
                foreach (var p in arr) {
                    if (arr != null) {

                        if (p.MemberSickDate != null && p.MemberRecoveryDate ==null) {
                            Avgpos ++;


                        }

                    }

                }
                pos.Add(Avgpos);

            }
            return pos;
        }



    }
}
