using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using Homework_7;

class Program
{
  static void Main(string[] args)
  {
    var json = File.ReadAllText("data.json");
    var JsonPresent = JsonSerializer.Deserialize<ProductList>(json);

    var myPresentBox = new PresentBox();
      
    foreach (var products in JsonPresent.products)
      {
        var full_name = products.full_name;
        var name_prefix = products.name_prefix;
        var min_price = Convert.ToDouble(products.prices.price_min.amount);  

        var present = new Present() 
        { 
          FullName = full_name,  
          NamePrefix = name_prefix,
          PriceMin = min_price
        }; 

        myPresentBox.Presents.Add(present);
      }
      
      // myPresentBox.ShowPresents();
      myPresentBox.AreTherePresentsLessThan(10);
      Console.WriteLine($"-----------------------------------------------------------------");
      myPresentBox.SelectCheapestPresent();
      Console.WriteLine($"-----------------------------------------------------------------");
      myPresentBox.SelectMostExpensivePresent();
      Console.WriteLine($"-----------------------------------------------------------------");
      myPresentBox.SelectCheapestPresentsOn(50);
      Console.WriteLine($"-----------------------------------------------------------------");
      myPresentBox.SelectRandomPresentsOn(80);
      Console.WriteLine($"-----------------------------------------------------------------");
      myPresentBox.ShowTotalSumOfPresents();
      Console.WriteLine($"-----------------------------------------------------------------");
      myPresentBox.ShowTotalSumOfPresentsLessThen(40);
      Console.WriteLine($"-----------------------------------------------------------------");
      myPresentBox.DisplayPresentsLessThen(25);
  }
}