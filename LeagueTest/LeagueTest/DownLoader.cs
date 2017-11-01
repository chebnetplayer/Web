using System.Net;
using System.Collections.Generic;
using LeagueTest.Models;
using Newtonsoft.Json;

namespace LeagueTest
{
    public class DownLoader
    {
        public static string DownloadWebString(string uri)
        {
            var webclient = new WebClient();
            return webclient.DownloadString(uri);
        }

        private static List<Human> GetlistHumans()
        {
            const string uri = @"http://testlodtask20172.azurewebsites.net/task";
            var txt = DownloadWebString(uri);
            var peoples = JsonConvert.DeserializeObject<List<Human>>(txt);
            foreach (var i in peoples)
                i.Age = i.GetAge();
            return peoples;
        }

        public static string GetHuman(string id)
        {
            var humans = GetlistHumans();
            var human = humans.Find(i => i.Id == id);
            return human.GetJson();
        }
        
    }
}