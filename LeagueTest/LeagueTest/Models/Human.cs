using Newtonsoft.Json;

namespace LeagueTest.Models
{
    public class Human 
    {
        public string Id;
        public string Name;
        public string Sex;
        public int Age;
        public int GetAge()
        {
            var uri = @"http://testlodtask20172.azurewebsites.net/task/" + Id;
            var humanHelper = JsonConvert.DeserializeObject<Human>(DownLoader.DownloadWebString(uri));
            return humanHelper.Age;
        }
        public string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}