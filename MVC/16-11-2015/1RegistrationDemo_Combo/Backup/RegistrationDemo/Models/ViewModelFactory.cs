using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationDemo.Models
{
    public static class ViewModelFactory
    {
        //public static List<City> CreateCities()
        //{

        //}

        public static List<MemberViewModel> CreateIndexViewModel()
        {
            List<MemberViewModel> mvms = new List<MemberViewModel>();
            foreach (Member member in Repository.Members)
            {
                MemberViewModel mvm = new MemberViewModel();
                mvm.MemberData=member;
                City city = CityRepository.Cities.FirstOrDefault(c => c.CityId == member.CityId);
                if (city != null)
                    mvm.CityName = city.CityName;
                mvms.Add(mvm);
            }
            return mvms;
        }

        //public static List<EditMemberViewModel> CreateEditViewModel_prev()
        //{
        //    List<EditMemberViewModel> emvms = new List<EditMemberViewModel>();
        //    foreach (Member member in Repository.Members)
        //    {
        //        EditMemberViewModel emvm = new EditMemberViewModel();
        //        emvm.MemberData = member;
        //        emvm.Cities = CityRepository.Cities;
        //        emvms.Add(emvm);
        //    }
        //    return emvms;
        //}

        public static CitiesViewModel CreateCities()
        {
            CitiesViewModel cvm = new CitiesViewModel();
            cvm.cities = CityRepository.Cities;
            return cvm;
        }

        public static EditMemberViewModel CreateEditViewModel(int id)
        {
            Member member = Repository.Members.FirstOrDefault(m => m.Id == id);
            if (member != null)
            {
                EditMemberViewModel emvm = new EditMemberViewModel();
                emvm.MemberData = member;
                emvm.Cities = CityRepository.Cities;
                return emvm;
            }
            else
            {
                return null;
            }
        }

        public static MemberViewModel CreateViewModel(int id)
        {
            Member member = Repository.Members.FirstOrDefault(m => m.Id == id);
            if (member != null)
            {
                MemberViewModel mvm = new MemberViewModel();
                mvm.MemberData = member;
                mvm.CityName = CityRepository.Cities.FirstOrDefault(c => c.CityId == member.CityId).CityName;
                return mvm;
            }
            else
            {
                return null;
            }
        }

    }
}