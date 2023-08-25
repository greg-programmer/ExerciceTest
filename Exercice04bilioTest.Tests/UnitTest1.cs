using Exercice04biblio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.InteropServices;
using System.Text;

namespace Exercice04bilioTest.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //Si le texte de la recherche contient moins de 2 caractères, Une exception est levée de type NotFoundException.
        public void When_TextSearch_Contains_LessThan2Chars_Then_NotFoundException()
        {
            City city = new City();           
            string ArgCity ;                
            Assert.ThrowsException<NotFoundException>(() => city.CitySearch("h") );
        }
    }
}