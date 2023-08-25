using Exercice04bilioTest.Tests;

namespace Exercice04biblio
{
    public class City
    {
        public string CityName { get; set; }
      

        public string CitySearch(string searchText)
        {
            if(searchText.Length < 2)
            {
                throw new NotFoundException("erreur");
            }
              throw new NotImplementedException();                    
            
        }
    }
}