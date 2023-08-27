using Exercice04bilioTest.Tests;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;

namespace Exercice04biblio
{
    public class City
    {
        private List<string> CitysList { get; set; } = new List<string> 
        { 
            "Paris","Budapest","Skopje"," Rotterdam",
            "Valence","Vancouver","Amsterdam","Vienne",
            "Sydney","New York","Londres","Bangkok",
            "Hong Kong", "Dubaï","Rome","Istanbul", 
            "Dunkerque"
        }; 
      

        public List<string> CitySearch(string searchText)
        {
            if(searchText.Length < 2)
            {
                throw new NotFoundException("erreur");
            }
            if(searchText.Length >= 2)
            {
                string concat = "";
                for (int i = 0; i < CitysList.Count; i++)
                {
                    CitysList[i] = CitysList[i].ToLower();
                }
                var a = CitysList.Where(a => a.Contains(searchText.ToLower())).ToList();
                List<string> result = new List<string>();
                foreach (var item in a)
                {
                    string letter = item.ToUpper();
                    concat += letter[0];
                    string letters = item.Substring(1).ToLower();
                    concat += letters;
                    result.Add(concat);
                    concat = "";
                }
                return result;
            }

              throw new NotImplementedException();                    
            
        }
    }
}