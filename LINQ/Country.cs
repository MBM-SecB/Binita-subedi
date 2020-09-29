using System;
public class Country
{
  public string Name { get; set; }
  public string Capital { get; set; }
  public string Continent { get; set; }
  public long Population { get; set; }
  public DateTime IndependenceDay { get; set; }
  public Country(string n, string cp, string c, long P, DateTime i = default)
  {
    this.Name = n;
    Capital = cp;
    Population = p;
    IndependenceDay = i;
  }
}