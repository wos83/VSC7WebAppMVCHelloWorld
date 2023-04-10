using System;
using System.Collections.Generic;

namespace VSC7WebAppMVCHelloWorld.Models
{
	public class HomeModel
	{
		public string? myName  { get; set; }
        public string? myMail  { get; set; }
        public string? myPhone { get; set; }
    }

    public static class HomeModelRepo
    {
        private static List<HomeModel> homeVisits = new List<HomeModel>();
        public static IEnumerable<HomeModel> HomeModels { get { return homeVisits; } }
        public static void AddHomeVisits(HomeModel homeVisit)
        {
            homeVisits.Add(homeVisit);
        }
    }
}