using System.Collections.Generic;

namespace AbpNorthwindTraders.Domain.DataSeeder.Data
{
  public static class TerritoryData
  {
    public readonly static List<Territory> Territories = new List<Territory>();

    public static void GetTerritories()
    {
      Territories.AddRange(new[]
      {
                new Territory("01581",  "Westboro", 1),
                new Territory("01730",  "Bedford", 1),
                new Territory("01833",  "Georgetow", 1),
                new Territory("02116",  "Boston", 1),
                new Territory("02139",  "Cambridge", 1),
                new Territory("02184",  "Braintree", 1),
                new Territory("02903",  "Providence", 1),
                new Territory("03049",  "Hollis", 3),
                new Territory("03801",  "Portsmouth", 3),
                new Territory("06897",  "Wilton", 1),
                new Territory("07960",  "Morristown", 1),
                new Territory("08837",  "Edison", 1),
                new Territory("10019",  "New York", 1),
                new Territory("10038",  "New York", 1),
                new Territory("11747",  "Mellvile", 1),
                new Territory("14450",  "Fairport", 1),
                new Territory("19428",  "Philadelphia", 3),
                new Territory("19713",  "Neward", 1),
                new Territory("20852",  "Rockville", 1),
                new Territory("27403",  "Greensboro", 1),
                new Territory("27511",  "Cary", 1),
                new Territory("29202",  "Columbia", 4),
                new Territory("30346",  "Atlanta", 4),
                new Territory("31406",  "Savannah", 4),
                new Territory("32859",  "Orlando", 4),
                new Territory("33607",  "Tampa", 4),
                new Territory("40222",  "Louisville", 1),
                new Territory("44122",  "Beachwood", 3),
                new Territory("45839",  "Findlay", 3),
                new Territory("48075",  "Southfield", 3),
                new Territory("48084",  "Troy", 3),
                new Territory("48304",  "Bloomfield Hills", 3),
                new Territory("53404",  "Racine", 3),
                new Territory("55113",  "Roseville", 3),
                new Territory("55439",  "Minneapolis", 3),
                new Territory("60179",  "Hoffman Estates", 2),
                new Territory("60601",  "Chicago", 2),
                new Territory("72716",  "Bentonville", 4),
                new Territory("75234",  "Dallas", 4),
                new Territory("78759",  "Austin", 4),
                new Territory("80202",  "Denver", 2),
                new Territory("80909",  "Colorado Springs", 2),
                new Territory("85014",  "Phoenix", 2),
                new Territory("85251",  "Scottsdale", 2),
                new Territory("90405",  "Santa Monica", 2),
                new Territory("94025",  "Menlo Park", 2),
                new Territory("94105",  "San Francisco", 2),
                new Territory("95008",  "Campbell", 2),
                new Territory("95054",  "Santa Clara", 2),
                new Territory("95060",  "Santa Cruz", 2),
                new Territory("98004",  "Bellevue", 2),
                new Territory("98052",  "Redmond", 2),
                new Territory("98104",  "Seattle", 2),
            });
    }

  }
}