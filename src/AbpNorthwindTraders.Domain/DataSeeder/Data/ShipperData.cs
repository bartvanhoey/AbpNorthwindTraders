using System.Collections.Generic;

namespace AbpNorthwindTraders.Domain.DataSeeder.Data
{
  public static class ShipperData
  {
    public static Dictionary<int, Shipper> GetShippers()
    {
      var shippers = new Dictionary<int, Shipper>();
      
      shippers.Add(1, new Shipper { CompanyName = "Speedy Express", Phone = "(503) 555-9831" });
      shippers.Add(2, new Shipper { CompanyName = "United Package", Phone = "(503) 555-3199" });
      shippers.Add(3, new Shipper { CompanyName = "Federal Shipping", Phone = "(503) 555-9931" });

      return shippers;
    }
  }
}