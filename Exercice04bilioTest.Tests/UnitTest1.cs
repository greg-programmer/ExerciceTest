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
            Assert.ThrowsException<NotFoundException>(() => city.CitySearch("h") );
        }
        //Si le texte de recherche est égal ou supérieur à 2 caractères,
        //il doit renvoyer tous les noms de ville commençant par le texte de recherche exact.
        //Par exemple, pour le texte de recherche "Va", la fonction doit renvoyer Valence et Vancouver
        [TestMethod]
        public void When_TextSearch_Equal_Or_MoreThan2Chars_Then_CitysList()
        {
            List<string> list = new List<string> {"Valence", "Vancouver" };
            City city = new City();
            CollectionAssert.AreEqual(list,city.CitySearch("Va"));
        }
        //La fonctionnalité de recherche doit être insensible à la casse
        [TestMethod]
        public void When_TextSearch_Case_Insensitive_Then_CitysList()
        {
            List<string> list = new List<string> { "Valence", "Vancouver" };
            City city = new City();
            CollectionAssert.AreEqual(list, city.CitySearch("Va"));
        }
        //La fonctionnalité de recherche devrait également fonctionner lorsque le texte de recherche n'est 
        //    qu'une partie d'un nom de ville Par exemple "ape" devrait renvoyer la ville "Budapest"
        [TestMethod]
        public void When_TextSearch_Part_0f_The_CityName_Then_CitysList()
        {
            List<string> list = new List<string> { "Budapest" };
            City city = new City();
            CollectionAssert.AreEqual(list, city.CitySearch("ap"));
        }
    }
}
