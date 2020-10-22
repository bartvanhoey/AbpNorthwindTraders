using System.Collections.Generic;

namespace AbpNorthwindTraders.Domain.DataSeeder.Data
{
  public static class ProductData
  {
   
    public static Dictionary<int, Category> Categories = new Dictionary<int, Category>();
    public static Dictionary<int, Supplier> Suppliers = new Dictionary<int, Supplier>();

    public static Dictionary<int, Product> GetProducts()
    {
      var products = new Dictionary<int, Product>();

      Categories = CategoryData.GetCategories();
      Suppliers = SupplierData.GetSuppliers();
      // products = ProductData.GetProducts();

      products.Add(1,
          new Product
          {
            ProductName = "Chai",
            Supplier = Suppliers[1],
            Category = Categories[1],
            QuantityPerUnit = "10 boxes x 20 bags",
            UnitPrice = 18.00m,
            UnitsInStock = 39,
            UnitsOnOrder = 0,
            ReorderLevel = 10,
            Discontinued = false
          });
      products.Add(2,
          new Product
          {
            ProductName = "Chang",
            Supplier = Suppliers[1],
            Category = Categories[1],
            QuantityPerUnit = "24 - 12 oz bottles",
            UnitPrice = 19.00m,
            UnitsInStock = 17,
            UnitsOnOrder = 40,
            ReorderLevel = 25,
            Discontinued = false
          });
      products.Add(3,
          new Product
          {
            ProductName = "Aniseed Syrup",
            Supplier = Suppliers[1],
            Category = Categories[2],
            QuantityPerUnit = "12 - 550 ml bottles",
            UnitPrice = 10.00m,
            UnitsInStock = 13,
            UnitsOnOrder = 70,
            ReorderLevel = 25,
            Discontinued = false
          });
      products.Add(4,
          new Product
          {
            ProductName = "Chef Anton's Cajun Seasoning",
            Supplier = Suppliers[2],
            Category = Categories[2],
            QuantityPerUnit = "48 - 6 oz jars",
            UnitPrice = 22.00m,
            UnitsInStock = 53,
            UnitsOnOrder = 0,
            ReorderLevel = 0,
            Discontinued = false
          });
      products.Add(5,
          new Product
          {
            ProductName = "Chef Anton's Gumbo Mix",
            Supplier = Suppliers[2],
            Category = Categories[2],
            QuantityPerUnit = "36 boxes",
            UnitPrice = 21.35m,
            UnitsInStock = 0,
            UnitsOnOrder = 0,
            ReorderLevel = 0,
            Discontinued = true
          });
      products.Add(6,
          new Product
          {
            ProductName = "Grandma's Boysenberry Spread",
            Supplier = Suppliers[3],
            Category = Categories[2],
            QuantityPerUnit = "12 - 8 oz jars",
            UnitPrice = 25.00m,
            UnitsInStock = 120,
            UnitsOnOrder = 0,
            ReorderLevel = 25,
            Discontinued = false
          });
      products.Add(7,
          new Product
          {
            ProductName = "Uncle Bob's Organic Dried Pears",
            Supplier = Suppliers[3],
            Category = Categories[7],
            QuantityPerUnit = "12 - 1 lb pkgs.",
            UnitPrice = 30.00m,
            UnitsInStock = 15,
            UnitsOnOrder = 0,
            ReorderLevel = 10,
            Discontinued = false
          });
      products.Add(8,
          new Product
          {
            ProductName = "Northwoods Cranberry Sauce",
            Supplier = Suppliers[3],
            Category = Categories[2],
            QuantityPerUnit = "12 - 12 oz jars",
            UnitPrice = 40.00m,
            UnitsInStock = 6,
            UnitsOnOrder = 0,
            ReorderLevel = 0,
            Discontinued = false
          });
      products.Add(9,
          new Product
          {
            ProductName = "Mishi Kobe Niku",
            Supplier = Suppliers[4],
            Category = Categories[6],
            QuantityPerUnit = "18 - 500 g pkgs.",
            UnitPrice = 97.00m,
            UnitsInStock = 29,
            UnitsOnOrder = 0,
            ReorderLevel = 0,
            Discontinued = true
          });
      products.Add(10,
          new Product
          {
            ProductName = "Ikura",
            Supplier = Suppliers[4],
            Category = Categories[8],
            QuantityPerUnit = "12 - 200 ml jars",
            UnitPrice = 31.00m,
            UnitsInStock = 31,
            UnitsOnOrder = 0,
            ReorderLevel = 0,
            Discontinued = false
          });
      products.Add(11,
          new Product
          {
            ProductName = "Queso Cabrales",
            Supplier = Suppliers[5],
            Category = Categories[4],
            QuantityPerUnit = "1 kg pkg.",
            UnitPrice = 21.00m,
            UnitsInStock = 22,
            UnitsOnOrder = 30,
            ReorderLevel = 30,
            Discontinued = false
          });
      products.Add(12,
          new Product
          {
            ProductName = "Queso Manchego La Pastora",
            Supplier = Suppliers[5],
            Category = Categories[4],
            QuantityPerUnit = "10 - 500 g pkgs.",
            UnitPrice = 38.00m,
            UnitsInStock = 86,
            UnitsOnOrder = 0,
            ReorderLevel = 0,
            Discontinued = false
          });
      products.Add(13,
          new Product
          {
            ProductName = "Konbu",
            Supplier = Suppliers[6],
            Category = Categories[8],
            QuantityPerUnit = "2 kg box",
            UnitPrice = 6.00m,
            UnitsInStock = 24,
            UnitsOnOrder = 0,
            ReorderLevel = 5,
            Discontinued = false
          });
      products.Add(14,
          new Product
          {
            ProductName = "Tofu",
            Supplier = Suppliers[6],
            Category = Categories[7],
            QuantityPerUnit = "40 - 100 g pkgs.",
            UnitPrice = 23.25m,
            UnitsInStock = 35,
            UnitsOnOrder = 0,
            ReorderLevel = 0,
            Discontinued = false
          });
      products.Add(15,
          new Product
          {
            ProductName = "Genen Shouyu",
            Supplier = Suppliers[6],
            Category = Categories[2],
            QuantityPerUnit = "24 - 250 ml bottles",
            UnitPrice = 15.50m,
            UnitsInStock = 39,
            UnitsOnOrder = 0,
            ReorderLevel = 5,
            Discontinued = false
          });
      products.Add(16,
          new Product
          {
            ProductName = "Pavlova",
            Supplier = Suppliers[7],
            Category = Categories[3],
            QuantityPerUnit = "32 - 500 g boxes",
            UnitPrice = 17.45m,
            UnitsInStock = 29,
            UnitsOnOrder = 0,
            ReorderLevel = 10,
            Discontinued = false
          });
      products.Add(17,
          new Product
          {
            ProductName = "Alice Mutton",
            Supplier = Suppliers[7],
            Category = Categories[6],
            QuantityPerUnit = "20 - 1 kg tins",
            UnitPrice = 39.00m,
            UnitsInStock = 0,
            UnitsOnOrder = 0,
            ReorderLevel = 0,
            Discontinued = true
          });
      products.Add(18,
          new Product
          {
            ProductName = "Carnarvon Tigers",
            Supplier = Suppliers[7],
            Category = Categories[8],
            QuantityPerUnit = "16 kg pkg.",
            UnitPrice = 62.50m,
            UnitsInStock = 42,
            UnitsOnOrder = 0,
            ReorderLevel = 0,
            Discontinued = false
          });
      products.Add(19,
          new Product
          {
            ProductName = "Teatime Chocolate Biscuits",
            Supplier = Suppliers[8],
            Category = Categories[3],
            QuantityPerUnit = "10 boxes x 12 pieces",
            UnitPrice = 9.20m,
            UnitsInStock = 25,
            UnitsOnOrder = 0,
            ReorderLevel = 5,
            Discontinued = false
          });
      products.Add(20,
          new Product
          {
            ProductName = "Sir Rodney's Marmalade",
            Supplier = Suppliers[8],
            Category = Categories[3],
            QuantityPerUnit = "30 gift boxes",
            UnitPrice = 81.00m,
            UnitsInStock = 40,
            UnitsOnOrder = 0,
            ReorderLevel = 0,
            Discontinued = false
          });
      products.Add(21,
          new Product
          {
            ProductName = "Sir Rodney's Scones",
            Supplier = Suppliers[8],
            Category = Categories[3],
            QuantityPerUnit = "24 pkgs. x 4 pieces",
            UnitPrice = 10.00m,
            UnitsInStock = 3,
            UnitsOnOrder = 40,
            ReorderLevel = 5,
            Discontinued = false
          });
      products.Add(22,
          new Product
          {
            ProductName = "Gustaf's Knäckebröd",
            Supplier = Suppliers[9],
            Category = Categories[5],
            QuantityPerUnit = "24 - 500 g pkgs.",
            UnitPrice = 21.00m,
            UnitsInStock = 104,
            UnitsOnOrder = 0,
            ReorderLevel = 25,
            Discontinued = false
          });
      products.Add(23,
          new Product
          {
            ProductName = "Tunnbröd",
            Supplier = Suppliers[9],
            Category = Categories[5],
            QuantityPerUnit = "12 - 250 g pkgs.",
            UnitPrice = 9.00m,
            UnitsInStock = 61,
            UnitsOnOrder = 0,
            ReorderLevel = 25,
            Discontinued = false
          });
      products.Add(24,
          new Product
          {
            ProductName = "Guaraná Fantástica",
            Supplier = Suppliers[10],
            Category = Categories[1],
            QuantityPerUnit = "12 - 355 ml cans",
            UnitPrice = 4.50m,
            UnitsInStock = 20,
            UnitsOnOrder = 0,
            ReorderLevel = 0,
            Discontinued = true
          });
      products.Add(25,
          new Product
          {
            ProductName = "NuNuCa Nuß-Nougat-Creme",
            Supplier = Suppliers[11],
            Category = Categories[3],
            QuantityPerUnit = "20 - 450 g glasses",
            UnitPrice = 14.00m,
            UnitsInStock = 76,
            UnitsOnOrder = 0,
            ReorderLevel = 30,
            Discontinued = false
          });
      products.Add(26,
          new Product
          {
            ProductName = "Gumbär Gummibärchen",
            Supplier = Suppliers[11],
            Category = Categories[3],
            QuantityPerUnit = "100 - 250 g bags",
            UnitPrice = 31.23m,
            UnitsInStock = 15,
            UnitsOnOrder = 0,
            ReorderLevel = 0,
            Discontinued = false
          });
      products.Add(27,
          new Product
          {
            ProductName = "Schoggi Schokolade",
            Supplier = Suppliers[11],
            Category = Categories[3],
            QuantityPerUnit = "100 - 100 g pieces",
            UnitPrice = 43.90m,
            UnitsInStock = 49,
            UnitsOnOrder = 0,
            ReorderLevel = 30,
            Discontinued = false
          });
      products.Add(28,
          new Product
          {
            ProductName = "Rössle Sauerkraut",
            Supplier = Suppliers[12],
            Category = Categories[7],
            QuantityPerUnit = "25 - 825 g cans",
            UnitPrice = 45.60m,
            UnitsInStock = 26,
            UnitsOnOrder = 0,
            ReorderLevel = 0,
            Discontinued = true
          });
      products.Add(29,
          new Product
          {
            ProductName = "Thüringer Rostbratwurst",
            Supplier = Suppliers[12],
            Category = Categories[6],
            QuantityPerUnit = "50 bags x 30 sausgs.",
            UnitPrice = 123.79m,
            UnitsInStock = 0,
            UnitsOnOrder = 0,
            ReorderLevel = 0,
            Discontinued = true
          });
      products.Add(30,
          new Product
          {
            ProductName = "Nord-Ost Matjeshering",
            Supplier = Suppliers[13],
            Category = Categories[8],
            QuantityPerUnit = "10 - 200 g glasses",
            UnitPrice = 25.89m,
            UnitsInStock = 10,
            UnitsOnOrder = 0,
            ReorderLevel = 15,
            Discontinued = false
          });
      products.Add(31,
          new Product
          {
            ProductName = "Gorgonzola Telino",
            Supplier = Suppliers[14],
            Category = Categories[4],
            QuantityPerUnit = "12 - 100 g pkgs",
            UnitPrice = 12.50m,
            UnitsInStock = 0,
            UnitsOnOrder = 70,
            ReorderLevel = 20,
            Discontinued = false
          });
      products.Add(32,
          new Product
          {
            ProductName = "Mascarpone Fabioli",
            Supplier = Suppliers[14],
            Category = Categories[4],
            QuantityPerUnit = "24 - 200 g pkgs.",
            UnitPrice = 32.00m,
            UnitsInStock = 9,
            UnitsOnOrder = 40,
            ReorderLevel = 25,
            Discontinued = false
          });
      products.Add(33,
          new Product
          {
            ProductName = "Geitost",
            Supplier = Suppliers[15],
            Category = Categories[4],
            QuantityPerUnit = "500 g",
            UnitPrice = 2.50m,
            UnitsInStock = 112,
            UnitsOnOrder = 0,
            ReorderLevel = 20,
            Discontinued = false
          });
      products.Add(34,
          new Product
          {
            ProductName = "Sasquatch Ale",
            Supplier = Suppliers[16],
            Category = Categories[1],
            QuantityPerUnit = "24 - 12 oz bottles",
            UnitPrice = 14.00m,
            UnitsInStock = 111,
            UnitsOnOrder = 0,
            ReorderLevel = 15,
            Discontinued = false
          });
      products.Add(35,
          new Product
          {
            ProductName = "Steeleye Stout",
            Supplier = Suppliers[16],
            Category = Categories[1],
            QuantityPerUnit = "24 - 12 oz bottles",
            UnitPrice = 18.00m,
            UnitsInStock = 20,
            UnitsOnOrder = 0,
            ReorderLevel = 15,
            Discontinued = false
          });
      products.Add(36,
          new Product
          {
            ProductName = "Inlagd Sill",
            Supplier = Suppliers[17],
            Category = Categories[8],
            QuantityPerUnit = "24 - 250 g  jars",
            UnitPrice = 19.00m,
            UnitsInStock = 112,
            UnitsOnOrder = 0,
            ReorderLevel = 20,
            Discontinued = false
          });
      products.Add(37,
          new Product
          {
            ProductName = "Gravad lax",
            Supplier = Suppliers[17],
            Category = Categories[8],
            QuantityPerUnit = "12 - 500 g pkgs.",
            UnitPrice = 26.00m,
            UnitsInStock = 11,
            UnitsOnOrder = 50,
            ReorderLevel = 25,
            Discontinued = false
          });
      products.Add(38,
          new Product
          {
            ProductName = "Côte de Blaye",
            Supplier = Suppliers[18],
            Category = Categories[1],
            QuantityPerUnit = "12 - 75 cl bottles",
            UnitPrice = 263.50m,
            UnitsInStock = 17,
            UnitsOnOrder = 0,
            ReorderLevel = 15,
            Discontinued = false
          });
      products.Add(39,
          new Product
          {
            ProductName = "Chartreuse verte",
            Supplier = Suppliers[18],
            Category = Categories[1],
            QuantityPerUnit = "750 cc per bottle",
            UnitPrice = 18.00m,
            UnitsInStock = 69,
            UnitsOnOrder = 0,
            ReorderLevel = 5,
            Discontinued = false
          });
      products.Add(40,
          new Product
          {
            ProductName = "Boston Crab Meat",
            Supplier = Suppliers[19],
            Category = Categories[8],
            QuantityPerUnit = "24 - 4 oz tins",
            UnitPrice = 18.40m,
            UnitsInStock = 123,
            UnitsOnOrder = 0,
            ReorderLevel = 30,
            Discontinued = false
          });
      products.Add(41,
          new Product
          {
            ProductName = "Jack's New England Clam Chowder",
            Supplier = Suppliers[19],
            Category = Categories[8],
            QuantityPerUnit = "12 - 12 oz cans",
            UnitPrice = 9.65m,
            UnitsInStock = 85,
            UnitsOnOrder = 0,
            ReorderLevel = 10,
            Discontinued = false
          });
      products.Add(42,
          new Product
          {
            ProductName = "Singaporean Hokkien Fried Mee",
            Supplier = Suppliers[20],
            Category = Categories[5],
            QuantityPerUnit = "32 - 1 kg pkgs.",
            UnitPrice = 14.00m,
            UnitsInStock = 26,
            UnitsOnOrder = 0,
            ReorderLevel = 0,
            Discontinued = true
          });
      products.Add(43,
          new Product
          {
            ProductName = "Ipoh Coffee",
            Supplier = Suppliers[20],
            Category = Categories[1],
            QuantityPerUnit = "16 - 500 g tins",
            UnitPrice = 46.00m,
            UnitsInStock = 17,
            UnitsOnOrder = 10,
            ReorderLevel = 25,
            Discontinued = false
          });
      products.Add(44,
          new Product
          {
            ProductName = "Gula Malacca",
            Supplier = Suppliers[20],
            Category = Categories[2],
            QuantityPerUnit = "20 - 2 kg bags",
            UnitPrice = 19.45m,
            UnitsInStock = 27,
            UnitsOnOrder = 0,
            ReorderLevel = 15,
            Discontinued = false
          });
      products.Add(45,
          new Product
          {
            ProductName = "Rogede sild",
            Supplier = Suppliers[21],
            Category = Categories[8],
            QuantityPerUnit = "1k pkg.",
            UnitPrice = 9.50m,
            UnitsInStock = 5,
            UnitsOnOrder = 70,
            ReorderLevel = 15,
            Discontinued = false
          });
      products.Add(46,
          new Product
          {
            ProductName = "Spegesild",
            Supplier = Suppliers[21],
            Category = Categories[8],
            QuantityPerUnit = "4 - 450 g glasses",
            UnitPrice = 12.00m,
            UnitsInStock = 95,
            UnitsOnOrder = 0,
            ReorderLevel = 0,
            Discontinued = false
          });
      products.Add(47,
          new Product
          {
            ProductName = "Zaanse koeken",
            Supplier = Suppliers[22],
            Category = Categories[3],
            QuantityPerUnit = "10 - 4 oz boxes",
            UnitPrice = 9.50m,
            UnitsInStock = 36,
            UnitsOnOrder = 0,
            ReorderLevel = 0,
            Discontinued = false
          });
      products.Add(48,
          new Product
          {
            ProductName = "Chocolade",
            Supplier = Suppliers[22],
            Category = Categories[3],
            QuantityPerUnit = "10 pkgs.",
            UnitPrice = 12.75m,
            UnitsInStock = 15,
            UnitsOnOrder = 70,
            ReorderLevel = 25,
            Discontinued = false
          });
      products.Add(49,
          new Product
          {
            ProductName = "Maxilaku",
            Supplier = Suppliers[23],
            Category = Categories[3],
            QuantityPerUnit = "24 - 50 g pkgs.",
            UnitPrice = 20.00m,
            UnitsInStock = 10,
            UnitsOnOrder = 60,
            ReorderLevel = 15,
            Discontinued = false
          });
      products.Add(50,
          new Product
          {
            ProductName = "Valkoinen suklaa",
            Supplier = Suppliers[23],
            Category = Categories[3],
            QuantityPerUnit = "12 - 100 g bars",
            UnitPrice = 16.25m,
            UnitsInStock = 65,
            UnitsOnOrder = 0,
            ReorderLevel = 30,
            Discontinued = false
          });
      products.Add(51,
          new Product
          {
            ProductName = "Manjimup Dried Apples",
            Supplier = Suppliers[24],
            Category = Categories[7],
            QuantityPerUnit = "50 - 300 g pkgs.",
            UnitPrice = 53.00m,
            UnitsInStock = 20,
            UnitsOnOrder = 0,
            ReorderLevel = 10,
            Discontinued = false
          });
      products.Add(52,
          new Product
          {
            ProductName = "Filo Mix",
            Supplier = Suppliers[24],
            Category = Categories[5],
            QuantityPerUnit = "16 - 2 kg boxes",
            UnitPrice = 7.00m,
            UnitsInStock = 38,
            UnitsOnOrder = 0,
            ReorderLevel = 25,
            Discontinued = false
          });
      products.Add(53,
          new Product
          {
            ProductName = "Perth Pasties",
            Supplier = Suppliers[24],
            Category = Categories[6],
            QuantityPerUnit = "48 pieces",
            UnitPrice = 32.80m,
            UnitsInStock = 0,
            UnitsOnOrder = 0,
            ReorderLevel = 0,
            Discontinued = true
          });
      products.Add(54,
          new Product
          {
            ProductName = "Tourtière",
            Supplier = Suppliers[25],
            Category = Categories[6],
            QuantityPerUnit = "16 pies",
            UnitPrice = 7.45m,
            UnitsInStock = 21,
            UnitsOnOrder = 0,
            ReorderLevel = 10,
            Discontinued = false
          });
      products.Add(55,
          new Product
          {
            ProductName = "Pâté chinois",
            Supplier = Suppliers[25],
            Category = Categories[6],
            QuantityPerUnit = "24 boxes x 2 pies",
            UnitPrice = 24.00m,
            UnitsInStock = 115,
            UnitsOnOrder = 0,
            ReorderLevel = 20,
            Discontinued = false
          });
      products.Add(56,
          new Product
          {
            ProductName = "Gnocchi di nonna Alice",
            Supplier = Suppliers[26],
            Category = Categories[5],
            QuantityPerUnit = "24 - 250 g pkgs.",
            UnitPrice = 38.00m,
            UnitsInStock = 21,
            UnitsOnOrder = 10,
            ReorderLevel = 30,
            Discontinued = false
          });
      products.Add(57,
          new Product
          {
            ProductName = "Ravioli Angelo",
            Supplier = Suppliers[26],
            Category = Categories[5],
            QuantityPerUnit = "24 - 250 g pkgs.",
            UnitPrice = 19.50m,
            UnitsInStock = 36,
            UnitsOnOrder = 0,
            ReorderLevel = 20,
            Discontinued = false
          });
      products.Add(58,
          new Product
          {
            ProductName = "Escargots de Bourgogne",
            Supplier = Suppliers[27],
            Category = Categories[8],
            QuantityPerUnit = "24 pieces",
            UnitPrice = 13.25m,
            UnitsInStock = 62,
            UnitsOnOrder = 0,
            ReorderLevel = 20,
            Discontinued = false
          });
      products.Add(59,
          new Product
          {
            ProductName = "Raclette Courdavault",
            Supplier = Suppliers[28],
            Category = Categories[4],
            QuantityPerUnit = "5 kg pkg.",
            UnitPrice = 55.00m,
            UnitsInStock = 79,
            UnitsOnOrder = 0,
            ReorderLevel = 0,
            Discontinued = false
          });
      products.Add(60,
          new Product
          {
            ProductName = "Camembert Pierrot",
            Supplier = Suppliers[28],
            Category = Categories[4],
            QuantityPerUnit = "15 - 300 g rounds",
            UnitPrice = 34.00m,
            UnitsInStock = 19,
            UnitsOnOrder = 0,
            ReorderLevel = 0,
            Discontinued = false
          });
      products.Add(61,
          new Product
          {
            ProductName = "Sirop d'érable",
            Supplier = Suppliers[29],
            Category = Categories[2],
            QuantityPerUnit = "24 - 500 ml bottles",
            UnitPrice = 28.50m,
            UnitsInStock = 113,
            UnitsOnOrder = 0,
            ReorderLevel = 25,
            Discontinued = false
          });
      products.Add(62,
          new Product
          {
            ProductName = "Tarte au sucre",
            Supplier = Suppliers[29],
            Category = Categories[3],
            QuantityPerUnit = "48 pies",
            UnitPrice = 49.30m,
            UnitsInStock = 17,
            UnitsOnOrder = 0,
            ReorderLevel = 0,
            Discontinued = false
          });
      products.Add(63,
          new Product
          {
            ProductName = "Vegie-spread",
            Supplier = Suppliers[7],
            Category = Categories[2],
            QuantityPerUnit = "15 - 625 g jars",
            UnitPrice = 43.90m,
            UnitsInStock = 24,
            UnitsOnOrder = 0,
            ReorderLevel = 5,
            Discontinued = false
          });
      products.Add(64,
          new Product
          {
            ProductName = "Wimmers gute Semmelknödel",
            Supplier = Suppliers[12],
            Category = Categories[5],
            QuantityPerUnit = "20 bags x 4 pieces",
            UnitPrice = 33.25m,
            UnitsInStock = 22,
            UnitsOnOrder = 80,
            ReorderLevel = 30,
            Discontinued = false
          });
      products.Add(65,
          new Product
          {
            ProductName = "Louisiana Fiery Hot Pepper Sauce",
            Supplier = Suppliers[2],
            Category = Categories[2],
            QuantityPerUnit = "32 - 8 oz bottles",
            UnitPrice = 21.05m,
            UnitsInStock = 76,
            UnitsOnOrder = 0,
            ReorderLevel = 0,
            Discontinued = false
          });
      products.Add(66,
          new Product
          {
            ProductName = "Louisiana Hot Spiced Okra",
            Supplier = Suppliers[2],
            Category = Categories[2],
            QuantityPerUnit = "24 - 8 oz jars",
            UnitPrice = 17.00m,
            UnitsInStock = 4,
            UnitsOnOrder = 100,
            ReorderLevel = 20,
            Discontinued = false
          });
      products.Add(67,
          new Product
          {
            ProductName = "Laughing Lumberjack Lager",
            Supplier = Suppliers[16],
            Category = Categories[1],
            QuantityPerUnit = "24 - 12 oz bottles",
            UnitPrice = 14.00m,
            UnitsInStock = 52,
            UnitsOnOrder = 0,
            ReorderLevel = 10,
            Discontinued = false
          });
      products.Add(68,
          new Product
          {
            ProductName = "Scottish Longbreads",
            Supplier = Suppliers[8],
            Category = Categories[3],
            QuantityPerUnit = "10 boxes x 8 pieces",
            UnitPrice = 12.50m,
            UnitsInStock = 6,
            UnitsOnOrder = 10,
            ReorderLevel = 15,
            Discontinued = false
          });
      products.Add(69,
          new Product
          {
            ProductName = "Gudbrandsdalsost",
            Supplier = Suppliers[15],
            Category = Categories[4],
            QuantityPerUnit = "10 kg pkg.",
            UnitPrice = 36.00m,
            UnitsInStock = 26,
            UnitsOnOrder = 0,
            ReorderLevel = 15,
            Discontinued = false
          });
      products.Add(70,
          new Product
          {
            ProductName = "Outback Lager",
            Supplier = Suppliers[7],
            Category = Categories[1],
            QuantityPerUnit = "24 - 355 ml bottles",
            UnitPrice = 15.00m,
            UnitsInStock = 15,
            UnitsOnOrder = 10,
            ReorderLevel = 30,
            Discontinued = false
          });
      products.Add(71,
          new Product
          {
            ProductName = "Flotemysost",
            Supplier = Suppliers[15],
            Category = Categories[4],
            QuantityPerUnit = "10 - 500 g pkgs.",
            UnitPrice = 21.50m,
            UnitsInStock = 26,
            UnitsOnOrder = 0,
            ReorderLevel = 0,
            Discontinued = false
          });
      products.Add(72,
          new Product
          {
            ProductName = "Mozzarella di Giovanni",
            Supplier = Suppliers[14],
            Category = Categories[4],
            QuantityPerUnit = "24 - 200 g pkgs.",
            UnitPrice = 34.80m,
            UnitsInStock = 14,
            UnitsOnOrder = 0,
            ReorderLevel = 0,
            Discontinued = false
          });
      products.Add(73,
          new Product
          {
            ProductName = "Röd Kaviar",
            Supplier = Suppliers[17],
            Category = Categories[8],
            QuantityPerUnit = "24 - 150 g jars",
            UnitPrice = 15.00m,
            UnitsInStock = 101,
            UnitsOnOrder = 0,
            ReorderLevel = 5,
            Discontinued = false
          });
      products.Add(74,
          new Product
          {
            ProductName = "Longlife Tofu",
            Supplier = Suppliers[4],
            Category = Categories[7],
            QuantityPerUnit = "5 kg pkg.",
            UnitPrice = 10.00m,
            UnitsInStock = 4,
            UnitsOnOrder = 20,
            ReorderLevel = 5,
            Discontinued = false
          });
      products.Add(75,
          new Product
          {
            ProductName = "Rhönbräu Klosterbier",
            Supplier = Suppliers[12],
            Category = Categories[1],
            QuantityPerUnit = "24 - 0.5 l bottles",
            UnitPrice = 7.75m,
            UnitsInStock = 125,
            UnitsOnOrder = 0,
            ReorderLevel = 25,
            Discontinued = false
          });
      products.Add(76,
          new Product
          {
            ProductName = "Lakkalikööri",
            Supplier = Suppliers[23],
            Category = Categories[1],
            QuantityPerUnit = "500 ml",
            UnitPrice = 18.00m,
            UnitsInStock = 57,
            UnitsOnOrder = 0,
            ReorderLevel = 20,
            Discontinued = false
          });
      products.Add(77,
          new Product
          {
            ProductName = "Original Frankfurter grüne Soße",
            Supplier = Suppliers[12],
            Category = Categories[2],
            QuantityPerUnit = "12 boxes",
            UnitPrice = 13.00m,
            UnitsInStock = 32,
            UnitsOnOrder = 0,
            ReorderLevel = 15,
            Discontinued = false
          });
      products.Add(78,
          new Product
          {
            ProductName = "Coffee",
            Supplier = Suppliers[1],
            Category = Categories[1],
            QuantityPerUnit = "1 boxes",
            UnitPrice = 25.00m,
            UnitsInStock = 32,
            UnitsOnOrder = 0,
            ReorderLevel = 15,
            Discontinued = false
          });

        return products;
      
    }


  }
}