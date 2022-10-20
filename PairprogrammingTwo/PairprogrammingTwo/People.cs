using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairprogrammingTwo
{
  public class People
  {
    public List<string> Hobbys = new List<string>();
    public string Name {get; set; }
    public int Age {get; set; }
    public People(string name, int age)
    {
      Name = name;
      Age = age;
    }
    public void addHobby(string hobby)
    {
      Hobbys.Add(hobby); 
    }

    public void addHobbys(List<string> hobbys)
    {
      Hobbys = hobbys;
    }
  }
}
