using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_7
{
  public class Present
  {
    public string FullName { get; set; }
    public string NamePrefix { get; set; }
    public double PriceMin { get; set; }

    public void ShowPresent()
    {
      Console.WriteLine($"\t - {NamePrefix} \"{FullName}\": {PriceMin}"); 
    }
  }
}