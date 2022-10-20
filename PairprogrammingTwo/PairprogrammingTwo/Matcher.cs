using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairprogrammingTwo
{
  public class Matcher
  {
    public List<People> Peoples = new List<People>();



    public bool ContainsPeople()
    {
      if(Peoples.Count == 0)
        return true;
      else
        return false;
    }

    public void add(People people)
    {
      Peoples.Add(people);
    }  
    public List<People> findMatchesForHobby(string hobbies)
    {
      List <People> maches = new List <People>();
      foreach (People people in Peoples)
      { 
        if(people.Hobbys.Contains(hobbies))
        {
          maches.Add(people);
        } 
      }
      return maches;
    }

  }
}
