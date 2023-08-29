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
            if (searchText.Length < 2 && searchText != "*")
            {
                throw new NotFoundException("Erreur");
            }
            else if(searchText.Length >= 2 && searchText != "*")
            {
                var a = CitysList.Where(a => a.ToLower().Contains(searchText.ToLower())).ToList();
                List<string> result = new List<string>();       
                return a;
            }         
            else if(searchText == "*")
            {
                return CitysList;
            }
            throw new NotImplementedException();                    
            
        }
    }
}