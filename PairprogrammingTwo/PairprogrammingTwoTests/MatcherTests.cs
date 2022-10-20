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
  public class MatcherTests
  {

    Matcher matcher = new Matcher();
    People henry = new People("Henry",18);
    People baerta = new People("Baerta",92);
    [TestMethod()]
    public void NewMatcherContainNoPeople()
    {
      Assert.AreEqual(matcher.ContainsPeople(), true);
    }
    [TestMethod()]
    public void MatcherContainPeopleAfterAddingOnePerson()
    {
      var henry = new People("Henry",999);
      var matcher = new Matcher();
      matcher.add(henry);
      Assert.AreEqual(matcher.ContainsPeople(), false);
    }

    [TestMethod()]
    public void MatcherMatchPeopleWithSameHobbys()
    {
      var bernd = new People("Bernd",17);
      bernd.addHobby("People");
      henry.addHobby("Backen");
      baerta.addHobby("Backen");

      List<People> matches = new List<People>() { henry,baerta };

      matcher.add(henry);
      matcher.add(baerta);
      matcher.add(bernd); 

      CollectionAssert.AreEqual(matcher.findMatchesForHobby("Backen"),matches );
    }

    [TestMethod()]
    public void MatchertDoNotMatchPeopleWithDifferentHobbys()
    {
      var bernd = new People("Bernd",18);
      bernd.addHobby("People");
      henry.addHobby("Snacken");
      baerta.addHobby("Backen");

      List<People> matches = new List<People>() { baerta };

      matcher.add(henry);
      matcher.add(baerta);
      matcher.add(bernd);

      CollectionAssert.AreEqual(matcher.findMatchesForHobby("Backen"), matches);
    }

  
  }
}