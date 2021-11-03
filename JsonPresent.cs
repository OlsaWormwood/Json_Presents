using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_7
{
  public class ProductList
  {
    public List<Product> products { get; set; }
  }

  public class Product
  {
    public string full_name { get; set; }
    public string name_prefix { get; set; }
    public Prices prices { get; set; }
  }

  public class Prices 
  {
    public PriceMin price_min { get; set; }
  }

  public class PriceMin 
  {
    public string amount { get; set; }
  }
}