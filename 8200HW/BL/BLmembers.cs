using System;
using AutoMapper;
using DAL;
using DTO;
using System.Collections.Generic;
using DAL.models;

namespace BL
{
    public class BLmembers
    {
        DALmembers _Pdal = new DALmembers();
        IMapper imapper;
        public BLmembers()
        {
            var config = new MapperConfiguration(cgf => { cgf.AddProfile<AutoProfilMapper>(); });
            imapper = config.CreateMapper();
        }

        public List<DTOmembers> GetAllMembers()
        {
            List<Member> members = _Pdal.GetAllMembers();
            List<DTOmembers> DTOmembers = new List<DTOmembers>();
            foreach (var item in members) {
                var m = imapper.Map<Member, DTOmembers>(item);
                DTOmembers.Add(m);
            }
            return DTOmembers;
        }

        public DTOmembers GetMember(string id)
        {
            Member m = _Pdal.GetMember(id);
            if (m == null)
                return null;
            DTOmembers currentMember = imapper.Map<Member, DTOmembers>(m);
            return currentMember;
        }
        public DTOKoronaTable GetMemberDetails(string id)
        {
            KoronaTable m = _Pdal.GetMemberDetails(id);
            if (m == null)
                return null;
            DTOKoronaTable currentMember = imapper.Map<KoronaTable, DTOKoronaTable>(m);
            return currentMember;
        }

        public void UppdateMemberProfile(string id, string img)
        {
             _Pdal.UppdateMemberProfile( id,img);
        }
        public void UppdateMemberKoronaDetails(string id, DTOKoronaTable kMember)
        {
            KoronaTable k = imapper.Map<DTOKoronaTable, KoronaTable>(kMember);
             _Pdal.UppdateMemberKoronaDetails(id,k);
        }
        public List<Member> AddMember(DTOmembers m)
        {
            Member currentMember = imapper.Map<DTOmembers, Member>(m);
            return _Pdal.AddMember(currentMember);
        }

        public List<Member> UppdateMember(DTOmembers m, string code)
        {
            Member currentMember = imapper.Map<DTOmembers, Member>(m);
            return _Pdal.UppdateMember(currentMember, code);
        }

        public List<Member> RemoveMember(string code)
        {
            return _Pdal.RemoveMember(code);
        }
        public List<DTOmembers> GetAllMembersDoV1()
        {
            List<Member> members = _Pdal.GetAllMembersDoV1();
            List<DTOmembers> DTOmembers = new List<DTOmembers>();
            foreach (var item in members) {
                var m = imapper.Map<Member, DTOmembers>(item);
                DTOmembers.Add(m);
            }
            return DTOmembers;
        }
        public List<DTOmembers> GetAllMembersDoV2()
        {
            List<Member> members = _Pdal.GetAllMembersDoV2();
            List<DTOmembers> DTOmembers = new List<DTOmembers>();
            foreach (var item in members) {
                var m = imapper.Map<Member, DTOmembers>(item);
                DTOmembers.Add(m);
            }
            return DTOmembers;
        }
        public List<DTOmembers> GetAllMembersDoV3()
        {
            List<Member> members = _Pdal.GetAllMembersDoV3();
            List<DTOmembers> DTOmembers = new List<DTOmembers>();
            foreach (var item in members) {
                var m = imapper.Map<Member, DTOmembers>(item);
                DTOmembers.Add(m);
            }
            return DTOmembers;
        }
        public List<DTOmembers> GetAllMembersDoV4()
        {
            List<Member> members = _Pdal.GetAllMembersDoV4();
            List<DTOmembers> DTOmembers = new List<DTOmembers>();
            foreach (var item in members) {
                var m = imapper.Map<Member, DTOmembers>(item);
                DTOmembers.Add(m);
            }
            return DTOmembers;
        }
        //כמות הלא מחוסנים:
        public int GetCountNotV()
        {
            return _Pdal.GetCountNotV();
        }






        //גרף:
        public List<int> AveragePos()
        {
            return _Pdal.AveragePos();
        }


    }
}

