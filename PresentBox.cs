using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Homework_7
{
  public class PresentBox
  {
    public List<Present> Presents { get; set; } = new List<Present>();

    //показать все подарки, если надо.
    public void ShowPresents()
    {
      Console.WriteLine("\nLet's see all the presents we have:");      
      foreach (var present in Presents) 
      {
        present.ShowPresent();
      }      
    }

    //определить, есть ли подарки дешевле 10 рублей, вывести да или нет.
    public void AreTherePresentsLessThan(double cost)
    {
      Console.WriteLine($"\nLet's see if there are presents that cost less than {cost}:");
      
      bool thereArePresents = false;

      foreach (var present in Presents) 
      {
        if (present.PriceMin < cost)
        {
          thereArePresents = true;
        }
      }  

      if (thereArePresents) 
      {
        Console.WriteLine("Lucky you! There are!");       
      }
      else 
      {
        Console.WriteLine("Sorry, we don't have such presents.");       
      }
    }
    
    // выбрать подарок Тёще - самый дешевый
    public void SelectCheapestPresent()
    {
      Console.WriteLine("\nLet's choose a present for my mother-in-law:");
      
      if (Presents.Count == 0) 
      {
        Console.WriteLine("Ooups! There are no presents...");
        return;
      }

      Present cheapestPresent = Presents[0];

      foreach (var present in Presents) 
      {        
        if (present.PriceMin < cheapestPresent.PriceMin)
        {
          cheapestPresent = present;
        }
      }  

      cheapestPresent.ShowPresent();       
    }    

    // выбрать подарок себе - самый дорогой
    public void SelectMostExpensivePresent()
    {
      Console.WriteLine("\nLet's choose a present for me:");
      
      if (Presents.Count == 0) 
      {
        Console.WriteLine("Oooups! There are no presents...");
        return;
      }

      Present mostExpensivePresent = Presents[0];

      foreach (var present in Presents) 
      {        
        if (present.PriceMin > mostExpensivePresent.PriceMin)
        {
          mostExpensivePresent = present;
        }
      }  

      mostExpensivePresent.ShowPresent();       
    }

    public void ShowPresentsLessThen(double cost)
    {
      Console.WriteLine($"\nLet's see what presents cost less than {cost}:");
      
      foreach (var present in Presents) 
      {
        if (present.PriceMin < cost)
        {
          present.ShowPresent();
        }
      }      
    }

    // выбрать самые дешевые подарки пока не закончатся 50 рублей, вывести список подарков
    public void SelectCheapestPresentsOn(double sum)
    {
      Console.WriteLine($"\nLet's choose the cheapest presents on {sum}");
      
      if (Presents.Count == 0) 
      {
        Console.WriteLine("Ooups! There are no presents...");
        return;
      }

      if (sum == 0) 
      {
        Console.WriteLine("Sorry! Incorrect sum.");
        return;
      }

      int presentCount = Presents.Count;

      var sortedPresents = Presents.OrderBy(o => o.PriceMin);

      while (sum > 0 && presentCount > 0)
      {
        presentCount -= 1;

        foreach (var present in sortedPresents) 
        {        
          if (sum > present.PriceMin)
          {
            present.ShowPresent();
            sum -= present.PriceMin;
          }
        }  
      }      
    }

    // выбрать случайные подарки, покупая всё пока не закончатся 80 рублей - вывести список подарков
    public void SelectRandomPresentsOn(double sum)
    {
      Console.WriteLine($"\nLet's choose the cheapest presents on {sum}");
      
      if (Presents.Count == 0) 
      {
        Console.WriteLine("Ooups! There are no presents...");
        return;
      }

      if (sum == 0) 
      {
        Console.WriteLine("Sorry! Incorrect sum.");
        return;
      }

      int presentCount = Presents.Count;

      var rnd = new Random();
      
      var unsortedPresents = Presents.OrderBy(o => rnd.Next());

      while (sum > 0 && presentCount > 0)
      {
        presentCount -= 1;

        foreach (var present in unsortedPresents) 
        {        
          if (sum > present.PriceMin)
          {
            present.ShowPresent();
            sum -= present.PriceMin;
          }
        }  
      }      
    }  

    // - посчитать сколько будут стоить все подарки
    public void ShowTotalSumOfPresents()
    {
      var totalSum = Presents.Sum(o => o.PriceMin);
      Console.WriteLine($"\nLet's see total sum of the presents we have: {totalSum}");   
    }    

    // - посчитать, сколько будут стоить все подарки с ценой до 40 рублей
    public void ShowTotalSumOfPresentsLessThen(double sum)
    {
      var totalSum = Presents.Where(o => o.PriceMin < 40).Sum(o => o.PriceMin);
      Console.WriteLine($"\nLet's see total sum of the presents that cost less then {sum}: {totalSum}");   
    }

    // - вывести список подарков с ценой до 25 рублей
    // ПОПОЗЖЕ РАЗОБРАТЬСЯ, ГДЕ КОСЯК
    // public void ShowPresentsLessThan(double cost)
    // {
    //   Console.WriteLine($"\nLet's see the presents that cost less then {cost}");         
    //   Presents.Where(o => o.PriceMin < cost).ForEach(o => o.ShowPresent());
    // }    

    // - вывести список подарков с ценой до 25 рублей
   public void DisplayPresentsLessThen(double cost)
    {
      Console.WriteLine($"\nLet's see what presents cost less than {cost}:");
      
      foreach (var present in Presents) 
      {
        if (present.PriceMin < cost)
        {
          present.ShowPresent();
        }
      }      
    }
  }
}