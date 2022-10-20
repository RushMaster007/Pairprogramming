using Microsoft.VisualStudio.TestTools.UnitTesting;
using PairprogrammingTwo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairprogrammingTwo.Tests
{
  [TestClass()]
  public class PeopleTests
  {
    People people = new People("henry",18);

    [TestMethod()]
    public void PeopleContainGivenName()
    {
      Assert.AreEqual(people.Name,"henry");
    }

    public void PeopleContainOneHobbyInListOfHobbysAfterAddingOneHobby()
    {
      people.addHobby("Sleeping");
      Assert.AreEqual(people.Hobbys.Last(), "Sleeping");
    }
    public void PeopleContainOneHobbyInListOfHobbysAfterAddingHobbys()
    {
      List<string> hobbys = new List<string>() { "Chilling", "Videogaming", "working"};
      people.addHobbys(hobbys);
      Assert.AreEqual(people.Hobbys, hobbys);
    }

    public void PeoplesFirstHobbyInListOfHobbysKeepsTheFirstAfterAddingNewHobbys()
    {
      people.addHobby("Sleeping");
      List<string> hobbys = new List<string>() { "Chilling", "Videogaming", "working" };
      people.addHobbys(hobbys);
      Assert.AreEqual(people.Hobbys.First(), "Sleeping");
    }

    //ToDo
    public void PeoplesMinAgeIs18()
    {
      var horst = new People("Horst", 52);
      var hildegard = new People("Hildegard", 17);

      List<People> notvalidMembers = new List<People>() { horst, hildegard };
      List<People> validMembers = new List<People>() { horst };
      CollectionAssert.AreNotEqual(notvalidMembers, validMembers);
    }

  }
}