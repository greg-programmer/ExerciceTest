using Exercice04bilioTest.Tests;
using static System.Formats.Asn1.AsnWriter;

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

                var a = CitysList.Where(a => a.Contains(searchText)).ToList();
                return a;
            }
              throw new NotImplementedException();                    
            
        }
    }
}