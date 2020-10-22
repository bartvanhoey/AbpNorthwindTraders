using System;
using System.Collections.Generic;

namespace AbpNorthwindTraders.Domain.DataSeeder.Data
{
  public static class OrderData
  {


    public static List<Order> GetOrders()
    {
      var orders = new List<Order>();

      var shippers = ShipperData.GetShippers();
      var employees = EmployeeData.GetEmployees();
      var products = ProductData.GetProducts();

      orders.AddRange(new List<Order>
            {
                new Order
                {
                    CustomerId = "VINET",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Jul  4 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug  1 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 16 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 32.38m,
                    ShipName = "Vins et alcools Chevalier",
                    ShipAddress = "59 rue de l'Abbaye",
                    ShipCity = "Reims",
                    ShipRegion = "",
                    ShipPostalCode = "51100",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 14.00m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[42], UnitPrice = 9.80m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[72], UnitPrice = 34.80m, Quantity = 5, Discount = 0F}
                ),

                new Order
                {
                    CustomerId = "TOMSP",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Jul  5 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 16 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 10 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 11.61m,
                    ShipName = "Toms Spezialitäten",
                    ShipAddress = "Luisenstr. 48",
                    ShipCity = "Münster",
                    ShipRegion = "",
                    ShipPostalCode = "44087",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[14], UnitPrice = 18.60m, Quantity = 9, Discount = 0F},
                    new OrderDetail {Product = products[51], UnitPrice = 42.40m, Quantity = 40, Discount = 0F}),

                new Order
                {
                    CustomerId = "HANAR",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Jul  8 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug  5 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 12 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 65.83m,
                    ShipName = "Hanari Carnes",
                    ShipAddress = "Rua do Paço, 67",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "05454-876",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[41], UnitPrice = 7.70m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[51], UnitPrice = 42.40m, Quantity = 35, Discount = 0.15F},
                    new OrderDetail {Product = products[65], UnitPrice = 16.80m, Quantity = 15, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "VICTE",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Jul  8 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug  5 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 15 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 41.34m,
                    ShipName = "Victuailles en stock",
                    ShipAddress = "2, rue du Commerce",
                    ShipCity = "Lyon",
                    ShipRegion = "",
                    ShipPostalCode = "69004",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[22], UnitPrice = 16.80m, Quantity = 6, Discount = 0.05F},
                    new OrderDetail {Product = products[57], UnitPrice = 15.60m, Quantity = 15, Discount = 0.05F},
                    new OrderDetail {Product = products[65], UnitPrice = 16.80m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "SUPRD",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Jul  9 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug  6 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 11 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 51.30m,
                    ShipName = "Suprêmes délices",
                    ShipAddress = "Boulevard Tirou, 255",
                    ShipCity = "Charleroi",
                    ShipRegion = "",
                    ShipPostalCode = "B-6000",
                    ShipCountry = "Belgium",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[20], UnitPrice = 64.80m, Quantity = 40, Discount = 0.05F},
                    new OrderDetail {Product = products[33], UnitPrice = 2.00m, Quantity = 25, Discount = 0.05F},
                    new OrderDetail {Product = products[60], UnitPrice = 27.20m, Quantity = 40, Discount = 0F}),

                new Order
                {
                    CustomerId = "HANAR",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Jul 10 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul 24 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 16 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 58.17m,
                    ShipName = "Hanari Carnes",
                    ShipAddress = "Rua do Paço, 67",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "05454-876",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[31], UnitPrice = 10.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[39], UnitPrice = 14.40m, Quantity = 42, Discount = 0F},
                    new OrderDetail {Product = products[49], UnitPrice = 16.00m, Quantity = 40, Discount = 0F}),

                new Order
                {
                    CustomerId = "CHOPS",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Jul 11 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug  8 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 23 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 22.98m,
                    ShipName = "Chop-suey Chinese",
                    ShipAddress = "Hauptstr. 31",
                    ShipCity = "Bern",
                    ShipRegion = "",
                    ShipPostalCode = "3012",
                    ShipCountry = "Switzerland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[24], UnitPrice = 3.60m, Quantity = 15, Discount = 0.15F},
                    new OrderDetail {Product = products[55], UnitPrice = 19.20m, Quantity = 21, Discount = 0.15F},
                    new OrderDetail {Product = products[74], UnitPrice = 8.00m, Quantity = 21, Discount = 0F}),

                new Order
                {
                    CustomerId = "RICSU",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Jul 12 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug  9 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 15 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 148.33m,
                    ShipName = "Richter Supermarkt",
                    ShipAddress = "Starenweg 5",
                    ShipCity = "Genève",
                    ShipRegion = "",
                    ShipPostalCode = "1204",
                    ShipCountry = "Switzerland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 15.20m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[16], UnitPrice = 13.90m, Quantity = 35, Discount = 0F},
                    new OrderDetail {Product = products[36], UnitPrice = 15.20m, Quantity = 25, Discount = 0F},
                    new OrderDetail {Product = products[59], UnitPrice = 44.00m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "WELLI",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Jul 15 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 12 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 17 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 13.97m,
                    ShipName = "Wellington Importadora",
                    ShipAddress = "Rua do Mercado, 12",
                    ShipCity = "Resende",
                    ShipRegion = "SP",
                    ShipPostalCode = "08737-363",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[53], UnitPrice = 26.20m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[77], UnitPrice = 10.40m, Quantity = 12, Discount = 0F}),

                new Order
                {
                    CustomerId = "HILAA",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Jul 16 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 13 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 22 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 81.91m,
                    ShipName = "HILARION-Abastos",
                    ShipAddress = "Carrera 22 con Ave. Carlos Soublette #8-35",
                    ShipCity = "San Cristóbal",
                    ShipRegion = "Táchira",
                    ShipPostalCode = "5022",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[27], UnitPrice = 35.10m, Quantity = 25, Discount = 0F},
                    new OrderDetail {Product = products[39], UnitPrice = 14.40m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[77], UnitPrice = 10.40m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "ERNSH",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Jul 17 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 14 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 23 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 140.51m,
                    ShipName = "Ernst Handel",
                    ShipAddress = "Kirchgasse 6",
                    ShipCity = "Graz",
                    ShipRegion = "",
                    ShipPostalCode = "8010",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 15.20m, Quantity = 50, Discount = 0.2F},
                    new OrderDetail {Product = products[5], UnitPrice = 17.00m, Quantity = 65, Discount = 0.2F},
                    new OrderDetail {Product = products[32], UnitPrice = 25.60m, Quantity = 6, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "CENTC",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Jul 18 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 15 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 25 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 3.25m,
                    ShipName = "Centro comercial Moctezuma",
                    ShipAddress = "Sierras de Granada 9993",
                    ShipCity = "México D.F.",
                    ShipRegion = "",
                    ShipPostalCode = "05022",
                    ShipCountry = "Mexico",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[21], UnitPrice = 8.00m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[37], UnitPrice = 20.80m, Quantity = 1, Discount = 0F}),

                new Order
                {
                    CustomerId = "OTTIK",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Jul 19 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 16 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 29 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 55.09m,
                    ShipName = "Ottilies Käseladen",
                    ShipAddress = "Mehrheimerstr. 369",
                    ShipCity = "Köln",
                    ShipRegion = "",
                    ShipPostalCode = "50739",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[41], UnitPrice = 7.70m, Quantity = 16, Discount = 0.25F},
                    new OrderDetail {Product = products[57], UnitPrice = 15.60m, Quantity = 50, Discount = 0F},
                    new OrderDetail {Product = products[62], UnitPrice = 39.40m, Quantity = 15, Discount = 0.25F},
                    new OrderDetail {Product = products[70], UnitPrice = 12.00m, Quantity = 21, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "QUEDE",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Jul 19 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 16 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 30 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 3.05m,
                    ShipName = "Que Delícia",
                    ShipAddress = "Rua da Panificadora, 12",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "02389-673",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[21], UnitPrice = 8.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[35], UnitPrice = 14.40m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "RATTC",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Jul 22 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 19 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 25 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 48.29m,
                    ShipName = "Rattlesnake Canyon Grocery",
                    ShipAddress = "2817 Milton Dr.",
                    ShipCity = "Albuquerque",
                    ShipRegion = "NM",
                    ShipPostalCode = "87110",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[5], UnitPrice = 17.00m, Quantity = 12, Discount = 0.2F},
                    new OrderDetail {Product = products[7], UnitPrice = 24.00m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[56], UnitPrice = 30.40m, Quantity = 2, Discount = 0F}),

                new Order
                {
                    CustomerId = "ERNSH",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Jul 23 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 20 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 31 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 146.06m,
                    ShipName = "Ernst Handel",
                    ShipAddress = "Kirchgasse 6",
                    ShipCity = "Graz",
                    ShipRegion = "",
                    ShipPostalCode = "8010",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[16], UnitPrice = 13.90m, Quantity = 60, Discount = 0.25F},
                    new OrderDetail {Product = products[24], UnitPrice = 3.60m, Quantity = 28, Discount = 0F},
                    new OrderDetail {Product = products[30], UnitPrice = 20.70m, Quantity = 60, Discount = 0.25F},
                    new OrderDetail {Product = products[74], UnitPrice = 8.00m, Quantity = 36, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "FOLKO",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Jul 24 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 21 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 23 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 3.67m,
                    ShipName = "Folk och fä HB",
                    ShipAddress = "Åkergatan 24",
                    ShipCity = "Bräcke",
                    ShipRegion = "",
                    ShipPostalCode = "S-844 67",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 15.20m, Quantity = 35, Discount = 0F},
                    new OrderDetail {Product = products[41], UnitPrice = 7.70m, Quantity = 25, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "BLONP",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Jul 25 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 22 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 12 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 55.28m,
                    ShipName = "Blondel père et fils",
                    ShipAddress = "24, place Kléber",
                    ShipCity = "Strasbourg",
                    ShipRegion = "",
                    ShipPostalCode = "67000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[17], UnitPrice = 31.20m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[70], UnitPrice = 12.00m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "WARTH",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Jul 26 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep  6 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 31 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 25.73m,
                    ShipName = "Wartian Herkku",
                    ShipAddress = "Torikatu 38",
                    ShipCity = "Oulu",
                    ShipRegion = "",
                    ShipPostalCode = "90110",
                    ShipCountry = "Finland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[12], UnitPrice = 30.40m, Quantity = 12, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "FRANK",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Jul 29 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 26 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug  6 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 208.58m,
                    ShipName = "Frankenversand",
                    ShipAddress = "Berliner Platz 43",
                    ShipCity = "München",
                    ShipRegion = "",
                    ShipPostalCode = "80805",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[40], UnitPrice = 14.70m, Quantity = 50, Discount = 0F},
                    new OrderDetail {Product = products[59], UnitPrice = 44.00m, Quantity = 70, Discount = 0.15F},
                    new OrderDetail {Product = products[76], UnitPrice = 14.40m, Quantity = 15, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "GROSR",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Jul 30 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 27 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug  2 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 66.29m,
                    ShipName = "GROSELLA-Restaurante",
                    ShipAddress = "5ª Ave. Los Palos Grandes",
                    ShipCity = "Caracas",
                    ShipRegion = "DF",
                    ShipPostalCode = "1081",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[29], UnitPrice = 99.00m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[72], UnitPrice = 27.80m, Quantity = 4, Discount = 0F}),

                new Order
                {
                    CustomerId = "WHITC",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Jul 31 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 14 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug  9 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 4.56m,
                    ShipName = "White Clover Markets",
                    ShipAddress = "1029 - 12th Ave. S.",
                    ShipCity = "Seattle",
                    ShipRegion = "WA",
                    ShipPostalCode = "98124",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[33], UnitPrice = 2.00m, Quantity = 60, Discount = 0.05F},
                    new OrderDetail {Product = products[72], UnitPrice = 27.80m, Quantity = 20, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "WARTH",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Aug  1 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 29 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug  2 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 136.54m,
                    ShipName = "Wartian Herkku",
                    ShipAddress = "Torikatu 38",
                    ShipCity = "Oulu",
                    ShipRegion = "",
                    ShipPostalCode = "90110",
                    ShipCountry = "Finland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[36], UnitPrice = 15.20m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[43], UnitPrice = 36.80m, Quantity = 25, Discount = 0F}),

                new Order
                {
                    CustomerId = "SPLIR",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Aug  1 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 29 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 30 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 4.54m,
                    ShipName = "Split Rail Beer & Ale",
                    ShipAddress = "P.O. Box 555",
                    ShipCity = "Lander",
                    ShipRegion = "WY",
                    ShipPostalCode = "82520",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[33], UnitPrice = 2.00m, Quantity = 24, Discount = 0F}),

                new Order
                {
                    CustomerId = "RATTC",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Aug  2 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 30 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug  6 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 98.03m,
                    ShipName = "Rattlesnake Canyon Grocery",
                    ShipAddress = "2817 Milton Dr.",
                    ShipCity = "Albuquerque",
                    ShipRegion = "NM",
                    ShipPostalCode = "87110",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[20], UnitPrice = 64.80m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[31], UnitPrice = 10.00m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[72], UnitPrice = 27.80m, Quantity = 24, Discount = 0F}),

                new Order
                {
                    CustomerId = "QUICK",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Aug  5 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep  2 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 12 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 76.07m,
                    ShipName = "QUICK-Stop",
                    ShipAddress = "Taucherstraße 10",
                    ShipCity = "Cunewalde",
                    ShipRegion = "",
                    ShipPostalCode = "01307",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[10], UnitPrice = 24.80m, Quantity = 24, Discount = 0.05F},
                    new OrderDetail {Product = products[31], UnitPrice = 10.00m, Quantity = 15, Discount = 0.05F},
                    new OrderDetail {Product = products[33], UnitPrice = 2.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[40], UnitPrice = 14.70m, Quantity = 60, Discount = 0.05F},
                    new OrderDetail {Product = products[76], UnitPrice = 14.40m, Quantity = 33, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "VINET",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Aug  6 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep  3 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 16 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 6.01m,
                    ShipName = "Vins et alcools Chevalier",
                    ShipAddress = "59 rue de l'Abbaye",
                    ShipCity = "Reims",
                    ShipRegion = "",
                    ShipPostalCode = "51100",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[71], UnitPrice = 17.20m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[72], UnitPrice = 27.80m, Quantity = 7, Discount = 0F}),

                new Order
                {
                    CustomerId = "MAGAA",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Aug  7 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep  4 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug  9 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 26.93m,
                    ShipName = "Magazzini Alimentari Riuniti",
                    ShipAddress = "Via Ludovico il Moro 22",
                    ShipCity = "Bergamo",
                    ShipRegion = "",
                    ShipPostalCode = "24100",
                    ShipCountry = "Italy",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[24], UnitPrice = 3.60m, Quantity = 12, Discount = 0.05F},
                    new OrderDetail {Product = products[59], UnitPrice = 44.00m, Quantity = 6, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "TORTU",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Aug  8 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 22 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 14 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 13.84m,
                    ShipName = "Tortuga Restaurante",
                    ShipAddress = "Avda. Azteca 123",
                    ShipCity = "México D.F.",
                    ShipRegion = "",
                    ShipPostalCode = "05033",
                    ShipCountry = "Mexico",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[10], UnitPrice = 24.80m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[13], UnitPrice = 4.80m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "MORGK",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Aug  9 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep  6 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 13 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 125.77m,
                    ShipName = "Morgenstern Gesundkost",
                    ShipAddress = "Heerstr. 22",
                    ShipCity = "Leipzig",
                    ShipRegion = "",
                    ShipPostalCode = "04179",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[28], UnitPrice = 36.40m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[62], UnitPrice = 39.40m, Quantity = 12, Discount = 0F}),

                new Order
                {
                    CustomerId = "BERGS",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Aug 12 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep  9 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 16 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 92.69m,
                    ShipName = "Berglunds snabbköp",
                    ShipAddress = "Berguvsvägen  8",
                    ShipCity = "Luleå",
                    ShipRegion = "",
                    ShipPostalCode = "S-958 22",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[44], UnitPrice = 15.50m, Quantity = 16, Discount = 0F},
                    new OrderDetail {Product = products[59], UnitPrice = 44.00m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[63], UnitPrice = 35.10m, Quantity = 8, Discount = 0F},
                    new OrderDetail {Product = products[73], UnitPrice = 12.00m, Quantity = 25, Discount = 0F}),

                new Order
                {
                    CustomerId = "LEHMS",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Aug 13 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 10 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 16 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 25.83m,
                    ShipName = "Lehmanns Marktstand",
                    ShipAddress = "Magazinweg 7",
                    ShipCity = "Frankfurt a.M.",
                    ShipRegion = "",
                    ShipPostalCode = "60528",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[17], UnitPrice = 31.20m, Quantity = 15, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "BERGS",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Aug 14 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 11 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 12 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 8.98m,
                    ShipName = "Berglunds snabbköp",
                    ShipAddress = "Berguvsvägen  8",
                    ShipCity = "Luleå",
                    ShipRegion = "",
                    ShipPostalCode = "S-958 22",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[24], UnitPrice = 3.60m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[55], UnitPrice = 19.20m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[75], UnitPrice = 6.20m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "ROMEY",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Aug 14 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 28 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 21 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 2.94m,
                    ShipName = "Romero y tomillo",
                    ShipAddress = "Gran Vía, 1",
                    ShipCity = "Madrid",
                    ShipRegion = "",
                    ShipPostalCode = "28001",
                    ShipCountry = "Spain",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[19], UnitPrice = 7.30m, Quantity = 1, Discount = 0F},
                    new OrderDetail {Product = products[24], UnitPrice = 3.60m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[35], UnitPrice = 14.40m, Quantity = 4, Discount = 0F}),

                new Order
                {
                    CustomerId = "ROMEY",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Aug 15 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 12 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 21 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 12.69m,
                    ShipName = "Romero y tomillo",
                    ShipAddress = "Gran Vía, 1",
                    ShipCity = "Madrid",
                    ShipRegion = "",
                    ShipPostalCode = "28001",
                    ShipCountry = "Spain",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[30], UnitPrice = 20.70m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[57], UnitPrice = 15.60m, Quantity = 2, Discount = 0F}),

                new Order
                {
                    CustomerId = "LILAS",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Aug 16 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 13 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 23 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 84.81m,
                    ShipName = "LILA-Supermercado",
                    ShipAddress = "Carrera 52 con Ave. Bolívar #65-98 Llano Largo",
                    ShipCity = "Barquisimeto",
                    ShipRegion = "Lara",
                    ShipPostalCode = "3508",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[15], UnitPrice = 12.40m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[19], UnitPrice = 7.30m, Quantity = 18, Discount = 0F},
                    new OrderDetail {Product = products[60], UnitPrice = 27.20m, Quantity = 35, Discount = 0F},
                    new OrderDetail {Product = products[72], UnitPrice = 27.80m, Quantity = 3, Discount = 0F}),

                new Order
                {
                    CustomerId = "LEHMS",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Aug 19 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 16 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 27 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 76.56m,
                    ShipName = "Lehmanns Marktstand",
                    ShipAddress = "Magazinweg 7",
                    ShipCity = "Frankfurt a.M.",
                    ShipRegion = "",
                    ShipPostalCode = "60528",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[27], UnitPrice = 35.10m, Quantity = 15, Discount = 0.25F},
                    new OrderDetail {Product = products[44], UnitPrice = 15.50m, Quantity = 21, Discount = 0F},
                    new OrderDetail {Product = products[60], UnitPrice = 27.20m, Quantity = 20, Discount = 0.25F},
                    new OrderDetail {Product = products[67], UnitPrice = 11.20m, Quantity = 5, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "QUICK",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Aug 20 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 17 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 26 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 76.83m,
                    ShipName = "QUICK-Stop",
                    ShipAddress = "Taucherstraße 10",
                    ShipCity = "Cunewalde",
                    ShipRegion = "",
                    ShipPostalCode = "01307",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 14.40m, Quantity = 45, Discount = 0.2F},
                    new OrderDetail {Product = products[40], UnitPrice = 14.70m, Quantity = 40, Discount = 0.2F},
                    new OrderDetail {Product = products[53], UnitPrice = 26.20m, Quantity = 36, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "QUICK",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Aug 21 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 18 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 30 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 229.24m,
                    ShipName = "QUICK-Stop",
                    ShipAddress = "Taucherstraße 10",
                    ShipCity = "Cunewalde",
                    ShipRegion = "",
                    ShipPostalCode = "01307",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[35], UnitPrice = 14.40m, Quantity = 100, Discount = 0F},
                    new OrderDetail {Product = products[62], UnitPrice = 39.40m, Quantity = 40, Discount = 0F}),

                new Order
                {
                    CustomerId = "RICAR",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Aug 22 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 19 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 28 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 12.76m,
                    ShipName = "Ricardo Adocicados",
                    ShipAddress = "Av. Copacabana, 267",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "02389-890",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[16], UnitPrice = 13.90m, Quantity = 40, Discount = 0.15F},
                    new OrderDetail {Product = products[34], UnitPrice = 11.20m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[46], UnitPrice = 9.60m, Quantity = 15, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "REGGC",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Aug 23 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 20 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep  3 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 7.45m,
                    ShipName = "Reggiani Caseifici",
                    ShipAddress = "Strada Provinciale 124",
                    ShipCity = "Reggio Emilia",
                    ShipRegion = "",
                    ShipPostalCode = "42100",
                    ShipCountry = "Italy",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[54], UnitPrice = 5.90m, Quantity = 10, Discount = 0.1F},
                    new OrderDetail {Product = products[68], UnitPrice = 10.00m, Quantity = 3, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "BSBEV",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Aug 26 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 23 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 28 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 22.77m,
                    ShipName = "B's Beverages",
                    ShipAddress = "Fauntleroy Circus",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "EC2 5NT",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[3], UnitPrice = 8.00m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[64], UnitPrice = 26.60m, Quantity = 9, Discount = 0F}),

                new Order
                {
                    CustomerId = "COMMI",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Aug 27 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 24 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep  3 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 79.70m,
                    ShipName = "Comércio Mineiro",
                    ShipAddress = "Av. dos Lusíadas, 23",
                    ShipCity = "Sao Paulo",
                    ShipRegion = "SP",
                    ShipPostalCode = "05432-043",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[5], UnitPrice = 17.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[29], UnitPrice = 99.00m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[49], UnitPrice = 16.00m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[77], UnitPrice = 10.40m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "QUEDE",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Aug 27 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 24 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep  4 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 6.40m,
                    ShipName = "Que Delícia",
                    ShipAddress = "Rua da Panificadora, 12",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "02389-673",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[13], UnitPrice = 4.80m, Quantity = 20, Discount = 0.1F},
                    new OrderDetail {Product = products[44], UnitPrice = 15.50m, Quantity = 24, Discount = 0.1F},
                    new OrderDetail {Product = products[51], UnitPrice = 42.40m, Quantity = 2, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "TRADH",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Aug 28 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 25 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep  2 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 1.35m,
                    ShipName = "Tradiçao Hipermercados",
                    ShipAddress = "Av. Inês de Castro, 414",
                    ShipCity = "Sao Paulo",
                    ShipRegion = "SP",
                    ShipPostalCode = "05634-030",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[20], UnitPrice = 64.80m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "TORTU",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Aug 29 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 26 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 11 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 21.18m,
                    ShipName = "Tortuga Restaurante",
                    ShipAddress = "Avda. Azteca 123",
                    ShipCity = "México D.F.",
                    ShipRegion = "",
                    ShipPostalCode = "05033",
                    ShipCountry = "Mexico",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[18], UnitPrice = 50.00m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[24], UnitPrice = 3.60m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[63], UnitPrice = 35.10m, Quantity = 5, Discount = 0F},
                    new OrderDetail {Product = products[75], UnitPrice = 6.20m, Quantity = 6, Discount = 0F}),

                new Order
                {
                    CustomerId = "RATTC",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Aug 30 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 27 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep  5 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 147.26m,
                    ShipName = "Rattlesnake Canyon Grocery",
                    ShipAddress = "2817 Milton Dr.",
                    ShipCity = "Albuquerque",
                    ShipRegion = "NM",
                    ShipPostalCode = "87110",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 14.40m, Quantity = 18, Discount = 0F},
                    new OrderDetail {Product = products[17], UnitPrice = 31.20m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[43], UnitPrice = 36.80m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[60], UnitPrice = 27.20m, Quantity = 21, Discount = 0F},
                    new OrderDetail {Product = products[75], UnitPrice = 6.20m, Quantity = 6, Discount = 0F}),

                new Order
                {
                    CustomerId = "VINET",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Sep  2 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 30 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 10 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 1.15m,
                    ShipName = "Vins et alcools Chevalier",
                    ShipAddress = "59 rue de l'Abbaye",
                    ShipCity = "Reims",
                    ShipRegion = "",
                    ShipPostalCode = "51100",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[56], UnitPrice = 30.40m, Quantity = 4, Discount = 0F}),

                new Order
                {
                    CustomerId = "LILAS",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Sep  3 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct  1 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 11 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 0.12m,
                    ShipName = "LILA-Supermercado",
                    ShipAddress = "Carrera 52 con Ave. Bolívar #65-98 Llano Largo",
                    ShipCity = "Barquisimeto",
                    ShipRegion = "Lara",
                    ShipPostalCode = "3508",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 16.80m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[16], UnitPrice = 13.90m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[69], UnitPrice = 28.80m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "BLONP",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Sep  4 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 16 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 10 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 5.74m,
                    ShipName = "Blondel père et fils",
                    ShipAddress = "24, place Kléber",
                    ShipCity = "Strasbourg",
                    ShipRegion = "",
                    ShipPostalCode = "67000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[39], UnitPrice = 14.40m, Quantity = 60, Discount = 0F},
                    new OrderDetail {Product = products[72], UnitPrice = 27.80m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "HUNGO",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Sep  5 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct  3 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 11 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 168.22m,
                    ShipName = "Hungry Owl All-Night Grocers",
                    ShipAddress = "8 Johnstown Road",
                    ShipCity = "Cork",
                    ShipRegion = "Co. Cork",
                    ShipPostalCode = "",
                    ShipCountry = "Ireland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 15.20m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[36], UnitPrice = 15.20m, Quantity = 40, Discount = 0.25F},
                    new OrderDetail {Product = products[59], UnitPrice = 44.00m, Quantity = 30, Discount = 0.25F},
                    new OrderDetail {Product = products[62], UnitPrice = 39.40m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "RICAR",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Sep  6 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct  4 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 13 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 29.76m,
                    ShipName = "Ricardo Adocicados",
                    ShipAddress = "Av. Copacabana, 267",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "02389-890",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[19], UnitPrice = 7.30m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[70], UnitPrice = 12.00m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "MAGAA",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Sep  9 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct  7 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 18 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 17.68m,
                    ShipName = "Magazzini Alimentari Riuniti",
                    ShipAddress = "Via Ludovico il Moro 22",
                    ShipCity = "Bergamo",
                    ShipRegion = "",
                    ShipPostalCode = "24100",
                    ShipCountry = "Italy",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[66], UnitPrice = 13.60m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[68], UnitPrice = 10.00m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "WANDK",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Sep  9 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct  7 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 17 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 45.08m,
                    ShipName = "Die Wandernde Kuh",
                    ShipAddress = "Adenauerallee 900",
                    ShipCity = "Stuttgart",
                    ShipRegion = "",
                    ShipPostalCode = "70563",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[40], UnitPrice = 14.70m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[56], UnitPrice = 30.40m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "SUPRD",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Sep 10 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct  8 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct  9 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 6.27m,
                    ShipName = "Suprêmes délices",
                    ShipAddress = "Boulevard Tirou, 255",
                    ShipCity = "Charleroi",
                    ShipRegion = "",
                    ShipPostalCode = "B-6000",
                    ShipCountry = "Belgium",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[17], UnitPrice = 31.20m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[28], UnitPrice = 36.40m, Quantity = 28, Discount = 0F},
                    new OrderDetail {Product = products[43], UnitPrice = 36.80m, Quantity = 12, Discount = 0F}),

                new Order
                {
                    CustomerId = "GODOS",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Sep 11 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct  9 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 18 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 107.83m,
                    ShipName = "Godos Cocina Típica",
                    ShipAddress = "C/ Romero, 33",
                    ShipCity = "Sevilla",
                    ShipRegion = "",
                    ShipPostalCode = "41101",
                    ShipCountry = "Spain",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[40], UnitPrice = 14.70m, Quantity = 40, Discount = 0.1F},
                    new OrderDetail {Product = products[65], UnitPrice = 16.80m, Quantity = 30, Discount = 0.1F},
                    new OrderDetail {Product = products[68], UnitPrice = 10.00m, Quantity = 15, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "TORTU",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Sep 12 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 10 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 17 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 63.79m,
                    ShipName = "Tortuga Restaurante",
                    ShipAddress = "Avda. Azteca 123",
                    ShipCity = "México D.F.",
                    ShipRegion = "",
                    ShipPostalCode = "05033",
                    ShipCountry = "Mexico",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[49], UnitPrice = 16.00m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[59], UnitPrice = 44.00m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[71], UnitPrice = 17.20m, Quantity = 2, Discount = 0F}),

                new Order
                {
                    CustomerId = "OLDWO",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Sep 13 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 11 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct  9 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 257.62m,
                    ShipName = "Old World Delicatessen",
                    ShipAddress = "2743 Bering St.",
                    ShipCity = "Anchorage",
                    ShipRegion = "AK",
                    ShipPostalCode = "99508",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[18], UnitPrice = 50.00m, Quantity = 25, Discount = 0.1F},
                    new OrderDetail {Product = products[29], UnitPrice = 99.00m, Quantity = 25, Discount = 0.1F},
                    new OrderDetail {Product = products[39], UnitPrice = 14.40m, Quantity = 30, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "ROMEY",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Sep 16 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 14 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 23 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 7.56m,
                    ShipName = "Romero y tomillo",
                    ShipAddress = "Gran Vía, 1",
                    ShipCity = "Madrid",
                    ShipRegion = "",
                    ShipPostalCode = "28001",
                    ShipCountry = "Spain",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[30], UnitPrice = 20.70m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[53], UnitPrice = 26.20m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[54], UnitPrice = 5.90m, Quantity = 5, Discount = 0F}),

                new Order
                {
                    CustomerId = "LONEP",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Sep 17 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 15 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 25 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 0.56m,
                    ShipName = "Lonesome Pine Restaurant",
                    ShipAddress = "89 Chiaroscuro Rd.",
                    ShipCity = "Portland",
                    ShipRegion = "OR",
                    ShipPostalCode = "97219",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[62], UnitPrice = 39.40m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[68], UnitPrice = 10.00m, Quantity = 3, Discount = 0F}),

                new Order
                {
                    CustomerId = "ANATR",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Sep 18 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 16 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 24 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 1.61m,
                    ShipName = "Ana Trujillo Emparedados y helados",
                    ShipAddress = "Avda. de la Constitución 2222",
                    ShipCity = "México D.F.",
                    ShipRegion = "",
                    ShipPostalCode = "05021",
                    ShipCountry = "Mexico",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[69], UnitPrice = 28.80m, Quantity = 1, Discount = 0F},
                    new OrderDetail {Product = products[70], UnitPrice = 12.00m, Quantity = 5, Discount = 0F}),

                new Order
                {
                    CustomerId = "HUNGO",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Sep 19 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 17 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 23 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 47.30m,
                    ShipName = "Hungry Owl All-Night Grocers",
                    ShipAddress = "8 Johnstown Road",
                    ShipCity = "Cork",
                    ShipRegion = "Co. Cork",
                    ShipPostalCode = "",
                    ShipCountry = "Ireland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[4], UnitPrice = 17.60m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[6], UnitPrice = 20.00m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[42], UnitPrice = 11.20m, Quantity = 2, Discount = 0F},
                    new OrderDetail {Product = products[43], UnitPrice = 36.80m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[71], UnitPrice = 17.20m, Quantity = 3, Discount = 0F}),

                new Order
                {
                    CustomerId = "THEBI",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Sep 20 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 18 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 27 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 17.52m,
                    ShipName = "The Big Cheese",
                    ShipAddress = "89 Jefferson Way Suite 2",
                    ShipCity = "Portland",
                    ShipRegion = "OR",
                    ShipPostalCode = "97201",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[16], UnitPrice = 13.90m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[62], UnitPrice = 39.40m, Quantity = 5, Discount = 0F}),

                new Order
                {
                    CustomerId = "DUMON",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Sep 20 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct  4 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 26 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 24.69m,
                    ShipName = "Du monde entier",
                    ShipAddress = "67, rue des Cinquante Otages",
                    ShipCity = "Nantes",
                    ShipRegion = "",
                    ShipPostalCode = "44000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[42], UnitPrice = 11.20m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[69], UnitPrice = 28.80m, Quantity = 7, Discount = 0F}),

                new Order
                {
                    CustomerId = "WANDK",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Sep 23 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 21 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct  3 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 40.26m,
                    ShipName = "Die Wandernde Kuh",
                    ShipAddress = "Adenauerallee 900",
                    ShipCity = "Stuttgart",
                    ShipRegion = "",
                    ShipPostalCode = "70563",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[28], UnitPrice = 36.40m, Quantity = 4, Discount = 0F},
                    new OrderDetail {Product = products[43], UnitPrice = 36.80m, Quantity = 24, Discount = 0F},
                    new OrderDetail {Product = products[53], UnitPrice = 26.20m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[75], UnitPrice = 6.20m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "QUICK",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Sep 24 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 22 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct  4 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 1.96m,
                    ShipName = "QUICK-Stop",
                    ShipAddress = "Taucherstraße 10",
                    ShipCity = "Cunewalde",
                    ShipRegion = "",
                    ShipPostalCode = "01307",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[36], UnitPrice = 15.20m, Quantity = 12, Discount = 0F}),

                new Order
                {
                    CustomerId = "RATTC",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Sep 25 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 23 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct  4 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 74.16m,
                    ShipName = "Rattlesnake Canyon Grocery",
                    ShipAddress = "2817 Milton Dr.",
                    ShipCity = "Albuquerque",
                    ShipRegion = "NM",
                    ShipPostalCode = "87110",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[32], UnitPrice = 25.60m, Quantity = 40, Discount = 0.1F},
                    new OrderDetail {Product = products[58], UnitPrice = 10.60m, Quantity = 30, Discount = 0.1F},
                    new OrderDetail {Product = products[62], UnitPrice = 39.40m, Quantity = 25, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "ISLAT",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Sep 26 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 24 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct  3 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 41.76m,
                    ShipName = "Island Trading",
                    ShipAddress = "Garden House Crowther Way",
                    ShipCity = "Cowes",
                    ShipRegion = "Isle of Wight",
                    ShipPostalCode = "PO31 7PJ",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[34], UnitPrice = 11.20m, Quantity = 14, Discount = 0F},
                    new OrderDetail {Product = products[70], UnitPrice = 12.00m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "RATTC",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Sep 27 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 25 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct  8 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 150.15m,
                    ShipName = "Rattlesnake Canyon Grocery",
                    ShipAddress = "2817 Milton Dr.",
                    ShipCity = "Albuquerque",
                    ShipRegion = "NM",
                    ShipPostalCode = "87110",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[41], UnitPrice = 7.70m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[62], UnitPrice = 39.40m, Quantity = 70, Discount = 0F}),

                new Order
                {
                    CustomerId = "LONEP",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Sep 30 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 28 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 10 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 12.69m,
                    ShipName = "Lonesome Pine Restaurant",
                    ShipAddress = "89 Chiaroscuro Rd.",
                    ShipCity = "Portland",
                    ShipRegion = "OR",
                    ShipPostalCode = "97219",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 14.40m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "ISLAT",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Oct  1 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 29 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct  4 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 4.73m,
                    ShipName = "Island Trading",
                    ShipAddress = "Garden House Crowther Way",
                    ShipCity = "Cowes",
                    ShipRegion = "Isle of Wight",
                    ShipPostalCode = "PO31 7PJ",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[41], UnitPrice = 7.70m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[76], UnitPrice = 14.40m, Quantity = 6, Discount = 0F}),

                new Order
                {
                    CustomerId = "TORTU",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Oct  2 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 30 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 11 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 64.50m,
                    ShipName = "Tortuga Restaurante",
                    ShipAddress = "Avda. Azteca 123",
                    ShipCity = "México D.F.",
                    ShipRegion = "",
                    ShipPostalCode = "05033",
                    ShipCountry = "Mexico",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[17], UnitPrice = 31.20m, Quantity = 8, Discount = 0F},
                    new OrderDetail {Product = products[28], UnitPrice = 36.40m, Quantity = 14, Discount = 0F},
                    new OrderDetail {Product = products[76], UnitPrice = 14.40m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "WARTH",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Oct  3 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 17 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 18 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 34.57m,
                    ShipName = "Wartian Herkku",
                    ShipAddress = "Torikatu 38",
                    ShipCity = "Oulu",
                    ShipRegion = "",
                    ShipPostalCode = "90110",
                    ShipCountry = "Finland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[71], UnitPrice = 17.20m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "ISLAT",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Oct  3 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 31 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 11 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 3.43m,
                    ShipName = "Island Trading",
                    ShipAddress = "Garden House Crowther Way",
                    ShipCity = "Cowes",
                    ShipRegion = "Isle of Wight",
                    ShipPostalCode = "PO31 7PJ",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[35], UnitPrice = 14.40m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "PERIC",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Oct  4 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov  1 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 23 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 0.40m,
                    ShipName = "Pericles Comidas clásicas",
                    ShipAddress = "Calle Dr. Jorge Cash 321",
                    ShipCity = "México D.F.",
                    ShipRegion = "",
                    ShipPostalCode = "05033",
                    ShipCountry = "Mexico",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[52], UnitPrice = 5.60m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "KOENE",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Oct  7 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov  4 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 14 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 4.88m,
                    ShipName = "Königlich Essen",
                    ShipAddress = "Maubelstr. 90",
                    ShipCity = "Brandenburg",
                    ShipRegion = "",
                    ShipPostalCode = "14776",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[15], UnitPrice = 12.40m, Quantity = 5, Discount = 0F},
                    new OrderDetail {Product = products[25], UnitPrice = 11.20m, Quantity = 4, Discount = 0F},
                    new OrderDetail {Product = products[39], UnitPrice = 14.40m, Quantity = 4, Discount = 0F}),

                new Order
                {
                    CustomerId = "SAVEA",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Oct  8 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov  5 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 10 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 214.27m,
                    ShipName = "Save-a-lot Markets",
                    ShipAddress = "187 Suffolk Ln.",
                    ShipCity = "Boise",
                    ShipRegion = "ID",
                    ShipPostalCode = "83720",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[16], UnitPrice = 13.90m, Quantity = 21, Discount = 0.15F},
                    new OrderDetail {Product = products[35], UnitPrice = 14.40m, Quantity = 70, Discount = 0.15F},
                    new OrderDetail {Product = products[46], UnitPrice = 9.60m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[59], UnitPrice = 44.00m, Quantity = 40, Discount = 0.15F},
                    new OrderDetail {Product = products[63], UnitPrice = 35.10m, Quantity = 80, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "KOENE",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Oct  9 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 23 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 14 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 64.86m,
                    ShipName = "Königlich Essen",
                    ShipAddress = "Maubelstr. 90",
                    ShipCity = "Brandenburg",
                    ShipRegion = "",
                    ShipPostalCode = "14776",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[6], UnitPrice = 20.00m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[13], UnitPrice = 4.80m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[14], UnitPrice = 18.60m, Quantity = 9, Discount = 0F},
                    new OrderDetail {Product = products[31], UnitPrice = 10.00m, Quantity = 4, Discount = 0F},
                    new OrderDetail {Product = products[72], UnitPrice = 27.80m, Quantity = 40, Discount = 0F}),

                new Order
                {
                    CustomerId = "BOLID",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Oct 10 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov  7 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 14 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 77.92m,
                    ShipName = "Bólido Comidas preparadas",
                    ShipAddress = "C/ Araquil, 67",
                    ShipCity = "Madrid",
                    ShipRegion = "",
                    ShipPostalCode = "28023",
                    ShipCountry = "Spain",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[4], UnitPrice = 17.60m, Quantity = 24, Discount = 0F},
                    new OrderDetail {Product = products[57], UnitPrice = 15.60m, Quantity = 16, Discount = 0F},
                    new OrderDetail {Product = products[75], UnitPrice = 6.20m, Quantity = 50, Discount = 0F}),

                new Order
                {
                    CustomerId = "FOLKO",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Oct 11 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov  8 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 14 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 63.36m,
                    ShipName = "Folk och fä HB",
                    ShipAddress = "Åkergatan 24",
                    ShipCity = "Bräcke",
                    ShipRegion = "",
                    ShipPostalCode = "S-844 67",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 15.20m, Quantity = 25, Discount = 0.2F},
                    new OrderDetail {Product = products[11], UnitPrice = 16.80m, Quantity = 50, Discount = 0.2F},
                    new OrderDetail {Product = products[30], UnitPrice = 20.70m, Quantity = 35, Discount = 0.2F},
                    new OrderDetail {Product = products[58], UnitPrice = 10.60m, Quantity = 30, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "FURIB",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Oct 14 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 11 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 17 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 87.03m,
                    ShipName = "Furia Bacalhau e Frutos do Mar",
                    ShipAddress = "Jardim das rosas n. 32",
                    ShipCity = "Lisboa",
                    ShipRegion = "",
                    ShipPostalCode = "1675",
                    ShipCountry = "Portugal",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[59], UnitPrice = 44.00m, Quantity = 9, Discount = 0F},
                    new OrderDetail {Product = products[65], UnitPrice = 16.80m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[68], UnitPrice = 10.00m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "SPLIR",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Oct 15 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 26 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 23 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 191.67m,
                    ShipName = "Split Rail Beer & Ale",
                    ShipAddress = "P.O. Box 555",
                    ShipCity = "Lander",
                    ShipRegion = "WY",
                    ShipPostalCode = "82520",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[19], UnitPrice = 7.30m, Quantity = 10, Discount = 0.05F},
                    new OrderDetail {Product = products[30], UnitPrice = 20.70m, Quantity = 8, Discount = 0.05F},
                    new OrderDetail {Product = products[38], UnitPrice = 210.80m, Quantity = 20, Discount = 0.05F},
                    new OrderDetail {Product = products[56], UnitPrice = 30.40m, Quantity = 12, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "LILAS",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Oct 16 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 13 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 28 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 12.75m,
                    ShipName = "LILA-Supermercado",
                    ShipAddress = "Carrera 52 con Ave. Bolívar #65-98 Llano Largo",
                    ShipCity = "Barquisimeto",
                    ShipRegion = "Lara",
                    ShipPostalCode = "3508",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[26], UnitPrice = 24.90m, Quantity = 50, Discount = 0.15F},
                    new OrderDetail {Product = products[72], UnitPrice = 27.80m, Quantity = 25, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "BONAP",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Oct 16 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 27 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 21 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 10.19m,
                    ShipName = "Bon app'",
                    ShipAddress = "12, rue des Bouchers",
                    ShipCity = "Marseille",
                    ShipRegion = "",
                    ShipPostalCode = "13008",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[54], UnitPrice = 5.90m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "MEREP",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Oct 17 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 28 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 21 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 52.84m,
                    ShipName = "Mère Paillarde",
                    ShipAddress = "43 rue St. Laurent",
                    ShipCity = "Montréal",
                    ShipRegion = "Québec",
                    ShipPostalCode = "H1J 1C3",
                    ShipCountry = "Canada",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[18], UnitPrice = 50.00m, Quantity = 40, Discount = 0.2F},
                    new OrderDetail {Product = products[42], UnitPrice = 11.20m, Quantity = 10, Discount = 0.2F},
                    new OrderDetail {Product = products[47], UnitPrice = 7.60m, Quantity = 16, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "WARTH",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Oct 18 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 15 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 25 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 0.59m,
                    ShipName = "Wartian Herkku",
                    ShipAddress = "Torikatu 38",
                    ShipCity = "Oulu",
                    ShipRegion = "",
                    ShipPostalCode = "90110",
                    ShipCountry = "Finland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[14], UnitPrice = 18.60m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[21], UnitPrice = 8.00m, Quantity = 10, Discount = 0.1F},
                    new OrderDetail {Product = products[71], UnitPrice = 17.20m, Quantity = 40, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "VICTE",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Oct 21 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 18 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 28 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 8.56m,
                    ShipName = "Victuailles en stock",
                    ShipAddress = "2, rue du Commerce",
                    ShipCity = "Lyon",
                    ShipRegion = "",
                    ShipPostalCode = "69004",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[52], UnitPrice = 5.60m, Quantity = 8, Discount = 0F},
                    new OrderDetail {Product = products[68], UnitPrice = 10.00m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "HUNGO",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Oct 22 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 19 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 24 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 42.11m,
                    ShipName = "Hungry Owl All-Night Grocers",
                    ShipAddress = "8 Johnstown Road",
                    ShipCity = "Cork",
                    ShipRegion = "Co. Cork",
                    ShipPostalCode = "",
                    ShipCountry = "Ireland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 15.20m, Quantity = 7, Discount = 0.2F},
                    new OrderDetail {Product = products[31], UnitPrice = 10.00m, Quantity = 25, Discount = 0.2F},
                    new OrderDetail {Product = products[32], UnitPrice = 25.60m, Quantity = 6, Discount = 0.2F},
                    new OrderDetail {Product = products[51], UnitPrice = 42.40m, Quantity = 48, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "PRINI",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Oct 23 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 20 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 25 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 15.51m,
                    ShipName = "Princesa Isabel Vinhos",
                    ShipAddress = "Estrada da saúde n. 58",
                    ShipCity = "Lisboa",
                    ShipRegion = "",
                    ShipPostalCode = "1756",
                    ShipCountry = "Portugal",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[4], UnitPrice = 17.60m, Quantity = 18, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "FRANK",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Oct 24 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 21 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 29 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 108.26m,
                    ShipName = "Frankenversand",
                    ShipAddress = "Berliner Platz 43",
                    ShipCity = "München",
                    ShipRegion = "",
                    ShipPostalCode = "80805",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[23], UnitPrice = 7.20m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[26], UnitPrice = 24.90m, Quantity = 24, Discount = 0F},
                    new OrderDetail {Product = products[36], UnitPrice = 15.20m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[37], UnitPrice = 20.80m, Quantity = 28, Discount = 0F},
                    new OrderDetail {Product = products[72], UnitPrice = 27.80m, Quantity = 25, Discount = 0F}),

                new Order
                {
                    CustomerId = "OLDWO",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Oct 25 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 22 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 29 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 84.21m,
                    ShipName = "Old World Delicatessen",
                    ShipAddress = "2743 Bering St.",
                    ShipCity = "Anchorage",
                    ShipRegion = "AK",
                    ShipPostalCode = "99508",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[17], UnitPrice = 31.20m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[30], UnitPrice = 20.70m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "MEREP",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Oct 28 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 25 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov  4 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 15.66m,
                    ShipName = "Mère Paillarde",
                    ShipAddress = "43 rue St. Laurent",
                    ShipCity = "Montréal",
                    ShipRegion = "Québec",
                    ShipPostalCode = "H1J 1C3",
                    ShipCountry = "Canada",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[4], UnitPrice = 17.60m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[17], UnitPrice = 31.20m, Quantity = 70, Discount = 0.05F},
                    new OrderDetail {Product = products[62], UnitPrice = 39.40m, Quantity = 28, Discount = 0F}),

                new Order
                {
                    CustomerId = "BONAP",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Oct 29 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 26 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov  8 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 166.31m,
                    ShipName = "Bon app'",
                    ShipAddress = "12, rue des Bouchers",
                    ShipCity = "Marseille",
                    ShipRegion = "",
                    ShipPostalCode = "13008",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[18], UnitPrice = 50.00m, Quantity = 20, Discount = 0.05F},
                    new OrderDetail {Product = products[41], UnitPrice = 7.70m, Quantity = 12, Discount = 0.05F},
                    new OrderDetail {Product = products[43], UnitPrice = 36.80m, Quantity = 40, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "SIMOB",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Oct 29 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 26 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov  5 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 26.78m,
                    ShipName = "Simons bistro",
                    ShipAddress = "Vinbæltet 34",
                    ShipCity = "Kobenhavn",
                    ShipRegion = "",
                    ShipPostalCode = "1734",
                    ShipCountry = "Denmark",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[33], UnitPrice = 2.00m, Quantity = 8, Discount = 0F},
                    new OrderDetail {Product = products[59], UnitPrice = 44.00m, Quantity = 9, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "FRANK",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Oct 30 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 13 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov  4 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 54.83m,
                    ShipName = "Frankenversand",
                    ShipAddress = "Berliner Platz 43",
                    ShipCity = "München",
                    ShipRegion = "",
                    ShipPostalCode = "80805",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 15.20m, Quantity = 24, Discount = 0.2F},
                    new OrderDetail {Product = products[31], UnitPrice = 10.00m, Quantity = 56, Discount = 0.2F},
                    new OrderDetail {Product = products[36], UnitPrice = 15.20m, Quantity = 40, Discount = 0.2F},
                    new OrderDetail {Product = products[55], UnitPrice = 19.20m, Quantity = 40, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "LEHMS",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Oct 31 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 28 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov  6 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 110.37m,
                    ShipName = "Lehmanns Marktstand",
                    ShipAddress = "Magazinweg 7",
                    ShipCity = "Frankfurt a.M.",
                    ShipRegion = "",
                    ShipPostalCode = "60528",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[64], UnitPrice = 26.60m, Quantity = 50, Discount = 0F},
                    new OrderDetail {Product = products[68], UnitPrice = 10.00m, Quantity = 4, Discount = 0.05F},
                    new OrderDetail {Product = products[76], UnitPrice = 14.40m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "WHITC",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Nov  1 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 29 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov  5 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 23.29m,
                    ShipName = "White Clover Markets",
                    ShipAddress = "1029 - 12th Ave. S.",
                    ShipCity = "Seattle",
                    ShipRegion = "WA",
                    ShipPostalCode = "98124",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[4], UnitPrice = 17.60m, Quantity = 35, Discount = 0F},
                    new OrderDetail {Product = products[8], UnitPrice = 32.00m, Quantity = 70, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "QUICK",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Nov  4 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec  2 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 11 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 249.06m,
                    ShipName = "QUICK-Stop",
                    ShipAddress = "Taucherstraße 10",
                    ShipCity = "Cunewalde",
                    ShipRegion = "",
                    ShipPostalCode = "01307",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[8], UnitPrice = 32.00m, Quantity = 70, Discount = 0F},
                    new OrderDetail {Product = products[19], UnitPrice = 7.30m, Quantity = 80, Discount = 0F},
                    new OrderDetail {Product = products[42], UnitPrice = 11.20m, Quantity = 9, Discount = 0F}),

                new Order
                {
                    CustomerId = "RATTC",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Nov  5 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 17 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov  8 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 142.08m,
                    ShipName = "Rattlesnake Canyon Grocery",
                    ShipAddress = "2817 Milton Dr.",
                    ShipCity = "Albuquerque",
                    ShipRegion = "NM",
                    ShipPostalCode = "87110",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[17], UnitPrice = 31.20m, Quantity = 36, Discount = 0.1F},
                    new OrderDetail {Product = products[56], UnitPrice = 30.40m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "FAMIA",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Nov  6 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec  4 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov  8 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 3.10m,
                    ShipName = "Familia Arquibaldo",
                    ShipAddress = "Rua Orós, 92",
                    ShipCity = "Sao Paulo",
                    ShipRegion = "SP",
                    ShipPostalCode = "05442-030",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[25], UnitPrice = 11.20m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[39], UnitPrice = 14.40m, Quantity = 50, Discount = 0.15F},
                    new OrderDetail {Product = products[40], UnitPrice = 14.70m, Quantity = 4, Discount = 0F},
                    new OrderDetail {Product = products[75], UnitPrice = 6.20m, Quantity = 6, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "WANDK",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Nov  7 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec  5 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 15 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 0.78m,
                    ShipName = "Die Wandernde Kuh",
                    ShipAddress = "Adenauerallee 900",
                    ShipCity = "Stuttgart",
                    ShipRegion = "",
                    ShipPostalCode = "70563",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 14.40m, Quantity = 15, Discount = 0.15F},
                    new OrderDetail {Product = products[23], UnitPrice = 7.20m, Quantity = 25, Discount = 0F}),

                new Order
                {
                    CustomerId = "SPLIR",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Nov  8 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec  6 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 15 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 8.63m,
                    ShipName = "Split Rail Beer & Ale",
                    ShipAddress = "P.O. Box 555",
                    ShipCity = "Lander",
                    ShipRegion = "WY",
                    ShipPostalCode = "82520",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[54], UnitPrice = 5.90m, Quantity = 24, Discount = 0F}),

                new Order
                {
                    CustomerId = "LAMAI",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Nov 11 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec  9 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec  3 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 64.19m,
                    ShipName = "La maison d'Asie",
                    ShipAddress = "1 rue Alsace-Lorraine",
                    ShipCity = "Toulouse",
                    ShipRegion = "",
                    ShipPostalCode = "31000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[50], UnitPrice = 13.00m, Quantity = 15, Discount = 0.1F},
                    new OrderDetail {Product = products[69], UnitPrice = 28.80m, Quantity = 18, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "ERNSH",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Nov 11 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec  9 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 20 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 162.33m,
                    ShipName = "Ernst Handel",
                    ShipAddress = "Kirchgasse 6",
                    ShipCity = "Graz",
                    ShipRegion = "",
                    ShipPostalCode = "8010",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[38], UnitPrice = 210.80m, Quantity = 20, Discount = 0.05F},
                    new OrderDetail {Product = products[41], UnitPrice = 7.70m, Quantity = 13, Discount = 0F},
                    new OrderDetail {Product = products[44], UnitPrice = 15.50m, Quantity = 77, Discount = 0.05F},
                    new OrderDetail {Product = products[65], UnitPrice = 16.80m, Quantity = 10, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "FURIB",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Nov 12 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 26 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 18 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 1.30m,
                    ShipName = "Furia Bacalhau e Frutos do Mar",
                    ShipAddress = "Jardim das rosas n. 32",
                    ShipCity = "Lisboa",
                    ShipRegion = "",
                    ShipPostalCode = "1675",
                    ShipCountry = "Portugal",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[24], UnitPrice = 3.60m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[54], UnitPrice = 5.90m, Quantity = 20, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "PICCO",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Nov 13 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 11 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 25 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 360.63m,
                    ShipName = "Piccolo und mehr",
                    ShipAddress = "Geislweg 14",
                    ShipCity = "Salzburg",
                    ShipRegion = "",
                    ShipPostalCode = "5020",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 16.80m, Quantity = 12, Discount = 0.2F},
                    new OrderDetail {Product = products[38], UnitPrice = 210.80m, Quantity = 50, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "PERIC",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Nov 14 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 12 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 20 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 53.80m,
                    ShipName = "Pericles Comidas clásicas",
                    ShipAddress = "Calle Dr. Jorge Cash 321",
                    ShipCity = "México D.F.",
                    ShipRegion = "",
                    ShipPostalCode = "05033",
                    ShipCountry = "Mexico",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 14.40m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[29], UnitPrice = 99.00m, Quantity = 4, Discount = 0F}),

                new Order
                {
                    CustomerId = "AROUT",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Nov 15 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 13 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 20 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 41.95m,
                    ShipName = "Around the Horn",
                    ShipAddress = "Brook Farm Stratford St. Mary",
                    ShipCity = "Colchester",
                    ShipRegion = "Essex",
                    ShipPostalCode = "CO7 6JX",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[24], UnitPrice = 3.60m, Quantity = 25, Discount = 0F},
                    new OrderDetail {Product = products[57], UnitPrice = 15.60m, Quantity = 25, Discount = 0F}),

                new Order
                {
                    CustomerId = "WANDK",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Nov 18 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 16 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 27 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 36.71m,
                    ShipName = "Die Wandernde Kuh",
                    ShipAddress = "Adenauerallee 900",
                    ShipCity = "Stuttgart",
                    ShipRegion = "",
                    ShipPostalCode = "70563",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[31], UnitPrice = 10.00m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[55], UnitPrice = 19.20m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[69], UnitPrice = 28.80m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "LILAS",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Nov 19 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 17 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec  2 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 34.88m,
                    ShipName = "LILA-Supermercado",
                    ShipAddress = "Carrera 52 con Ave. Bolívar #65-98 Llano Largo",
                    ShipCity = "Barquisimeto",
                    ShipRegion = "Lara",
                    ShipPostalCode = "3508",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[10], UnitPrice = 24.80m, Quantity = 30, Discount = 0.2F},
                    new OrderDetail {Product = products[26], UnitPrice = 24.90m, Quantity = 16, Discount = 0F},
                    new OrderDetail {Product = products[60], UnitPrice = 27.20m, Quantity = 8, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "LAMAI",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Nov 20 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 18 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 27 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 19.64m,
                    ShipName = "La maison d'Asie",
                    ShipAddress = "1 rue Alsace-Lorraine",
                    ShipCity = "Toulouse",
                    ShipRegion = "",
                    ShipPostalCode = "31000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[24], UnitPrice = 3.60m, Quantity = 10, Discount = 0.05F},
                    new OrderDetail {Product = products[34], UnitPrice = 11.20m, Quantity = 10, Discount = 0.05F},
                    new OrderDetail {Product = products[36], UnitPrice = 15.20m, Quantity = 20, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "SEVES",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Nov 21 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 19 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 26 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 288.43m,
                    ShipName = "Seven Seas Imports",
                    ShipAddress = "90 Wadhurst Rd.",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "OX15 4NB",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[16], UnitPrice = 13.90m, Quantity = 56, Discount = 0.05F},
                    new OrderDetail {Product = products[31], UnitPrice = 10.00m, Quantity = 70, Discount = 0.05F},
                    new OrderDetail {Product = products[60], UnitPrice = 27.20m, Quantity = 80, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "BLONP",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Nov 22 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 20 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec  2 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 131.70m,
                    ShipName = "Blondel père et fils",
                    ShipAddress = "24, place Kléber",
                    ShipCity = "Strasbourg",
                    ShipRegion = "",
                    ShipPostalCode = "67000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[28], UnitPrice = 36.40m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[29], UnitPrice = 99.00m, Quantity = 35, Discount = 0F},
                    new OrderDetail {Product = products[38], UnitPrice = 210.80m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[49], UnitPrice = 16.00m, Quantity = 35, Discount = 0F},
                    new OrderDetail {Product = products[54], UnitPrice = 5.90m, Quantity = 28, Discount = 0F}),

                new Order
                {
                    CustomerId = "QUICK",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Nov 22 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 20 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec  3 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 183.17m,
                    ShipName = "QUICK-Stop",
                    ShipAddress = "Taucherstraße 10",
                    ShipCity = "Cunewalde",
                    ShipRegion = "",
                    ShipPostalCode = "01307",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[39], UnitPrice = 14.40m, Quantity = 54, Discount = 0.1F},
                    new OrderDetail {Product = products[60], UnitPrice = 27.20m, Quantity = 55, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "BONAP",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Nov 25 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 23 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 28 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 96.04m,
                    ShipName = "Bon app'",
                    ShipAddress = "12, rue des Bouchers",
                    ShipCity = "Marseille",
                    ShipRegion = "",
                    ShipPostalCode = "13008",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[25], UnitPrice = 11.20m, Quantity = 50, Discount = 0F},
                    new OrderDetail {Product = products[51], UnitPrice = 42.40m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[54], UnitPrice = 5.90m, Quantity = 24, Discount = 0F}),

                new Order
                {
                    CustomerId = "DRACD",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Nov 26 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 24 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec  4 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 30.54m,
                    ShipName = "Drachenblut Delikatessen",
                    ShipAddress = "Walserweg 21",
                    ShipCity = "Aachen",
                    ShipRegion = "",
                    ShipPostalCode = "52066",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[31], UnitPrice = 10.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[75], UnitPrice = 6.20m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[76], UnitPrice = 14.40m, Quantity = 12, Discount = 0F}),

                new Order
                {
                    CustomerId = "EASTC",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Nov 26 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan  7 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec  4 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 71.97m,
                    ShipName = "Eastern Connection",
                    ShipAddress = "35 King George",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "WX3 6FW",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[69], UnitPrice = 28.80m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[71], UnitPrice = 17.20m, Quantity = 5, Discount = 0F}),

                new Order
                {
                    CustomerId = "ANTON",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Nov 27 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 25 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec  2 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 22.00m,
                    ShipName = "Antonio Moreno Taquería",
                    ShipAddress = "Mataderos  2312",
                    ShipCity = "México D.F.",
                    ShipRegion = "",
                    ShipPostalCode = "05023",
                    ShipCountry = "Mexico",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 16.80m, Quantity = 24, Discount = 0F}),

                new Order
                {
                    CustomerId = "GALED",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Nov 28 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan  9 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 30 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 10.14m,
                    ShipName = "Galería del gastronómo",
                    ShipAddress = "Rambla de Cataluña, 23",
                    ShipCity = "Barcelona",
                    ShipRegion = "",
                    ShipPostalCode = "8022",
                    ShipCountry = "Spain",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[65], UnitPrice = 16.80m, Quantity = 5, Discount = 0F},
                    new OrderDetail {Product = products[77], UnitPrice = 10.40m, Quantity = 5, Discount = 0F}),

                new Order
                {
                    CustomerId = "VAFFE",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Nov 28 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 26 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec  2 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 13.55m,
                    ShipName = "Vaffeljernet",
                    ShipAddress = "Smagsloget 45",
                    ShipCity = "Århus",
                    ShipRegion = "",
                    ShipPostalCode = "8200",
                    ShipCountry = "Denmark",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[34], UnitPrice = 11.20m, Quantity = 36, Discount = 0F},
                    new OrderDetail {Product = products[54], UnitPrice = 5.90m, Quantity = 18, Discount = 0F},
                    new OrderDetail {Product = products[65], UnitPrice = 16.80m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[77], UnitPrice = 10.40m, Quantity = 7, Discount = 0F}),

                new Order
                {
                    CustomerId = "ERNSH",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Nov 29 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 27 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec  2 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 101.95m,
                    ShipName = "Ernst Handel",
                    ShipAddress = "Kirchgasse 6",
                    ShipCity = "Graz",
                    ShipRegion = "",
                    ShipPostalCode = "8010",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[21], UnitPrice = 8.00m, Quantity = 5, Discount = 0.1F},
                    new OrderDetail {Product = products[28], UnitPrice = 36.40m, Quantity = 13, Discount = 0.1F},
                    new OrderDetail {Product = products[57], UnitPrice = 15.60m, Quantity = 25, Discount = 0F},
                    new OrderDetail {Product = products[64], UnitPrice = 26.60m, Quantity = 35, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "SPLIR",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Dec  2 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 30 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec  9 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 195.68m,
                    ShipName = "Split Rail Beer & Ale",
                    ShipAddress = "P.O. Box 555",
                    ShipCity = "Lander",
                    ShipRegion = "WY",
                    ShipPostalCode = "82520",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[29], UnitPrice = 99.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[56], UnitPrice = 30.40m, Quantity = 18, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "CHOPS",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Dec  3 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 31 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 27 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 1.17m,
                    ShipName = "Chop-suey Chinese",
                    ShipAddress = "Hauptstr. 31",
                    ShipCity = "Bern",
                    ShipRegion = "",
                    ShipPostalCode = "3012",
                    ShipCountry = "Switzerland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 14.40m, Quantity = 15, Discount = 0.15F},
                    new OrderDetail {Product = products[64], UnitPrice = 26.60m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[74], UnitPrice = 8.00m, Quantity = 20, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "LAMAI",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Dec  3 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 31 1996 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 24 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 0.45m,
                    ShipName = "La maison d'Asie",
                    ShipAddress = "1 rue Alsace-Lorraine",
                    ShipCity = "Toulouse",
                    ShipRegion = "",
                    ShipPostalCode = "31000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[36], UnitPrice = 15.20m, Quantity = 6, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "QUEEN",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Dec  4 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan  1 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec  9 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 890.78m,
                    ShipName = "Queen Cozinha",
                    ShipAddress = "Alameda dos Canàrios, 891",
                    ShipCity = "Sao Paulo",
                    ShipRegion = "SP",
                    ShipPostalCode = "05487-020",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[20], UnitPrice = 64.80m, Quantity = 12, Discount = 0.25F},
                    new OrderDetail {Product = products[38], UnitPrice = 210.80m, Quantity = 40, Discount = 0.25F},
                    new OrderDetail {Product = products[60], UnitPrice = 27.20m, Quantity = 70, Discount = 0.25F},
                    new OrderDetail {Product = products[72], UnitPrice = 27.80m, Quantity = 42, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "HUNGO",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Dec  5 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan  2 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 11 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 124.12m,
                    ShipName = "Hungry Owl All-Night Grocers",
                    ShipAddress = "8 Johnstown Road",
                    ShipCity = "Cork",
                    ShipRegion = "Co. Cork",
                    ShipPostalCode = "",
                    ShipCountry = "Ireland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[58], UnitPrice = 10.60m, Quantity = 80, Discount = 0.2F},
                    new OrderDetail {Product = products[71], UnitPrice = 17.20m, Quantity = 50, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "WOLZA",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Dec  5 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan  2 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec  9 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 3.94m,
                    ShipName = "Wolski Zajazd",
                    ShipAddress = "ul. Filtrowa 68",
                    ShipCity = "Warszawa",
                    ShipRegion = "",
                    ShipPostalCode = "01-012",
                    ShipCountry = "Poland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[31], UnitPrice = 10.00m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[58], UnitPrice = 10.60m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "HUNGC",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Dec  6 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan  3 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec  9 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 20.12m,
                    ShipName = "Hungry Coyote Import Store",
                    ShipAddress = "City Center Plaza 516 Main St.",
                    ShipCity = "Elgin",
                    ShipRegion = "OR",
                    ShipPostalCode = "97827",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[14], UnitPrice = 18.60m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[54], UnitPrice = 5.90m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "MEREP",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Dec  9 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan  6 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 13 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 20.39m,
                    ShipName = "Mère Paillarde",
                    ShipAddress = "43 rue St. Laurent",
                    ShipCity = "Montréal",
                    ShipRegion = "Québec",
                    ShipPostalCode = "H1J 1C3",
                    ShipCountry = "Canada",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[31], UnitPrice = 10.00m, Quantity = 42, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "SEVES",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Dec  9 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan  6 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 13 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 22.21m,
                    ShipName = "Seven Seas Imports",
                    ShipAddress = "90 Wadhurst Rd.",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "OX15 4NB",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[28], UnitPrice = 36.40m, Quantity = 20, Discount = 0.15F},
                    new OrderDetail {Product = products[39], UnitPrice = 14.40m, Quantity = 20, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "FOLKO",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Dec 10 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan  7 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 19 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 5.44m,
                    ShipName = "Folk och fä HB",
                    ShipAddress = "Åkergatan 24",
                    ShipCity = "Bräcke",
                    ShipRegion = "",
                    ShipPostalCode = "S-844 67",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[71], UnitPrice = 17.20m, Quantity = 6, Discount = 0F}),

                new Order
                {
                    CustomerId = "QUEDE",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Dec 11 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan  8 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 13 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 45.03m,
                    ShipName = "Que Delícia",
                    ShipAddress = "Rua da Panificadora, 12",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "02389-673",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[41], UnitPrice = 7.70m, Quantity = 8, Discount = 0.1F},
                    new OrderDetail {Product = products[63], UnitPrice = 35.10m, Quantity = 16, Discount = 0.1F},
                    new OrderDetail {Product = products[65], UnitPrice = 16.80m, Quantity = 20, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "HUNGO",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Dec 12 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan  9 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 16 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 35.03m,
                    ShipName = "Hungry Owl All-Night Grocers",
                    ShipAddress = "8 Johnstown Road",
                    ShipCity = "Cork",
                    ShipRegion = "Co. Cork",
                    ShipPostalCode = "",
                    ShipCountry = "Ireland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[30], UnitPrice = 20.70m, Quantity = 18, Discount = 0.1F},
                    new OrderDetail {Product = products[53], UnitPrice = 26.20m, Quantity = 20, Discount = 0.1F},
                    new OrderDetail {Product = products[60], UnitPrice = 27.20m, Quantity = 6, Discount = 0.1F},
                    new OrderDetail {Product = products[70], UnitPrice = 12.00m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "LILAS",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Dec 12 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan  9 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 13 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 7.99m,
                    ShipName = "LILA-Supermercado",
                    ShipAddress = "Carrera 52 con Ave. Bolívar #65-98 Llano Largo",
                    ShipCity = "Barquisimeto",
                    ShipRegion = "Lara",
                    ShipPostalCode = "3508",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[74], UnitPrice = 8.00m, Quantity = 14, Discount = 0F}),

                new Order
                {
                    CustomerId = "ERNSH",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Dec 13 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 10 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 16 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 94.77m,
                    ShipName = "Ernst Handel",
                    ShipAddress = "Kirchgasse 6",
                    ShipCity = "Graz",
                    ShipRegion = "",
                    ShipPostalCode = "8010",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[5], UnitPrice = 17.00m, Quantity = 32, Discount = 0F},
                    new OrderDetail {Product = products[18], UnitPrice = 50.00m, Quantity = 9, Discount = 0F},
                    new OrderDetail {Product = products[29], UnitPrice = 99.00m, Quantity = 14, Discount = 0F},
                    new OrderDetail {Product = products[33], UnitPrice = 2.00m, Quantity = 60, Discount = 0F},
                    new OrderDetail {Product = products[74], UnitPrice = 8.00m, Quantity = 50, Discount = 0F}),

                new Order
                {
                    CustomerId = "AROUT",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Dec 16 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 13 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 18 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 34.24m,
                    ShipName = "Around the Horn",
                    ShipAddress = "Brook Farm Stratford St. Mary",
                    ShipCity = "Colchester",
                    ShipRegion = "Essex",
                    ShipPostalCode = "CO7 6JX",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[13], UnitPrice = 4.80m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[50], UnitPrice = 13.00m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[56], UnitPrice = 30.40m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "BERGS",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Dec 16 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 13 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 20 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 168.64m,
                    ShipName = "Berglunds snabbköp",
                    ShipAddress = "Berguvsvägen  8",
                    ShipCity = "Luleå",
                    ShipRegion = "",
                    ShipPostalCode = "S-958 22",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[20], UnitPrice = 64.80m, Quantity = 28, Discount = 0F},
                    new OrderDetail {Product = products[60], UnitPrice = 27.20m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "SPLIR",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Dec 17 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 14 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 23 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 30.96m,
                    ShipName = "Split Rail Beer & Ale",
                    ShipAddress = "P.O. Box 555",
                    ShipCity = "Lander",
                    ShipRegion = "WY",
                    ShipPostalCode = "82520",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[7], UnitPrice = 24.00m, Quantity = 10, Discount = 0.2F},
                    new OrderDetail {Product = products[60], UnitPrice = 27.20m, Quantity = 20, Discount = 0.2F},
                    new OrderDetail {Product = products[68], UnitPrice = 10.00m, Quantity = 8, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "FAMIA",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Dec 18 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan  1 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 25 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 13.99m,
                    ShipName = "Familia Arquibaldo",
                    ShipAddress = "Rua Orós, 92",
                    ShipCity = "Sao Paulo",
                    ShipRegion = "SP",
                    ShipPostalCode = "05442-030",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[24], UnitPrice = 3.60m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[34], UnitPrice = 11.20m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "SANTG",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Dec 18 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 15 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 20 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 93.63m,
                    ShipName = "Santé Gourmet",
                    ShipAddress = "Erling Skakkes gate 78",
                    ShipCity = "Stavern",
                    ShipRegion = "",
                    ShipPostalCode = "4110",
                    ShipCountry = "Norway",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[24], UnitPrice = 3.60m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[28], UnitPrice = 36.40m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[59], UnitPrice = 44.00m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[71], UnitPrice = 17.20m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "SEVES",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Dec 19 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 16 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 20 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 34.86m,
                    ShipName = "Seven Seas Imports",
                    ShipAddress = "90 Wadhurst Rd.",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "OX15 4NB",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[45], UnitPrice = 7.60m, Quantity = 15, Discount = 0.2F},
                    new OrderDetail {Product = products[52], UnitPrice = 5.60m, Quantity = 20, Discount = 0.2F},
                    new OrderDetail {Product = products[53], UnitPrice = 26.20m, Quantity = 40, Discount = 0F}),

                new Order
                {
                    CustomerId = "BOTTM",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Dec 20 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 17 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 24 1996 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 47.42m,
                    ShipName = "Bottom-Dollar Markets",
                    ShipAddress = "23 Tsawassen Blvd.",
                    ShipCity = "Tsawassen",
                    ShipRegion = "BC",
                    ShipPostalCode = "T2F 8M4",
                    ShipCountry = "Canada",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[10], UnitPrice = 24.80m, Quantity = 16, Discount = 0F},
                    new OrderDetail {Product = products[55], UnitPrice = 19.20m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[62], UnitPrice = 39.40m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[70], UnitPrice = 12.00m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "ERNSH",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Dec 23 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 20 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 26 1996 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 126.38m,
                    ShipName = "Ernst Handel",
                    ShipAddress = "Kirchgasse 6",
                    ShipCity = "Graz",
                    ShipRegion = "",
                    ShipPostalCode = "8010",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[31], UnitPrice = 10.00m, Quantity = 60, Discount = 0.1F},
                    new OrderDetail {Product = products[35], UnitPrice = 14.40m, Quantity = 40, Discount = 0.1F},
                    new OrderDetail {Product = products[46], UnitPrice = 9.60m, Quantity = 45, Discount = 0F},
                    new OrderDetail {Product = products[72], UnitPrice = 27.80m, Quantity = 24, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "DRACD",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Dec 23 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 20 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 31 1996 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 5.45m,
                    ShipName = "Drachenblut Delikatessen",
                    ShipAddress = "Walserweg 21",
                    ShipCity = "Aachen",
                    ShipRegion = "",
                    ShipPostalCode = "52066",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[13], UnitPrice = 4.80m, Quantity = 18, Discount = 0F}),

                new Order
                {
                    CustomerId = "PICCO",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Dec 24 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 21 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan  1 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 122.46m,
                    ShipName = "Piccolo und mehr",
                    ShipAddress = "Geislweg 14",
                    ShipCity = "Salzburg",
                    ShipRegion = "",
                    ShipPostalCode = "5020",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[69], UnitPrice = 28.80m, Quantity = 50, Discount = 0F}),

                new Order
                {
                    CustomerId = "SAVEA",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Dec 25 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 22 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan  3 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 126.56m,
                    ShipName = "Save-a-lot Markets",
                    ShipAddress = "187 Suffolk Ln.",
                    ShipCity = "Boise",
                    ShipRegion = "ID",
                    ShipPostalCode = "83720",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 15.20m, Quantity = 25, Discount = 0.25F},
                    new OrderDetail {Product = products[14], UnitPrice = 18.60m, Quantity = 42, Discount = 0.25F},
                    new OrderDetail {Product = products[25], UnitPrice = 11.20m, Quantity = 7, Discount = 0.25F},
                    new OrderDetail {Product = products[26], UnitPrice = 24.90m, Quantity = 70, Discount = 0.25F},
                    new OrderDetail {Product = products[31], UnitPrice = 10.00m, Quantity = 32, Discount = 0F}),

                new Order
                {
                    CustomerId = "HUNGC",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Dec 25 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 22 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan  3 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 30.34m,
                    ShipName = "Hungry Coyote Import Store",
                    ShipAddress = "City Center Plaza 516 Main St.",
                    ShipCity = "Elgin",
                    ShipRegion = "OR",
                    ShipPostalCode = "97827",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[13], UnitPrice = 4.80m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[62], UnitPrice = 39.40m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "HILAA",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Dec 26 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 23 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan  3 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 184.41m,
                    ShipName = "HILARION-Abastos",
                    ShipAddress = "Carrera 22 con Ave. Carlos Soublette #8-35",
                    ShipCity = "San Cristóbal",
                    ShipRegion = "Táchira",
                    ShipPostalCode = "5022",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[46], UnitPrice = 9.60m, Quantity = 28, Discount = 0.1F},
                    new OrderDetail {Product = products[53], UnitPrice = 26.20m, Quantity = 70, Discount = 0.1F},
                    new OrderDetail {Product = products[69], UnitPrice = 28.80m, Quantity = 8, Discount = 0F}),

                new Order
                {
                    CustomerId = "FRANK",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Dec 27 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 10 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan  6 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 135.35m,
                    ShipName = "Frankenversand",
                    ShipAddress = "Berliner Platz 43",
                    ShipCity = "München",
                    ShipRegion = "",
                    ShipPostalCode = "80805",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[23], UnitPrice = 7.20m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[71], UnitPrice = 17.20m, Quantity = 60, Discount = 0F},
                    new OrderDetail {Product = products[72], UnitPrice = 27.80m, Quantity = 21, Discount = 0F}),

                new Order
                {
                    CustomerId = "PRINI",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Dec 27 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 24 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan  2 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 60.26m,
                    ShipName = "Princesa Isabel Vinhos",
                    ShipAddress = "Estrada da saúde n. 58",
                    ShipCity = "Lisboa",
                    ShipRegion = "",
                    ShipPostalCode = "1756",
                    ShipCountry = "Portugal",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[21], UnitPrice = 8.00m, Quantity = 10, Discount = 0.15F},
                    new OrderDetail {Product = products[51], UnitPrice = 42.40m, Quantity = 18, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "SAVEA",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Dec 30 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 27 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan  9 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 89.16m,
                    ShipName = "Save-a-lot Markets",
                    ShipAddress = "187 Suffolk Ln.",
                    ShipCity = "Boise",
                    ShipRegion = "ID",
                    ShipPostalCode = "83720",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[35], UnitPrice = 14.40m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[55], UnitPrice = 19.20m, Quantity = 120, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "VAFFE",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Dec 31 1996 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 14 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan  8 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 27.36m,
                    ShipName = "Vaffeljernet",
                    ShipAddress = "Smagsloget 45",
                    ShipCity = "Århus",
                    ShipRegion = "",
                    ShipPostalCode = "8200",
                    ShipCountry = "Denmark",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[68], UnitPrice = 10.00m, Quantity = 60, Discount = 0F},
                    new OrderDetail {Product = products[71], UnitPrice = 17.20m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[76], UnitPrice = 14.40m, Quantity = 35, Discount = 0F},
                    new OrderDetail {Product = products[77], UnitPrice = 10.40m, Quantity = 14, Discount = 0F}),

                new Order
                {
                    CustomerId = "EASTC",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Jan  1 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 29 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 16 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 83.93m,
                    ShipName = "Eastern Connection",
                    ShipAddress = "35 King George",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "WX3 6FW",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[29], UnitPrice = 99.00m, Quantity = 21, Discount = 0F},
                    new OrderDetail {Product = products[35], UnitPrice = 14.40m, Quantity = 35, Discount = 0F},
                    new OrderDetail {Product = products[49], UnitPrice = 16.00m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "RATTC",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Jan  1 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 29 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 10 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 12.51m,
                    ShipName = "Rattlesnake Canyon Grocery",
                    ShipAddress = "2817 Milton Dr.",
                    ShipCity = "Albuquerque",
                    ShipRegion = "NM",
                    ShipPostalCode = "87110",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[30], UnitPrice = 20.70m, Quantity = 18, Discount = 0F},
                    new OrderDetail {Product = products[56], UnitPrice = 30.40m, Quantity = 70, Discount = 0F},
                    new OrderDetail {Product = products[65], UnitPrice = 16.80m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[71], UnitPrice = 17.20m, Quantity = 60, Discount = 0F}),

                new Order
                {
                    CustomerId = "ERNSH",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Jan  2 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 13 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 10 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 67.88m,
                    ShipName = "Ernst Handel",
                    ShipAddress = "Kirchgasse 6",
                    ShipCity = "Graz",
                    ShipRegion = "",
                    ShipPostalCode = "8010",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[23], UnitPrice = 7.20m, Quantity = 60, Discount = 0F},
                    new OrderDetail {Product = products[63], UnitPrice = 35.10m, Quantity = 65, Discount = 0F}),

                new Order
                {
                    CustomerId = "ERNSH",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Jan  3 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 31 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan  9 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 73.79m,
                    ShipName = "Ernst Handel",
                    ShipAddress = "Kirchgasse 6",
                    ShipCity = "Graz",
                    ShipRegion = "",
                    ShipPostalCode = "8010",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[16], UnitPrice = 13.90m, Quantity = 21, Discount = 0.15F},
                    new OrderDetail {Product = products[48], UnitPrice = 10.20m, Quantity = 70, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "MAGAA",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Jan  3 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 31 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan  8 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 155.97m,
                    ShipName = "Magazzini Alimentari Riuniti",
                    ShipAddress = "Via Ludovico il Moro 22",
                    ShipCity = "Bergamo",
                    ShipRegion = "",
                    ShipPostalCode = "24100",
                    ShipCountry = "Italy",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[26], UnitPrice = 24.90m, Quantity = 30, Discount = 0.05F},
                    new OrderDetail {Product = products[42], UnitPrice = 11.20m, Quantity = 40, Discount = 0.05F},
                    new OrderDetail {Product = products[49], UnitPrice = 16.00m, Quantity = 30, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "LINOD",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Jan  6 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb  3 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 22 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 34.82m,
                    ShipName = "LINO-Delicateses",
                    ShipAddress = "Ave. 5 de Mayo Porlamar",
                    ShipCity = "I. de Margarita",
                    ShipRegion = "Nueva Esparta",
                    ShipPostalCode = "4980",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[3], UnitPrice = 8.00m, Quantity = 50, Discount = 0F}),

                new Order
                {
                    CustomerId = "QUEEN",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Jan  7 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 18 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 13 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 108.04m,
                    ShipName = "Queen Cozinha",
                    ShipAddress = "Alameda dos Canàrios, 891",
                    ShipCity = "Sao Paulo",
                    ShipRegion = "SP",
                    ShipPostalCode = "05487-020",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 14.40m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[21], UnitPrice = 8.00m, Quantity = 30, Discount = 0.1F},
                    new OrderDetail {Product = products[28], UnitPrice = 36.40m, Quantity = 42, Discount = 0.1F},
                    new OrderDetail {Product = products[36], UnitPrice = 15.20m, Quantity = 5, Discount = 0.1F},
                    new OrderDetail {Product = products[40], UnitPrice = 14.70m, Quantity = 2, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "OTTIK",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Jan  7 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb  4 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 30 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 91.48m,
                    ShipName = "Ottilies Käseladen",
                    ShipAddress = "Mehrheimerstr. 369",
                    ShipCity = "Köln",
                    ShipRegion = "",
                    ShipPostalCode = "50739",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 16.80m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[69], UnitPrice = 28.80m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[71], UnitPrice = 17.20m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "FOLIG",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Jan  8 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb  5 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 14 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 11.26m,
                    ShipName = "Folies gourmandes",
                    ShipAddress = "184, chaussée de Tournai",
                    ShipCity = "Lille",
                    ShipRegion = "",
                    ShipPostalCode = "59000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[37], UnitPrice = 20.80m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[54], UnitPrice = 5.90m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[62], UnitPrice = 39.40m, Quantity = 35, Discount = 0F}),

                new Order
                {
                    CustomerId = "OCEAN",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Jan  9 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb  6 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 14 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 29.83m,
                    ShipName = "Océano Atlántico Ltda.",
                    ShipAddress = "Ing. Gustavo Moncada 8585 Piso 20-A",
                    ShipCity = "Buenos Aires",
                    ShipRegion = "",
                    ShipPostalCode = "1010",
                    ShipCountry = "Argentina",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[14], UnitPrice = 18.60m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[21], UnitPrice = 8.00m, Quantity = 12, Discount = 0F}),

                new Order
                {
                    CustomerId = "BOTTM",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Jan 10 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb  7 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 15 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 2.40m,
                    ShipName = "Bottom-Dollar Markets",
                    ShipAddress = "23 Tsawassen Blvd.",
                    ShipCity = "Tsawassen",
                    ShipRegion = "BC",
                    ShipPostalCode = "T2F 8M4",
                    ShipCountry = "Canada",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[33], UnitPrice = 2.00m, Quantity = 49, Discount = 0F},
                    new OrderDetail {Product = products[59], UnitPrice = 44.00m, Quantity = 16, Discount = 0F}),

                new Order
                {
                    CustomerId = "BOTTM",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Jan 10 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb  7 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 21 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 23.65m,
                    ShipName = "Bottom-Dollar Markets",
                    ShipAddress = "23 Tsawassen Blvd.",
                    ShipCity = "Tsawassen",
                    ShipRegion = "BC",
                    ShipPostalCode = "T2F 8M4",
                    ShipCountry = "Canada",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[41], UnitPrice = 7.70m, Quantity = 25, Discount = 0.2F},
                    new OrderDetail {Product = products[44], UnitPrice = 15.50m, Quantity = 40, Discount = 0.2F},
                    new OrderDetail {Product = products[59], UnitPrice = 44.00m, Quantity = 9, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "WARTH",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Jan 13 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 10 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 15 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 3.77m,
                    ShipName = "Wartian Herkku",
                    ShipAddress = "Torikatu 38",
                    ShipCity = "Oulu",
                    ShipRegion = "",
                    ShipPostalCode = "90110",
                    ShipCountry = "Finland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[14], UnitPrice = 18.60m, Quantity = 20, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "LAMAI",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Jan 14 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 11 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 16 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 95.66m,
                    ShipName = "La maison d'Asie",
                    ShipAddress = "1 rue Alsace-Lorraine",
                    ShipCity = "Toulouse",
                    ShipRegion = "",
                    ShipPostalCode = "31000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 14.40m, Quantity = 24, Discount = 0F},
                    new OrderDetail {Product = products[62], UnitPrice = 39.40m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[76], UnitPrice = 14.40m, Quantity = 14, Discount = 0F}),

                new Order
                {
                    CustomerId = "FAMIA",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Jan 14 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 11 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 17 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 21.48m,
                    ShipName = "Familia Arquibaldo",
                    ShipAddress = "Rua Orós, 92",
                    ShipCity = "Sao Paulo",
                    ShipRegion = "SP",
                    ShipPostalCode = "05442-030",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[19], UnitPrice = 7.30m, Quantity = 18, Discount = 0.05F},
                    new OrderDetail {Product = products[33], UnitPrice = 2.00m, Quantity = 50, Discount = 0F}),

                new Order
                {
                    CustomerId = "HUNGC",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Jan 15 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 12 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 24 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 0.20m,
                    ShipName = "Hungry Coyote Import Store",
                    ShipAddress = "City Center Plaza 516 Main St.",
                    ShipCity = "Elgin",
                    ShipRegion = "OR",
                    ShipPostalCode = "97827",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[17], UnitPrice = 31.20m, Quantity = 2, Discount = 0F},
                    new OrderDetail {Product = products[33], UnitPrice = 2.00m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "WARTH",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Jan 16 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 13 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 27 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 22.72m,
                    ShipName = "Wartian Herkku",
                    ShipAddress = "Torikatu 38",
                    ShipCity = "Oulu",
                    ShipRegion = "",
                    ShipPostalCode = "90110",
                    ShipCountry = "Finland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[19], UnitPrice = 7.30m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[53], UnitPrice = 26.20m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[57], UnitPrice = 15.60m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "SIMOB",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Jan 16 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 13 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 28 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 70.29m,
                    ShipName = "Simons bistro",
                    ShipAddress = "Vinbæltet 34",
                    ShipCity = "Kobenhavn",
                    ShipRegion = "",
                    ShipPostalCode = "1734",
                    ShipCountry = "Denmark",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[38], UnitPrice = 210.80m, Quantity = 50, Discount = 0F},
                    new OrderDetail {Product = products[46], UnitPrice = 9.60m, Quantity = 2, Discount = 0.25F},
                    new OrderDetail {Product = products[68], UnitPrice = 10.00m, Quantity = 36, Discount = 0.25F},
                    new OrderDetail {Product = products[77], UnitPrice = 10.40m, Quantity = 35, Discount = 0F}),

                new Order
                {
                    CustomerId = "QUICK",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Jan 17 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 14 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 24 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 17.55m,
                    ShipName = "QUICK-Stop",
                    ShipAddress = "Taucherstraße 10",
                    ShipCity = "Cunewalde",
                    ShipRegion = "",
                    ShipPostalCode = "01307",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 15.20m, Quantity = 60, Discount = 0F},
                    new OrderDetail {Product = products[47], UnitPrice = 7.60m, Quantity = 55, Discount = 0F},
                    new OrderDetail {Product = products[61], UnitPrice = 22.80m, Quantity = 16, Discount = 0F},
                    new OrderDetail {Product = products[74], UnitPrice = 8.00m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "RICSU",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Jan 20 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 17 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 30 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 137.35m,
                    ShipName = "Richter Supermarkt",
                    ShipAddress = "Starenweg 5",
                    ShipCity = "Genève",
                    ShipRegion = "",
                    ShipPostalCode = "1204",
                    ShipCountry = "Switzerland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[60], UnitPrice = 27.20m, Quantity = 60, Discount = 0.05F},
                    new OrderDetail {Product = products[69], UnitPrice = 28.80m, Quantity = 20, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "WELLI",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Jan 21 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 18 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 27 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 44.12m,
                    ShipName = "Wellington Importadora",
                    ShipAddress = "Rua do Mercado, 12",
                    ShipCity = "Resende",
                    ShipRegion = "SP",
                    ShipPostalCode = "08737-363",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[9], UnitPrice = 77.60m, Quantity = 20, Discount = 0.1F},
                    new OrderDetail {Product = products[13], UnitPrice = 4.80m, Quantity = 2, Discount = 0.1F},
                    new OrderDetail {Product = products[70], UnitPrice = 12.00m, Quantity = 8, Discount = 0.1F},
                    new OrderDetail {Product = products[73], UnitPrice = 12.00m, Quantity = 20, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "QUEDE",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Jan 21 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar  4 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 27 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 99.23m,
                    ShipName = "Que Delícia",
                    ShipAddress = "Rua da Panificadora, 12",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "02389-673",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[19], UnitPrice = 7.30m, Quantity = 4, Discount = 0.15F},
                    new OrderDetail {Product = products[26], UnitPrice = 24.90m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[53], UnitPrice = 26.20m, Quantity = 15, Discount = 0.15F},
                    new OrderDetail {Product = products[77], UnitPrice = 10.40m, Quantity = 10, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "FRANS",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Jan 22 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 19 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 31 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 3.02m,
                    ShipName = "Franchi S.p.A.",
                    ShipAddress = "Via Monte Bianco 34",
                    ShipCity = "Torino",
                    ShipRegion = "",
                    ShipPostalCode = "10100",
                    ShipCountry = "Italy",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[26], UnitPrice = 24.90m, Quantity = 2, Discount = 0F}),

                new Order
                {
                    CustomerId = "GOURL",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Jan 23 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb  6 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 24 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 24.50m,
                    ShipName = "Gourmet Lanchonetes",
                    ShipAddress = "Av. Brasil, 442",
                    ShipCity = "Campinas",
                    ShipRegion = "SP",
                    ShipPostalCode = "04876-786",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[31], UnitPrice = 10.00m, Quantity = 14, Discount = 0F},
                    new OrderDetail {Product = products[59], UnitPrice = 44.00m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "MEREP",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Jan 23 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 20 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 27 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 370.61m,
                    ShipName = "Mère Paillarde",
                    ShipAddress = "43 rue St. Laurent",
                    ShipCity = "Montréal",
                    ShipRegion = "Québec",
                    ShipPostalCode = "H1J 1C3",
                    ShipCountry = "Canada",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[35], UnitPrice = 14.40m, Quantity = 60, Discount = 0.2F},
                    new OrderDetail {Product = products[38], UnitPrice = 210.80m, Quantity = 49, Discount = 0.2F},
                    new OrderDetail {Product = products[68], UnitPrice = 10.00m, Quantity = 30, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "LAMAI",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Jan 24 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 21 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 14 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 7.93m,
                    ShipName = "La maison d'Asie",
                    ShipAddress = "1 rue Alsace-Lorraine",
                    ShipCity = "Toulouse",
                    ShipRegion = "",
                    ShipPostalCode = "31000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[55], UnitPrice = 19.20m, Quantity = 10, Discount = 0.25F},
                    new OrderDetail {Product = products[76], UnitPrice = 14.40m, Quantity = 20, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "GALED",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Jan 27 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 24 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb  6 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 18.69m,
                    ShipName = "Galería del gastronómo",
                    ShipAddress = "Rambla de Cataluña, 23",
                    ShipCity = "Barcelona",
                    ShipRegion = "",
                    ShipPostalCode = "8022",
                    ShipCountry = "Spain",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[56], UnitPrice = 30.40m, Quantity = 5, Discount = 0F},
                    new OrderDetail {Product = products[64], UnitPrice = 26.60m, Quantity = 7, Discount = 0F}),

                new Order
                {
                    CustomerId = "PICCO",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Jan 27 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 24 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar  3 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 31.29m,
                    ShipName = "Piccolo und mehr",
                    ShipAddress = "Geislweg 14",
                    ShipCity = "Salzburg",
                    ShipRegion = "",
                    ShipPostalCode = "5020",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[14], UnitPrice = 18.60m, Quantity = 35, Discount = 0F}),

                new Order
                {
                    CustomerId = "REGGC",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Jan 28 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 25 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb  4 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 11.09m,
                    ShipName = "Reggiani Caseifici",
                    ShipAddress = "Strada Provinciale 124",
                    ShipCity = "Reggio Emilia",
                    ShipRegion = "",
                    ShipPostalCode = "42100",
                    ShipCountry = "Italy",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[46], UnitPrice = 9.60m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "HUNGO",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Jan 29 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 12 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb  7 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 56.63m,
                    ShipName = "Hungry Owl All-Night Grocers",
                    ShipAddress = "8 Johnstown Road",
                    ShipCity = "Cork",
                    ShipRegion = "Co. Cork",
                    ShipPostalCode = "",
                    ShipCountry = "Ireland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[50], UnitPrice = 13.00m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[63], UnitPrice = 35.10m, Quantity = 35, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "ERNSH",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Jan 30 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 13 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb  3 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 458.78m,
                    ShipName = "Ernst Handel",
                    ShipAddress = "Kirchgasse 6",
                    ShipCity = "Graz",
                    ShipRegion = "",
                    ShipPostalCode = "8010",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[17], UnitPrice = 31.20m, Quantity = 45, Discount = 0.2F},
                    new OrderDetail {Product = products[21], UnitPrice = 8.00m, Quantity = 50, Discount = 0F},
                    new OrderDetail {Product = products[56], UnitPrice = 30.40m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[59], UnitPrice = 44.00m, Quantity = 70, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "BOTTM",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Jan 30 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 13 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb  7 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 44.17m,
                    ShipName = "Bottom-Dollar Markets",
                    ShipAddress = "23 Tsawassen Blvd.",
                    ShipCity = "Tsawassen",
                    ShipRegion = "BC",
                    ShipPostalCode = "T2F 8M4",
                    ShipCountry = "Canada",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[17], UnitPrice = 31.20m, Quantity = 50, Discount = 0.25F},
                    new OrderDetail {Product = products[40], UnitPrice = 14.70m, Quantity = 50, Discount = 0.25F},
                    new OrderDetail {Product = products[47], UnitPrice = 7.60m, Quantity = 30, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "SPLIR",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Jan 31 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 14 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb  7 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 4.34m,
                    ShipName = "Split Rail Beer & Ale",
                    ShipAddress = "P.O. Box 555",
                    ShipCity = "Lander",
                    ShipRegion = "WY",
                    ShipPostalCode = "82520",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[26], UnitPrice = 24.90m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[54], UnitPrice = 5.90m, Quantity = 40, Discount = 0F}),

                new Order
                {
                    CustomerId = "PRINI",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Feb  3 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar  3 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar  4 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 73.83m,
                    ShipName = "Princesa Isabel Vinhos",
                    ShipAddress = "Estrada da saúde n. 58",
                    ShipCity = "Lisboa",
                    ShipRegion = "",
                    ShipPostalCode = "1756",
                    ShipCountry = "Portugal",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[56], UnitPrice = 30.40m, Quantity = 28, Discount = 0F}),

                new Order
                {
                    CustomerId = "FOLKO",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Feb  3 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar  3 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 13 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 17.92m,
                    ShipName = "Folk och fä HB",
                    ShipAddress = "Åkergatan 24",
                    ShipCity = "Bräcke",
                    ShipRegion = "",
                    ShipPostalCode = "S-844 67",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 16.80m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[76], UnitPrice = 14.40m, Quantity = 18, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "CONSH",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Feb  4 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 18 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb  7 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 9.21m,
                    ShipName = "Consolidated Holdings",
                    ShipAddress = "Berkeley Gardens 12  Brewery",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "WX1 6LT",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 15.20m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[22], UnitPrice = 16.80m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[72], UnitPrice = 27.80m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "BLONP",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Feb  5 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar  5 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 11 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 156.66m,
                    ShipName = "Blondel père et fils",
                    ShipAddress = "24, place Kléber",
                    ShipCity = "Strasbourg",
                    ShipRegion = "",
                    ShipPostalCode = "67000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[46], UnitPrice = 9.60m, Quantity = 5, Discount = 0F},
                    new OrderDetail {Product = products[56], UnitPrice = 30.40m, Quantity = 40, Discount = 0.1F},
                    new OrderDetail {Product = products[64], UnitPrice = 26.60m, Quantity = 30, Discount = 0.1F},
                    new OrderDetail {Product = products[75], UnitPrice = 6.20m, Quantity = 24, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "WARTH",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Feb  5 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar  5 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 12 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 19.97m,
                    ShipName = "Wartian Herkku",
                    ShipAddress = "Torikatu 38",
                    ShipCity = "Oulu",
                    ShipRegion = "",
                    ShipPostalCode = "90110",
                    ShipCountry = "Finland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[53], UnitPrice = 26.20m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "TOMSP",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Feb  6 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar  6 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 14 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 8.24m,
                    ShipName = "Toms Spezialitäten",
                    ShipAddress = "Luisenstr. 48",
                    ShipCity = "Münster",
                    ShipRegion = "",
                    ShipPostalCode = "44087",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[19], UnitPrice = 7.30m, Quantity = 15, Discount = 0.2F},
                    new OrderDetail {Product = products[34], UnitPrice = 11.20m, Quantity = 20, Discount = 0.2F},
                    new OrderDetail {Product = products[57], UnitPrice = 15.60m, Quantity = 15, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "MEREP",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Feb  7 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar  7 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 10 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 4.07m,
                    ShipName = "Mère Paillarde",
                    ShipAddress = "43 rue St. Laurent",
                    ShipCity = "Montréal",
                    ShipRegion = "Québec",
                    ShipPostalCode = "H1J 1C3",
                    ShipCountry = "Canada",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[12], UnitPrice = 30.40m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[16], UnitPrice = 13.90m, Quantity = 16, Discount = 0F},
                    new OrderDetail {Product = products[64], UnitPrice = 26.60m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[74], UnitPrice = 8.00m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "SAVEA",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Feb 10 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 10 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 28 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 86.53m,
                    ShipName = "Save-a-lot Markets",
                    ShipAddress = "187 Suffolk Ln.",
                    ShipCity = "Boise",
                    ShipRegion = "ID",
                    ShipPostalCode = "83720",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 15.20m, Quantity = 45, Discount = 0.15F},
                    new OrderDetail {Product = products[16], UnitPrice = 13.90m, Quantity = 49, Discount = 0.15F},
                    new OrderDetail {Product = products[29], UnitPrice = 99.00m, Quantity = 24, Discount = 0.15F},
                    new OrderDetail {Product = products[61], UnitPrice = 22.80m, Quantity = 90, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "OLDWO",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Feb 10 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 24 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 14 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 73.02m,
                    ShipName = "Old World Delicatessen",
                    ShipAddress = "2743 Bering St.",
                    ShipCity = "Anchorage",
                    ShipRegion = "AK",
                    ShipPostalCode = "99508",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[27], UnitPrice = 35.10m, Quantity = 50, Discount = 0F}),

                new Order
                {
                    CustomerId = "ERNSH",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Feb 11 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 11 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 18 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 47.94m,
                    ShipName = "Ernst Handel",
                    ShipAddress = "Kirchgasse 6",
                    ShipCity = "Graz",
                    ShipRegion = "",
                    ShipPostalCode = "8010",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 16.80m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[54], UnitPrice = 5.90m, Quantity = 80, Discount = 0F},
                    new OrderDetail {Product = products[66], UnitPrice = 13.60m, Quantity = 60, Discount = 0F}),

                new Order
                {
                    CustomerId = "REGGC",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Feb 12 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 12 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 14 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 13.95m,
                    ShipName = "Reggiani Caseifici",
                    ShipAddress = "Strada Provinciale 124",
                    ShipCity = "Reggio Emilia",
                    ShipRegion = "",
                    ShipPostalCode = "42100",
                    ShipCountry = "Italy",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 16.80m, Quantity = 6, Discount = 0.2F},
                    new OrderDetail {Product = products[28], UnitPrice = 36.40m, Quantity = 12, Discount = 0F}),

                new Order
                {
                    CustomerId = "BERGS",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Feb 12 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 12 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 21 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 3.50m,
                    ShipName = "Berglunds snabbköp",
                    ShipAddress = "Berguvsvägen  8",
                    ShipCity = "Luleå",
                    ShipRegion = "",
                    ShipPostalCode = "S-958 22",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[17], UnitPrice = 31.20m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[26], UnitPrice = 24.90m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[35], UnitPrice = 14.40m, Quantity = 8, Discount = 0F},
                    new OrderDetail {Product = products[41], UnitPrice = 7.70m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "BERGS",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Feb 13 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 13 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 20 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 9.30m,
                    ShipName = "Berglunds snabbköp",
                    ShipAddress = "Berguvsvägen  8",
                    ShipCity = "Luleå",
                    ShipRegion = "",
                    ShipPostalCode = "S-958 22",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[39], UnitPrice = 14.40m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[54], UnitPrice = 5.90m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "TOMSP",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Feb 14 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 14 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 19 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 14.68m,
                    ShipName = "Toms Spezialitäten",
                    ShipAddress = "Luisenstr. 48",
                    ShipCity = "Münster",
                    ShipRegion = "",
                    ShipPostalCode = "44087",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[19], UnitPrice = 7.30m, Quantity = 12, Discount = 0.1F},
                    new OrderDetail {Product = products[24], UnitPrice = 3.60m, Quantity = 20, Discount = 0.1F},
                    new OrderDetail {Product = products[31], UnitPrice = 10.00m, Quantity = 3, Discount = 0.1F},
                    new OrderDetail {Product = products[52], UnitPrice = 5.60m, Quantity = 15, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "RICAR",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Feb 14 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 14 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar  7 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 68.66m,
                    ShipName = "Ricardo Adocicados",
                    ShipAddress = "Av. Copacabana, 267",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "02389-890",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[19], UnitPrice = 7.30m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[65], UnitPrice = 16.80m, Quantity = 35, Discount = 0F},
                    new OrderDetail {Product = products[71], UnitPrice = 17.20m, Quantity = 2, Discount = 0F}),

                new Order
                {
                    CustomerId = "RANCH",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Feb 17 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 17 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 24 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 38.82m,
                    ShipName = "Rancho grande",
                    ShipAddress = "Av. del Libertador 900",
                    ShipCity = "Buenos Aires",
                    ShipRegion = "",
                    ShipPostalCode = "1010",
                    ShipCountry = "Argentina",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[26], UnitPrice = 24.90m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[40], UnitPrice = 14.70m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "BLONP",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Feb 18 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 18 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 27 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 53.30m,
                    ShipName = "Blondel père et fils",
                    ShipAddress = "24, place Kléber",
                    ShipCity = "Strasbourg",
                    ShipRegion = "",
                    ShipPostalCode = "67000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[10], UnitPrice = 24.80m, Quantity = 14, Discount = 0F},
                    new OrderDetail {Product = products[52], UnitPrice = 5.60m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[62], UnitPrice = 39.40m, Quantity = 35, Discount = 0F}),

                new Order
                {
                    CustomerId = "VICTE",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Feb 19 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 19 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 11 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 7.23m,
                    ShipName = "Victuailles en stock",
                    ShipAddress = "2, rue du Commerce",
                    ShipCity = "Lyon",
                    ShipRegion = "",
                    ShipPostalCode = "69004",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[10], UnitPrice = 24.80m, Quantity = 20, Discount = 0.2F},
                    new OrderDetail {Product = products[54], UnitPrice = 5.90m, Quantity = 6, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "QUICK",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Feb 19 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar  5 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 12 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 189.09m,
                    ShipName = "QUICK-Stop",
                    ShipAddress = "Taucherstraße 10",
                    ShipCity = "Cunewalde",
                    ShipRegion = "",
                    ShipPostalCode = "01307",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[55], UnitPrice = 19.20m, Quantity = 120, Discount = 0.1F},
                    new OrderDetail {Product = products[64], UnitPrice = 26.60m, Quantity = 35, Discount = 0.1F},
                    new OrderDetail {Product = products[65], UnitPrice = 16.80m, Quantity = 28, Discount = 0.1F},
                    new OrderDetail {Product = products[77], UnitPrice = 10.40m, Quantity = 55, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "SAVEA",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Feb 20 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 20 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 26 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 140.26m,
                    ShipName = "Save-a-lot Markets",
                    ShipAddress = "187 Suffolk Ln.",
                    ShipCity = "Boise",
                    ShipRegion = "ID",
                    ShipPostalCode = "83720",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[28], UnitPrice = 36.40m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[44], UnitPrice = 15.50m, Quantity = 100, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "AROUT",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Feb 21 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 21 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 26 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 25.36m,
                    ShipName = "Around the Horn",
                    ShipAddress = "Brook Farm Stratford St. Mary",
                    ShipCity = "Colchester",
                    ShipRegion = "Essex",
                    ShipPostalCode = "CO7 6JX",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[48], UnitPrice = 10.20m, Quantity = 15, Discount = 0.1F},
                    new OrderDetail {Product = products[70], UnitPrice = 12.00m, Quantity = 25, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "LAMAI",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Feb 21 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 21 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 25 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 2.74m,
                    ShipName = "La maison d'Asie",
                    ShipAddress = "1 rue Alsace-Lorraine",
                    ShipCity = "Toulouse",
                    ShipRegion = "",
                    ShipPostalCode = "31000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[16], UnitPrice = 13.90m, Quantity = 20, Discount = 0.2F},
                    new OrderDetail {Product = products[33], UnitPrice = 2.00m, Quantity = 20, Discount = 0.2F},
                    new OrderDetail {Product = products[46], UnitPrice = 9.60m, Quantity = 10, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "WARTH",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Feb 24 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  7 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar  3 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 180.45m,
                    ShipName = "Wartian Herkku",
                    ShipAddress = "Torikatu 38",
                    ShipCity = "Oulu",
                    ShipRegion = "",
                    ShipPostalCode = "90110",
                    ShipCountry = "Finland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[39], UnitPrice = 14.40m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[53], UnitPrice = 26.20m, Quantity = 50, Discount = 0F},
                    new OrderDetail {Product = products[61], UnitPrice = 22.80m, Quantity = 25, Discount = 0F},
                    new OrderDetail {Product = products[71], UnitPrice = 17.20m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "KOENE",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Feb 25 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  8 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 28 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 8.12m,
                    ShipName = "Königlich Essen",
                    ShipAddress = "Maubelstr. 90",
                    ShipCity = "Brandenburg",
                    ShipRegion = "",
                    ShipPostalCode = "14776",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[21], UnitPrice = 8.00m, Quantity = 40, Discount = 0.15F},
                    new OrderDetail {Product = products[49], UnitPrice = 16.00m, Quantity = 21, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "KOENE",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Feb 25 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 25 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar  3 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 11.57m,
                    ShipName = "Königlich Essen",
                    ShipAddress = "Maubelstr. 90",
                    ShipCity = "Brandenburg",
                    ShipRegion = "",
                    ShipPostalCode = "14776",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[59], UnitPrice = 44.00m, Quantity = 36, Discount = 0F}),

                new Order
                {
                    CustomerId = "SUPRD",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Feb 26 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 26 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar  4 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 147.06m,
                    ShipName = "Suprêmes délices",
                    ShipAddress = "Boulevard Tirou, 255",
                    ShipCity = "Charleroi",
                    ShipRegion = "",
                    ShipPostalCode = "B-6000",
                    ShipCountry = "Belgium",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[26], UnitPrice = 24.90m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[28], UnitPrice = 36.40m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[43], UnitPrice = 36.80m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[56], UnitPrice = 30.40m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[71], UnitPrice = 17.20m, Quantity = 50, Discount = 0F}),

                new Order
                {
                    CustomerId = "VICTE",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Feb 27 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 27 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 28 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 25.09m,
                    ShipName = "Victuailles en stock",
                    ShipAddress = "2, rue du Commerce",
                    ShipCity = "Lyon",
                    ShipRegion = "",
                    ShipPostalCode = "69004",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[7], UnitPrice = 24.00m, Quantity = 16, Discount = 0.05F},
                    new OrderDetail {Product = products[46], UnitPrice = 9.60m, Quantity = 20, Discount = 0.05F},
                    new OrderDetail {Product = products[72], UnitPrice = 27.80m, Quantity = 40, Discount = 0F}),

                new Order
                {
                    CustomerId = "FOLKO",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Feb 28 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 28 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar  3 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 16.27m,
                    ShipName = "Folk och fä HB",
                    ShipAddress = "Åkergatan 24",
                    ShipCity = "Bräcke",
                    ShipRegion = "",
                    ShipPostalCode = "S-844 67",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[68], UnitPrice = 10.00m, Quantity = 21, Discount = 0.25F},
                    new OrderDetail {Product = products[75], UnitPrice = 6.20m, Quantity = 4, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "LILAS",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Feb 28 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 28 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar  5 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 148.61m,
                    ShipName = "LILA-Supermercado",
                    ShipAddress = "Carrera 52 con Ave. Bolívar #65-98 Llano Largo",
                    ShipCity = "Barquisimeto",
                    ShipRegion = "Lara",
                    ShipPostalCode = "3508",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[21], UnitPrice = 8.00m, Quantity = 40, Discount = 0.25F},
                    new OrderDetail {Product = products[30], UnitPrice = 20.70m, Quantity = 28, Discount = 0.25F},
                    new OrderDetail {Product = products[55], UnitPrice = 19.20m, Quantity = 60, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "CONSH",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Mar  3 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 31 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 18 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 6.17m,
                    ShipName = "Consolidated Holdings",
                    ShipAddress = "Berkeley Gardens 12  Brewery",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "WX1 6LT",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[13], UnitPrice = 4.80m, Quantity = 1, Discount = 0F},
                    new OrderDetail {Product = products[23], UnitPrice = 7.20m, Quantity = 21, Discount = 0F}),

                new Order
                {
                    CustomerId = "SUPRD",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Mar  4 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  1 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar  6 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 14.78m,
                    ShipName = "Suprêmes délices",
                    ShipAddress = "Boulevard Tirou, 255",
                    ShipCity = "Charleroi",
                    ShipRegion = "",
                    ShipPostalCode = "B-6000",
                    ShipCountry = "Belgium",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[19], UnitPrice = 7.30m, Quantity = 21, Discount = 0F},
                    new OrderDetail {Product = products[42], UnitPrice = 11.20m, Quantity = 50, Discount = 0F}),

                new Order
                {
                    CustomerId = "FURIB",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Mar  4 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  1 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 14 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 89.00m,
                    ShipName = "Furia Bacalhau e Frutos do Mar",
                    ShipAddress = "Jardim das rosas n. 32",
                    ShipCity = "Lisboa",
                    ShipRegion = "",
                    ShipPostalCode = "1675",
                    ShipCountry = "Portugal",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[4], UnitPrice = 17.60m, Quantity = 16, Discount = 0.2F},
                    new OrderDetail {Product = products[43], UnitPrice = 36.80m, Quantity = 3, Discount = 0F},
                    new OrderDetail {Product = products[56], UnitPrice = 30.40m, Quantity = 30, Discount = 0.2F},
                    new OrderDetail {Product = products[60], UnitPrice = 27.20m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "VAFFE",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Mar  5 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  2 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 14 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 145.04m,
                    ShipName = "Vaffeljernet",
                    ShipAddress = "Smagsloget 45",
                    ShipCity = "Århus",
                    ShipRegion = "",
                    ShipPostalCode = "8200",
                    ShipCountry = "Denmark",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[24], UnitPrice = 3.60m, Quantity = 25, Discount = 0F},
                    new OrderDetail {Product = products[29], UnitPrice = 99.00m, Quantity = 18, Discount = 0.1F},
                    new OrderDetail {Product = products[40], UnitPrice = 14.70m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[45], UnitPrice = 7.60m, Quantity = 30, Discount = 0.1F},
                    new OrderDetail {Product = products[50], UnitPrice = 13.00m, Quantity = 25, Discount = 0F}),

                new Order
                {
                    CustomerId = "COMMI",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Mar  6 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  3 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 13 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 11.93m,
                    ShipName = "Comércio Mineiro",
                    ShipAddress = "Av. dos Lusíadas, 23",
                    ShipCity = "Sao Paulo",
                    ShipRegion = "SP",
                    ShipPostalCode = "05432-043",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 16.80m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[46], UnitPrice = 9.60m, Quantity = 5, Discount = 0F}),

                new Order
                {
                    CustomerId = "MAGAA",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Mar  6 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  3 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 11 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 4.93m,
                    ShipName = "Magazzini Alimentari Riuniti",
                    ShipAddress = "Via Ludovico il Moro 22",
                    ShipCity = "Bergamo",
                    ShipRegion = "",
                    ShipPostalCode = "24100",
                    ShipCountry = "Italy",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[24], UnitPrice = 3.60m, Quantity = 28, Discount = 0F},
                    new OrderDetail {Product = products[25], UnitPrice = 11.20m, Quantity = 12, Discount = 0F}),

                new Order
                {
                    CustomerId = "KOENE",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Mar  7 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  4 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 12 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 44.12m,
                    ShipName = "Königlich Essen",
                    ShipAddress = "Maubelstr. 90",
                    ShipCity = "Brandenburg",
                    ShipRegion = "",
                    ShipPostalCode = "14776",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[30], UnitPrice = 20.70m, Quantity = 8, Discount = 0F},
                    new OrderDetail {Product = products[43], UnitPrice = 36.80m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "WHITC",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Mar 10 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  7 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 14 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 60.18m,
                    ShipName = "White Clover Markets",
                    ShipAddress = "1029 - 12th Ave. S.",
                    ShipCity = "Seattle",
                    ShipRegion = "WA",
                    ShipPostalCode = "98124",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 15.20m, Quantity = 40, Discount = 0.15F},
                    new OrderDetail {Product = products[16], UnitPrice = 13.90m, Quantity = 35, Discount = 0.15F},
                    new OrderDetail {Product = products[44], UnitPrice = 15.50m, Quantity = 2, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "BONAP",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Mar 11 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  8 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 14 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 64.56m,
                    ShipName = "Bon app'",
                    ShipAddress = "12, rue des Bouchers",
                    ShipCity = "Marseille",
                    ShipRegion = "",
                    ShipPostalCode = "13008",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[18], UnitPrice = 50.00m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[23], UnitPrice = 7.20m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[64], UnitPrice = 26.60m, Quantity = 8, Discount = 0F}),

                new Order
                {
                    CustomerId = "BSBEV",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Mar 11 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  8 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 18 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 45.59m,
                    ShipName = "B's Beverages",
                    ShipAddress = "Fauntleroy Circus",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "EC2 5NT",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[7], UnitPrice = 24.00m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[56], UnitPrice = 30.40m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "SEVES",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Mar 12 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  9 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 19 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 4.20m,
                    ShipName = "Seven Seas Imports",
                    ShipAddress = "90 Wadhurst Rd.",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "OX15 4NB",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[24], UnitPrice = 3.60m, Quantity = 80, Discount = 0.05F},
                    new OrderDetail {Product = products[51], UnitPrice = 42.40m, Quantity = 18, Discount = 0F}),

                new Order
                {
                    CustomerId = "ISLAT",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Mar 13 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 27 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 21 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 16.37m,
                    ShipName = "Island Trading",
                    ShipAddress = "Garden House Crowther Way",
                    ShipCity = "Cowes",
                    ShipRegion = "Isle of Wight",
                    ShipPostalCode = "PO31 7PJ",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[33], UnitPrice = 2.00m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[71], UnitPrice = 17.20m, Quantity = 12, Discount = 0F}),

                new Order
                {
                    CustomerId = "PERIC",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Mar 13 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 10 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 21 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 83.49m,
                    ShipName = "Pericles Comidas clásicas",
                    ShipAddress = "Calle Dr. Jorge Cash 321",
                    ShipCity = "México D.F.",
                    ShipRegion = "",
                    ShipPostalCode = "05033",
                    ShipCountry = "Mexico",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[14], UnitPrice = 18.60m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[28], UnitPrice = 36.40m, Quantity = 18, Discount = 0F},
                    new OrderDetail {Product = products[40], UnitPrice = 14.70m, Quantity = 21, Discount = 0F},
                    new OrderDetail {Product = products[75], UnitPrice = 6.20m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "SUPRD",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Mar 14 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 11 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  4 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 68.52m,
                    ShipName = "Suprêmes délices",
                    ShipAddress = "Boulevard Tirou, 255",
                    ShipCity = "Charleroi",
                    ShipRegion = "",
                    ShipPostalCode = "B-6000",
                    ShipCountry = "Belgium",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[31], UnitPrice = 10.00m, Quantity = 35, Discount = 0.15F},
                    new OrderDetail {Product = products[66], UnitPrice = 13.60m, Quantity = 60, Discount = 0.15F},
                    new OrderDetail {Product = products[76], UnitPrice = 14.40m, Quantity = 42, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "HILAA",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Mar 17 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 14 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 24 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 4.41m,
                    ShipName = "HILARION-Abastos",
                    ShipAddress = "Carrera 22 con Ave. Carlos Soublette #8-35",
                    ShipCity = "San Cristóbal",
                    ShipRegion = "Táchira",
                    ShipPostalCode = "5022",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[55], UnitPrice = 19.20m, Quantity = 2, Discount = 0.05F},
                    new OrderDetail {Product = products[70], UnitPrice = 12.00m, Quantity = 12, Discount = 0F}),

                new Order
                {
                    CustomerId = "PRINI",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Mar 17 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 14 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 25 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 13.02m,
                    ShipName = "Princesa Isabel Vinhos",
                    ShipAddress = "Estrada da saúde n. 58",
                    ShipCity = "Lisboa",
                    ShipRegion = "",
                    ShipPostalCode = "1756",
                    ShipCountry = "Portugal",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 14.40m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[21], UnitPrice = 8.00m, Quantity = 21, Discount = 0.25F},
                    new OrderDetail {Product = products[39], UnitPrice = 14.40m, Quantity = 20, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "VICTE",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Mar 18 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  1 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 26 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 4.81m,
                    ShipName = "Victuailles en stock",
                    ShipAddress = "2, rue du Commerce",
                    ShipCity = "Lyon",
                    ShipRegion = "",
                    ShipPostalCode = "69004",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[10], UnitPrice = 24.80m, Quantity = 20, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "RATTC",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Mar 19 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 16 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 21 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 708.95m,
                    ShipName = "Rattlesnake Canyon Grocery",
                    ShipAddress = "2817 Milton Dr.",
                    ShipCity = "Albuquerque",
                    ShipRegion = "NM",
                    ShipPostalCode = "87110",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[38], UnitPrice = 210.80m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[53], UnitPrice = 26.20m, Quantity = 28, Discount = 0F},
                    new OrderDetail {Product = products[59], UnitPrice = 44.00m, Quantity = 60, Discount = 0F},
                    new OrderDetail {Product = products[64], UnitPrice = 26.60m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "FOLIG",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Mar 20 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 17 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 24 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 1.35m,
                    ShipName = "Folies gourmandes",
                    ShipAddress = "184, chaussée de Tournai",
                    ShipCity = "Lille",
                    ShipRegion = "",
                    ShipPostalCode = "59000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[47], UnitPrice = 7.60m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[59], UnitPrice = 44.00m, Quantity = 12, Discount = 0F}),

                new Order
                {
                    CustomerId = "RICAR",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Mar 20 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 17 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 25 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 64.33m,
                    ShipName = "Ricardo Adocicados",
                    ShipAddress = "Av. Copacabana, 267",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "02389-890",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[49], UnitPrice = 16.00m, Quantity = 24, Discount = 0F},
                    new OrderDetail {Product = products[60], UnitPrice = 27.20m, Quantity = 40, Discount = 0F}),

                new Order
                {
                    CustomerId = "LAZYK",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Mar 21 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 18 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 10 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 7.48m,
                    ShipName = "Lazy K Kountry Store",
                    ShipAddress = "12 Orchestra Terrace",
                    ShipCity = "Walla Walla",
                    ShipRegion = "WA",
                    ShipPostalCode = "99362",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[40], UnitPrice = 14.70m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "WHITC",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Mar 24 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 21 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 25 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 15.28m,
                    ShipName = "White Clover Markets",
                    ShipAddress = "1029 - 12th Ave. S.",
                    ShipCity = "Seattle",
                    ShipRegion = "WA",
                    ShipPostalCode = "98124",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[34], UnitPrice = 11.20m, Quantity = 35, Discount = 0.05F},
                    new OrderDetail {Product = products[77], UnitPrice = 10.40m, Quantity = 30, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "BSBEV",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Mar 24 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 21 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  1 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 6.88m,
                    ShipName = "B's Beverages",
                    ShipAddress = "Fauntleroy Circus",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "EC2 5NT",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[21], UnitPrice = 8.00m, Quantity = 14, Discount = 0F},
                    new OrderDetail {Product = products[40], UnitPrice = 14.70m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[51], UnitPrice = 42.40m, Quantity = 3, Discount = 0F}),

                new Order
                {
                    CustomerId = "LINOD",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Mar 25 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  8 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 31 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 64.45m,
                    ShipName = "LINO-Delicateses",
                    ShipAddress = "Ave. 5 de Mayo Porlamar",
                    ShipCity = "I. de Margarita",
                    ShipRegion = "Nueva Esparta",
                    ShipPostalCode = "4980",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 15.20m, Quantity = 20, Discount = 0.1F},
                    new OrderDetail {Product = products[3], UnitPrice = 8.00m, Quantity = 20, Discount = 0.1F},
                    new OrderDetail {Product = products[55], UnitPrice = 19.20m, Quantity = 30, Discount = 0.1F},
                    new OrderDetail {Product = products[70], UnitPrice = 12.00m, Quantity = 60, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "HILAA",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Mar 26 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 23 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  2 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 30.53m,
                    ShipName = "HILARION-Abastos",
                    ShipAddress = "Carrera 22 con Ave. Carlos Soublette #8-35",
                    ShipCity = "San Cristóbal",
                    ShipRegion = "Táchira",
                    ShipPostalCode = "5022",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 16.80m, Quantity = 5, Discount = 0F},
                    new OrderDetail {Product = products[51], UnitPrice = 42.40m, Quantity = 25, Discount = 0F},
                    new OrderDetail {Product = products[74], UnitPrice = 8.00m, Quantity = 16, Discount = 0F}),

                new Order
                {
                    CustomerId = "QUEEN",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Mar 26 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 23 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 28 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 71.07m,
                    ShipName = "Queen Cozinha",
                    ShipAddress = "Alameda dos Canàrios, 891",
                    ShipCity = "Sao Paulo",
                    ShipRegion = "SP",
                    ShipPostalCode = "05487-020",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[19], UnitPrice = 7.30m, Quantity = 5, Discount = 0F},
                    new OrderDetail {Product = products[26], UnitPrice = 24.90m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[54], UnitPrice = 5.90m, Quantity = 24, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "FRANK",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Mar 27 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 24 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  2 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 4.93m,
                    ShipName = "Frankenversand",
                    ShipAddress = "Berliner Platz 43",
                    ShipCity = "München",
                    ShipRegion = "",
                    ShipPostalCode = "80805",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[59], UnitPrice = 44.00m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[73], UnitPrice = 12.00m, Quantity = 20, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "PICCO",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Mar 28 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 25 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  9 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 5.29m,
                    ShipName = "Piccolo und mehr",
                    ShipAddress = "Geislweg 14",
                    ShipCity = "Salzburg",
                    ShipRegion = "",
                    ShipPostalCode = "5020",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 16.80m, Quantity = 15, Discount = 0.25F},
                    new OrderDetail {Product = products[16], UnitPrice = 13.90m, Quantity = 18, Discount = 0F}),

                new Order
                {
                    CustomerId = "HILAA",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Mar 31 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 28 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  3 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 210.19m,
                    ShipName = "HILARION-Abastos",
                    ShipAddress = "Carrera 22 con Ave. Carlos Soublette #8-35",
                    ShipCity = "San Cristóbal",
                    ShipRegion = "Táchira",
                    ShipPostalCode = "5022",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[59], UnitPrice = 44.00m, Quantity = 60, Discount = 0F},
                    new OrderDetail {Product = products[68], UnitPrice = 10.00m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[75], UnitPrice = 6.20m, Quantity = 36, Discount = 0F}),

                new Order
                {
                    CustomerId = "FURIB",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Mar 31 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 28 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  8 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 16.96m,
                    ShipName = "Furia Bacalhau e Frutos do Mar",
                    ShipAddress = "Jardim das rosas n. 32",
                    ShipCity = "Lisboa",
                    ShipRegion = "",
                    ShipPostalCode = "1675",
                    ShipCountry = "Portugal",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[44], UnitPrice = 15.50m, Quantity = 15, Discount = 0.15F},
                    new OrderDetail {Product = products[77], UnitPrice = 10.40m, Quantity = 7, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "BOTTM",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Apr  1 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 29 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 11 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 62.89m,
                    ShipName = "Bottom-Dollar Markets",
                    ShipAddress = "23 Tsawassen Blvd.",
                    ShipCity = "Tsawassen",
                    ShipRegion = "BC",
                    ShipPostalCode = "T2F 8M4",
                    ShipCountry = "Canada",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[25], UnitPrice = 11.20m, Quantity = 60, Discount = 0.05F},
                    new OrderDetail {Product = products[42], UnitPrice = 11.20m, Quantity = 20, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "LAMAI",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Apr  2 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 30 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 10 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 10.64m,
                    ShipName = "La maison d'Asie",
                    ShipAddress = "1 rue Alsace-Lorraine",
                    ShipCity = "Toulouse",
                    ShipRegion = "",
                    ShipPostalCode = "31000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[65], UnitPrice = 16.80m, Quantity = 15, Discount = 0.1F},
                    new OrderDetail {Product = products[66], UnitPrice = 13.60m, Quantity = 10, Discount = 0.1F},
                    new OrderDetail {Product = products[69], UnitPrice = 28.80m, Quantity = 10, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "COMMI",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Apr  2 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 30 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  9 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 65.99m,
                    ShipName = "Comércio Mineiro",
                    ShipAddress = "Av. dos Lusíadas, 23",
                    ShipCity = "Sao Paulo",
                    ShipRegion = "SP",
                    ShipPostalCode = "05432-043",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[56], UnitPrice = 30.40m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "LAUGB",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Apr  3 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("May  1 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 11 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 4.65m,
                    ShipName = "Laughing Bacchus Wine Cellars",
                    ShipAddress = "2319 Elm St.",
                    ShipCity = "Vancouver",
                    ShipRegion = "BC",
                    ShipPostalCode = "V3F 2K1",
                    ShipCountry = "Canada",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[23], UnitPrice = 7.20m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[41], UnitPrice = 7.70m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[77], UnitPrice = 10.40m, Quantity = 5, Discount = 0F}),

                new Order
                {
                    CustomerId = "TRADH",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Apr  4 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("May  2 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  7 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 46.77m,
                    ShipName = "Tradiçao Hipermercados",
                    ShipAddress = "Av. Inês de Castro, 414",
                    ShipCity = "Sao Paulo",
                    ShipRegion = "SP",
                    ShipPostalCode = "05634-030",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[31], UnitPrice = 10.00m, Quantity = 20, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "LEHMS",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Apr  4 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("May  2 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  7 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 36.21m,
                    ShipName = "Lehmanns Marktstand",
                    ShipAddress = "Magazinweg 7",
                    ShipCity = "Frankfurt a.M.",
                    ShipRegion = "",
                    ShipPostalCode = "60528",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[56], UnitPrice = 30.40m, Quantity = 14, Discount = 0F},
                    new OrderDetail {Product = products[72], UnitPrice = 27.80m, Quantity = 25, Discount = 0F},
                    new OrderDetail {Product = products[77], UnitPrice = 10.40m, Quantity = 25, Discount = 0F}),

                new Order
                {
                    CustomerId = "HILAA",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Apr  7 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("May  5 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 11 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 29.75m,
                    ShipName = "HILARION-Abastos",
                    ShipAddress = "Carrera 22 con Ave. Carlos Soublette #8-35",
                    ShipCity = "San Cristóbal",
                    ShipRegion = "Táchira",
                    ShipPostalCode = "5022",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 14, Discount = 0F},
                    new OrderDetail {Product = products[40], UnitPrice = 18.40m, Quantity = 5, Discount = 0F},
                    new OrderDetail {Product = products[42], UnitPrice = 14.00m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "LILAS",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Apr  8 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("May  6 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 16 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 102.02m,
                    ShipName = "LILA-Supermercado",
                    ShipAddress = "Carrera 52 con Ave. Bolívar #65-98 Llano Largo",
                    ShipCity = "Barquisimeto",
                    ShipRegion = "Lara",
                    ShipPostalCode = "3508",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[28], UnitPrice = 45.60m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[49], UnitPrice = 20.00m, Quantity = 25, Discount = 0F}),

                new Order
                {
                    CustomerId = "LAMAI",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Apr  9 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("May  7 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 17 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 42.68m,
                    ShipName = "La maison d'Asie",
                    ShipAddress = "1 rue Alsace-Lorraine",
                    ShipCity = "Toulouse",
                    ShipRegion = "",
                    ShipPostalCode = "31000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[15], UnitPrice = 15.50m, Quantity = 12, Discount = 0.05F},
                    new OrderDetail {Product = products[28], UnitPrice = 45.60m, Quantity = 8, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "BLAUS",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Apr  9 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("May  7 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 16 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 8.85m,
                    ShipName = "Blauer See Delikatessen",
                    ShipAddress = "Forsterstr. 57",
                    ShipCity = "Mannheim",
                    ShipRegion = "",
                    ShipPostalCode = "68306",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[54], UnitPrice = 7.45m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "PERIC",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Apr 10 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("May  8 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 29 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 69.32m,
                    ShipName = "Pericles Comidas clásicas",
                    ShipAddress = "Calle Dr. Jorge Cash 321",
                    ShipCity = "México D.F.",
                    ShipRegion = "",
                    ShipPostalCode = "05033",
                    ShipCountry = "Mexico",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[45], UnitPrice = 9.50m, Quantity = 21, Discount = 0F},
                    new OrderDetail {Product = products[53], UnitPrice = 32.80m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[67], UnitPrice = 14.00m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "HUNGO",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Apr 11 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("May  9 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 16 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 16.74m,
                    ShipName = "Hungry Owl All-Night Grocers",
                    ShipAddress = "8 Johnstown Road",
                    ShipCity = "Cork",
                    ShipRegion = "Co. Cork",
                    ShipPostalCode = "",
                    ShipCountry = "Ireland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[14], UnitPrice = 23.25m, Quantity = 70, Discount = 0F},
                    new OrderDetail {Product = products[65], UnitPrice = 21.05m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "WHITC",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Apr 11 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("May  9 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 18 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 59.13m,
                    ShipName = "White Clover Markets",
                    ShipAddress = "1029 - 12th Ave. S.",
                    ShipCity = "Seattle",
                    ShipRegion = "WA",
                    ShipPostalCode = "98124",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 19.00m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[21], UnitPrice = 10.00m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[53], UnitPrice = 32.80m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[61], UnitPrice = 28.50m, Quantity = 25, Discount = 0F}),

                new Order
                {
                    CustomerId = "MEREP",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Apr 14 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("May 12 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 21 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 7.13m,
                    ShipName = "Mère Paillarde",
                    ShipAddress = "43 rue St. Laurent",
                    ShipCity = "Montréal",
                    ShipRegion = "Québec",
                    ShipPostalCode = "H1J 1C3",
                    ShipCountry = "Canada",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 3, Discount = 0F}),

                new Order
                {
                    CustomerId = "KOENE",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Apr 15 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("May 13 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("May  2 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 21.19m,
                    ShipName = "Königlich Essen",
                    ShipAddress = "Maubelstr. 90",
                    ShipCity = "Brandenburg",
                    ShipRegion = "",
                    ShipPostalCode = "14776",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[25], UnitPrice = 14.00m, Quantity = 18, Discount = 0.1F},
                    new OrderDetail {Product = products[70], UnitPrice = 15.00m, Quantity = 14, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "ANTON",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Apr 15 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("May 13 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 22 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 47.45m,
                    ShipName = "Antonio Moreno Taquería",
                    ShipAddress = "Mataderos  2312",
                    ShipCity = "México D.F.",
                    ShipRegion = "",
                    ShipPostalCode = "05023",
                    ShipCountry = "Mexico",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[43], UnitPrice = 46.00m, Quantity = 15, Discount = 0.15F},
                    new OrderDetail {Product = products[48], UnitPrice = 12.75m, Quantity = 15, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "OTTIK",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Apr 16 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("May 14 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("May 13 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 4.99m,
                    ShipName = "Ottilies Käseladen",
                    ShipAddress = "Mehrheimerstr. 369",
                    ShipCity = "Köln",
                    ShipRegion = "",
                    ShipPostalCode = "50739",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[13], UnitPrice = 6.00m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[39], UnitPrice = 18.00m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "BLAUS",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Apr 17 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("May 15 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 29 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 0.15m,
                    ShipName = "Blauer See Delikatessen",
                    ShipAddress = "Forsterstr. 57",
                    ShipCity = "Mannheim",
                    ShipRegion = "",
                    ShipPostalCode = "68306",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[28], UnitPrice = 45.60m, Quantity = 3, Discount = 0F}),

                new Order
                {
                    CustomerId = "SAVEA",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Apr 18 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("May 16 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 28 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 367.63m,
                    ShipName = "Save-a-lot Markets",
                    ShipAddress = "187 Suffolk Ln.",
                    ShipCity = "Boise",
                    ShipRegion = "ID",
                    ShipPostalCode = "83720",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[29], UnitPrice = 123.79m, Quantity = 36, Discount = 0F},
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 36, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "BONAP",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Apr 18 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("May 16 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 21 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 350.64m,
                    ShipName = "Bon app'",
                    ShipAddress = "12, rue des Bouchers",
                    ShipCity = "Marseille",
                    ShipRegion = "",
                    ShipPostalCode = "13008",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[4], UnitPrice = 22.00m, Quantity = 50, Discount = 0.15F},
                    new OrderDetail {Product = products[7], UnitPrice = 30.00m, Quantity = 50, Discount = 0.15F},
                    new OrderDetail {Product = products[8], UnitPrice = 40.00m, Quantity = 10, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "FAMIA",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Apr 21 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("May 19 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 24 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 3.53m,
                    ShipName = "Familia Arquibaldo",
                    ShipAddress = "Rua Orós, 92",
                    ShipCity = "Sao Paulo",
                    ShipRegion = "SP",
                    ShipPostalCode = "05442-030",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 10, Discount = 0.15F},
                    new OrderDetail {Product = products[46], UnitPrice = 12.00m, Quantity = 9, Discount = 0.15F},
                    new OrderDetail {Product = products[47], UnitPrice = 9.50m, Quantity = 6, Discount = 0.15F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 12, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "WANDK",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Apr 22 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun  3 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 28 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 105.65m,
                    ShipName = "Die Wandernde Kuh",
                    ShipAddress = "Adenauerallee 900",
                    ShipCity = "Stuttgart",
                    ShipRegion = "",
                    ShipPostalCode = "70563",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[21], UnitPrice = 10.00m, Quantity = 40, Discount = 0.2F},
                    new OrderDetail {Product = products[32], UnitPrice = 32.00m, Quantity = 50, Discount = 0.2F},
                    new OrderDetail {Product = products[61], UnitPrice = 28.50m, Quantity = 15, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "ERNSH",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Apr 22 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("May 20 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("May 16 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 789.95m,
                    ShipName = "Ernst Handel",
                    ShipAddress = "Kirchgasse 6",
                    ShipCity = "Graz",
                    ShipRegion = "",
                    ShipPostalCode = "8010",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[20], UnitPrice = 81.00m, Quantity = 39, Discount = 0F},
                    new OrderDetail {Product = products[28], UnitPrice = 45.60m, Quantity = 35, Discount = 0F},
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 70, Discount = 0F},
                    new OrderDetail {Product = products[65], UnitPrice = 21.05m, Quantity = 39, Discount = 0F},
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 50, Discount = 0F}),

                new Order
                {
                    CustomerId = "QUICK",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Apr 23 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("May  7 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("May 23 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 204.47m,
                    ShipName = "QUICK-Stop",
                    ShipAddress = "Taucherstraße 10",
                    ShipCity = "Cunewalde",
                    ShipRegion = "",
                    ShipPostalCode = "01307",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[9], UnitPrice = 97.00m, Quantity = 16, Discount = 0.15F},
                    new OrderDetail {Product = products[16], UnitPrice = 17.45m, Quantity = 50, Discount = 0F},
                    new OrderDetail {Product = products[27], UnitPrice = 43.90m, Quantity = 120, Discount = 0F},
                    new OrderDetail {Product = products[33], UnitPrice = 2.50m, Quantity = 16, Discount = 0.15F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 84, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "HUNGO",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Apr 24 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("May 22 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("May  1 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 62.78m,
                    ShipName = "Hungry Owl All-Night Grocers",
                    ShipAddress = "8 Johnstown Road",
                    ShipCity = "Cork",
                    ShipRegion = "Co. Cork",
                    ShipPostalCode = "",
                    ShipCountry = "Ireland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[18], UnitPrice = 62.50m, Quantity = 25, Discount = 0.1F},
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 80, Discount = 0.1F},
                    new OrderDetail {Product = products[42], UnitPrice = 14.00m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "NORTS",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Apr 24 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("May 22 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 29 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 32.07m,
                    ShipName = "North/South",
                    ShipAddress = "South House 300 Queensbridge",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "SW7 1RZ",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[52], UnitPrice = 7.00m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 4, Discount = 0F},
                    new OrderDetail {Product = products[70], UnitPrice = 15.00m, Quantity = 6, Discount = 0F}),

                new Order
                {
                    CustomerId = "TORTU",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Apr 25 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("May  9 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("May  5 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 218.15m,
                    ShipName = "Tortuga Restaurante",
                    ShipAddress = "Avda. Azteca 123",
                    ShipCity = "México D.F.",
                    ShipRegion = "",
                    ShipPostalCode = "05033",
                    ShipCountry = "Mexico",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 5, Discount = 0F},
                    new OrderDetail {Product = products[38], UnitPrice = 263.50m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[44], UnitPrice = 19.45m, Quantity = 9, Discount = 0F}),

                new Order
                {
                    CustomerId = "CHOPS",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Apr 28 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("May 26 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("May  1 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 91.76m,
                    ShipName = "Chop-suey Chinese",
                    ShipAddress = "Hauptstr. 31",
                    ShipCity = "Bern",
                    ShipRegion = "",
                    ShipPostalCode = "3012",
                    ShipCountry = "Switzerland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[10], UnitPrice = 31.00m, Quantity = 16, Discount = 0.05F},
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 10, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "SANTG",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Apr 29 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("May 27 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("May  1 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 13.37m,
                    ShipName = "Santé Gourmet",
                    ShipAddress = "Erling Skakkes gate 78",
                    ShipCity = "Stavern",
                    ShipRegion = "",
                    ShipPostalCode = "4110",
                    ShipCountry = "Norway",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 8, Discount = 0F},
                    new OrderDetail {Product = products[53], UnitPrice = 32.80m, Quantity = 5, Discount = 0F}),

                new Order
                {
                    CustomerId = "CACTU",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Apr 29 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("May 27 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("May  2 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 17.22m,
                    ShipName = "Cactus Comidas para llevar",
                    ShipAddress = "Cerrito 333",
                    ShipCity = "Buenos Aires",
                    ShipRegion = "",
                    ShipPostalCode = "1010",
                    ShipCountry = "Argentina",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[35], UnitPrice = 18.00m, Quantity = 3, Discount = 0F},
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[68], UnitPrice = 12.50m, Quantity = 6, Discount = 0F}),

                new Order
                {
                    CustomerId = "LEHMS",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Apr 30 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("May 28 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("May  6 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 45.33m,
                    ShipName = "Lehmanns Marktstand",
                    ShipAddress = "Magazinweg 7",
                    ShipCity = "Frankfurt a.M.",
                    ShipRegion = "",
                    ShipPostalCode = "60528",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 18.00m, Quantity = 40, Discount = 0.2F},
                    new OrderDetail {Product = products[8], UnitPrice = 40.00m, Quantity = 24, Discount = 0F},
                    new OrderDetail {Product = products[30], UnitPrice = 25.89m, Quantity = 20, Discount = 0.2F},
                    new OrderDetail {Product = products[40], UnitPrice = 18.40m, Quantity = 25, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "SEVES",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("May  1 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("May 29 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("May 30 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 77.63m,
                    ShipName = "Seven Seas Imports",
                    ShipAddress = "90 Wadhurst Rd.",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "OX15 4NB",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[17], UnitPrice = 39.00m, Quantity = 25, Discount = 0.1F},
                    new OrderDetail {Product = products[20], UnitPrice = 81.00m, Quantity = 15, Discount = 0.1F},
                    new OrderDetail {Product = products[37], UnitPrice = 26.00m, Quantity = 18, Discount = 0.1F},
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 6, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "BERGS",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("May  1 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("May 29 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("May  7 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 244.79m,
                    ShipName = "Berglunds snabbköp",
                    ShipAddress = "Berguvsvägen  8",
                    ShipCity = "Luleå",
                    ShipRegion = "",
                    ShipPostalCode = "S-958 22",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[10], UnitPrice = 31.00m, Quantity = 2, Discount = 0F},
                    new OrderDetail {Product = products[30], UnitPrice = 25.89m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[43], UnitPrice = 46.00m, Quantity = 60, Discount = 0F},
                    new OrderDetail {Product = products[54], UnitPrice = 7.45m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "BONAP",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("May  2 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("May 30 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("May 23 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 11.06m,
                    ShipName = "Bon app'",
                    ShipAddress = "12, rue des Bouchers",
                    ShipCity = "Marseille",
                    ShipRegion = "",
                    ShipPostalCode = "13008",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[36], UnitPrice = 19.00m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[40], UnitPrice = 18.40m, Quantity = 15, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "WARTH",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("May  5 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun  2 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("May 15 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 58.59m,
                    ShipName = "Wartian Herkku",
                    ShipAddress = "Torikatu 38",
                    ShipCity = "Oulu",
                    ShipRegion = "",
                    ShipPostalCode = "90110",
                    ShipCountry = "Finland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 18.00m, Quantity = 8, Discount = 0.15F},
                    new OrderDetail {Product = products[13], UnitPrice = 6.00m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 30, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "QUICK",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("May  5 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun  2 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("May  7 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 41.90m,
                    ShipName = "QUICK-Stop",
                    ShipAddress = "Taucherstraße 10",
                    ShipCity = "Cunewalde",
                    ShipRegion = "",
                    ShipPostalCode = "01307",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[4], UnitPrice = 22.00m, Quantity = 50, Discount = 0.1F},
                    new OrderDetail {Product = products[36], UnitPrice = 19.00m, Quantity = 30, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "GREAL",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("May  6 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("May 20 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("May  9 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 3.35m,
                    ShipName = "Great Lakes Food Market",
                    ShipAddress = "2732 Baker Blvd.",
                    ShipCity = "Eugene",
                    ShipRegion = "OR",
                    ShipPostalCode = "97403",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 21.00m, Quantity = 3, Discount = 0F},
                    new OrderDetail {Product = products[33], UnitPrice = 2.50m, Quantity = 8, Discount = 0.2F},
                    new OrderDetail {Product = products[72], UnitPrice = 34.80m, Quantity = 9, Discount = 0F}),

                new Order
                {
                    CustomerId = "MAISD",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("May  7 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun  4 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("May  9 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 66.69m,
                    ShipName = "Maison Dewey",
                    ShipAddress = "Rue Joseph-Bens 532",
                    ShipCity = "Bruxelles",
                    ShipRegion = "",
                    ShipPostalCode = "B-1180",
                    ShipCountry = "Belgium",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[55], UnitPrice = 24.00m, Quantity = 14, Discount = 0F},
                    new OrderDetail {Product = products[68], UnitPrice = 12.50m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[69], UnitPrice = 36.00m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "PICCO",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("May  8 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun  5 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("May 12 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 339.22m,
                    ShipName = "Piccolo und mehr",
                    ShipAddress = "Geislweg 14",
                    ShipCity = "Salzburg",
                    ShipRegion = "",
                    ShipPostalCode = "5020",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[17], UnitPrice = 39.00m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[43], UnitPrice = 46.00m, Quantity = 25, Discount = 0F},
                    new OrderDetail {Product = products[61], UnitPrice = 28.50m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[76], UnitPrice = 18.00m, Quantity = 50, Discount = 0F}),

                new Order
                {
                    CustomerId = "OCEAN",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("May  8 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun  5 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("May 19 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 8.12m,
                    ShipName = "Océano Atlántico Ltda.",
                    ShipAddress = "Ing. Gustavo Moncada 8585 Piso 20-A",
                    ShipCity = "Buenos Aires",
                    ShipRegion = "",
                    ShipPostalCode = "1010",
                    ShipCountry = "Argentina",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 2, Discount = 0F}),

                new Order
                {
                    CustomerId = "EASTC",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("May  9 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun  6 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("May 12 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 74.46m,
                    ShipName = "Eastern Connection",
                    ShipAddress = "35 King George",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "WX3 6FW",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[30], UnitPrice = 25.89m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[66], UnitPrice = 17.00m, Quantity = 24, Discount = 0F}),

                new Order
                {
                    CustomerId = "FOLKO",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("May 12 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun  9 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("May 22 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 188.04m,
                    ShipName = "Folk och fä HB",
                    ShipAddress = "Åkergatan 24",
                    ShipCity = "Bräcke",
                    ShipRegion = "",
                    ShipPostalCode = "S-844 67",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[4], UnitPrice = 22.00m, Quantity = 50, Discount = 0.05F},
                    new OrderDetail {Product = products[72], UnitPrice = 34.80m, Quantity = 24, Discount = 0F},
                    new OrderDetail {Product = products[73], UnitPrice = 15.00m, Quantity = 24, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "LEHMS",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("May 12 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun  9 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("May 14 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 27.94m,
                    ShipName = "Lehmanns Marktstand",
                    ShipAddress = "Magazinweg 7",
                    ShipCity = "Frankfurt a.M.",
                    ShipRegion = "",
                    ShipPostalCode = "60528",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[30], UnitPrice = 25.89m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[40], UnitPrice = 18.40m, Quantity = 10, Discount = 0.2F},
                    new OrderDetail {Product = products[54], UnitPrice = 7.45m, Quantity = 10, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "ANTON",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("May 13 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun 10 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("May 21 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 15.64m,
                    ShipName = "Antonio Moreno Taquería",
                    ShipAddress = "Mataderos  2312",
                    ShipCity = "México D.F.",
                    ShipRegion = "",
                    ShipPostalCode = "05023",
                    ShipCountry = "Mexico",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 21.00m, Quantity = 50, Discount = 0.1F},
                    new OrderDetail {Product = products[40], UnitPrice = 18.40m, Quantity = 10, Discount = 0.1F},
                    new OrderDetail {Product = products[57], UnitPrice = 19.50m, Quantity = 5, Discount = 0.1F},
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 15, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "LEHMS",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("May 14 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun 11 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jun  6 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 58.88m,
                    ShipName = "Lehmanns Marktstand",
                    ShipAddress = "Magazinweg 7",
                    ShipCity = "Frankfurt a.M.",
                    ShipRegion = "",
                    ShipPostalCode = "60528",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[12], UnitPrice = 38.00m, Quantity = 15, Discount = 0.25F},
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[33], UnitPrice = 2.50m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 35, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "RICSU",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("May 14 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("May 28 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("May 19 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 78.85m,
                    ShipName = "Richter Supermarkt",
                    ShipAddress = "Starenweg 5",
                    ShipCity = "Genève",
                    ShipRegion = "",
                    ShipPostalCode = "1204",
                    ShipCountry = "Switzerland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[51], UnitPrice = 53.00m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[58], UnitPrice = 13.25m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[72], UnitPrice = 34.80m, Quantity = 21, Discount = 0F},
                    new OrderDetail {Product = products[73], UnitPrice = 15.00m, Quantity = 9, Discount = 0F}),

                new Order
                {
                    CustomerId = "BSBEV",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("May 15 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun 12 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("May 16 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 4.87m,
                    ShipName = "B's Beverages",
                    ShipAddress = "Fauntleroy Circus",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "EC2 5NT",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[70], UnitPrice = 15.00m, Quantity = 7, Discount = 0F},
                    new OrderDetail {Product = products[72], UnitPrice = 34.80m, Quantity = 1, Discount = 0F}),

                new Order
                {
                    CustomerId = "BSBEV",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("May 16 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun 13 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("May 23 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 12.36m,
                    ShipName = "B's Beverages",
                    ShipAddress = "Fauntleroy Circus",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "EC2 5NT",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[13], UnitPrice = 6.00m, Quantity = 8, Discount = 0F},
                    new OrderDetail {Product = products[21], UnitPrice = 10.00m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[33], UnitPrice = 2.50m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[49], UnitPrice = 20.00m, Quantity = 6, Discount = 0F}),

                new Order
                {
                    CustomerId = "QUICK",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("May 19 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun 16 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jun 13 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 1007.64m,
                    ShipName = "QUICK-Stop",
                    ShipAddress = "Taucherstraße 10",
                    ShipCity = "Cunewalde",
                    ShipRegion = "",
                    ShipPostalCode = "01307",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[3], UnitPrice = 10.00m, Quantity = 60, Discount = 0F},
                    new OrderDetail {Product = products[26], UnitPrice = 31.23m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[38], UnitPrice = 263.50m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[68], UnitPrice = 12.50m, Quantity = 35, Discount = 0F}),

                new Order
                {
                    CustomerId = "HANAR",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("May 19 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun 16 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("May 29 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 68.65m,
                    ShipName = "Hanari Carnes",
                    ShipAddress = "Rua do Paço, 67",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "05454-876",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 35, Discount = 0.1F},
                    new OrderDetail {Product = products[38], UnitPrice = 263.50m, Quantity = 4, Discount = 0.1F},
                    new OrderDetail {Product = products[65], UnitPrice = 21.05m, Quantity = 36, Discount = 0.1F},
                    new OrderDetail {Product = products[71], UnitPrice = 21.50m, Quantity = 9, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "KOENE",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("May 20 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun 17 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("May 26 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 10.95m,
                    ShipName = "Königlich Essen",
                    ShipAddress = "Maubelstr. 90",
                    ShipCity = "Brandenburg",
                    ShipRegion = "",
                    ShipPostalCode = "14776",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 21.00m, Quantity = 15, Discount = 0.05F},
                    new OrderDetail {Product = products[54], UnitPrice = 7.45m, Quantity = 24, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "LILAS",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("May 21 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun 18 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("May 23 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 48.17m,
                    ShipName = "LILA-Supermercado",
                    ShipAddress = "Carrera 52 con Ave. Bolívar #65-98 Llano Largo",
                    ShipCity = "Barquisimeto",
                    ShipRegion = "Lara",
                    ShipPostalCode = "3508",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[12], UnitPrice = 38.00m, Quantity = 30, Discount = 0.15F},
                    new OrderDetail {Product = products[23], UnitPrice = 9.00m, Quantity = 70, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "LONEP",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("May 21 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun 18 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("May 30 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 24.91m,
                    ShipName = "Lonesome Pine Restaurant",
                    ShipAddress = "89 Chiaroscuro Rd.",
                    ShipCity = "Portland",
                    ShipRegion = "OR",
                    ShipPostalCode = "97219",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[28], UnitPrice = 45.60m, Quantity = 7, Discount = 0F},
                    new OrderDetail {Product = products[67], UnitPrice = 14.00m, Quantity = 7, Discount = 0F}),

                new Order
                {
                    CustomerId = "LAZYK",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("May 22 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun 19 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jun 26 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 11.92m,
                    ShipName = "Lazy K Kountry Store",
                    ShipAddress = "12 Orchestra Terrace",
                    ShipCity = "Walla Walla",
                    ShipRegion = "WA",
                    ShipPostalCode = "99362",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 21.00m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "VICTE",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("May 23 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun 20 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("May 27 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 194.72m,
                    ShipName = "Victuailles en stock",
                    ShipAddress = "2, rue du Commerce",
                    ShipCity = "Lyon",
                    ShipRegion = "",
                    ShipPostalCode = "69004",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[7], UnitPrice = 30.00m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[35], UnitPrice = 18.00m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 40, Discount = 0F}),

                new Order
                {
                    CustomerId = "SEVES",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("May 23 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun 20 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jun  2 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 178.43m,
                    ShipName = "Seven Seas Imports",
                    ShipAddress = "90 Wadhurst Rd.",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "OX15 4NB",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[32], UnitPrice = 32.00m, Quantity = 24, Discount = 0.15F},
                    new OrderDetail {Product = products[36], UnitPrice = 19.00m, Quantity = 60, Discount = 0F}),

                new Order
                {
                    CustomerId = "TOMSP",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("May 26 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun 23 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jun  2 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 1.43m,
                    ShipName = "Toms Spezialitäten",
                    ShipAddress = "Luisenstr. 48",
                    ShipCity = "Münster",
                    ShipRegion = "",
                    ShipPostalCode = "44087",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[34], UnitPrice = 14.00m, Quantity = 10, Discount = 0.25F},
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 14, Discount = 0F}),

                new Order
                {
                    CustomerId = "QUICK",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("May 27 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun 10 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("May 30 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 171.24m,
                    ShipName = "QUICK-Stop",
                    ShipAddress = "Taucherstraße 10",
                    ShipCity = "Cunewalde",
                    ShipRegion = "",
                    ShipPostalCode = "01307",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 55, Discount = 0.15F},
                    new OrderDetail {Product = products[45], UnitPrice = 9.50m, Quantity = 100, Discount = 0.15F},
                    new OrderDetail {Product = products[51], UnitPrice = 53.00m, Quantity = 48, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "GODOS",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("May 28 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun 25 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jun  6 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 4.32m,
                    ShipName = "Godos Cocina Típica",
                    ShipAddress = "C/ Romero, 33",
                    ShipCity = "Sevilla",
                    ShipRegion = "",
                    ShipPostalCode = "41101",
                    ShipCountry = "Spain",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[17], UnitPrice = 39.00m, Quantity = 8, Discount = 0.1F},
                    new OrderDetail {Product = products[19], UnitPrice = 9.20m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[21], UnitPrice = 10.00m, Quantity = 6, Discount = 0.1F},
                    new OrderDetail {Product = products[61], UnitPrice = 28.50m, Quantity = 10, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "FURIB",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("May 28 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul  9 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jun  6 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 72.95m,
                    ShipName = "Furia Bacalhau e Frutos do Mar",
                    ShipAddress = "Jardim das rosas n. 32",
                    ShipCity = "Lisboa",
                    ShipRegion = "",
                    ShipPostalCode = "1675",
                    ShipCountry = "Portugal",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[16], UnitPrice = 17.45m, Quantity = 40, Discount = 0.15F},
                    new OrderDetail {Product = products[35], UnitPrice = 18.00m, Quantity = 20, Discount = 0.15F},
                    new OrderDetail {Product = products[44], UnitPrice = 19.45m, Quantity = 40, Discount = 0F}),

                new Order
                {
                    CustomerId = "HILAA",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("May 29 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun 26 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jun  5 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 83.22m,
                    ShipName = "HILARION-Abastos",
                    ShipAddress = "Carrera 22 con Ave. Carlos Soublette #8-35",
                    ShipCity = "San Cristóbal",
                    ShipRegion = "Táchira",
                    ShipPostalCode = "5022",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[69], UnitPrice = 36.00m, Quantity = 18, Discount = 0F},
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "WARTH",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("May 30 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun 27 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jun  3 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 149.49m,
                    ShipName = "Wartian Herkku",
                    ShipAddress = "Torikatu 38",
                    ShipCity = "Oulu",
                    ShipRegion = "",
                    ShipPostalCode = "90110",
                    ShipCountry = "Finland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 21.00m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[16], UnitPrice = 17.45m, Quantity = 14, Discount = 0F},
                    new OrderDetail {Product = products[22], UnitPrice = 21.00m, Quantity = 24, Discount = 0F},
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[35], UnitPrice = 18.00m, Quantity = 6, Discount = 0F}),

                new Order
                {
                    CustomerId = "OTTIK",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("May 30 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun 27 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jun  5 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 120.97m,
                    ShipName = "Ottilies Käseladen",
                    ShipAddress = "Mehrheimerstr. 369",
                    ShipCity = "Köln",
                    ShipRegion = "",
                    ShipPostalCode = "50739",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[16], UnitPrice = 17.45m, Quantity = 30, Discount = 0.05F},
                    new OrderDetail {Product = products[23], UnitPrice = 9.00m, Quantity = 20, Discount = 0.05F},
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 20, Discount = 0.05F},
                    new OrderDetail {Product = products[77], UnitPrice = 13.00m, Quantity = 10, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "SAVEA",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Jun  2 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun 30 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jun  4 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 252.49m,
                    ShipName = "Save-a-lot Markets",
                    ShipAddress = "187 Suffolk Ln.",
                    ShipCity = "Boise",
                    ShipRegion = "ID",
                    ShipPostalCode = "83720",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[14], UnitPrice = 23.25m, Quantity = 30, Discount = 0.2F},
                    new OrderDetail {Product = products[19], UnitPrice = 9.20m, Quantity = 35, Discount = 0.2F},
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 18, Discount = 0.2F},
                    new OrderDetail {Product = products[51], UnitPrice = 53.00m, Quantity = 20, Discount = 0.2F},
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 40, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "SIMOB",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Jun  3 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul 15 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jun 13 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 9.80m,
                    ShipName = "Simons bistro",
                    ShipAddress = "Vinbæltet 34",
                    ShipCity = "Kobenhavn",
                    ShipRegion = "",
                    ShipPostalCode = "1734",
                    ShipCountry = "Denmark",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[72], UnitPrice = 34.80m, Quantity = 24, Discount = 0F}),

                new Order
                {
                    CustomerId = "LEHMS",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Jun  3 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun 17 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jun  6 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 96.72m,
                    ShipName = "Lehmanns Marktstand",
                    ShipAddress = "Magazinweg 7",
                    ShipCity = "Frankfurt a.M.",
                    ShipRegion = "",
                    ShipPostalCode = "60528",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[64], UnitPrice = 33.25m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "AROUT",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Jun  4 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul  2 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jun 10 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 72.97m,
                    ShipName = "Around the Horn",
                    ShipAddress = "Brook Farm Stratford St. Mary",
                    ShipCity = "Colchester",
                    ShipRegion = "Essex",
                    ShipPostalCode = "CO7 6JX",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[47], UnitPrice = 9.50m, Quantity = 25, Discount = 0F},
                    new OrderDetail {Product = products[51], UnitPrice = 53.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[52], UnitPrice = 7.00m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[53], UnitPrice = 32.80m, Quantity = 18, Discount = 0F},
                    new OrderDetail {Product = products[73], UnitPrice = 15.00m, Quantity = 3, Discount = 0F}),

                new Order
                {
                    CustomerId = "BLONP",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Jun  5 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul  3 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jun 13 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 8.05m,
                    ShipName = "Blondel père et fils",
                    ShipAddress = "24, place Kléber",
                    ShipCity = "Strasbourg",
                    ShipRegion = "",
                    ShipPostalCode = "67000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 12, Discount = 0.05F},
                    new OrderDetail {Product = products[55], UnitPrice = 24.00m, Quantity = 18, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "FRANK",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Jun  6 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul  4 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jun  9 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 36.65m,
                    ShipName = "Frankenversand",
                    ShipAddress = "Berliner Platz 43",
                    ShipCity = "München",
                    ShipRegion = "",
                    ShipPostalCode = "80805",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[30], UnitPrice = 25.89m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 15, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "FOLKO",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Jun  6 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul  4 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jun  9 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 242.21m,
                    ShipName = "Folk och fä HB",
                    ShipAddress = "Åkergatan 24",
                    ShipCity = "Bräcke",
                    ShipRegion = "",
                    ShipPostalCode = "S-844 67",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[44], UnitPrice = 19.45m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[51], UnitPrice = 53.00m, Quantity = 50, Discount = 0F}),

                new Order
                {
                    CustomerId = "REGGC",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Jun  9 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul  7 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jun 12 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 22.95m,
                    ShipName = "Reggiani Caseifici",
                    ShipAddress = "Strada Provinciale 124",
                    ShipCity = "Reggio Emilia",
                    ShipRegion = "",
                    ShipPostalCode = "42100",
                    ShipCountry = "Italy",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[33], UnitPrice = 2.50m, Quantity = 20, Discount = 0.1F},
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 10, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "RICAR",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Jun 10 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul 22 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jun 24 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 60.43m,
                    ShipName = "Ricardo Adocicados",
                    ShipAddress = "Av. Copacabana, 267",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "02389-890",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[36], UnitPrice = 19.00m, Quantity = 25, Discount = 0F},
                    new OrderDetail {Product = products[52], UnitPrice = 7.00m, Quantity = 70, Discount = 0F}),

                new Order
                {
                    CustomerId = "RATTC",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Jun 10 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul  8 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jun 16 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 13.75m,
                    ShipName = "Rattlesnake Canyon Grocery",
                    ShipAddress = "2817 Milton Dr.",
                    ShipCity = "Albuquerque",
                    ShipRegion = "NM",
                    ShipPostalCode = "87110",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[17], UnitPrice = 39.00m, Quantity = 16, Discount = 0.05F},
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 6, Discount = 0.05F},
                    new OrderDetail {Product = products[55], UnitPrice = 24.00m, Quantity = 25, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "MEREP",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Jun 11 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul  9 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jun 18 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 7.15m,
                    ShipName = "Mère Paillarde",
                    ShipAddress = "43 rue St. Laurent",
                    ShipCity = "Montréal",
                    ShipRegion = "Québec",
                    ShipPostalCode = "H1J 1C3",
                    ShipCountry = "Canada",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 25, Discount = 0.1F},
                    new OrderDetail {Product = products[64], UnitPrice = 33.25m, Quantity = 18, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "BLONP",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Jun 12 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul 10 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jun 18 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 88.40m,
                    ShipName = "Blondel père et fils",
                    ShipAddress = "24, place Kléber",
                    ShipCity = "Strasbourg",
                    ShipRegion = "",
                    ShipPostalCode = "67000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 21.00m, Quantity = 35, Discount = 0.15F},
                    new OrderDetail {Product = products[18], UnitPrice = 62.50m, Quantity = 18, Discount = 0.15F},
                    new OrderDetail {Product = products[76], UnitPrice = 18.00m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "HUNGO",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Jun 12 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul 10 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jun 17 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 33.97m,
                    ShipName = "Hungry Owl All-Night Grocers",
                    ShipAddress = "8 Johnstown Road",
                    ShipCity = "Cork",
                    ShipRegion = "Co. Cork",
                    ShipPostalCode = "",
                    ShipCountry = "Ireland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 60, Discount = 0.2F},
                    new OrderDetail {Product = products[51], UnitPrice = 53.00m, Quantity = 3, Discount = 0F},
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 40, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "GALED",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Jun 13 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul 11 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul  9 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 6.54m,
                    ShipName = "Galería del gastronómo",
                    ShipAddress = "Rambla de Cataluña, 23",
                    ShipCity = "Barcelona",
                    ShipRegion = "",
                    ShipPostalCode = "8022",
                    ShipCountry = "Spain",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[10], UnitPrice = 31.00m, Quantity = 5, Discount = 0F}),

                new Order
                {
                    CustomerId = "RATTC",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Jun 16 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul 14 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 11 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 58.98m,
                    ShipName = "Rattlesnake Canyon Grocery",
                    ShipAddress = "2817 Milton Dr.",
                    ShipCity = "Albuquerque",
                    ShipRegion = "NM",
                    ShipPostalCode = "87110",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 35, Discount = 0.2F},
                    new OrderDetail {Product = products[76], UnitPrice = 18.00m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "MEREP",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Jun 17 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul 15 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jun 19 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 188.99m,
                    ShipName = "Mère Paillarde",
                    ShipAddress = "43 rue St. Laurent",
                    ShipCity = "Montréal",
                    ShipRegion = "Québec",
                    ShipPostalCode = "H1J 1C3",
                    ShipCountry = "Canada",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 21.00m, Quantity = 15, Discount = 0.05F},
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 60, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "ERNSH",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Jun 17 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul 29 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul  4 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 26.06m,
                    ShipName = "Ernst Handel",
                    ShipAddress = "Kirchgasse 6",
                    ShipCity = "Graz",
                    ShipRegion = "",
                    ShipPostalCode = "8010",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[14], UnitPrice = 23.25m, Quantity = 11, Discount = 0.15F},
                    new OrderDetail {Product = products[42], UnitPrice = 14.00m, Quantity = 28, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "BERGS",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Jun 18 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul 16 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jun 25 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 116.43m,
                    ShipName = "Berglunds snabbköp",
                    ShipAddress = "Berguvsvägen  8",
                    ShipCity = "Luleå",
                    ShipRegion = "",
                    ShipPostalCode = "S-958 22",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[16], UnitPrice = 17.45m, Quantity = 12, Discount = 0.1F},
                    new OrderDetail {Product = products[32], UnitPrice = 32.00m, Quantity = 10, Discount = 0.1F},
                    new OrderDetail {Product = products[40], UnitPrice = 18.40m, Quantity = 50, Discount = 0F},
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 15, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "ANTON",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Jun 19 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul 17 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jun 20 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 84.84m,
                    ShipName = "Antonio Moreno Taquería",
                    ShipAddress = "Mataderos  2312",
                    ShipCity = "México D.F.",
                    ShipRegion = "",
                    ShipPostalCode = "05023",
                    ShipCountry = "Mexico",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[17], UnitPrice = 39.00m, Quantity = 18, Discount = 0F},
                    new OrderDetail {Product = products[34], UnitPrice = 14.00m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[53], UnitPrice = 32.80m, Quantity = 25, Discount = 0F}),

                new Order
                {
                    CustomerId = "TRAIH",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Jun 19 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul 17 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jun 30 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 37.60m,
                    ShipName = "Trail's Head Gourmet Provisioners",
                    ShipAddress = "722 DaVinci Blvd.",
                    ShipCity = "Kirkland",
                    ShipRegion = "WA",
                    ShipPostalCode = "98034",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[33], UnitPrice = 2.50m, Quantity = 14, Discount = 0F},
                    new OrderDetail {Product = products[40], UnitPrice = 18.40m, Quantity = 2, Discount = 0F},
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[64], UnitPrice = 33.25m, Quantity = 6, Discount = 0F}),

                new Order
                {
                    CustomerId = "MORGK",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Jun 20 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul  4 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jun 30 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 127.34m,
                    ShipName = "Morgenstern Gesundkost",
                    ShipAddress = "Heerstr. 22",
                    ShipCity = "Leipzig",
                    ShipRegion = "",
                    ShipPostalCode = "04179",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[63], UnitPrice = 43.90m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[72], UnitPrice = 34.80m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[76], UnitPrice = 18.00m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "TORTU",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Jun 23 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul  7 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jun 30 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 18.56m,
                    ShipName = "Tortuga Restaurante",
                    ShipAddress = "Avda. Azteca 123",
                    ShipCity = "México D.F.",
                    ShipRegion = "",
                    ShipPostalCode = "05033",
                    ShipCountry = "Mexico",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 18.00m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[44], UnitPrice = 19.45m, Quantity = 21, Discount = 0F}),

                new Order
                {
                    CustomerId = "TRAIH",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Jun 23 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug  4 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jun 30 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 25.41m,
                    ShipName = "Trail's Head Gourmet Provisioners",
                    ShipAddress = "722 DaVinci Blvd.",
                    ShipCity = "Kirkland",
                    ShipRegion = "WA",
                    ShipPostalCode = "98034",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[39], UnitPrice = 18.00m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[77], UnitPrice = 13.00m, Quantity = 18, Discount = 0F}),

                new Order
                {
                    CustomerId = "BSBEV",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Jun 24 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul 22 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 25 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 29.60m,
                    ShipName = "B's Beverages",
                    ShipAddress = "Fauntleroy Circus",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "EC2 5NT",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[35], UnitPrice = 18.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[57], UnitPrice = 19.50m, Quantity = 6, Discount = 0F}),

                new Order
                {
                    CustomerId = "LETSS",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Jun 25 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul 23 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul  4 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 13.73m,
                    ShipName = "Let's Stop N Shop",
                    ShipAddress = "87 Polk St. Suite 5",
                    ShipCity = "San Francisco",
                    ShipRegion = "CA",
                    ShipPostalCode = "94117",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[15], UnitPrice = 15.50m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 21, Discount = 0F}),

                new Order
                {
                    CustomerId = "OTTIK",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Jun 26 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul 24 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul  1 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 75.89m,
                    ShipName = "Ottilies Käseladen",
                    ShipAddress = "Mehrheimerstr. 369",
                    ShipCity = "Köln",
                    ShipRegion = "",
                    ShipPostalCode = "50739",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[14], UnitPrice = 23.25m, Quantity = 15, Discount = 0.05F},
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 9, Discount = 0.05F},
                    new OrderDetail {Product = products[65], UnitPrice = 21.05m, Quantity = 30, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "FAMIA",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Jun 26 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul 24 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul  2 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 3.01m,
                    ShipName = "Familia Arquibaldo",
                    ShipAddress = "Rua Orós, 92",
                    ShipCity = "Sao Paulo",
                    ShipRegion = "SP",
                    ShipPostalCode = "05442-030",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 50, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "BLAUS",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Jun 27 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul 25 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 14 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 27.71m,
                    ShipName = "Blauer See Delikatessen",
                    ShipAddress = "Forsterstr. 57",
                    ShipCity = "Mannheim",
                    ShipRegion = "",
                    ShipPostalCode = "68306",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[57], UnitPrice = 19.50m, Quantity = 4, Discount = 0F},
                    new OrderDetail {Product = products[76], UnitPrice = 18.00m, Quantity = 14, Discount = 0F}),

                new Order
                {
                    CustomerId = "WARTH",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Jun 30 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul 28 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul  4 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 7.28m,
                    ShipName = "Wartian Herkku",
                    ShipAddress = "Torikatu 38",
                    ShipCity = "Oulu",
                    ShipRegion = "",
                    ShipPostalCode = "90110",
                    ShipCountry = "Finland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[29], UnitPrice = 123.79m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 24, Discount = 0.15F},
                    new OrderDetail {Product = products[69], UnitPrice = 36.00m, Quantity = 10, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "BLONP",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Jun 30 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul 28 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul  4 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 59.14m,
                    ShipName = "Blondel père et fils",
                    ShipAddress = "24, place Kléber",
                    ShipCity = "Strasbourg",
                    ShipRegion = "",
                    ShipPostalCode = "67000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 50, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "WELLI",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Jul  1 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul 29 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 10 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 13.41m,
                    ShipName = "Wellington Importadora",
                    ShipAddress = "Rua do Mercado, 12",
                    ShipCity = "Resende",
                    ShipRegion = "SP",
                    ShipPostalCode = "08737-363",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[47], UnitPrice = 9.50m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "REGGC",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Jul  2 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul 30 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul  9 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 0.48m,
                    ShipName = "Reggiani Caseifici",
                    ShipAddress = "Strada Provinciale 124",
                    ShipCity = "Reggio Emilia",
                    ShipRegion = "",
                    ShipPostalCode = "42100",
                    ShipCountry = "Italy",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[52], UnitPrice = 7.00m, Quantity = 4, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "QUEDE",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Jul  2 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul 30 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul  9 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 62.52m,
                    ShipName = "Que Delícia",
                    ShipAddress = "Rua da Panificadora, 12",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "02389-673",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[26], UnitPrice = 31.23m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[35], UnitPrice = 18.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[77], UnitPrice = 13.00m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "QUICK",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Jul  3 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul 31 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 10 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 194.67m,
                    ShipName = "QUICK-Stop",
                    ShipAddress = "Taucherstraße 10",
                    ShipCity = "Cunewalde",
                    ShipRegion = "",
                    ShipPostalCode = "01307",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[18], UnitPrice = 62.50m, Quantity = 40, Discount = 0.2F},
                    new OrderDetail {Product = products[42], UnitPrice = 14.00m, Quantity = 100, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "GREAL",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Jul  4 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug  1 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 14 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 4.42m,
                    ShipName = "Great Lakes Food Market",
                    ShipAddress = "2732 Baker Blvd.",
                    ShipCity = "Eugene",
                    ShipRegion = "OR",
                    ShipPostalCode = "97403",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[35], UnitPrice = 18.00m, Quantity = 4, Discount = 0F}),

                new Order
                {
                    CustomerId = "MEREP",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Jul  7 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug  4 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 14 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 44.77m,
                    ShipName = "Mère Paillarde",
                    ShipAddress = "43 rue St. Laurent",
                    ShipCity = "Montréal",
                    ShipRegion = "Québec",
                    ShipPostalCode = "H1J 1C3",
                    ShipCountry = "Canada",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 18.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[77], UnitPrice = 13.00m, Quantity = 60, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "VAFFE",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Jul  7 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jul 21 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 16 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 55.92m,
                    ShipName = "Vaffeljernet",
                    ShipAddress = "Smagsloget 45",
                    ShipCity = "Århus",
                    ShipRegion = "",
                    ShipPostalCode = "8200",
                    ShipCountry = "Denmark",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[3], UnitPrice = 10.00m, Quantity = 14, Discount = 0F},
                    new OrderDetail {Product = products[7], UnitPrice = 30.00m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[54], UnitPrice = 7.45m, Quantity = 50, Discount = 0F}),

                new Order
                {
                    CustomerId = "LEHMS",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Jul  8 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug  5 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 16 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 32.10m,
                    ShipName = "Lehmanns Marktstand",
                    ShipAddress = "Magazinweg 7",
                    ShipCity = "Frankfurt a.M.",
                    ShipRegion = "",
                    ShipPostalCode = "60528",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[15], UnitPrice = 15.50m, Quantity = 25, Discount = 0.05F},
                    new OrderDetail {Product = products[26], UnitPrice = 31.23m, Quantity = 5, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "LEHMS",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Jul  9 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug  6 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 13 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 174.20m,
                    ShipName = "Lehmanns Marktstand",
                    ShipAddress = "Magazinweg 7",
                    ShipCity = "Frankfurt a.M.",
                    ShipRegion = "",
                    ShipPostalCode = "60528",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[20], UnitPrice = 81.00m, Quantity = 21, Discount = 0.2F},
                    new OrderDetail {Product = products[69], UnitPrice = 36.00m, Quantity = 20, Discount = 0.2F},
                    new OrderDetail {Product = products[76], UnitPrice = 18.00m, Quantity = 4, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "OLDWO",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Jul  9 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug  6 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 16 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 5.24m,
                    ShipName = "Old World Delicatessen",
                    ShipAddress = "2743 Bering St.",
                    ShipCity = "Anchorage",
                    ShipRegion = "AK",
                    ShipPostalCode = "99508",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[52], UnitPrice = 7.00m, Quantity = 24, Discount = 0F},
                    new OrderDetail {Product = products[58], UnitPrice = 13.25m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "ERNSH",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Jul 10 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug  7 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 14 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 96.78m,
                    ShipName = "Ernst Handel",
                    ShipAddress = "Kirchgasse 6",
                    ShipCity = "Graz",
                    ShipRegion = "",
                    ShipPostalCode = "8010",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[35], UnitPrice = 18.00m, Quantity = 30, Discount = 0.25F},
                    new OrderDetail {Product = products[61], UnitPrice = 28.50m, Quantity = 120, Discount = 0.25F},
                    new OrderDetail {Product = products[69], UnitPrice = 36.00m, Quantity = 65, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "WHITC",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Jul 11 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug  8 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 12 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 16.34m,
                    ShipName = "White Clover Markets",
                    ShipAddress = "1029 - 12th Ave. S.",
                    ShipCity = "Seattle",
                    ShipRegion = "WA",
                    ShipPostalCode = "98124",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 5, Discount = 0.2F},
                    new OrderDetail {Product = products[63], UnitPrice = 43.90m, Quantity = 24, Discount = 0.2F},
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 30, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "PICCO",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Jul 11 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug  8 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 18 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 35.12m,
                    ShipName = "Piccolo und mehr",
                    ShipAddress = "Geislweg 14",
                    ShipCity = "Salzburg",
                    ShipRegion = "",
                    ShipPostalCode = "5020",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 35, Discount = 0.2F},
                    new OrderDetail {Product = products[57], UnitPrice = 19.50m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[65], UnitPrice = 21.05m, Quantity = 12, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "RATTC",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Jul 14 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 11 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 18 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 44.42m,
                    ShipName = "Rattlesnake Canyon Grocery",
                    ShipAddress = "2817 Milton Dr.",
                    ShipCity = "Albuquerque",
                    ShipRegion = "NM",
                    ShipPostalCode = "87110",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[27], UnitPrice = 43.90m, Quantity = 50, Discount = 0F},
                    new OrderDetail {Product = products[71], UnitPrice = 21.50m, Quantity = 9, Discount = 0F}),

                new Order
                {
                    CustomerId = "BSBEV",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Jul 15 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 26 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 21 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 29.98m,
                    ShipName = "B's Beverages",
                    ShipAddress = "Fauntleroy Circus",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "EC2 5NT",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "HUNGC",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Jul 16 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 13 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 21 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 45.13m,
                    ShipName = "Hungry Coyote Import Store",
                    ShipAddress = "City Center Plaza 516 Main St.",
                    ShipCity = "Elgin",
                    ShipRegion = "OR",
                    ShipPostalCode = "97827",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[54], UnitPrice = 7.45m, Quantity = 4, Discount = 0F},
                    new OrderDetail {Product = products[73], UnitPrice = 15.00m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "HILAA",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Jul 16 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 27 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 22 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 58.30m,
                    ShipName = "HILARION-Abastos",
                    ShipAddress = "Carrera 22 con Ave. Carlos Soublette #8-35",
                    ShipCity = "San Cristóbal",
                    ShipRegion = "Táchira",
                    ShipPostalCode = "5022",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[13], UnitPrice = 6.00m, Quantity = 60, Discount = 0F},
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 35, Discount = 0F}),

                new Order
                {
                    CustomerId = "VAFFE",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Jul 17 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 14 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 22 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 2.92m,
                    ShipName = "Vaffeljernet",
                    ShipAddress = "Smagsloget 45",
                    ShipCity = "Århus",
                    ShipRegion = "",
                    ShipPostalCode = "8200",
                    ShipCountry = "Denmark",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[77], UnitPrice = 13.00m, Quantity = 5, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "SAVEA",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Jul 18 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 15 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug  8 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 48.77m,
                    ShipName = "Save-a-lot Markets",
                    ShipAddress = "187 Suffolk Ln.",
                    ShipCity = "Boise",
                    ShipRegion = "ID",
                    ShipPostalCode = "83720",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[22], UnitPrice = 21.00m, Quantity = 48, Discount = 0F},
                    new OrderDetail {Product = products[49], UnitPrice = 20.00m, Quantity = 25, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "FURIB",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Jul 18 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 15 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 29 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 7.46m,
                    ShipName = "Furia Bacalhau e Frutos do Mar",
                    ShipAddress = "Jardim das rosas n. 32",
                    ShipCity = "Lisboa",
                    ShipRegion = "",
                    ShipPostalCode = "1675",
                    ShipCountry = "Portugal",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[48], UnitPrice = 12.75m, Quantity = 6, Discount = 0.1F},
                    new OrderDetail {Product = products[76], UnitPrice = 18.00m, Quantity = 10, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "MEREP",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Jul 21 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 18 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 29 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 379.13m,
                    ShipName = "Mère Paillarde",
                    ShipAddress = "43 rue St. Laurent",
                    ShipCity = "Montréal",
                    ShipRegion = "Québec",
                    ShipPostalCode = "H1J 1C3",
                    ShipCountry = "Canada",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[16], UnitPrice = 17.45m, Quantity = 30, Discount = 0.05F},
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 20, Discount = 0.05F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 70, Discount = 0.05F},
                    new OrderDetail {Product = products[71], UnitPrice = 21.50m, Quantity = 15, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "TRADH",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Jul 22 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 19 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 31 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 79.40m,
                    ShipName = "Tradiçao Hipermercados",
                    ShipAddress = "Av. Inês de Castro, 414",
                    ShipCity = "Sao Paulo",
                    ShipRegion = "SP",
                    ShipPostalCode = "05634-030",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[4], UnitPrice = 22.00m, Quantity = 20, Discount = 0.2F},
                    new OrderDetail {Product = products[55], UnitPrice = 24.00m, Quantity = 20, Discount = 0.2F},
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 10, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "SAVEA",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Jul 22 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 19 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 25 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 200.24m,
                    ShipName = "Save-a-lot Markets",
                    ShipAddress = "187 Suffolk Ln.",
                    ShipCity = "Boise",
                    ShipRegion = "ID",
                    ShipPostalCode = "83720",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[7], UnitPrice = 30.00m, Quantity = 45, Discount = 0F},
                    new OrderDetail {Product = products[17], UnitPrice = 39.00m, Quantity = 100, Discount = 0F},
                    new OrderDetail {Product = products[33], UnitPrice = 2.50m, Quantity = 14, Discount = 0F},
                    new OrderDetail {Product = products[40], UnitPrice = 18.40m, Quantity = 42, Discount = 0F},
                    new OrderDetail {Product = products[72], UnitPrice = 34.80m, Quantity = 12, Discount = 0F}),

                new Order
                {
                    CustomerId = "TOMSP",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Jul 23 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 20 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug  1 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 27.79m,
                    ShipName = "Toms Spezialitäten",
                    ShipAddress = "Luisenstr. 48",
                    ShipCity = "Münster",
                    ShipRegion = "",
                    ShipPostalCode = "44087",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 28, Discount = 0F}),

                new Order
                {
                    CustomerId = "DUMON",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Jul 24 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 21 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jul 30 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 1.85m,
                    ShipName = "Du monde entier",
                    ShipAddress = "67, rue des Cinquante Otages",
                    ShipCity = "Nantes",
                    ShipRegion = "",
                    ShipPostalCode = "44000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 18.00m, Quantity = 3, Discount = 0F},
                    new OrderDetail {Product = products[10], UnitPrice = 31.00m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[21], UnitPrice = 10.00m, Quantity = 6, Discount = 0F}),

                new Order
                {
                    CustomerId = "LAMAI",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Jul 25 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 22 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug  6 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 26.78m,
                    ShipName = "La maison d'Asie",
                    ShipAddress = "1 rue Alsace-Lorraine",
                    ShipCity = "Toulouse",
                    ShipRegion = "",
                    ShipPostalCode = "31000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[36], UnitPrice = 19.00m, Quantity = 21, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "WOLZA",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Jul 25 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 22 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug  1 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 80.65m,
                    ShipName = "Wolski Zajazd",
                    ShipAddress = "ul. Filtrowa 68",
                    ShipCity = "Warszawa",
                    ShipRegion = "",
                    ShipPostalCode = "01-012",
                    ShipCountry = "Poland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 18.00m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[2], UnitPrice = 19.00m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "SAVEA",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Jul 28 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 25 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug  1 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 544.08m,
                    ShipName = "Save-a-lot Markets",
                    ShipAddress = "187 Suffolk Ln.",
                    ShipCity = "Boise",
                    ShipRegion = "ID",
                    ShipPostalCode = "83720",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[10], UnitPrice = 31.00m, Quantity = 70, Discount = 0F},
                    new OrderDetail {Product = products[36], UnitPrice = 19.00m, Quantity = 55, Discount = 0F},
                    new OrderDetail {Product = products[49], UnitPrice = 20.00m, Quantity = 18, Discount = 0F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[76], UnitPrice = 18.00m, Quantity = 80, Discount = 0F}),

                new Order
                {
                    CustomerId = "HILAA",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Jul 29 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 26 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug  1 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 8.11m,
                    ShipName = "HILARION-Abastos",
                    ShipAddress = "Carrera 22 con Ave. Carlos Soublette #8-35",
                    ShipCity = "San Cristóbal",
                    ShipRegion = "Táchira",
                    ShipPostalCode = "5022",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[13], UnitPrice = 6.00m, Quantity = 8, Discount = 0.1F},
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 40, Discount = 0F}),

                new Order
                {
                    CustomerId = "BLAUS",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Jul 29 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 26 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug  1 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 1.93m,
                    ShipName = "Blauer See Delikatessen",
                    ShipAddress = "Forsterstr. 57",
                    ShipCity = "Mannheim",
                    ShipRegion = "",
                    ShipPostalCode = "68306",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 21.00m, Quantity = 14, Discount = 0F},
                    new OrderDetail {Product = products[21], UnitPrice = 10.00m, Quantity = 8, Discount = 0F},
                    new OrderDetail {Product = products[39], UnitPrice = 18.00m, Quantity = 5, Discount = 0F}),

                new Order
                {
                    CustomerId = "WILMK",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Jul 30 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 27 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug  6 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 0.75m,
                    ShipName = "Wilman Kala",
                    ShipAddress = "Keskuskatu 45",
                    ShipCity = "Helsinki",
                    ShipRegion = "",
                    ShipPostalCode = "21240",
                    ShipCountry = "Finland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[55], UnitPrice = 24.00m, Quantity = 5, Discount = 0F}),

                new Order
                {
                    CustomerId = "GREAL",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Jul 31 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 28 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug  5 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 116.53m,
                    ShipName = "Great Lakes Food Market",
                    ShipAddress = "2732 Baker Blvd.",
                    ShipCity = "Eugene",
                    ShipRegion = "OR",
                    ShipPostalCode = "97403",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[38], UnitPrice = 263.50m, Quantity = 15, Discount = 0.05F},
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 14, Discount = 0F},
                    new OrderDetail {Product = products[70], UnitPrice = 15.00m, Quantity = 15, Discount = 0.05F},
                    new OrderDetail {Product = products[71], UnitPrice = 21.50m, Quantity = 15, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "GREAL",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Jul 31 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Aug 28 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug  4 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 18.53m,
                    ShipName = "Great Lakes Food Market",
                    ShipAddress = "2732 Baker Blvd.",
                    ShipCity = "Eugene",
                    ShipRegion = "OR",
                    ShipPostalCode = "97403",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 30, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "MEREP",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Aug  1 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 12 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug  8 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 154.68m,
                    ShipName = "Mère Paillarde",
                    ShipAddress = "43 rue St. Laurent",
                    ShipCity = "Montréal",
                    ShipRegion = "Québec",
                    ShipPostalCode = "H1J 1C3",
                    ShipCountry = "Canada",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[6], UnitPrice = 25.00m, Quantity = 70, Discount = 0F},
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[68], UnitPrice = 12.50m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "MEREP",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Aug  4 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep  1 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug  7 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 91.05m,
                    ShipName = "Mère Paillarde",
                    ShipAddress = "43 rue St. Laurent",
                    ShipCity = "Montréal",
                    ShipRegion = "Québec",
                    ShipPostalCode = "H1J 1C3",
                    ShipCountry = "Canada",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[21], UnitPrice = 10.00m, Quantity = 42, Discount = 0F},
                    new OrderDetail {Product = products[22], UnitPrice = 21.00m, Quantity = 40, Discount = 0F}),

                new Order
                {
                    CustomerId = "LAUGB",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Aug  5 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep  2 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 14 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 0.94m,
                    ShipName = "Laughing Bacchus Wine Cellars",
                    ShipAddress = "2319 Elm St.",
                    ShipCity = "Vancouver",
                    ShipRegion = "BC",
                    ShipPostalCode = "V3F 2K1",
                    ShipCountry = "Canada",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 5, Discount = 0F},
                    new OrderDetail {Product = products[52], UnitPrice = 7.00m, Quantity = 5, Discount = 0F}),

                new Order
                {
                    CustomerId = "ISLAT",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Aug  5 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep  2 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 11 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 23.73m,
                    ShipName = "Island Trading",
                    ShipAddress = "Garden House Crowther Way",
                    ShipCity = "Cowes",
                    ShipRegion = "Isle of Wight",
                    ShipPostalCode = "PO31 7PJ",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[19], UnitPrice = 9.20m, Quantity = 5, Discount = 0F},
                    new OrderDetail {Product = products[23], UnitPrice = 9.00m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[70], UnitPrice = 15.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[71], UnitPrice = 21.50m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "RICAR",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Aug  6 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep  3 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 11 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 50.97m,
                    ShipName = "Ricardo Adocicados",
                    ShipAddress = "Av. Copacabana, 267",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "02389-890",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 19.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[68], UnitPrice = 12.50m, Quantity = 18, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "FRANK",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Aug  7 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep  4 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 12 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 97.18m,
                    ShipName = "Frankenversand",
                    ShipAddress = "Berliner Platz 43",
                    ShipCity = "München",
                    ShipRegion = "",
                    ShipPostalCode = "80805",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[14], UnitPrice = 23.25m, Quantity = 21, Discount = 0F},
                    new OrderDetail {Product = products[19], UnitPrice = 9.20m, Quantity = 15, Discount = 0.1F},
                    new OrderDetail {Product = products[21], UnitPrice = 10.00m, Quantity = 25, Discount = 0.1F},
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 3, Discount = 0F},
                    new OrderDetail {Product = products[35], UnitPrice = 18.00m, Quantity = 30, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "THECR",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Aug  7 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep  4 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 19 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 94.80m,
                    ShipName = "The Cracker Box",
                    ShipAddress = "55 Grizzly Peak Rd.",
                    ShipCity = "Butte",
                    ShipRegion = "MT",
                    ShipPostalCode = "59801",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[28], UnitPrice = 45.60m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[29], UnitPrice = 123.79m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[44], UnitPrice = 19.45m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "ANATR",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Aug  8 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep  5 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 14 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 43.90m,
                    ShipName = "Ana Trujillo Emparedados y helados",
                    ShipAddress = "Avda. de la Constitución 2222",
                    ShipCity = "México D.F.",
                    ShipRegion = "",
                    ShipPostalCode = "05021",
                    ShipCountry = "Mexico",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[14], UnitPrice = 23.25m, Quantity = 3, Discount = 0F},
                    new OrderDetail {Product = products[42], UnitPrice = 14.00m, Quantity = 5, Discount = 0F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "BERGS",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Aug 11 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep  8 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 20 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 138.69m,
                    ShipName = "Berglunds snabbköp",
                    ShipAddress = "Berguvsvägen  8",
                    ShipCity = "Luleå",
                    ShipRegion = "",
                    ShipPostalCode = "S-958 22",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[53], UnitPrice = 32.80m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[71], UnitPrice = 21.50m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "SAVEA",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Aug 11 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 22 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 21 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 107.46m,
                    ShipName = "Save-a-lot Markets",
                    ShipAddress = "187 Suffolk Ln.",
                    ShipCity = "Boise",
                    ShipRegion = "ID",
                    ShipPostalCode = "83720",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[73], UnitPrice = 15.00m, Quantity = 35, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "BLONP",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Aug 12 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep  9 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 20 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 30.36m,
                    ShipName = "Blondel père et fils",
                    ShipAddress = "24, place Kléber",
                    ShipCity = "Strasbourg",
                    ShipRegion = "",
                    ShipPostalCode = "67000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 18.00m, Quantity = 25, Discount = 0F}),

                new Order
                {
                    CustomerId = "GODOS",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Aug 12 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep  9 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 20 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 85.46m,
                    ShipName = "Godos Cocina Típica",
                    ShipAddress = "C/ Romero, 33",
                    ShipCity = "Sevilla",
                    ShipRegion = "",
                    ShipPostalCode = "41101",
                    ShipCountry = "Spain",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[29], UnitPrice = 123.79m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[64], UnitPrice = 33.25m, Quantity = 9, Discount = 0F}),

                new Order
                {
                    CustomerId = "KOENE",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Aug 13 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 10 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 19 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 32.35m,
                    ShipName = "Königlich Essen",
                    ShipAddress = "Maubelstr. 90",
                    ShipCity = "Brandenburg",
                    ShipRegion = "",
                    ShipPostalCode = "14776",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[55], UnitPrice = 24.00m, Quantity = 12, Discount = 0.05F},
                    new OrderDetail {Product = products[76], UnitPrice = 18.00m, Quantity = 35, Discount = 0F}),

                new Order
                {
                    CustomerId = "LAMAI",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Aug 14 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 11 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 15 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 0.87m,
                    ShipName = "La maison d'Asie",
                    ShipAddress = "1 rue Alsace-Lorraine",
                    ShipCity = "Toulouse",
                    ShipRegion = "",
                    ShipPostalCode = "31000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 8, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "WANDK",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Aug 14 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 11 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 19 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 41.38m,
                    ShipName = "Die Wandernde Kuh",
                    ShipAddress = "Adenauerallee 900",
                    ShipCity = "Stuttgart",
                    ShipRegion = "",
                    ShipPostalCode = "70563",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 19.00m, Quantity = 30, Discount = 0.05F},
                    new OrderDetail {Product = products[33], UnitPrice = 2.50m, Quantity = 20, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "ERNSH",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Aug 15 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 12 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 18 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 477.90m,
                    ShipName = "Ernst Handel",
                    ShipAddress = "Kirchgasse 6",
                    ShipCity = "Graz",
                    ShipRegion = "",
                    ShipPostalCode = "8010",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[12], UnitPrice = 38.00m, Quantity = 36, Discount = 0.15F},
                    new OrderDetail {Product = products[13], UnitPrice = 6.00m, Quantity = 13, Discount = 0.15F},
                    new OrderDetail {Product = products[26], UnitPrice = 31.23m, Quantity = 35, Discount = 0.15F},
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 80, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "FOLIG",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Aug 15 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 12 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 21 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 487.38m,
                    ShipName = "Folies gourmandes",
                    ShipAddress = "184, chaussée de Tournai",
                    ShipCity = "Lille",
                    ShipRegion = "",
                    ShipPostalCode = "59000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[7], UnitPrice = 30.00m, Quantity = 35, Discount = 0F},
                    new OrderDetail {Product = products[18], UnitPrice = 62.50m, Quantity = 50, Discount = 0F},
                    new OrderDetail {Product = products[51], UnitPrice = 53.00m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 2, Discount = 0F}),

                new Order
                {
                    CustomerId = "MAGAA",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Aug 18 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 15 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 21 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 47.46m,
                    ShipName = "Magazzini Alimentari Riuniti",
                    ShipAddress = "Via Ludovico il Moro 22",
                    ShipCity = "Bergamo",
                    ShipRegion = "",
                    ShipPostalCode = "24100",
                    ShipCountry = "Italy",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[4], UnitPrice = 22.00m, Quantity = 10, Discount = 0.1F},
                    new OrderDetail {Product = products[5], UnitPrice = 21.35m, Quantity = 15, Discount = 0.1F},
                    new OrderDetail {Product = products[22], UnitPrice = 21.00m, Quantity = 40, Discount = 0F}),

                new Order
                {
                    CustomerId = "WARTH",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Aug 19 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 16 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 26 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 1.15m,
                    ShipName = "Wartian Herkku",
                    ShipAddress = "Torikatu 38",
                    ShipCity = "Oulu",
                    ShipRegion = "",
                    ShipPostalCode = "90110",
                    ShipCountry = "Finland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[4], UnitPrice = 22.00m, Quantity = 25, Discount = 0F},
                    new OrderDetail {Product = products[58], UnitPrice = 13.25m, Quantity = 6, Discount = 0F}),

                new Order
                {
                    CustomerId = "QUEEN",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Aug 19 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 16 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 26 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 201.29m,
                    ShipName = "Queen Cozinha",
                    ShipAddress = "Alameda dos Canàrios, 891",
                    ShipCity = "Sao Paulo",
                    ShipRegion = "SP",
                    ShipPostalCode = "05487-020",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 21.00m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[50], UnitPrice = 16.25m, Quantity = 25, Discount = 0.05F},
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 60, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "LINOD",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Aug 20 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 17 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep  1 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 158.44m,
                    ShipName = "LINO-Delicateses",
                    ShipAddress = "Ave. 5 de Mayo Porlamar",
                    ShipCity = "I. de Margarita",
                    ShipRegion = "Nueva Esparta",
                    ShipPostalCode = "4980",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[45], UnitPrice = 9.50m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[65], UnitPrice = 21.05m, Quantity = 21, Discount = 0F},
                    new OrderDetail {Product = products[72], UnitPrice = 34.80m, Quantity = 60, Discount = 0F}),

                new Order
                {
                    CustomerId = "SANTG",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Aug 20 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 17 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 27 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 38.64m,
                    ShipName = "Santé Gourmet",
                    ShipAddress = "Erling Skakkes gate 78",
                    ShipCity = "Stavern",
                    ShipRegion = "",
                    ShipPostalCode = "4110",
                    ShipCountry = "Norway",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[18], UnitPrice = 62.50m, Quantity = 8, Discount = 0F}),

                new Order
                {
                    CustomerId = "WANDK",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Aug 21 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 18 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 28 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 23.55m,
                    ShipName = "Die Wandernde Kuh",
                    ShipAddress = "Adenauerallee 900",
                    ShipCity = "Stuttgart",
                    ShipRegion = "",
                    ShipPostalCode = "70563",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[69], UnitPrice = 36.00m, Quantity = 20, Discount = 0.25F},
                    new OrderDetail {Product = products[70], UnitPrice = 15.00m, Quantity = 15, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "HILAA",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Aug 22 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 19 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 26 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 179.61m,
                    ShipName = "HILARION-Abastos",
                    ShipAddress = "Carrera 22 con Ave. Carlos Soublette #8-35",
                    ShipCity = "San Cristóbal",
                    ShipRegion = "Táchira",
                    ShipPostalCode = "5022",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 19.00m, Quantity = 50, Discount = 0F},
                    new OrderDetail {Product = products[40], UnitPrice = 18.40m, Quantity = 60, Discount = 0F}),

                new Order
                {
                    CustomerId = "SIMOB",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Aug 22 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 19 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep  5 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 41.89m,
                    ShipName = "Simons bistro",
                    ShipAddress = "Vinbæltet 34",
                    ShipCity = "Kobenhavn",
                    ShipRegion = "",
                    ShipPostalCode = "1734",
                    ShipCountry = "Denmark",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[21], UnitPrice = 10.00m, Quantity = 30, Discount = 0.2F},
                    new OrderDetail {Product = products[61], UnitPrice = 28.50m, Quantity = 20, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "ALFKI",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Aug 25 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 22 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep  2 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 29.46m,
                    ShipName = "Alfreds Futterkiste",
                    ShipAddress = "Obere Str. 57",
                    ShipCity = "Berlin",
                    ShipRegion = "",
                    ShipPostalCode = "12209",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[28], UnitPrice = 45.60m, Quantity = 15, Discount = 0.25F},
                    new OrderDetail {Product = products[39], UnitPrice = 18.00m, Quantity = 21, Discount = 0.25F},
                    new OrderDetail {Product = products[46], UnitPrice = 12.00m, Quantity = 2, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "WELLI",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Aug 25 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 22 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep  1 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 0.14m,
                    ShipName = "Wellington Importadora",
                    ShipAddress = "Rua do Mercado, 12",
                    ShipCity = "Resende",
                    ShipRegion = "SP",
                    ShipPostalCode = "08737-363",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[18], UnitPrice = 62.50m, Quantity = 4, Discount = 0.1F},
                    new OrderDetail {Product = products[43], UnitPrice = 46.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[46], UnitPrice = 12.00m, Quantity = 21, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "HANAR",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Aug 26 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 23 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep  2 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 12.41m,
                    ShipName = "Hanari Carnes",
                    ShipAddress = "Rua do Paço, 67",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "05454-876",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[18], UnitPrice = 62.50m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[36], UnitPrice = 19.00m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "HUNGO",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Aug 27 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct  8 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep  3 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 142.33m,
                    ShipName = "Hungry Owl All-Night Grocers",
                    ShipAddress = "8 Johnstown Road",
                    ShipCity = "Cork",
                    ShipRegion = "Co. Cork",
                    ShipPostalCode = "",
                    ShipCountry = "Ireland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 18.00m, Quantity = 15, Discount = 0.25F},
                    new OrderDetail {Product = products[10], UnitPrice = 31.00m, Quantity = 18, Discount = 0.25F},
                    new OrderDetail {Product = products[71], UnitPrice = 21.50m, Quantity = 30, Discount = 0.25F},
                    new OrderDetail {Product = products[77], UnitPrice = 13.00m, Quantity = 35, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "QUEDE",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Aug 27 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 10 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep  3 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 45.54m,
                    ShipName = "Que Delícia",
                    ShipAddress = "Rua da Panificadora, 12",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "02389-673",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[19], UnitPrice = 9.20m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[39], UnitPrice = 18.00m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "RICAR",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Aug 28 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct  9 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep  9 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 14.25m,
                    ShipName = "Ricardo Adocicados",
                    ShipAddress = "Av. Copacabana, 267",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "02389-890",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[22], UnitPrice = 21.00m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 15, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "MAISD",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Aug 28 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 25 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Aug 29 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 6.20m,
                    ShipName = "Maison Dewey",
                    ShipAddress = "Rue Joseph-Bens 532",
                    ShipCity = "Bruxelles",
                    ShipRegion = "",
                    ShipPostalCode = "B-1180",
                    ShipCountry = "Belgium",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[28], UnitPrice = 45.60m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[72], UnitPrice = 34.80m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "FAMIA",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Aug 29 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 26 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep  3 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 176.81m,
                    ShipName = "Familia Arquibaldo",
                    ShipAddress = "Rua Orós, 92",
                    ShipCity = "Sao Paulo",
                    ShipRegion = "SP",
                    ShipPostalCode = "05442-030",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[30], UnitPrice = 25.89m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[53], UnitPrice = 32.80m, Quantity = 25, Discount = 0.05F},
                    new OrderDetail {Product = products[54], UnitPrice = 7.45m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "WANDK",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Sep  1 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 29 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 11 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 20.60m,
                    ShipName = "Die Wandernde Kuh",
                    ShipAddress = "Adenauerallee 900",
                    ShipCity = "Stuttgart",
                    ShipRegion = "",
                    ShipPostalCode = "70563",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[19], UnitPrice = 9.20m, Quantity = 12, Discount = 0.25F},
                    new OrderDetail {Product = products[22], UnitPrice = 21.00m, Quantity = 20, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "GOURL",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Sep  1 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 29 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep  8 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 7.14m,
                    ShipName = "Gourmet Lanchonetes",
                    ShipAddress = "Av. Brasil, 442",
                    ShipCity = "Campinas",
                    ShipRegion = "SP",
                    ShipPostalCode = "04876-786",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[30], UnitPrice = 25.89m, Quantity = 2, Discount = 0.25F},
                    new OrderDetail {Product = products[42], UnitPrice = 14.00m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "FRANK",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Sep  2 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 30 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 19 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 93.25m,
                    ShipName = "Frankenversand",
                    ShipAddress = "Berliner Platz 43",
                    ShipCity = "München",
                    ShipRegion = "",
                    ShipPostalCode = "80805",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[16], UnitPrice = 17.45m, Quantity = 30, Discount = 0.1F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 20, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "BERGS",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Sep  2 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 30 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 11 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 55.26m,
                    ShipName = "Berglunds snabbköp",
                    ShipAddress = "Berguvsvägen  8",
                    ShipCity = "Luleå",
                    ShipRegion = "",
                    ShipPostalCode = "S-958 22",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[4], UnitPrice = 22.00m, Quantity = 12, Discount = 0.1F},
                    new OrderDetail {Product = products[39], UnitPrice = 18.00m, Quantity = 20, Discount = 0.1F},
                    new OrderDetail {Product = products[54], UnitPrice = 7.45m, Quantity = 6, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "REGGC",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Sep  3 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct  1 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 11 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 4.41m,
                    ShipName = "Reggiani Caseifici",
                    ShipAddress = "Strada Provinciale 124",
                    ShipCity = "Reggio Emilia",
                    ShipRegion = "",
                    ShipPostalCode = "42100",
                    ShipCountry = "Italy",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 20, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "GREAL",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Sep  4 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct  2 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 10 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 57.15m,
                    ShipName = "Great Lakes Food Market",
                    ShipAddress = "2732 Baker Blvd.",
                    ShipCity = "Eugene",
                    ShipRegion = "OR",
                    ShipPostalCode = "97403",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[14], UnitPrice = 23.25m, Quantity = 3, Discount = 0.1F},
                    new OrderDetail {Product = products[44], UnitPrice = 19.45m, Quantity = 28, Discount = 0.1F},
                    new OrderDetail {Product = products[47], UnitPrice = 9.50m, Quantity = 6, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "SAVEA",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Sep  4 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct  2 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 15 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 352.69m,
                    ShipName = "Save-a-lot Markets",
                    ShipAddress = "187 Suffolk Ln.",
                    ShipCity = "Boise",
                    ShipRegion = "ID",
                    ShipPostalCode = "83720",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[15], UnitPrice = 15.50m, Quantity = 50, Discount = 0F},
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 24, Discount = 0F},
                    new OrderDetail {Product = products[46], UnitPrice = 12.00m, Quantity = 45, Discount = 0F},
                    new OrderDetail {Product = products[47], UnitPrice = 9.50m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 45, Discount = 0F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "QUICK",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Sep  5 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct  3 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep  8 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 364.15m,
                    ShipName = "QUICK-Stop",
                    ShipAddress = "Taucherstraße 10",
                    ShipCity = "Cunewalde",
                    ShipRegion = "",
                    ShipPostalCode = "01307",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[21], UnitPrice = 10.00m, Quantity = 60, Discount = 0F},
                    new OrderDetail {Product = products[40], UnitPrice = 18.40m, Quantity = 70, Discount = 0.05F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 55, Discount = 0.05F},
                    new OrderDetail {Product = products[77], UnitPrice = 13.00m, Quantity = 70, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "QUEEN",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Sep  5 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct  3 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 10 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 105.81m,
                    ShipName = "Queen Cozinha",
                    ShipAddress = "Alameda dos Canàrios, 891",
                    ShipCity = "Sao Paulo",
                    ShipRegion = "SP",
                    ShipPostalCode = "05487-020",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 20, Discount = 0.05F},
                    new OrderDetail {Product = products[40], UnitPrice = 18.40m, Quantity = 24, Discount = 0.05F},
                    new OrderDetail {Product = products[70], UnitPrice = 15.00m, Quantity = 40, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "HUNGC",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Sep  8 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct  6 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 15 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 111.29m,
                    ShipName = "Hungry Coyote Import Store",
                    ShipAddress = "City Center Plaza 516 Main St.",
                    ShipCity = "Elgin",
                    ShipRegion = "OR",
                    ShipPostalCode = "97827",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[20], UnitPrice = 81.00m, Quantity = 21, Discount = 0F}),

                new Order
                {
                    CustomerId = "HUNGO",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Sep  9 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct  7 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 15 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 17.55m,
                    ShipName = "Hungry Owl All-Night Grocers",
                    ShipAddress = "8 Johnstown Road",
                    ShipCity = "Cork",
                    ShipRegion = "Co. Cork",
                    ShipPostalCode = "",
                    ShipCountry = "Ireland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[39], UnitPrice = 18.00m, Quantity = 3, Discount = 0.2F},
                    new OrderDetail {Product = products[58], UnitPrice = 13.25m, Quantity = 49, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "LONEP",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Sep  9 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct  7 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 18 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 1.28m,
                    ShipName = "Lonesome Pine Restaurant",
                    ShipAddress = "89 Chiaroscuro Rd.",
                    ShipCity = "Portland",
                    ShipRegion = "OR",
                    ShipPostalCode = "97219",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[68], UnitPrice = 12.50m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "BONAP",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Sep 10 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Sep 24 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct  3 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 113.15m,
                    ShipName = "Bon app'",
                    ShipAddress = "12, rue des Bouchers",
                    ShipCity = "Marseille",
                    ShipRegion = "",
                    ShipPostalCode = "13008",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[40], UnitPrice = 18.40m, Quantity = 30, Discount = 0.05F},
                    new OrderDetail {Product = products[42], UnitPrice = 14.00m, Quantity = 30, Discount = 0.05F},
                    new OrderDetail {Product = products[51], UnitPrice = 53.00m, Quantity = 20, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "FURIB",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Sep 10 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct  8 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 19 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 1.27m,
                    ShipName = "Furia Bacalhau e Frutos do Mar",
                    ShipAddress = "Jardim das rosas n. 32",
                    ShipCity = "Lisboa",
                    ShipRegion = "",
                    ShipPostalCode = "1675",
                    ShipCountry = "Portugal",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[10], UnitPrice = 31.00m, Quantity = 24, Discount = 0.15F},
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 12, Discount = 0.15F},
                    new OrderDetail {Product = products[65], UnitPrice = 21.05m, Quantity = 15, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "LONEP",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Sep 11 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct  9 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 17 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 26.31m,
                    ShipName = "Lonesome Pine Restaurant",
                    ShipAddress = "89 Chiaroscuro Rd.",
                    ShipCity = "Portland",
                    ShipRegion = "OR",
                    ShipPostalCode = "97219",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[51], UnitPrice = 53.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 1, Discount = 0F},
                    new OrderDetail {Product = products[76], UnitPrice = 18.00m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "RICSU",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Sep 12 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 10 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 22 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 232.42m,
                    ShipName = "Richter Supermarkt",
                    ShipAddress = "Starenweg 5",
                    ShipCity = "Genève",
                    ShipRegion = "",
                    ShipPostalCode = "1204",
                    ShipCountry = "Switzerland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[29], UnitPrice = 123.79m, Quantity = 36, Discount = 0F},
                    new OrderDetail {Product = products[65], UnitPrice = 21.05m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "ERNSH",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Sep 12 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 10 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 19 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 78.09m,
                    ShipName = "Ernst Handel",
                    ShipAddress = "Kirchgasse 6",
                    ShipCity = "Graz",
                    ShipRegion = "",
                    ShipPostalCode = "8010",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[69], UnitPrice = 36.00m, Quantity = 45, Discount = 0.2F},
                    new OrderDetail {Product = products[71], UnitPrice = 21.50m, Quantity = 14, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "WANDK",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Sep 15 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 13 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 23 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 47.22m,
                    ShipName = "Die Wandernde Kuh",
                    ShipAddress = "Adenauerallee 900",
                    ShipCity = "Stuttgart",
                    ShipRegion = "",
                    ShipPostalCode = "70563",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 8, Discount = 0.1F},
                    new OrderDetail {Product = products[55], UnitPrice = 24.00m, Quantity = 4, Discount = 0.1F},
                    new OrderDetail {Product = products[64], UnitPrice = 33.25m, Quantity = 15, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "SIMOB",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Sep 15 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 13 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 22 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 24.39m,
                    ShipName = "Simons bistro",
                    ShipAddress = "Vinbæltet 34",
                    ShipCity = "Kobenhavn",
                    ShipRegion = "",
                    ShipPostalCode = "1734",
                    ShipCountry = "Denmark",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[36], UnitPrice = 19.00m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "FRANK",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Sep 16 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 14 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 18 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 203.48m,
                    ShipName = "Frankenversand",
                    ShipAddress = "Berliner Platz 43",
                    ShipCity = "München",
                    ShipRegion = "",
                    ShipPostalCode = "80805",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[23], UnitPrice = 9.00m, Quantity = 32, Discount = 0F},
                    new OrderDetail {Product = products[46], UnitPrice = 12.00m, Quantity = 60, Discount = 0F},
                    new OrderDetail {Product = products[67], UnitPrice = 14.00m, Quantity = 25, Discount = 0F},
                    new OrderDetail {Product = products[73], UnitPrice = 15.00m, Quantity = 50, Discount = 0F},
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 25, Discount = 0F}),

                new Order
                {
                    CustomerId = "FRANR",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Sep 17 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 15 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 24 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 30.34m,
                    ShipName = "France restauration",
                    ShipAddress = "54, rue Royale",
                    ShipCity = "Nantes",
                    ShipRegion = "",
                    ShipPostalCode = "44000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[16], UnitPrice = 17.45m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[65], UnitPrice = 21.05m, Quantity = 12, Discount = 0F}),

                new Order
                {
                    CustomerId = "BERGS",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Sep 17 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct  1 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 26 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 95.75m,
                    ShipName = "Berglunds snabbköp",
                    ShipAddress = "Berguvsvägen  8",
                    ShipCity = "Luleå",
                    ShipRegion = "",
                    ShipPostalCode = "S-958 22",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[38], UnitPrice = 263.50m, Quantity = 15, Discount = 0.1F},
                    new OrderDetail {Product = products[71], UnitPrice = 21.50m, Quantity = 12, Discount = 0F}),

                new Order
                {
                    CustomerId = "WILMK",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Sep 18 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 16 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 19 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 22.76m,
                    ShipName = "Wilman Kala",
                    ShipAddress = "Keskuskatu 45",
                    ShipCity = "Helsinki",
                    ShipRegion = "",
                    ShipPostalCode = "21240",
                    ShipCountry = "Finland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[16], UnitPrice = 17.45m, Quantity = 3, Discount = 0F},
                    new OrderDetail {Product = products[42], UnitPrice = 14.00m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[43], UnitPrice = 46.00m, Quantity = 6, Discount = 0F}),

                new Order
                {
                    CustomerId = "ISLAT",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Sep 18 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 16 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 30 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 0.90m,
                    ShipName = "Island Trading",
                    ShipAddress = "Garden House Crowther Way",
                    ShipCity = "Cowes",
                    ShipRegion = "Isle of Wight",
                    ShipPostalCode = "PO31 7PJ",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[23], UnitPrice = 9.00m, Quantity = 5, Discount = 0F}),

                new Order
                {
                    CustomerId = "FRANK",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Sep 19 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 17 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 23 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 31.85m,
                    ShipName = "Frankenversand",
                    ShipAddress = "Berliner Platz 43",
                    ShipCity = "München",
                    ShipRegion = "",
                    ShipPostalCode = "80805",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[14], UnitPrice = 23.25m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[53], UnitPrice = 32.80m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[58], UnitPrice = 13.25m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "TORTU",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Sep 22 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 20 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 29 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 2.01m,
                    ShipName = "Tortuga Restaurante",
                    ShipAddress = "Avda. Azteca 123",
                    ShipCity = "México D.F.",
                    ShipRegion = "",
                    ShipPostalCode = "05033",
                    ShipCountry = "Mexico",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[10], UnitPrice = 31.00m, Quantity = 2, Discount = 0F},
                    new OrderDetail {Product = products[19], UnitPrice = 9.20m, Quantity = 7, Discount = 0F},
                    new OrderDetail {Product = products[44], UnitPrice = 19.45m, Quantity = 21, Discount = 0F}),

                new Order
                {
                    CustomerId = "ANTON",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Sep 22 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 20 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 26 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 4.03m,
                    ShipName = "Antonio Moreno Taquería",
                    ShipAddress = "Mataderos  2312",
                    ShipCity = "México D.F.",
                    ShipRegion = "",
                    ShipPostalCode = "05023",
                    ShipCountry = "Mexico",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[26], UnitPrice = 31.23m, Quantity = 30, Discount = 0.15F},
                    new OrderDetail {Product = products[33], UnitPrice = 2.50m, Quantity = 8, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "SAVEA",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Sep 23 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 21 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 16 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 388.98m,
                    ShipName = "Save-a-lot Markets",
                    ShipAddress = "187 Suffolk Ln.",
                    ShipCity = "Boise",
                    ShipRegion = "ID",
                    ShipPostalCode = "83720",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[12], UnitPrice = 38.00m, Quantity = 100, Discount = 0F},
                    new OrderDetail {Product = products[33], UnitPrice = 2.50m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 120, Discount = 0F},
                    new OrderDetail {Product = products[54], UnitPrice = 7.45m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "BLONP",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Sep 23 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 21 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 30 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 27.94m,
                    ShipName = "Blondel père et fils",
                    ShipAddress = "24, place Kléber",
                    ShipCity = "Strasbourg",
                    ShipRegion = "",
                    ShipPostalCode = "67000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 12, Discount = 0F}),

                new Order
                {
                    CustomerId = "OLDWO",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Sep 24 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 22 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 26 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 26.61m,
                    ShipName = "Old World Delicatessen",
                    ShipAddress = "2743 Bering St.",
                    ShipCity = "Anchorage",
                    ShipRegion = "AK",
                    ShipPostalCode = "99508",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[16], UnitPrice = 17.45m, Quantity = 50, Discount = 0.25F},
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 20, Discount = 0.25F},
                    new OrderDetail {Product = products[42], UnitPrice = 14.00m, Quantity = 40, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "GREAL",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Sep 25 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 23 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 30 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 76.13m,
                    ShipName = "Great Lakes Food Market",
                    ShipAddress = "2732 Baker Blvd.",
                    ShipCity = "Eugene",
                    ShipRegion = "OR",
                    ShipPostalCode = "97403",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[19], UnitPrice = 9.20m, Quantity = 30, Discount = 0.1F},
                    new OrderDetail {Product = products[21], UnitPrice = 10.00m, Quantity = 12, Discount = 0.1F},
                    new OrderDetail {Product = products[64], UnitPrice = 33.25m, Quantity = 28, Discount = 0F}),

                new Order
                {
                    CustomerId = "ANTON",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Sep 25 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 23 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct  1 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 36.13m,
                    ShipName = "Antonio Moreno Taquería",
                    ShipAddress = "Mataderos  2312",
                    ShipCity = "México D.F.",
                    ShipRegion = "",
                    ShipPostalCode = "05023",
                    ShipCountry = "Mexico",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[33], UnitPrice = 2.50m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[66], UnitPrice = 17.00m, Quantity = 4, Discount = 0F},
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "DUMON",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Sep 26 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 24 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct  1 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 4.40m,
                    ShipName = "Du monde entier",
                    ShipAddress = "67, rue des Cinquante Otages",
                    ShipCity = "Nantes",
                    ShipRegion = "",
                    ShipPostalCode = "44000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[52], UnitPrice = 7.00m, Quantity = 9, Discount = 0F}),

                new Order
                {
                    CustomerId = "OTTIK",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Sep 26 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 24 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Sep 30 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 145.63m,
                    ShipName = "Ottilies Käseladen",
                    ShipAddress = "Mehrheimerstr. 369",
                    ShipCity = "Köln",
                    ShipRegion = "",
                    ShipPostalCode = "50739",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[40], UnitPrice = 18.40m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[47], UnitPrice = 9.50m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "GOURL",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Sep 29 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 13 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct  3 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 33.75m,
                    ShipName = "Gourmet Lanchonetes",
                    ShipAddress = "Av. Brasil, 442",
                    ShipCity = "Campinas",
                    ShipRegion = "SP",
                    ShipPostalCode = "04876-786",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[10], UnitPrice = 31.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 4, Discount = 0F},
                    new OrderDetail {Product = products[47], UnitPrice = 9.50m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "PICCO",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Sep 30 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 28 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct  8 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 96.50m,
                    ShipName = "Piccolo und mehr",
                    ShipAddress = "Geislweg 14",
                    ShipCity = "Salzburg",
                    ShipRegion = "",
                    ShipPostalCode = "5020",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[17], UnitPrice = 39.00m, Quantity = 30, Discount = 0.2F},
                    new OrderDetail {Product = products[26], UnitPrice = 31.23m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "HUNGO",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Sep 30 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 28 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 30 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 296.43m,
                    ShipName = "Hungry Owl All-Night Grocers",
                    ShipAddress = "8 Johnstown Road",
                    ShipCity = "Cork",
                    ShipRegion = "Co. Cork",
                    ShipPostalCode = "",
                    ShipCountry = "Ireland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[9], UnitPrice = 97.00m, Quantity = 50, Discount = 0.25F},
                    new OrderDetail {Product = products[29], UnitPrice = 123.79m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[36], UnitPrice = 19.00m, Quantity = 6, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "VAFFE",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Oct  1 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 15 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct  7 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 299.09m,
                    ShipName = "Vaffeljernet",
                    ShipAddress = "Smagsloget 45",
                    ShipCity = "Århus",
                    ShipRegion = "",
                    ShipPostalCode = "8200",
                    ShipCountry = "Denmark",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[10], UnitPrice = 31.00m, Quantity = 18, Discount = 0.1F},
                    new OrderDetail {Product = products[28], UnitPrice = 45.60m, Quantity = 60, Discount = 0.1F},
                    new OrderDetail {Product = products[34], UnitPrice = 14.00m, Quantity = 14, Discount = 0F}),

                new Order
                {
                    CustomerId = "BERGS",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Oct  1 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 29 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct  7 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 13.42m,
                    ShipName = "Berglunds snabbköp",
                    ShipAddress = "Berguvsvägen  8",
                    ShipCity = "Luleå",
                    ShipRegion = "",
                    ShipPostalCode = "S-958 22",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 18.00m, Quantity = 35, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "HANAR",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Oct  2 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 30 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct  3 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 15.80m,
                    ShipName = "Hanari Carnes",
                    ShipAddress = "Rua do Paço, 67",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "05454-876",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 20, Discount = 0.25F},
                    new OrderDetail {Product = products[77], UnitPrice = 13.00m, Quantity = 30, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "QUICK",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Oct  3 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 14 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 22 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 810.05m,
                    ShipName = "QUICK-Stop",
                    ShipAddress = "Taucherstraße 10",
                    ShipCity = "Cunewalde",
                    ShipRegion = "",
                    ShipPostalCode = "01307",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 18.00m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[29], UnitPrice = 123.79m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[43], UnitPrice = 46.00m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[44], UnitPrice = 19.45m, Quantity = 24, Discount = 0F},
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 48, Discount = 0F}),

                new Order
                {
                    CustomerId = "ALFKI",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Oct  3 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 31 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 13 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 61.02m,
                    ShipName = "Alfred's Futterkiste",
                    ShipAddress = "Obere Str. 57",
                    ShipCity = "Berlin",
                    ShipRegion = "",
                    ShipPostalCode = "12209",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[63], UnitPrice = 43.90m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "WHITC",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Oct  6 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 20 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 10 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 139.34m,
                    ShipName = "White Clover Markets",
                    ShipAddress = "1029 - 12th Ave. S.",
                    ShipCity = "Seattle",
                    ShipRegion = "WA",
                    ShipPostalCode = "98124",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[9], UnitPrice = 97.00m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[54], UnitPrice = 7.45m, Quantity = 60, Discount = 0.15F},
                    new OrderDetail {Product = products[69], UnitPrice = 36.00m, Quantity = 30, Discount = 0.15F},
                    new OrderDetail {Product = products[73], UnitPrice = 15.00m, Quantity = 15, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "QUICK",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Oct  6 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov  3 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct  9 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 398.36m,
                    ShipName = "QUICK-Stop",
                    ShipAddress = "Taucherstraße 10",
                    ShipCity = "Cunewalde",
                    ShipRegion = "",
                    ShipPostalCode = "01307",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[7], UnitPrice = 30.00m, Quantity = 90, Discount = 0F},
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 25, Discount = 0F},
                    new OrderDetail {Product = products[70], UnitPrice = 15.00m, Quantity = 50, Discount = 0F}),

                new Order
                {
                    CustomerId = "WILMK",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Oct  7 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 18 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 14 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 16.72m,
                    ShipName = "Wilman Kala",
                    ShipAddress = "Keskuskatu 45",
                    ShipCity = "Helsinki",
                    ShipRegion = "",
                    ShipPostalCode = "21240",
                    ShipCountry = "Finland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[8], UnitPrice = 40.00m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[12], UnitPrice = 38.00m, Quantity = 4, Discount = 0F},
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "WHITC",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Oct  8 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 19 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 14 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 102.55m,
                    ShipName = "White Clover Markets",
                    ShipAddress = "1029 - 12th Ave. S.",
                    ShipCity = "Seattle",
                    ShipRegion = "WA",
                    ShipPostalCode = "98124",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[17], UnitPrice = 39.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[46], UnitPrice = 12.00m, Quantity = 18, Discount = 0F}),

                new Order
                {
                    CustomerId = "LINOD",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Oct  8 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov  5 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 14 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 45.52m,
                    ShipName = "LINO-Delicateses",
                    ShipAddress = "Ave. 5 de Mayo Porlamar",
                    ShipCity = "I. de Margarita",
                    ShipRegion = "Nueva Esparta",
                    ShipPostalCode = "4980",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[19], UnitPrice = 9.20m, Quantity = 7, Discount = 0.25F},
                    new OrderDetail {Product = products[35], UnitPrice = 18.00m, Quantity = 9, Discount = 0.25F},
                    new OrderDetail {Product = products[58], UnitPrice = 13.25m, Quantity = 30, Discount = 0.25F},
                    new OrderDetail {Product = products[70], UnitPrice = 15.00m, Quantity = 30, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "ERNSH",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Oct  9 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov  6 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 17 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 272.47m,
                    ShipName = "Ernst Handel",
                    ShipAddress = "Kirchgasse 6",
                    ShipCity = "Graz",
                    ShipRegion = "",
                    ShipPostalCode = "8010",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 21.00m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[17], UnitPrice = 39.00m, Quantity = 8, Discount = 0.05F},
                    new OrderDetail {Product = products[29], UnitPrice = 123.79m, Quantity = 12, Discount = 0.05F},
                    new OrderDetail {Product = products[65], UnitPrice = 21.05m, Quantity = 65, Discount = 0.05F},
                    new OrderDetail {Product = products[70], UnitPrice = 15.00m, Quantity = 8, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "MORGK",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Oct  9 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov  6 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 13 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 0.58m,
                    ShipName = "Morgenstern Gesundkost",
                    ShipAddress = "Heerstr. 22",
                    ShipCity = "Leipzig",
                    ShipRegion = "",
                    ShipPostalCode = "04179",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[47], UnitPrice = 9.50m, Quantity = 12, Discount = 0F}),

                new Order
                {
                    CustomerId = "SAVEA",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Oct 10 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov  7 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 16 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 65.10m,
                    ShipName = "Save-a-lot Markets",
                    ShipAddress = "187 Suffolk Ln.",
                    ShipCity = "Boise",
                    ShipRegion = "ID",
                    ShipPostalCode = "83720",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 18.00m, Quantity = 5, Discount = 0.2F},
                    new OrderDetail {Product = products[34], UnitPrice = 14.00m, Quantity = 12, Discount = 0.2F},
                    new OrderDetail {Product = products[68], UnitPrice = 12.50m, Quantity = 40, Discount = 0.2F},
                    new OrderDetail {Product = products[71], UnitPrice = 21.50m, Quantity = 60, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "HUNGO",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Oct 13 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 27 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 15 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 220.31m,
                    ShipName = "Hungry Owl All-Night Grocers",
                    ShipAddress = "8 Johnstown Road",
                    ShipCity = "Cork",
                    ShipRegion = "Co. Cork",
                    ShipPostalCode = "",
                    ShipCountry = "Ireland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 42, Discount = 0.15F},
                    new OrderDetail {Product = products[71], UnitPrice = 21.50m, Quantity = 20, Discount = 0.15F},
                    new OrderDetail {Product = products[76], UnitPrice = 18.00m, Quantity = 35, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "ALFKI",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Oct 13 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 24 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 21 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 23.94m,
                    ShipName = "Alfred's Futterkiste",
                    ShipAddress = "Obere Str. 57",
                    ShipCity = "Berlin",
                    ShipRegion = "",
                    ShipPostalCode = "12209",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[3], UnitPrice = 10.00m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[76], UnitPrice = 18.00m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "FOLKO",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Oct 14 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 11 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 20 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 152.30m,
                    ShipName = "Folk och fä HB",
                    ShipAddress = "Åkergatan 24",
                    ShipCity = "Bräcke",
                    ShipRegion = "",
                    ShipPostalCode = "S-844 67",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 19.00m, Quantity = 5, Discount = 0F},
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 35, Discount = 0F},
                    new OrderDetail {Product = products[73], UnitPrice = 15.00m, Quantity = 35, Discount = 0F}),

                new Order
                {
                    CustomerId = "QUEEN",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Oct 14 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 11 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov  7 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 4.78m,
                    ShipName = "Queen Cozinha",
                    ShipAddress = "Alameda dos Canàrios, 891",
                    ShipCity = "Sao Paulo",
                    ShipRegion = "SP",
                    ShipPostalCode = "05487-020",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[4], UnitPrice = 22.00m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 35, Discount = 0F},
                    new OrderDetail {Product = products[48], UnitPrice = 12.75m, Quantity = 24, Discount = 0F}),

                new Order
                {
                    CustomerId = "HILAA",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Oct 15 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 12 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 18 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 3.52m,
                    ShipName = "HILARION-Abastos",
                    ShipAddress = "Carrera 22 con Ave. Carlos Soublette #8-35",
                    ShipCity = "San Cristóbal",
                    ShipRegion = "Táchira",
                    ShipPostalCode = "5022",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[32], UnitPrice = 32.00m, Quantity = 4, Discount = 0F}),

                new Order
                {
                    CustomerId = "OLDWO",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Oct 16 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 13 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 21 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 135.63m,
                    ShipName = "Old World Delicatessen",
                    ShipAddress = "2743 Bering St.",
                    ShipCity = "Anchorage",
                    ShipRegion = "AK",
                    ShipPostalCode = "99508",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[16], UnitPrice = 17.45m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[43], UnitPrice = 46.00m, Quantity = 24, Discount = 0F},
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 8, Discount = 0F}),

                new Order
                {
                    CustomerId = "AROUT",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Oct 16 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Oct 30 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 23 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 21.74m,
                    ShipName = "Around the Horn",
                    ShipAddress = "Brook Farm Stratford St. Mary",
                    ShipCity = "Colchester",
                    ShipRegion = "Essex",
                    ShipPostalCode = "CO7 6JX",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[55], UnitPrice = 24.00m, Quantity = 21, Discount = 0F},
                    new OrderDetail {Product = products[57], UnitPrice = 19.50m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[70], UnitPrice = 15.00m, Quantity = 28, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "THEBI",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Oct 17 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 28 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov  5 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 2.96m,
                    ShipName = "The Big Cheese",
                    ShipAddress = "89 Jefferson Way Suite 2",
                    ShipCity = "Portland",
                    ShipRegion = "OR",
                    ShipPostalCode = "97201",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[5], UnitPrice = 21.35m, Quantity = 4, Discount = 0F},
                    new OrderDetail {Product = products[36], UnitPrice = 19.00m, Quantity = 5, Discount = 0F}),

                new Order
                {
                    CustomerId = "GOURL",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Oct 17 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 14 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 20 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 210.80m,
                    ShipName = "Gourmet Lanchonetes",
                    ShipAddress = "Av. Brasil, 442",
                    ShipCity = "Campinas",
                    ShipRegion = "SP",
                    ShipPostalCode = "04876-786",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[8], UnitPrice = 40.00m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[51], UnitPrice = 53.00m, Quantity = 28, Discount = 0F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "FRANS",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Oct 20 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 17 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 23 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 4.98m,
                    ShipName = "Franchi S.p.A.",
                    ShipAddress = "Via Monte Bianco 34",
                    ShipCity = "Torino",
                    ShipRegion = "",
                    ShipPostalCode = "10100",
                    ShipCountry = "Italy",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[19], UnitPrice = 9.20m, Quantity = 5, Discount = 0F},
                    new OrderDetail {Product = products[47], UnitPrice = 9.50m, Quantity = 5, Discount = 0F}),

                new Order
                {
                    CustomerId = "SAVEA",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Oct 21 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec  2 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 29 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 52.41m,
                    ShipName = "Save-a-lot Markets",
                    ShipAddress = "187 Suffolk Ln.",
                    ShipCity = "Boise",
                    ShipRegion = "ID",
                    ShipPostalCode = "83720",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[19], UnitPrice = 9.20m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 42, Discount = 0F},
                    new OrderDetail {Product = products[53], UnitPrice = 32.80m, Quantity = 120, Discount = 0F}),

                new Order
                {
                    CustomerId = "HUNGO",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Oct 21 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 18 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 31 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 89.93m,
                    ShipName = "Hungry Owl All-Night Grocers",
                    ShipAddress = "8 Johnstown Road",
                    ShipCity = "Cork",
                    ShipRegion = "Co. Cork",
                    ShipPostalCode = "",
                    ShipCountry = "Ireland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[53], UnitPrice = 32.80m, Quantity = 3, Discount = 0.05F},
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "SAVEA",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Oct 22 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 19 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 24 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 167.05m,
                    ShipName = "Save-a-lot Markets",
                    ShipAddress = "187 Suffolk Ln.",
                    ShipCity = "Boise",
                    ShipRegion = "ID",
                    ShipPostalCode = "83720",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[10], UnitPrice = 31.00m, Quantity = 18, Discount = 0F},
                    new OrderDetail {Product = products[26], UnitPrice = 31.23m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[45], UnitPrice = 9.50m, Quantity = 110, Discount = 0F},
                    new OrderDetail {Product = products[46], UnitPrice = 12.00m, Quantity = 24, Discount = 0F}),

                new Order
                {
                    CustomerId = "SAVEA",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Oct 22 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 19 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 27 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 24.49m,
                    ShipName = "Save-a-lot Markets",
                    ShipAddress = "187 Suffolk Ln.",
                    ShipCity = "Boise",
                    ShipRegion = "ID",
                    ShipPostalCode = "83720",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 19.00m, Quantity = 30, Discount = 0.25F},
                    new OrderDetail {Product = products[17], UnitPrice = 39.00m, Quantity = 27, Discount = 0.25F},
                    new OrderDetail {Product = products[47], UnitPrice = 9.50m, Quantity = 50, Discount = 0.25F},
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 18, Discount = 0.25F},
                    new OrderDetail {Product = products[58], UnitPrice = 13.25m, Quantity = 12, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "BONAP",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Oct 23 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov  6 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 29 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 63.20m,
                    ShipName = "Bon app'",
                    ShipAddress = "12, rue des Bouchers",
                    ShipCity = "Marseille",
                    ShipRegion = "",
                    ShipPostalCode = "13008",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[10], UnitPrice = 31.00m, Quantity = 21, Discount = 0F},
                    new OrderDetail {Product = products[71], UnitPrice = 21.50m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "RANCH",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Oct 24 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 21 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 27 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 22.57m,
                    ShipName = "Rancho grande",
                    ShipAddress = "Av. del Libertador 900",
                    ShipCity = "Buenos Aires",
                    ShipRegion = "",
                    ShipPostalCode = "1010",
                    ShipCountry = "Argentina",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[21], UnitPrice = 10.00m, Quantity = 5, Discount = 0F},
                    new OrderDetail {Product = products[51], UnitPrice = 53.00m, Quantity = 7, Discount = 0F},
                    new OrderDetail {Product = products[61], UnitPrice = 28.50m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "FRANK",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Oct 24 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 21 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 29 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 59.25m,
                    ShipName = "Frankenversand",
                    ShipAddress = "Berliner Platz 43",
                    ShipCity = "München",
                    ShipRegion = "",
                    ShipPostalCode = "80805",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[21], UnitPrice = 10.00m, Quantity = 32, Discount = 0.05F},
                    new OrderDetail {Product = products[54], UnitPrice = 7.45m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[69], UnitPrice = 36.00m, Quantity = 25, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "KOENE",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Oct 27 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 24 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 29 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 170.88m,
                    ShipName = "Königlich Essen",
                    ShipAddress = "Maubelstr. 90",
                    ShipCity = "Brandenburg",
                    ShipRegion = "",
                    ShipPostalCode = "14776",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[12], UnitPrice = 38.00m, Quantity = 36, Discount = 0F},
                    new OrderDetail {Product = products[16], UnitPrice = 17.45m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[36], UnitPrice = 19.00m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "LETSS",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Oct 27 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 24 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov  5 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 51.44m,
                    ShipName = "Let's Stop N Shop",
                    ShipAddress = "87 Polk St. Suite 5",
                    ShipCity = "San Francisco",
                    ShipRegion = "CA",
                    ShipPostalCode = "94117",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[18], UnitPrice = 62.50m, Quantity = 12, Discount = 0.25F},
                    new OrderDetail {Product = products[30], UnitPrice = 25.89m, Quantity = 3, Discount = 0.25F},
                    new OrderDetail {Product = products[54], UnitPrice = 7.45m, Quantity = 40, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "QUEDE",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Oct 28 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 11 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov  5 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 9.53m,
                    ShipName = "Que Delícia",
                    ShipAddress = "Rua da Panificadora, 12",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "02389-673",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[35], UnitPrice = 18.00m, Quantity = 21, Discount = 0F},
                    new OrderDetail {Product = products[71], UnitPrice = 21.50m, Quantity = 8, Discount = 0F}),

                new Order
                {
                    CustomerId = "QUICK",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Oct 29 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 26 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Oct 31 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 48.92m,
                    ShipName = "QUICK-Stop",
                    ShipAddress = "Taucherstraße 10",
                    ShipCity = "Cunewalde",
                    ShipRegion = "",
                    ShipPostalCode = "01307",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[44], UnitPrice = 19.45m, Quantity = 50, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "SAVEA",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Oct 29 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 10 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov  4 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 74.58m,
                    ShipName = "Save-a-lot Markets",
                    ShipAddress = "187 Suffolk Ln.",
                    ShipCity = "Boise",
                    ShipRegion = "ID",
                    ShipPostalCode = "83720",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 19.00m, Quantity = 3, Discount = 0F},
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 50, Discount = 0F},
                    new OrderDetail {Product = products[68], UnitPrice = 12.50m, Quantity = 45, Discount = 0F},
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 42, Discount = 0F}),

                new Order
                {
                    CustomerId = "WHITC",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Oct 30 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 27 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 25 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 21.72m,
                    ShipName = "White Clover Markets",
                    ShipAddress = "1029 - 12th Ave. S.",
                    ShipCity = "Seattle",
                    ShipRegion = "WA",
                    ShipPostalCode = "98124",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[26], UnitPrice = 31.23m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "MEREP",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Oct 30 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 11 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov  5 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 57.75m,
                    ShipName = "Mère Paillarde",
                    ShipAddress = "43 rue St. Laurent",
                    ShipCity = "Montréal",
                    ShipRegion = "Québec",
                    ShipPostalCode = "H1J 1C3",
                    ShipCountry = "Canada",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[10], UnitPrice = 31.00m, Quantity = 16, Discount = 0F},
                    new OrderDetail {Product = products[61], UnitPrice = 28.50m, Quantity = 5, Discount = 0F}),

                new Order
                {
                    CustomerId = "FAMIA",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Oct 31 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 28 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov  5 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 10.83m,
                    ShipName = "Familia Arquibaldo",
                    ShipAddress = "Rua Orós, 92",
                    ShipCity = "Sao Paulo",
                    ShipRegion = "SP",
                    ShipPostalCode = "05442-030",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[52], UnitPrice = 7.00m, Quantity = 4, Discount = 0F},
                    new OrderDetail {Product = products[55], UnitPrice = 24.00m, Quantity = 6, Discount = 0F}),

                new Order
                {
                    CustomerId = "EASTC",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Nov  3 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 17 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec  5 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 16.56m,
                    ShipName = "Eastern Connection",
                    ShipAddress = "35 King George",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "WX3 6FW",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[4], UnitPrice = 22.00m, Quantity = 25, Discount = 0F},
                    new OrderDetail {Product = products[11], UnitPrice = 21.00m, Quantity = 5, Discount = 0F}),

                new Order
                {
                    CustomerId = "REGGC",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Nov  3 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec  1 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec  5 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 89.90m,
                    ShipName = "Reggiani Caseifici",
                    ShipAddress = "Strada Provinciale 124",
                    ShipCity = "Reggio Emilia",
                    ShipRegion = "",
                    ShipPostalCode = "42100",
                    ShipCountry = "Italy",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[17], UnitPrice = 39.00m, Quantity = 20, Discount = 0.05F},
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 10, Discount = 0.05F},
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 10, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "QUEEN",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Nov  4 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec  2 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 11 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 58.33m,
                    ShipName = "Queen Cozinha",
                    ShipAddress = "Alameda dos Canàrios, 891",
                    ShipCity = "Sao Paulo",
                    ShipRegion = "SP",
                    ShipPostalCode = "05487-020",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[30], UnitPrice = 25.89m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[40], UnitPrice = 18.40m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[55], UnitPrice = 24.00m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "LINOD",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Nov  4 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 16 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 14 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 141.06m,
                    ShipName = "LINO-Delicateses",
                    ShipAddress = "Ave. 5 de Mayo Porlamar",
                    ShipCity = "I. de Margarita",
                    ShipRegion = "Nueva Esparta",
                    ShipPostalCode = "4980",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 18.00m, Quantity = 50, Discount = 0F},
                    new OrderDetail {Product = products[21], UnitPrice = 10.00m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[50], UnitPrice = 16.25m, Quantity = 40, Discount = 0F}),

                new Order
                {
                    CustomerId = "BONAP",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Nov  5 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec  3 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 14 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 20.12m,
                    ShipName = "Bon app'",
                    ShipAddress = "12, rue des Bouchers",
                    ShipCity = "Marseille",
                    ShipRegion = "",
                    ShipPostalCode = "13008",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[16], UnitPrice = 17.45m, Quantity = 15, Discount = 0.05F},
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 3, Discount = 0.05F},
                    new OrderDetail {Product = products[65], UnitPrice = 21.05m, Quantity = 10, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "CHOPS",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Nov  6 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec  4 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 14 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 96.65m,
                    ShipName = "Chop-suey Chinese",
                    ShipAddress = "Hauptstr. 31",
                    ShipCity = "Bern",
                    ShipRegion = "",
                    ShipPostalCode = "3012",
                    ShipCountry = "Switzerland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[21], UnitPrice = 10.00m, Quantity = 40, Discount = 0.05F},
                    new OrderDetail {Product = products[51], UnitPrice = 53.00m, Quantity = 30, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "BONAP",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Nov  6 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec  4 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov  7 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 16.97m,
                    ShipName = "Bon app'",
                    ShipAddress = "12, rue des Bouchers",
                    ShipCity = "Marseille",
                    ShipRegion = "",
                    ShipPostalCode = "13008",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[76], UnitPrice = 18.00m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "BERGS",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Nov  7 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec  5 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 10 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 110.11m,
                    ShipName = "Berglunds snabbköp",
                    ShipAddress = "Berguvsvägen  8",
                    ShipCity = "Luleå",
                    ShipRegion = "",
                    ShipPostalCode = "S-958 22",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[14], UnitPrice = 23.25m, Quantity = 16, Discount = 0F},
                    new OrderDetail {Product = products[28], UnitPrice = 45.60m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[52], UnitPrice = 7.00m, Quantity = 25, Discount = 0F}),

                new Order
                {
                    CustomerId = "GOURL",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Nov  7 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec  5 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 12 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 1.63m,
                    ShipName = "Gourmet Lanchonetes",
                    ShipAddress = "Av. Brasil, 442",
                    ShipCity = "Campinas",
                    ShipRegion = "SP",
                    ShipPostalCode = "04876-786",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[6], UnitPrice = 25.00m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[30], UnitPrice = 25.89m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[76], UnitPrice = 18.00m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "LETSS",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Nov 10 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec  8 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 21 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 45.97m,
                    ShipName = "Let's Stop N Shop",
                    ShipAddress = "87 Polk St. Suite 5",
                    ShipCity = "San Francisco",
                    ShipRegion = "CA",
                    ShipPostalCode = "94117",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[61], UnitPrice = 28.50m, Quantity = 20, Discount = 0.1F},
                    new OrderDetail {Product = products[77], UnitPrice = 13.00m, Quantity = 2, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "HUNGO",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Nov 11 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec  9 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 21 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 44.10m,
                    ShipName = "Hungry Owl All-Night Grocers",
                    ShipAddress = "8 Johnstown Road",
                    ShipCity = "Cork",
                    ShipRegion = "Co. Cork",
                    ShipPostalCode = "",
                    ShipCountry = "Ireland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[65], UnitPrice = 21.05m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "VINET",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Nov 11 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec  9 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 18 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 7.79m,
                    ShipName = "Vins et alcools Chevalier",
                    ShipAddress = "59 rue de l'Abbaye",
                    ShipCity = "Reims",
                    ShipRegion = "",
                    ShipPostalCode = "51100",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[13], UnitPrice = 6.00m, Quantity = 4, Discount = 0F},
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 12, Discount = 0F}),

                new Order
                {
                    CustomerId = "SPECD",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Nov 12 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 10 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 18 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 2.91m,
                    ShipName = "Spécialités du monde",
                    ShipAddress = "25, rue Lauriston",
                    ShipCity = "Paris",
                    ShipRegion = "",
                    ShipPostalCode = "75016",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[16], UnitPrice = 17.45m, Quantity = 3, Discount = 0F}),

                new Order
                {
                    CustomerId = "VINET",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Nov 12 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 10 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 17 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 11.08m,
                    ShipName = "Vins et alcools Chevalier",
                    ShipAddress = "59 rue de l'Abbaye",
                    ShipCity = "Reims",
                    ShipRegion = "",
                    ShipPostalCode = "51100",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[36], UnitPrice = 19.00m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[52], UnitPrice = 7.00m, Quantity = 18, Discount = 0F}),

                new Order
                {
                    CustomerId = "WHITC",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Nov 13 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 11 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 25 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 81.88m,
                    ShipName = "White Clover Markets",
                    ShipAddress = "1029 - 12th Ave. S.",
                    ShipCity = "Seattle",
                    ShipRegion = "WA",
                    ShipPostalCode = "98124",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[28], UnitPrice = 45.60m, Quantity = 5, Discount = 0.2F},
                    new OrderDetail {Product = products[35], UnitPrice = 18.00m, Quantity = 35, Discount = 0.2F},
                    new OrderDetail {Product = products[45], UnitPrice = 9.50m, Quantity = 40, Discount = 0.2F},
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 14, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "AROUT",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Nov 14 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Nov 28 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 18 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 10.96m,
                    ShipName = "Around the Horn",
                    ShipAddress = "Brook Farm Stratford St. Mary",
                    ShipCity = "Colchester",
                    ShipRegion = "Essex",
                    ShipPostalCode = "CO7 6JX",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 19.00m, Quantity = 15, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "BOTTM",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Nov 14 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 12 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 18 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 243.73m,
                    ShipName = "Bottom-Dollar Markets",
                    ShipAddress = "23 Tsawassen Blvd.",
                    ShipCity = "Tsawassen",
                    ShipRegion = "BC",
                    ShipPostalCode = "T2F 8M4",
                    ShipCountry = "Canada",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[3], UnitPrice = 10.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 50, Discount = 0F},
                    new OrderDetail {Product = products[72], UnitPrice = 34.80m, Quantity = 35, Discount = 0F}),

                new Order
                {
                    CustomerId = "AROUT",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Nov 17 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 15 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 21 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 23.72m,
                    ShipName = "Around the Horn",
                    ShipAddress = "Brook Farm Stratford St. Mary",
                    ShipCity = "Colchester",
                    ShipRegion = "Essex",
                    ShipPostalCode = "CO7 6JX",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[46], UnitPrice = 12.00m, Quantity = 28, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "VAFFE",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Nov 17 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 15 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 24 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 69.19m,
                    ShipName = "Vaffeljernet",
                    ShipAddress = "Smagsloget 45",
                    ShipCity = "Århus",
                    ShipRegion = "",
                    ShipPostalCode = "8200",
                    ShipCountry = "Denmark",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[40], UnitPrice = 18.40m, Quantity = 50, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "QUICK",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Nov 18 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 16 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 27 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 3.52m,
                    ShipName = "QUICK-Stop",
                    ShipAddress = "Taucherstraße 10",
                    ShipCity = "Cunewalde",
                    ShipRegion = "",
                    ShipPostalCode = "01307",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[18], UnitPrice = 62.50m, Quantity = 24, Discount = 0F},
                    new OrderDetail {Product = products[44], UnitPrice = 19.45m, Quantity = 16, Discount = 0F},
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 45, Discount = 0F},
                    new OrderDetail {Product = products[72], UnitPrice = 34.80m, Quantity = 7, Discount = 0F}),

                new Order
                {
                    CustomerId = "CHOPS",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Nov 19 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 17 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 21 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 31.43m,
                    ShipName = "Chop-suey Chinese",
                    ShipAddress = "Hauptstr. 31",
                    ShipCity = "Bern",
                    ShipRegion = "",
                    ShipPostalCode = "3012",
                    ShipCountry = "Switzerland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[13], UnitPrice = 6.00m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[42], UnitPrice = 14.00m, Quantity = 28, Discount = 0F},
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 9, Discount = 0F},
                    new OrderDetail {Product = products[69], UnitPrice = 36.00m, Quantity = 40, Discount = 0F}),

                new Order
                {
                    CustomerId = "PICCO",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Nov 19 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 17 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 26 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 117.33m,
                    ShipName = "Piccolo und mehr",
                    ShipAddress = "Geislweg 14",
                    ShipCity = "Salzburg",
                    ShipRegion = "",
                    ShipPostalCode = "5020",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 8, Discount = 0F},
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 35, Discount = 0F},
                    new OrderDetail {Product = products[63], UnitPrice = 43.90m, Quantity = 9, Discount = 0F},
                    new OrderDetail {Product = products[69], UnitPrice = 36.00m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "SAVEA",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Nov 20 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 18 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 28 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 232.55m,
                    ShipName = "Save-a-lot Markets",
                    ShipAddress = "187 Suffolk Ln.",
                    ShipCity = "Boise",
                    ShipRegion = "ID",
                    ShipPostalCode = "83720",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[23], UnitPrice = 9.00m, Quantity = 44, Discount = 0F},
                    new OrderDetail {Product = products[40], UnitPrice = 18.40m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 28, Discount = 0F}),

                new Order
                {
                    CustomerId = "ISLAT",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Nov 20 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 18 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 19 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 61.53m,
                    ShipName = "Island Trading",
                    ShipAddress = "Garden House Crowther Way",
                    ShipCity = "Cowes",
                    ShipRegion = "Isle of Wight",
                    ShipPostalCode = "PO31 7PJ",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[76], UnitPrice = 18.00m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "WARTH",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Nov 21 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 19 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 24 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 79.30m,
                    ShipName = "Wartian Herkku",
                    ShipAddress = "Torikatu 38",
                    ShipCity = "Oulu",
                    ShipRegion = "",
                    ShipPostalCode = "90110",
                    ShipCountry = "Finland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[14], UnitPrice = 23.25m, Quantity = 5, Discount = 0.15F},
                    new OrderDetail {Product = products[45], UnitPrice = 9.50m, Quantity = 40, Discount = 0.15F},
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 25, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "RICSU",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Nov 24 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 22 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec  3 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 130.79m,
                    ShipName = "Richter Supermarkt",
                    ShipAddress = "Starenweg 5",
                    ShipCity = "Genève",
                    ShipRegion = "",
                    ShipPostalCode = "1204",
                    ShipCountry = "Switzerland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[26], UnitPrice = 31.23m, Quantity = 12, Discount = 0.1F},
                    new OrderDetail {Product = products[30], UnitPrice = 25.89m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[50], UnitPrice = 16.25m, Quantity = 20, Discount = 0.1F},
                    new OrderDetail {Product = products[73], UnitPrice = 15.00m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "NORTS",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Nov 24 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 22 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 28 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 1.39m,
                    ShipName = "North/South",
                    ShipAddress = "South House 300 Queensbridge",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "SW7 1RZ",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 18.00m, Quantity = 8, Discount = 0F},
                    new OrderDetail {Product = products[69], UnitPrice = 36.00m, Quantity = 3, Discount = 0F}),

                new Order
                {
                    CustomerId = "FRANS",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Nov 25 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 23 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 27 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 7.70m,
                    ShipName = "Franchi S.p.A.",
                    ShipAddress = "Via Monte Bianco 34",
                    ShipCity = "Torino",
                    ShipRegion = "",
                    ShipPostalCode = "10100",
                    ShipCountry = "Italy",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[45], UnitPrice = 9.50m, Quantity = 4, Discount = 0F},
                    new OrderDetail {Product = products[74], UnitPrice = 10.00m, Quantity = 5, Discount = 0F}),

                new Order
                {
                    CustomerId = "MAGAA",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Nov 25 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 23 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 27 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 2.38m,
                    ShipName = "Magazzini Alimentari Riuniti",
                    ShipAddress = "Via Ludovico il Moro 22",
                    ShipCity = "Bergamo",
                    ShipRegion = "",
                    ShipPostalCode = "24100",
                    ShipCountry = "Italy",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[40], UnitPrice = 18.40m, Quantity = 3, Discount = 0F}),

                new Order
                {
                    CustomerId = "BONAP",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Nov 26 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 24 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Nov 28 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 16.71m,
                    ShipName = "Bon app'",
                    ShipAddress = "12, rue des Bouchers",
                    ShipCity = "Marseille",
                    ShipRegion = "",
                    ShipPostalCode = "13008",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[47], UnitPrice = 9.50m, Quantity = 30, Discount = 0.25F},
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 30, Discount = 0.25F},
                    new OrderDetail {Product = products[57], UnitPrice = 19.50m, Quantity = 14, Discount = 0.25F},
                    new OrderDetail {Product = products[69], UnitPrice = 36.00m, Quantity = 25, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "SPLIR",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Nov 27 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 25 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec  2 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 73.21m,
                    ShipName = "Split Rail Beer & Ale",
                    ShipAddress = "P.O. Box 555",
                    ShipCity = "Lander",
                    ShipRegion = "WY",
                    ShipPostalCode = "82520",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[18], UnitPrice = 62.50m, Quantity = 21, Discount = 0.2F},
                    new OrderDetail {Product = products[36], UnitPrice = 19.00m, Quantity = 20, Discount = 0.2F},
                    new OrderDetail {Product = products[68], UnitPrice = 12.50m, Quantity = 6, Discount = 0.2F},
                    new OrderDetail {Product = products[69], UnitPrice = 36.00m, Quantity = 20, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "SAVEA",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Nov 27 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 25 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 15 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 8.19m,
                    ShipName = "Save-a-lot Markets",
                    ShipAddress = "187 Suffolk Ln.",
                    ShipCity = "Boise",
                    ShipRegion = "ID",
                    ShipPostalCode = "83720",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[34], UnitPrice = 14.00m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 7, Discount = 0F},
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[64], UnitPrice = 33.25m, Quantity = 24, Discount = 0F}),

                new Order
                {
                    CustomerId = "RICSU",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Nov 28 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 26 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec  4 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 138.17m,
                    ShipName = "Richter Supermarkt",
                    ShipAddress = "Starenweg 5",
                    ShipCity = "Genève",
                    ShipRegion = "",
                    ShipPostalCode = "1204",
                    ShipCountry = "Switzerland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[26], UnitPrice = 31.23m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[52], UnitPrice = 7.00m, Quantity = 60, Discount = 0F},
                    new OrderDetail {Product = products[70], UnitPrice = 15.00m, Quantity = 40, Discount = 0F}),

                new Order
                {
                    CustomerId = "ANATR",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Nov 28 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 26 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 12 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 11.99m,
                    ShipName = "Ana Trujillo Emparedados y helados",
                    ShipAddress = "Avda. de la Constitución 2222",
                    ShipCity = "México D.F.",
                    ShipRegion = "",
                    ShipPostalCode = "05021",
                    ShipCountry = "Mexico",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[32], UnitPrice = 32.00m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "MAISD",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Dec  1 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 29 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 10 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 155.64m,
                    ShipName = "Maison Dewey",
                    ShipAddress = "Rue Joseph-Bens 532",
                    ShipCity = "Bruxelles",
                    ShipRegion = "",
                    ShipPostalCode = "B-1180",
                    ShipCountry = "Belgium",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[25], UnitPrice = 14.00m, Quantity = 12, Discount = 0.25F},
                    new OrderDetail {Product = products[27], UnitPrice = 43.90m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[43], UnitPrice = 46.00m, Quantity = 30, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "RATTC",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Dec  2 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 30 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec  8 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 18.66m,
                    ShipName = "Rattlesnake Canyon Grocery",
                    ShipAddress = "2817 Milton Dr.",
                    ShipCity = "Albuquerque",
                    ShipRegion = "NM",
                    ShipPostalCode = "87110",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[25], UnitPrice = 14.00m, Quantity = 35, Discount = 0.25F},
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 18, Discount = 0F}),

                new Order
                {
                    CustomerId = "FOLKO",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Dec  2 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 30 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec  9 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 328.74m,
                    ShipName = "Folk och fä HB",
                    ShipAddress = "Åkergatan 24",
                    ShipCity = "Bräcke",
                    ShipRegion = "",
                    ShipPostalCode = "S-844 67",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[39], UnitPrice = 18.00m, Quantity = 16, Discount = 0F},
                    new OrderDetail {Product = products[47], UnitPrice = 9.50m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[51], UnitPrice = 53.00m, Quantity = 28, Discount = 0F},
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 60, Discount = 0F}),

                new Order
                {
                    CustomerId = "FOLIG",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Dec  3 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 31 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec  8 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 37.35m,
                    ShipName = "Folies gourmandes",
                    ShipAddress = "184, chaussée de Tournai",
                    ShipCity = "Lille",
                    ShipRegion = "",
                    ShipPostalCode = "59000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[21], UnitPrice = 10.00m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[22], UnitPrice = 21.00m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "ERNSH",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Dec  3 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 31 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec  8 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 145.45m,
                    ShipName = "Ernst Handel",
                    ShipAddress = "Kirchgasse 6",
                    ShipCity = "Graz",
                    ShipRegion = "",
                    ShipPostalCode = "8010",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[3], UnitPrice = 10.00m, Quantity = 20, Discount = 0.1F},
                    new OrderDetail {Product = products[39], UnitPrice = 18.00m, Quantity = 130, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "QUICK",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Dec  4 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan  1 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec  9 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 42.74m,
                    ShipName = "QUICK-Stop",
                    ShipAddress = "Taucherstraße 10",
                    ShipCity = "Cunewalde",
                    ShipRegion = "",
                    ShipPostalCode = "01307",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[65], UnitPrice = 21.05m, Quantity = 80, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "OTTIK",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Dec  5 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan  2 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec  9 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 157.55m,
                    ShipName = "Ottilies Käseladen",
                    ShipAddress = "Mehrheimerstr. 369",
                    ShipCity = "Köln",
                    ShipRegion = "",
                    ShipPostalCode = "50739",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 19.00m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[7], UnitPrice = 30.00m, Quantity = 35, Discount = 0F},
                    new OrderDetail {Product = products[68], UnitPrice = 12.50m, Quantity = 40, Discount = 0F}),

                new Order
                {
                    CustomerId = "SUPRD",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Dec  5 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan  2 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 15 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 1.59m,
                    ShipName = "Suprêmes délices",
                    ShipAddress = "Boulevard Tirou, 255",
                    ShipCity = "Charleroi",
                    ShipRegion = "",
                    ShipPostalCode = "B-6000",
                    ShipCountry = "Belgium",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[42], UnitPrice = 14.00m, Quantity = 2, Discount = 0F}),

                new Order
                {
                    CustomerId = "AROUT",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Dec  8 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan  5 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 15 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 146.32m,
                    ShipName = "Around the Horn",
                    ShipAddress = "Brook Farm Stratford St. Mary",
                    ShipCity = "Colchester",
                    ShipRegion = "Essex",
                    ShipPostalCode = "CO7 6JX",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[22], UnitPrice = 21.00m, Quantity = 4, Discount = 0F},
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 50, Discount = 0F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[71], UnitPrice = 21.50m, Quantity = 12, Discount = 0F}),

                new Order
                {
                    CustomerId = "VAFFE",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Dec  8 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan  5 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 12 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 65.06m,
                    ShipName = "Vaffeljernet",
                    ShipAddress = "Smagsloget 45",
                    ShipCity = "Århus",
                    ShipRegion = "",
                    ShipPostalCode = "8200",
                    ShipCountry = "Denmark",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 30, Discount = 0.05F},
                    new OrderDetail {Product = products[52], UnitPrice = 7.00m, Quantity = 15, Discount = 0.05F},
                    new OrderDetail {Product = products[61], UnitPrice = 28.50m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "HANAR",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Dec  9 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan  6 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 17 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 5.32m,
                    ShipName = "Hanari Carnes",
                    ShipAddress = "Rua do Paço, 67",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "05454-876",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 21.00m, Quantity = 15, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "ERNSH",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Dec 10 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan  7 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan  2 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 11.19m,
                    ShipName = "Ernst Handel",
                    ShipAddress = "Kirchgasse 6",
                    ShipCity = "Graz",
                    ShipRegion = "",
                    ShipPostalCode = "8010",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[71], UnitPrice = 21.50m, Quantity = 16, Discount = 0F}),

                new Order
                {
                    CustomerId = "LEHMS",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Dec 10 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan  7 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 19 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 91.28m,
                    ShipName = "Lehmanns Marktstand",
                    ShipAddress = "Magazinweg 7",
                    ShipCity = "Frankfurt a.M.",
                    ShipRegion = "",
                    ShipPostalCode = "60528",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[29], UnitPrice = 123.79m, Quantity = 18, Discount = 0F},
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 25, Discount = 0F}),

                new Order
                {
                    CustomerId = "ERNSH",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Dec 11 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan  8 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 16 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 96.43m,
                    ShipName = "Ernst Handel",
                    ShipAddress = "Kirchgasse 6",
                    ShipCity = "Graz",
                    ShipRegion = "",
                    ShipPostalCode = "8010",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[17], UnitPrice = 39.00m, Quantity = 33, Discount = 0F},
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 70, Discount = 0.2F},
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 7, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "FOLKO",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Dec 11 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 25 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 12 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 48.20m,
                    ShipName = "Folk och fä HB",
                    ShipAddress = "Åkergatan 24",
                    ShipCity = "Bräcke",
                    ShipRegion = "",
                    ShipPostalCode = "S-844 67",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 2, Discount = 0.25F},
                    new OrderDetail {Product = products[66], UnitPrice = 17.00m, Quantity = 50, Discount = 0F}),

                new Order
                {
                    CustomerId = "THECR",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Dec 12 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan  9 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 26 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 20.25m,
                    ShipName = "The Cracker Box",
                    ShipAddress = "55 Grizzly Peak Rd.",
                    ShipCity = "Butte",
                    ShipRegion = "MT",
                    ShipPostalCode = "59801",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[10], UnitPrice = 31.00m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[67], UnitPrice = 14.00m, Quantity = 3, Discount = 0F}),

                new Order
                {
                    CustomerId = "ERNSH",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Dec 15 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 12 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 18 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 351.53m,
                    ShipName = "Ernst Handel",
                    ShipAddress = "Kirchgasse 6",
                    ShipCity = "Graz",
                    ShipRegion = "",
                    ShipPostalCode = "8010",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 16, Discount = 0.05F},
                    new OrderDetail {Product = products[42], UnitPrice = 14.00m, Quantity = 12, Discount = 0.05F},
                    new OrderDetail {Product = products[45], UnitPrice = 9.50m, Quantity = 27, Discount = 0.05F},
                    new OrderDetail {Product = products[51], UnitPrice = 53.00m, Quantity = 120, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "GOURL",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Dec 15 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 29 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 21 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 3.01m,
                    ShipName = "Gourmet Lanchonetes",
                    ShipAddress = "Av. Brasil, 442",
                    ShipCity = "Campinas",
                    ShipRegion = "SP",
                    ShipPostalCode = "04876-786",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[42], UnitPrice = 14.00m, Quantity = 20, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "BERGS",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Dec 16 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 13 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 24 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 6.79m,
                    ShipName = "Berglunds snabbköp",
                    ShipAddress = "Berguvsvägen  8",
                    ShipCity = "Luleå",
                    ShipRegion = "",
                    ShipPostalCode = "S-958 22",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "MORGK",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Dec 16 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 13 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 14 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 58.13m,
                    ShipName = "Morgenstern Gesundkost",
                    ShipAddress = "Heerstr. 22",
                    ShipCity = "Leipzig",
                    ShipRegion = "",
                    ShipPostalCode = "04179",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[16], UnitPrice = 17.45m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "LILAS",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Dec 16 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Dec 30 1997 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 25 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 42.13m,
                    ShipName = "LILA-Supermercado",
                    ShipAddress = "Carrera 52 con Ave. Bolívar #65-98 Llano Largo",
                    ShipCity = "Barquisimeto",
                    ShipRegion = "Lara",
                    ShipPostalCode = "3508",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[70], UnitPrice = 15.00m, Quantity = 35, Discount = 0F},
                    new OrderDetail {Product = products[77], UnitPrice = 13.00m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "WARTH",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Dec 17 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 14 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 19 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 73.16m,
                    ShipName = "Wartian Herkku",
                    ShipAddress = "Torikatu 38",
                    ShipCity = "Oulu",
                    ShipRegion = "",
                    ShipPostalCode = "90110",
                    ShipCountry = "Finland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[54], UnitPrice = 7.45m, Quantity = 3, Discount = 0.2F},
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 20, Discount = 0.2F},
                    new OrderDetail {Product = products[74], UnitPrice = 10.00m, Quantity = 35, Discount = 0F}),

                new Order
                {
                    CustomerId = "CACTU",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Dec 17 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 14 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 22 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 1.10m,
                    ShipName = "Cactus Comidas para llevar",
                    ShipAddress = "Cerrito 333",
                    ShipCity = "Buenos Aires",
                    ShipRegion = "",
                    ShipPostalCode = "1010",
                    ShipCountry = "Argentina",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 1, Discount = 0F}),

                new Order
                {
                    CustomerId = "HANAR",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Dec 18 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 15 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 19 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 124.98m,
                    ShipName = "Hanari Carnes",
                    ShipAddress = "Rua do Paço, 67",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "05454-876",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[38], UnitPrice = 263.50m, Quantity = 5, Discount = 0F}),

                new Order
                {
                    CustomerId = "MAGAA",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Dec 18 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 15 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 22 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 70.09m,
                    ShipName = "Magazzini Alimentari Riuniti",
                    ShipAddress = "Via Ludovico il Moro 22",
                    ShipCity = "Bergamo",
                    ShipRegion = "",
                    ShipPostalCode = "24100",
                    ShipCountry = "Italy",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[36], UnitPrice = 19.00m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[39], UnitPrice = 18.00m, Quantity = 2, Discount = 0.15F},
                    new OrderDetail {Product = products[72], UnitPrice = 34.80m, Quantity = 30, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "GROSR",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Dec 18 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 15 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 24 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 1.51m,
                    ShipName = "GROSELLA-Restaurante",
                    ShipAddress = "5ª Ave. Los Palos Grandes",
                    ShipCity = "Caracas",
                    ShipRegion = "DF",
                    ShipPostalCode = "1081",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[10], UnitPrice = 31.00m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "QUEEN",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Dec 19 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 16 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 23 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 110.87m,
                    ShipName = "Queen Cozinha",
                    ShipAddress = "Alameda dos Canàrios, 891",
                    ShipCity = "Sao Paulo",
                    ShipRegion = "SP",
                    ShipPostalCode = "05487-020",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[8], UnitPrice = 40.00m, Quantity = 30, Discount = 0.2F},
                    new OrderDetail {Product = products[30], UnitPrice = 25.89m, Quantity = 15, Discount = 0.2F},
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 42, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "LAMAI",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Dec 19 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan  2 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 26 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 249.93m,
                    ShipName = "La maison d'Asie",
                    ShipAddress = "1 rue Alsace-Lorraine",
                    ShipCity = "Toulouse",
                    ShipRegion = "",
                    ShipPostalCode = "31000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 19.00m, Quantity = 15, Discount = 0.05F},
                    new OrderDetail {Product = products[29], UnitPrice = 123.79m, Quantity = 20, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "QUICK",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Dec 22 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 19 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 19 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 42.70m,
                    ShipName = "QUICK-Stop",
                    ShipAddress = "Taucherstraße 10",
                    ShipCity = "Cunewalde",
                    ShipRegion = "",
                    ShipPostalCode = "01307",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[19], UnitPrice = 9.20m, Quantity = 50, Discount = 0.05F},
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 40, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "FOLIG",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Dec 22 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 19 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 31 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 100.60m,
                    ShipName = "Folies gourmandes",
                    ShipAddress = "184, chaussée de Tournai",
                    ShipCity = "Lille",
                    ShipRegion = "",
                    ShipPostalCode = "59000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[18], UnitPrice = 62.50m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[35], UnitPrice = 18.00m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[63], UnitPrice = 43.90m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[68], UnitPrice = 12.50m, Quantity = 18, Discount = 0F}),

                new Order
                {
                    CustomerId = "GOURL",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Dec 22 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 19 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 26 1997 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 28.23m,
                    ShipName = "Gourmet Lanchonetes",
                    ShipAddress = "Av. Brasil, 442",
                    ShipCity = "Campinas",
                    ShipRegion = "SP",
                    ShipPostalCode = "04876-786",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[7], UnitPrice = 30.00m, Quantity = 3, Discount = 0.15F},
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 20, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "FRANK",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Dec 23 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 20 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan  1 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 16.85m,
                    ShipName = "Frankenversand",
                    ShipAddress = "Berliner Platz 43",
                    ShipCity = "München",
                    ShipRegion = "",
                    ShipPostalCode = "80805",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[29], UnitPrice = 123.79m, Quantity = 14, Discount = 0.05F},
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 20, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "WOLZA",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Dec 23 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 20 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 31 1997 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 23.79m,
                    ShipName = "Wolski Zajazd",
                    ShipAddress = "ul. Filtrowa 68",
                    ShipCity = "Warszawa",
                    ShipRegion = "",
                    ShipPostalCode = "01-012",
                    ShipCountry = "Poland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 19.00m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[54], UnitPrice = 7.45m, Quantity = 3, Discount = 0F},
                    new OrderDetail {Product = products[68], UnitPrice = 12.50m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "AROUT",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Dec 24 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 21 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan  8 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 4.52m,
                    ShipName = "Around the Horn",
                    ShipAddress = "Brook Farm Stratford St. Mary",
                    ShipCity = "Colchester",
                    ShipRegion = "Essex",
                    ShipPostalCode = "CO7 6JX",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 14, Discount = 0F},
                    new OrderDetail {Product = products[52], UnitPrice = 7.00m, Quantity = 8, Discount = 0F}),

                new Order
                {
                    CustomerId = "QUEDE",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Dec 24 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 21 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan  2 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 21.49m,
                    ShipName = "Que Delícia",
                    ShipAddress = "Rua da Panificadora, 12",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "02389-673",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[14], UnitPrice = 23.25m, Quantity = 15, Discount = 0.2F},
                    new OrderDetail {Product = products[54], UnitPrice = 7.45m, Quantity = 6, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "ERNSH",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Dec 24 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 21 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 20 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 126.66m,
                    ShipName = "Ernst Handel",
                    ShipAddress = "Kirchgasse 6",
                    ShipCity = "Graz",
                    ShipRegion = "",
                    ShipPostalCode = "8010",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[16], UnitPrice = 17.45m, Quantity = 65, Discount = 0F},
                    new OrderDetail {Product = products[17], UnitPrice = 39.00m, Quantity = 35, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "HILAA",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Dec 25 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 22 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 14 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 26.52m,
                    ShipName = "HILARION-Abastos",
                    ShipAddress = "Carrera 22 con Ave. Carlos Soublette #8-35",
                    ShipCity = "San Cristóbal",
                    ShipRegion = "Táchira",
                    ShipPostalCode = "5022",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[26], UnitPrice = 31.23m, Quantity = 21, Discount = 0.2F},
                    new OrderDetail {Product = products[44], UnitPrice = 19.45m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[64], UnitPrice = 33.25m, Quantity = 35, Discount = 0.2F},
                    new OrderDetail {Product = products[69], UnitPrice = 36.00m, Quantity = 24, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "DRACD",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Dec 25 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 22 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan  5 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 33.35m,
                    ShipName = "Drachenblut Delikatessen",
                    ShipAddress = "Walserweg 21",
                    ShipCity = "Aachen",
                    ShipRegion = "",
                    ShipPostalCode = "52066",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 21.00m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "ISLAT",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Dec 26 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 23 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan  5 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 2.33m,
                    ShipName = "Island Trading",
                    ShipAddress = "Garden House Crowther Way",
                    ShipCity = "Cowes",
                    ShipRegion = "Isle of Wight",
                    ShipPostalCode = "PO31 7PJ",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 2, Discount = 0F},
                    new OrderDetail {Product = products[72], UnitPrice = 34.80m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "KOENE",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Dec 26 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb  6 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan  5 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 30.76m,
                    ShipName = "Königlich Essen",
                    ShipAddress = "Maubelstr. 90",
                    ShipCity = "Brandenburg",
                    ShipRegion = "",
                    ShipPostalCode = "14776",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[13], UnitPrice = 6.00m, Quantity = 20, Discount = 0.15F},
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 20, Discount = 0.15F},
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 25, Discount = 0F}),

                new Order
                {
                    CustomerId = "SEVES",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Dec 26 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 23 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan  5 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 137.44m,
                    ShipName = "Seven Seas Imports",
                    ShipAddress = "90 Wadhurst Rd.",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "OX15 4NB",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 21.00m, Quantity = 50, Discount = 0.1F},
                    new OrderDetail {Product = products[51], UnitPrice = 53.00m, Quantity = 10, Discount = 0.1F},
                    new OrderDetail {Product = products[54], UnitPrice = 7.45m, Quantity = 7, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "BOLID",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Dec 29 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 26 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Dec 31 1997 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 97.09m,
                    ShipName = "Bólido Comidas preparadas",
                    ShipAddress = "C/ Araquil, 67",
                    ShipCity = "Madrid",
                    ShipRegion = "",
                    ShipPostalCode = "28023",
                    ShipCountry = "Spain",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[17], UnitPrice = 39.00m, Quantity = 40, Discount = 0.25F},
                    new OrderDetail {Product = products[29], UnitPrice = 123.79m, Quantity = 20, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "SIMOB",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Dec 29 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 26 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan  2 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 257.26m,
                    ShipName = "Simons bistro",
                    ShipAddress = "Vinbæltet 34",
                    ShipCity = "Kobenhavn",
                    ShipRegion = "",
                    ShipPostalCode = "1734",
                    ShipCountry = "Denmark",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[30], UnitPrice = 25.89m, Quantity = 25, Discount = 0.25F},
                    new OrderDetail {Product = products[51], UnitPrice = 53.00m, Quantity = 30, Discount = 0.25F},
                    new OrderDetail {Product = products[55], UnitPrice = 24.00m, Quantity = 60, Discount = 0.25F},
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 5, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "WELLI",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Dec 30 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 27 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan  6 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 55.23m,
                    ShipName = "Wellington Importadora",
                    ShipAddress = "Rua do Mercado, 12",
                    ShipCity = "Resende",
                    ShipRegion = "SP",
                    ShipPostalCode = "08737-363",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[19], UnitPrice = 9.20m, Quantity = 24, Discount = 0.05F},
                    new OrderDetail {Product = products[25], UnitPrice = 14.00m, Quantity = 15, Discount = 0.05F},
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 15, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "SEVES",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Dec 30 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 27 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan  7 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 27.33m,
                    ShipName = "Seven Seas Imports",
                    ShipAddress = "90 Wadhurst Rd.",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "OX15 4NB",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[10], UnitPrice = 31.00m, Quantity = 36, Discount = 0F},
                    new OrderDetail {Product = products[28], UnitPrice = 45.60m, Quantity = 24, Discount = 0F},
                    new OrderDetail {Product = products[49], UnitPrice = 20.00m, Quantity = 4, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "THEBI",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Dec 30 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 27 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan  9 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 237.34m,
                    ShipName = "The Big Cheese",
                    ShipAddress = "89 Jefferson Way Suite 2",
                    ShipCity = "Portland",
                    ShipRegion = "OR",
                    ShipPostalCode = "97201",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[34], UnitPrice = 14.00m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[38], UnitPrice = 263.50m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "VICTE",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Dec 31 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 28 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan  5 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 22.11m,
                    ShipName = "Victuailles en stock",
                    ShipAddress = "2, rue du Commerce",
                    ShipCity = "Lyon",
                    ShipRegion = "",
                    ShipPostalCode = "69004",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 19.00m, Quantity = 20, Discount = 0.25F},
                    new OrderDetail {Product = products[65], UnitPrice = 21.05m, Quantity = 2, Discount = 0F},
                    new OrderDetail {Product = products[74], UnitPrice = 10.00m, Quantity = 15, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "FRANS",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Dec 31 1997 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 28 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 30 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 1.36m,
                    ShipName = "Franchi S.p.A.",
                    ShipAddress = "Via Monte Bianco 34",
                    ShipCity = "Torino",
                    ShipRegion = "",
                    ShipPostalCode = "10100",
                    ShipCountry = "Italy",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[40], UnitPrice = 18.40m, Quantity = 1, Discount = 0F}),

                new Order
                {
                    CustomerId = "OLDWO",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Jan  1 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 29 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan  9 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 45.53m,
                    ShipName = "Old World Delicatessen",
                    ShipAddress = "2743 Bering St.",
                    ShipCity = "Anchorage",
                    ShipRegion = "AK",
                    ShipPostalCode = "99508",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 20, Discount = 0.15F},
                    new OrderDetail {Product = products[76], UnitPrice = 18.00m, Quantity = 50, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "WELLI",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Jan  1 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 29 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan  7 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 4.87m,
                    ShipName = "Wellington Importadora",
                    ShipAddress = "Rua do Mercado, 12",
                    ShipCity = "Resende",
                    ShipRegion = "SP",
                    ShipPostalCode = "08737-363",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[52], UnitPrice = 7.00m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "LAUGB",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Jan  1 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 29 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan  7 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 4.33m,
                    ShipName = "Laughing Bacchus Wine Cellars",
                    ShipAddress = "2319 Elm St.",
                    ShipCity = "Vancouver",
                    ShipRegion = "BC",
                    ShipPostalCode = "V3F 2K1",
                    ShipCountry = "Canada",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[13], UnitPrice = 6.00m, Quantity = 7, Discount = 0F},
                    new OrderDetail {Product = products[25], UnitPrice = 14.00m, Quantity = 5, Discount = 0F},
                    new OrderDetail {Product = products[70], UnitPrice = 15.00m, Quantity = 5, Discount = 0F}),

                new Order
                {
                    CustomerId = "LINOD",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Jan  2 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 30 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan  8 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 31.22m,
                    ShipName = "LINO-Delicateses",
                    ShipAddress = "Ave. 5 de Mayo Porlamar",
                    ShipCity = "I. de Margarita",
                    ShipRegion = "Nueva Esparta",
                    ShipPostalCode = "4980",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[19], UnitPrice = 9.20m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[23], UnitPrice = 9.00m, Quantity = 18, Discount = 0F},
                    new OrderDetail {Product = products[40], UnitPrice = 18.40m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "REGGC",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Jan  2 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 30 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 12 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 59.78m,
                    ShipName = "Reggiani Caseifici",
                    ShipAddress = "Strada Provinciale 124",
                    ShipCity = "Reggio Emilia",
                    ShipRegion = "",
                    ShipPostalCode = "42100",
                    ShipCountry = "Italy",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 16, Discount = 0.1F},
                    new OrderDetail {Product = products[72], UnitPrice = 34.80m, Quantity = 40, Discount = 0.1F},
                    new OrderDetail {Product = products[77], UnitPrice = 13.00m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "RICAR",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Jan  5 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb  2 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan  9 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 47.38m,
                    ShipName = "Ricardo Adocicados",
                    ShipAddress = "Av. Copacabana, 267",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "02389-890",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 19.00m, Quantity = 12, Discount = 0.2F},
                    new OrderDetail {Product = products[46], UnitPrice = 12.00m, Quantity = 35, Discount = 0F}),

                new Order
                {
                    CustomerId = "VICTE",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Jan  5 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb  2 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 14 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 130.94m,
                    ShipName = "Victuailles en stock",
                    ShipAddress = "2, rue du Commerce",
                    ShipCity = "Lyon",
                    ShipRegion = "",
                    ShipPostalCode = "69004",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[43], UnitPrice = 46.00m, Quantity = 20, Discount = 0.15F},
                    new OrderDetail {Product = products[48], UnitPrice = 12.75m, Quantity = 8, Discount = 0.15F},
                    new OrderDetail {Product = products[61], UnitPrice = 28.50m, Quantity = 30, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "SAVEA",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Jan  5 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb  2 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 14 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 14.62m,
                    ShipName = "Save-a-lot Markets",
                    ShipAddress = "187 Suffolk Ln.",
                    ShipCity = "Boise",
                    ShipRegion = "ID",
                    ShipPostalCode = "83720",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[33], UnitPrice = 2.50m, Quantity = 16, Discount = 0F}),

                new Order
                {
                    CustomerId = "GREAL",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Jan  6 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb  3 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb  4 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 719.78m,
                    ShipName = "Great Lakes Food Market",
                    ShipAddress = "2732 Baker Blvd.",
                    ShipCity = "Eugene",
                    ShipRegion = "OR",
                    ShipPostalCode = "97403",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[38], UnitPrice = 263.50m, Quantity = 30, Discount = 0.05F},
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 20, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "KOENE",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Jan  6 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 20 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 13 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 306.07m,
                    ShipName = "Königlich Essen",
                    ShipAddress = "Maubelstr. 90",
                    ShipCity = "Brandenburg",
                    ShipRegion = "",
                    ShipPostalCode = "14776",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[26], UnitPrice = 31.23m, Quantity = 40, Discount = 0.15F},
                    new OrderDetail {Product = products[38], UnitPrice = 263.50m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[40], UnitPrice = 18.40m, Quantity = 60, Discount = 0.15F},
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 25, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "MAGAA",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Jan  7 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb  4 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 12 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 65.48m,
                    ShipName = "Magazzini Alimentari Riuniti",
                    ShipAddress = "Via Ludovico il Moro 22",
                    ShipCity = "Bergamo",
                    ShipRegion = "",
                    ShipPostalCode = "24100",
                    ShipCountry = "Italy",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[32], UnitPrice = 32.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "CACTU",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Jan  7 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb  4 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 16 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 19.76m,
                    ShipName = "Cactus Comidas para llevar",
                    ShipAddress = "Cerrito 333",
                    ShipCity = "Buenos Aires",
                    ShipRegion = "",
                    ShipPostalCode = "1010",
                    ShipCountry = "Argentina",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[43], UnitPrice = 46.00m, Quantity = 7, Discount = 0F},
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "RATTC",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Jan  7 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb  4 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 13 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 37.52m,
                    ShipName = "Rattlesnake Canyon Grocery",
                    ShipAddress = "2817 Milton Dr.",
                    ShipCity = "Albuquerque",
                    ShipRegion = "NM",
                    ShipPostalCode = "87110",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "SPLIR",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Jan  8 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb  5 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 15 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 36.68m,
                    ShipName = "Split Rail Beer & Ale",
                    ShipAddress = "P.O. Box 555",
                    ShipCity = "Lander",
                    ShipRegion = "WY",
                    ShipPostalCode = "82520",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[35], UnitPrice = 18.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[51], UnitPrice = 53.00m, Quantity = 6, Discount = 0F}),

                new Order
                {
                    CustomerId = "TRAIH",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Jan  8 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb  5 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 16 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 7.00m,
                    ShipName = "Trail's Head Gourmet Provisioners",
                    ShipAddress = "722 DaVinci Blvd.",
                    ShipCity = "Kirkland",
                    ShipRegion = "WA",
                    ShipPostalCode = "98034",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 3, Discount = 0F},
                    new OrderDetail {Product = products[70], UnitPrice = 15.00m, Quantity = 6, Discount = 0F}),

                new Order
                {
                    CustomerId = "LILAS",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Jan  9 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb  6 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 13 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 163.97m,
                    ShipName = "LILA-Supermercado",
                    ShipAddress = "Carrera 52 con Ave. Bolívar #65-98 Llano Largo",
                    ShipCity = "Barquisimeto",
                    ShipRegion = "Lara",
                    ShipPostalCode = "3508",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 21.00m, Quantity = 20, Discount = 0.1F},
                    new OrderDetail {Product = products[57], UnitPrice = 19.50m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 40, Discount = 0.1F},
                    new OrderDetail {Product = products[77], UnitPrice = 13.00m, Quantity = 15, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "FOLKO",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Jan  9 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb  6 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 30 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 1.23m,
                    ShipName = "Folk och fä HB",
                    ShipAddress = "Åkergatan 24",
                    ShipCity = "Bräcke",
                    ShipRegion = "",
                    ShipPostalCode = "S-844 67",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[70], UnitPrice = 15.00m, Quantity = 9, Discount = 0F}),

                new Order
                {
                    CustomerId = "DRACD",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Jan  9 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb  6 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 14 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 79.25m,
                    ShipName = "Drachenblut Delikatessen",
                    ShipAddress = "Walserweg 21",
                    ShipCity = "Aachen",
                    ShipRegion = "",
                    ShipPostalCode = "52066",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[26], UnitPrice = 31.23m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[53], UnitPrice = 32.80m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "BLONP",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Jan 12 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb  9 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb  6 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 7.09m,
                    ShipName = "Blondel père et fils",
                    ShipAddress = "24, place Kléber",
                    ShipCity = "Strasbourg",
                    ShipRegion = "",
                    ShipPostalCode = "67000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 35, Discount = 0F},
                    new OrderDetail {Product = products[57], UnitPrice = 19.50m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "BONAP",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Jan 12 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 26 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb  6 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 63.54m,
                    ShipName = "Bon app'",
                    ShipAddress = "12, rue des Bouchers",
                    ShipCity = "Marseille",
                    ShipRegion = "",
                    ShipPostalCode = "13008",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[10], UnitPrice = 31.00m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[39], UnitPrice = 18.00m, Quantity = 21, Discount = 0F}),

                new Order
                {
                    CustomerId = "RANCH",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Jan 13 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Jan 27 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb  4 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 90.85m,
                    ShipName = "Rancho grande",
                    ShipAddress = "Av. del Libertador 900",
                    ShipCity = "Buenos Aires",
                    ShipRegion = "",
                    ShipPostalCode = "1010",
                    ShipCountry = "Argentina",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[20], UnitPrice = 81.00m, Quantity = 5, Discount = 0F},
                    new OrderDetail {Product = products[38], UnitPrice = 263.50m, Quantity = 2, Discount = 0F}),

                new Order
                {
                    CustomerId = "ISLAT",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Jan 13 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 10 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 23 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 154.72m,
                    ShipName = "Island Trading",
                    ShipAddress = "Garden House Crowther Way",
                    ShipCity = "Cowes",
                    ShipRegion = "Isle of Wight",
                    ShipPostalCode = "PO31 7PJ",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 19.00m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[8], UnitPrice = 40.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[13], UnitPrice = 6.00m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 21, Discount = 0F}),

                new Order
                {
                    CustomerId = "TRADH",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Jan 13 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 24 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 21 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 81.83m,
                    ShipName = "Tradiçao Hipermercados",
                    ShipAddress = "Av. Inês de Castro, 414",
                    ShipCity = "Sao Paulo",
                    ShipRegion = "SP",
                    ShipPostalCode = "05634-030",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[6], UnitPrice = 25.00m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[39], UnitPrice = 18.00m, Quantity = 28, Discount = 0F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[68], UnitPrice = 12.50m, Quantity = 24, Discount = 0F}),

                new Order
                {
                    CustomerId = "SANTG",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Jan 14 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 11 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 23 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 72.19m,
                    ShipName = "Santé Gourmet",
                    ShipAddress = "Erling Skakkes gate 78",
                    ShipCity = "Stavern",
                    ShipRegion = "",
                    ShipPostalCode = "4110",
                    ShipCountry = "Norway",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[19], UnitPrice = 9.20m, Quantity = 2, Discount = 0F},
                    new OrderDetail {Product = products[35], UnitPrice = 18.00m, Quantity = 8, Discount = 0F},
                    new OrderDetail {Product = products[38], UnitPrice = 263.50m, Quantity = 8, Discount = 0F},
                    new OrderDetail {Product = products[43], UnitPrice = 46.00m, Quantity = 9, Discount = 0F}),

                new Order
                {
                    CustomerId = "LAMAI",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Jan 14 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 11 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 19 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 43.26m,
                    ShipName = "La maison d'Asie",
                    ShipAddress = "1 rue Alsace-Lorraine",
                    ShipCity = "Toulouse",
                    ShipRegion = "",
                    ShipPostalCode = "31000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[13], UnitPrice = 6.00m, Quantity = 3, Discount = 0.2F},
                    new OrderDetail {Product = products[25], UnitPrice = 14.00m, Quantity = 10, Discount = 0.2F},
                    new OrderDetail {Product = products[44], UnitPrice = 19.45m, Quantity = 16, Discount = 0.2F},
                    new OrderDetail {Product = products[64], UnitPrice = 33.25m, Quantity = 3, Discount = 0F}),

                new Order
                {
                    CustomerId = "OTTIK",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Jan 15 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 12 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 23 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 71.49m,
                    ShipName = "Ottilies Käseladen",
                    ShipAddress = "Mehrheimerstr. 369",
                    ShipCity = "Köln",
                    ShipRegion = "",
                    ShipPostalCode = "50739",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[7], UnitPrice = 30.00m, Quantity = 20, Discount = 0.1F},
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 9, Discount = 0.1F},
                    new OrderDetail {Product = products[53], UnitPrice = 32.80m, Quantity = 9, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "TRADH",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Jan 15 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 12 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 19 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 29.78m,
                    ShipName = "Tradiçao Hipermercados",
                    ShipAddress = "Av. Inês de Castro, 414",
                    ShipCity = "Sao Paulo",
                    ShipRegion = "SP",
                    ShipPostalCode = "05634-030",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[29], UnitPrice = 123.79m, Quantity = 8, Discount = 0.05F},
                    new OrderDetail {Product = products[30], UnitPrice = 25.89m, Quantity = 20, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "ALFKI",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Jan 15 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 12 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 21 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 69.53m,
                    ShipName = "Alfred's Futterkiste",
                    ShipAddress = "Obere Str. 57",
                    ShipCity = "Berlin",
                    ShipRegion = "",
                    ShipPostalCode = "12209",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[77], UnitPrice = 13.00m, Quantity = 2, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "ERNSH",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Jan 16 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 13 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 21 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 411.88m,
                    ShipName = "Ernst Handel",
                    ShipAddress = "Kirchgasse 6",
                    ShipCity = "Graz",
                    ShipRegion = "",
                    ShipPostalCode = "8010",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[22], UnitPrice = 21.00m, Quantity = 52, Discount = 0F},
                    new OrderDetail {Product = products[35], UnitPrice = 18.00m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[57], UnitPrice = 19.50m, Quantity = 24, Discount = 0F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 60, Discount = 0F},
                    new OrderDetail {Product = products[64], UnitPrice = 33.25m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "BERGS",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Jan 16 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 13 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 23 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 13.32m,
                    ShipName = "Berglunds snabbköp",
                    ShipAddress = "Berguvsvägen  8",
                    ShipCity = "Luleå",
                    ShipRegion = "",
                    ShipPostalCode = "S-958 22",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[13], UnitPrice = 6.00m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[40], UnitPrice = 18.40m, Quantity = 25, Discount = 0F},
                    new OrderDetail {Product = products[47], UnitPrice = 9.50m, Quantity = 40, Discount = 0.25F},
                    new OrderDetail {Product = products[76], UnitPrice = 18.00m, Quantity = 21, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "LINOD",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Jan 19 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 16 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 23 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 59.28m,
                    ShipName = "LINO-Delicateses",
                    ShipAddress = "Ave. 5 de Mayo Porlamar",
                    ShipCity = "I. de Margarita",
                    ShipRegion = "Nueva Esparta",
                    ShipPostalCode = "4980",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 18.00m, Quantity = 4, Discount = 0.25F},
                    new OrderDetail {Product = products[18], UnitPrice = 62.50m, Quantity = 25, Discount = 0.25F},
                    new OrderDetail {Product = products[36], UnitPrice = 19.00m, Quantity = 50, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "TRADH",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Jan 19 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 16 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 22 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 35.43m,
                    ShipName = "Tradiçao Hipermercados",
                    ShipAddress = "Av. Inês de Castro, 414",
                    ShipCity = "Sao Paulo",
                    ShipRegion = "SP",
                    ShipPostalCode = "05634-030",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[58], UnitPrice = 13.25m, Quantity = 30, Discount = 0.1F},
                    new OrderDetail {Product = products[72], UnitPrice = 34.80m, Quantity = 15, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "LINOD",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Jan 19 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar  2 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 16 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 2.71m,
                    ShipName = "LINO-Delicateses",
                    ShipAddress = "Ave. 5 de Mayo Porlamar",
                    ShipCity = "I. de Margarita",
                    ShipRegion = "Nueva Esparta",
                    ShipPostalCode = "4980",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[25], UnitPrice = 14.00m, Quantity = 6, Discount = 0.2F},
                    new OrderDetail {Product = products[39], UnitPrice = 18.00m, Quantity = 10, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "SUPRD",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Jan 20 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 17 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 29 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 424.30m,
                    ShipName = "Suprêmes délices",
                    ShipAddress = "Boulevard Tirou, 255",
                    ShipCity = "Charleroi",
                    ShipRegion = "",
                    ShipPostalCode = "B-6000",
                    ShipCountry = "Belgium",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[10], UnitPrice = 31.00m, Quantity = 16, Discount = 0F},
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 50, Discount = 0F},
                    new OrderDetail {Product = products[77], UnitPrice = 13.00m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "TORTU",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Jan 20 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 17 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 29 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 54.42m,
                    ShipName = "Tortuga Restaurante",
                    ShipAddress = "Avda. Azteca 123",
                    ShipCity = "México D.F.",
                    ShipRegion = "",
                    ShipPostalCode = "05033",
                    ShipCountry = "Mexico",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 21.00m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[43], UnitPrice = 46.00m, Quantity = 5, Discount = 0F},
                    new OrderDetail {Product = products[68], UnitPrice = 12.50m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[70], UnitPrice = 15.00m, Quantity = 12, Discount = 0F}),

                new Order
                {
                    CustomerId = "VICTE",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Jan 21 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 18 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 26 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 9.26m,
                    ShipName = "Victuailles en stock",
                    ShipAddress = "2, rue du Commerce",
                    ShipCity = "Lyon",
                    ShipRegion = "",
                    ShipPostalCode = "69004",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[51], UnitPrice = 53.00m, Quantity = 4, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "PICCO",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Jan 21 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 18 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 26 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 25.22m,
                    ShipName = "Piccolo und mehr",
                    ShipAddress = "Geislweg 14",
                    ShipCity = "Salzburg",
                    ShipRegion = "",
                    ShipPostalCode = "5020",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[22], UnitPrice = 21.00m, Quantity = 35, Discount = 0F}),

                new Order
                {
                    CustomerId = "QUICK",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Jan 21 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb  4 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 30 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 212.98m,
                    ShipName = "QUICK-Stop",
                    ShipAddress = "Taucherstraße 10",
                    ShipCity = "Cunewalde",
                    ShipRegion = "",
                    ShipPostalCode = "01307",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[23], UnitPrice = 9.00m, Quantity = 70, Discount = 0.1F},
                    new OrderDetail {Product = products[35], UnitPrice = 18.00m, Quantity = 25, Discount = 0.1F},
                    new OrderDetail {Product = products[42], UnitPrice = 14.00m, Quantity = 42, Discount = 0.1F},
                    new OrderDetail {Product = products[58], UnitPrice = 13.25m, Quantity = 60, Discount = 0.1F},
                    new OrderDetail {Product = products[64], UnitPrice = 33.25m, Quantity = 48, Discount = 0F}),

                new Order
                {
                    CustomerId = "SUPRD",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Jan 22 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar  5 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 23 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 56.46m,
                    ShipName = "Suprêmes délices",
                    ShipAddress = "Boulevard Tirou, 255",
                    ShipCity = "Charleroi",
                    ShipRegion = "",
                    ShipPostalCode = "B-6000",
                    ShipCountry = "Belgium",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[4], UnitPrice = 22.00m, Quantity = 21, Discount = 0F},
                    new OrderDetail {Product = products[70], UnitPrice = 15.00m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[74], UnitPrice = 10.00m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "SAVEA",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Jan 22 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb  5 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 10 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 487.57m,
                    ShipName = "Save-a-lot Markets",
                    ShipAddress = "187 Suffolk Ln.",
                    ShipCity = "Boise",
                    ShipRegion = "ID",
                    ShipPostalCode = "83720",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 18.00m, Quantity = 80, Discount = 0.2F},
                    new OrderDetail {Product = products[19], UnitPrice = 9.20m, Quantity = 12, Discount = 0.2F},
                    new OrderDetail {Product = products[37], UnitPrice = 26.00m, Quantity = 60, Discount = 0.2F},
                    new OrderDetail {Product = products[45], UnitPrice = 9.50m, Quantity = 36, Discount = 0.2F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 45, Discount = 0.2F},
                    new OrderDetail {Product = products[71], UnitPrice = 21.50m, Quantity = 55, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "CONSH",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Jan 23 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 20 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 29 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 38.24m,
                    ShipName = "Consolidated Holdings",
                    ShipAddress = "Berkeley Gardens 12  Brewery",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "WX1 6LT",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[5], UnitPrice = 21.35m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[9], UnitPrice = 97.00m, Quantity = 3, Discount = 0F}),

                new Order
                {
                    CustomerId = "KOENE",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Jan 23 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 20 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 30 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 0.56m,
                    ShipName = "Königlich Essen",
                    ShipAddress = "Maubelstr. 90",
                    ShipCity = "Brandenburg",
                    ShipRegion = "",
                    ShipPostalCode = "14776",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[3], UnitPrice = 10.00m, Quantity = 49, Discount = 0F},
                    new OrderDetail {Product = products[26], UnitPrice = 31.23m, Quantity = 18, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "VICTE",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Jan 23 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar  6 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 30 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 49.19m,
                    ShipName = "Victuailles en stock",
                    ShipAddress = "2, rue du Commerce",
                    ShipCity = "Lyon",
                    ShipRegion = "",
                    ShipPostalCode = "69004",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[25], UnitPrice = 14.00m, Quantity = 20, Discount = 0.15F},
                    new OrderDetail {Product = products[33], UnitPrice = 2.50m, Quantity = 4, Discount = 0.15F},
                    new OrderDetail {Product = products[70], UnitPrice = 15.00m, Quantity = 30, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "RICAR",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Jan 26 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 23 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb  2 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 160.55m,
                    ShipName = "Ricardo Adocicados",
                    ShipAddress = "Av. Copacabana, 267",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "02389-890",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 19.00m, Quantity = 5, Discount = 0.05F},
                    new OrderDetail {Product = products[25], UnitPrice = 14.00m, Quantity = 10, Discount = 0.05F},
                    new OrderDetail {Product = products[57], UnitPrice = 19.50m, Quantity = 10, Discount = 0.05F},
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 42, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "RATTC",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Jan 26 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb  9 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Jan 30 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 174.05m,
                    ShipName = "Rattlesnake Canyon Grocery",
                    ShipAddress = "2817 Milton Dr.",
                    ShipCity = "Albuquerque",
                    ShipRegion = "NM",
                    ShipPostalCode = "87110",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 19.00m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[17], UnitPrice = 39.00m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 50, Discount = 0F}),

                new Order
                {
                    CustomerId = "BLAUS",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Jan 27 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 24 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb  3 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 53.83m,
                    ShipName = "Blauer See Delikatessen",
                    ShipAddress = "Forsterstr. 57",
                    ShipCity = "Mannheim",
                    ShipRegion = "",
                    ShipPostalCode = "68306",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[18], UnitPrice = 62.50m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "ERNSH",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Jan 27 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 24 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb  5 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 100.22m,
                    ShipName = "Ernst Handel",
                    ShipAddress = "Kirchgasse 6",
                    ShipCity = "Graz",
                    ShipRegion = "",
                    ShipPostalCode = "8010",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[10], UnitPrice = 31.00m, Quantity = 100, Discount = 0.15F},
                    new OrderDetail {Product = products[13], UnitPrice = 6.00m, Quantity = 65, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "OLDWO",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Jan 27 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 24 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb  4 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 170.97m,
                    ShipName = "Old World Delicatessen",
                    ShipAddress = "2743 Bering St.",
                    ShipCity = "Anchorage",
                    ShipRegion = "AK",
                    ShipPostalCode = "99508",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[16], UnitPrice = 17.45m, Quantity = 50, Discount = 0F},
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 14, Discount = 0F},
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 24, Discount = 0F},
                    new OrderDetail {Product = products[65], UnitPrice = 21.05m, Quantity = 15, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "ANTON",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Jan 28 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 25 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 10 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 58.43m,
                    ShipName = "Antonio Moreno Taquería",
                    ShipAddress = "Mataderos  2312",
                    ShipCity = "México D.F.",
                    ShipRegion = "",
                    ShipPostalCode = "05023",
                    ShipCountry = "Mexico",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 19.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[42], UnitPrice = 14.00m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "BERGS",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Jan 28 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 25 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb  6 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 188.85m,
                    ShipName = "Berglunds snabbköp",
                    ShipAddress = "Berguvsvägen  8",
                    ShipCity = "Luleå",
                    ShipRegion = "",
                    ShipPostalCode = "S-958 22",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[3], UnitPrice = 10.00m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[26], UnitPrice = 31.23m, Quantity = 35, Discount = 0.25F},
                    new OrderDetail {Product = products[29], UnitPrice = 123.79m, Quantity = 10, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "LACOR",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Jan 29 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 26 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb  3 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 52.51m,
                    ShipName = "La corne d'abondance",
                    ShipAddress = "67, avenue de l'Europe",
                    ShipCity = "Versailles",
                    ShipRegion = "",
                    ShipPostalCode = "78000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[7], UnitPrice = 30.00m, Quantity = 5, Discount = 0F},
                    new OrderDetail {Product = products[27], UnitPrice = 43.90m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[70], UnitPrice = 15.00m, Quantity = 4, Discount = 0F}),

                new Order
                {
                    CustomerId = "FRANK",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Jan 29 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 26 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb  2 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 76.10m,
                    ShipName = "Frankenversand",
                    ShipAddress = "Berliner Platz 43",
                    ShipCity = "München",
                    ShipRegion = "",
                    ShipPostalCode = "80805",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 40, Discount = 0.25F},
                    new OrderDetail {Product = products[54], UnitPrice = 7.45m, Quantity = 35, Discount = 0.25F},
                    new OrderDetail {Product = products[64], UnitPrice = 33.25m, Quantity = 30, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "FRANR",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Jan 29 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 26 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb  4 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 19.26m,
                    ShipName = "France restauration",
                    ShipAddress = "54, rue Royale",
                    ShipCity = "Nantes",
                    ShipRegion = "",
                    ShipPostalCode = "44000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[51], UnitPrice = 53.00m, Quantity = 3, Discount = 0F},
                    new OrderDetail {Product = products[76], UnitPrice = 18.00m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "WHITC",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Jan 30 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 27 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 17 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 14.93m,
                    ShipName = "White Clover Markets",
                    ShipAddress = "1029 - 12th Ave. S.",
                    ShipCity = "Seattle",
                    ShipRegion = "WA",
                    ShipPostalCode = "98124",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[17], UnitPrice = 39.00m, Quantity = 42, Discount = 0F},
                    new OrderDetail {Product = products[18], UnitPrice = 62.50m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[21], UnitPrice = 10.00m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[33], UnitPrice = 2.50m, Quantity = 35, Discount = 0F},
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 3, Discount = 0F}),

                new Order
                {
                    CustomerId = "LEHMS",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Jan 30 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 13 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb  2 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 53.23m,
                    ShipName = "Lehmanns Marktstand",
                    ShipAddress = "Magazinweg 7",
                    ShipCity = "Frankfurt a.M.",
                    ShipRegion = "",
                    ShipPostalCode = "60528",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 21.00m, Quantity = 25, Discount = 0F},
                    new OrderDetail {Product = products[52], UnitPrice = 7.00m, Quantity = 8, Discount = 0F}),

                new Order
                {
                    CustomerId = "HILAA",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Feb  2 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar  2 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 17 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 30.26m,
                    ShipName = "HILARION-Abastos",
                    ShipAddress = "Carrera 22 con Ave. Carlos Soublette #8-35",
                    ShipCity = "San Cristóbal",
                    ShipRegion = "Táchira",
                    ShipPostalCode = "5022",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 18.00m, Quantity = 20, Discount = 0.15F},
                    new OrderDetail {Product = products[58], UnitPrice = 13.25m, Quantity = 12, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "AROUT",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Feb  2 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar  2 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb  9 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 3.04m,
                    ShipName = "Around the Horn",
                    ShipAddress = "Brook Farm Stratford St. Mary",
                    ShipCity = "Colchester",
                    ShipRegion = "Essex",
                    ShipPostalCode = "CO7 6JX",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[35], UnitPrice = 18.00m, Quantity = 4, Discount = 0F},
                    new OrderDetail {Product = products[67], UnitPrice = 14.00m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "QUICK",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Feb  2 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Feb 16 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 12 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 348.14m,
                    ShipName = "QUICK-Stop",
                    ShipAddress = "Taucherstraße 10",
                    ShipCity = "Cunewalde",
                    ShipRegion = "",
                    ShipPostalCode = "01307",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[38], UnitPrice = 263.50m, Quantity = 60, Discount = 0.05F},
                    new OrderDetail {Product = products[39], UnitPrice = 18.00m, Quantity = 80, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "BERGS",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Feb  3 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar  3 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 12 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 109.11m,
                    ShipName = "Berglunds snabbköp",
                    ShipAddress = "Berguvsvägen  8",
                    ShipCity = "Luleå",
                    ShipRegion = "",
                    ShipPostalCode = "S-958 22",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 19.00m, Quantity = 21, Discount = 0.25F},
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 6, Discount = 0.25F},
                    new OrderDetail {Product = products[30], UnitPrice = 25.89m, Quantity = 40, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "LONEP",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Feb  3 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 17 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 11 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 1.93m,
                    ShipName = "Lonesome Pine Restaurant",
                    ShipAddress = "89 Chiaroscuro Rd.",
                    ShipCity = "Portland",
                    ShipRegion = "OR",
                    ShipPostalCode = "97219",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[53], UnitPrice = 32.80m, Quantity = 3, Discount = 0F}),

                new Order
                {
                    CustomerId = "QUEEN",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Feb  4 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar  4 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 23 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 191.27m,
                    ShipName = "Queen Cozinha",
                    ShipAddress = "Alameda dos Canàrios, 891",
                    ShipCity = "Sao Paulo",
                    ShipRegion = "SP",
                    ShipPostalCode = "05487-020",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[26], UnitPrice = 31.23m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[35], UnitPrice = 18.00m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[49], UnitPrice = 20.00m, Quantity = 42, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "SEVES",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Feb  4 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar  4 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb  9 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 143.28m,
                    ShipName = "Seven Seas Imports",
                    ShipAddress = "90 Wadhurst Rd.",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "OX15 4NB",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 18.00m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[11], UnitPrice = 21.00m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[23], UnitPrice = 9.00m, Quantity = 50, Discount = 0F},
                    new OrderDetail {Product = products[68], UnitPrice = 12.50m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "WOLZA",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Feb  4 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar  4 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 13 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 12.04m,
                    ShipName = "Wolski Zajazd",
                    ShipAddress = "ul. Filtrowa 68",
                    ShipCity = "Warszawa",
                    ShipRegion = "",
                    ShipPostalCode = "01-012",
                    ShipCountry = "Poland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[35], UnitPrice = 18.00m, Quantity = 3, Discount = 0F},
                    new OrderDetail {Product = products[51], UnitPrice = 53.00m, Quantity = 2, Discount = 0F}),

                new Order
                {
                    CustomerId = "BONAP",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Feb  5 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar  5 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 10 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 112.27m,
                    ShipName = "Bon app'",
                    ShipAddress = "12, rue des Bouchers",
                    ShipCity = "Marseille",
                    ShipRegion = "",
                    ShipPostalCode = "13008",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[6], UnitPrice = 25.00m, Quantity = 50, Discount = 0.05F},
                    new OrderDetail {Product = products[16], UnitPrice = 17.45m, Quantity = 12, Discount = 0.05F},
                    new OrderDetail {Product = products[17], UnitPrice = 39.00m, Quantity = 16, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "GODOS",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Feb  5 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar  5 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb  9 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 175.32m,
                    ShipName = "Godos Cocina Típica",
                    ShipAddress = "C/ Romero, 33",
                    ShipCity = "Sevilla",
                    ShipRegion = "",
                    ShipPostalCode = "41101",
                    ShipCountry = "Spain",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[55], UnitPrice = 24.00m, Quantity = 10, Discount = 0.05F},
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 20, Discount = 0.05F},
                    new OrderDetail {Product = products[64], UnitPrice = 33.25m, Quantity = 15, Discount = 0.05F},
                    new OrderDetail {Product = products[65], UnitPrice = 21.05m, Quantity = 21, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "WILMK",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Feb  6 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar  6 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb  9 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 0.82m,
                    ShipName = "Wilman Kala",
                    ShipAddress = "Keskuskatu 45",
                    ShipCity = "Helsinki",
                    ShipRegion = "",
                    ShipPostalCode = "21240",
                    ShipCountry = "Finland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[21], UnitPrice = 10.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[28], UnitPrice = 45.60m, Quantity = 3, Discount = 0F}),

                new Order
                {
                    CustomerId = "GODOS",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Feb  6 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar  6 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 11 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 19.58m,
                    ShipName = "Godos Cocina Típica",
                    ShipAddress = "C/ Romero, 33",
                    ShipCity = "Sevilla",
                    ShipRegion = "",
                    ShipPostalCode = "41101",
                    ShipCountry = "Spain",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[10], UnitPrice = 31.00m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "BERGS",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Feb  6 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar  6 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar  3 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 32.37m,
                    ShipName = "Berglunds snabbköp",
                    ShipAddress = "Berguvsvägen  8",
                    ShipCity = "Luleå",
                    ShipRegion = "",
                    ShipPostalCode = "S-958 22",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[19], UnitPrice = 9.20m, Quantity = 25, Discount = 0F},
                    new OrderDetail {Product = products[47], UnitPrice = 9.50m, Quantity = 21, Discount = 0.1F},
                    new OrderDetail {Product = products[49], UnitPrice = 20.00m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "BONAP",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Feb  9 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar  9 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 12 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 60.42m,
                    ShipName = "Bon app'",
                    ShipAddress = "12, rue des Bouchers",
                    ShipCity = "Marseille",
                    ShipRegion = "",
                    ShipPostalCode = "13008",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[46], UnitPrice = 12.00m, Quantity = 21, Discount = 0F},
                    new OrderDetail {Product = products[64], UnitPrice = 33.25m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "RICAR",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Feb  9 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar  9 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 19 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 38.06m,
                    ShipName = "Ricardo Adocicados",
                    ShipAddress = "Av. Copacabana, 267",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "02389-890",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[16], UnitPrice = 17.45m, Quantity = 30, Discount = 0.25F},
                    new OrderDetail {Product = products[18], UnitPrice = 62.50m, Quantity = 25, Discount = 0F}),

                new Order
                {
                    CustomerId = "QUICK",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Feb 10 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 10 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 12 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 46.69m,
                    ShipName = "QUICK-Stop",
                    ShipAddress = "Taucherstraße 10",
                    ShipCity = "Cunewalde",
                    ShipRegion = "",
                    ShipPostalCode = "01307",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[20], UnitPrice = 81.00m, Quantity = 20, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "WILMK",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Feb 10 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 10 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 12 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 8.50m,
                    ShipName = "Wilman Kala",
                    ShipAddress = "Keskuskatu 45",
                    ShipCity = "Helsinki",
                    ShipRegion = "",
                    ShipPostalCode = "21240",
                    ShipCountry = "Finland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[40], UnitPrice = 18.40m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[65], UnitPrice = 21.05m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[76], UnitPrice = 18.00m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "FOLKO",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Feb 10 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 24 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 18 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 88.01m,
                    ShipName = "Folk och fä HB",
                    ShipAddress = "Åkergatan 24",
                    ShipCity = "Bräcke",
                    ShipRegion = "",
                    ShipPostalCode = "S-844 67",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[23], UnitPrice = 9.00m, Quantity = 30, Discount = 0.2F},
                    new OrderDetail {Product = products[61], UnitPrice = 28.50m, Quantity = 30, Discount = 0.2F},
                    new OrderDetail {Product = products[70], UnitPrice = 15.00m, Quantity = 50, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "CACTU",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Feb 11 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 11 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 18 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 2.84m,
                    ShipName = "Cactus Comidas para llevar",
                    ShipAddress = "Cerrito 333",
                    ShipCity = "Buenos Aires",
                    ShipRegion = "",
                    ShipPostalCode = "1010",
                    ShipCountry = "Argentina",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[73], UnitPrice = 15.00m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "SAVEA",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Feb 11 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 11 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 20 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 23.10m,
                    ShipName = "Save-a-lot Markets",
                    ShipAddress = "187 Suffolk Ln.",
                    ShipCity = "Boise",
                    ShipRegion = "ID",
                    ShipPostalCode = "83720",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[42], UnitPrice = 14.00m, Quantity = 25, Discount = 0F},
                    new OrderDetail {Product = products[49], UnitPrice = 20.00m, Quantity = 20, Discount = 0.15F},
                    new OrderDetail {Product = products[54], UnitPrice = 7.45m, Quantity = 32, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "LONEP",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Feb 12 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 12 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 20 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 0.53m,
                    ShipName = "Lonesome Pine Restaurant",
                    ShipAddress = "89 Chiaroscuro Rd.",
                    ShipCity = "Portland",
                    ShipRegion = "OR",
                    ShipPostalCode = "97219",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 8, Discount = 0F}),

                new Order
                {
                    CustomerId = "LETSS",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Feb 12 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 12 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 13 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 90.97m,
                    ShipName = "Let's Stop N Shop",
                    ShipAddress = "87 Polk St. Suite 5",
                    ShipCity = "San Francisco",
                    ShipRegion = "CA",
                    ShipPostalCode = "94117",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[21], UnitPrice = 10.00m, Quantity = 40, Discount = 0.05F},
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 21, Discount = 0.05F},
                    new OrderDetail {Product = products[65], UnitPrice = 21.05m, Quantity = 12, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "SUPRD",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Feb 12 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 12 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 18 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 5.64m,
                    ShipName = "Suprêmes délices",
                    ShipAddress = "Boulevard Tirou, 255",
                    ShipCity = "Charleroi",
                    ShipRegion = "",
                    ShipPostalCode = "B-6000",
                    ShipCountry = "Belgium",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 19.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[70], UnitPrice = 15.00m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[77], UnitPrice = 13.00m, Quantity = 25, Discount = 0F}),

                new Order
                {
                    CustomerId = "HANAR",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Feb 13 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 13 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar  2 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 4.99m,
                    ShipName = "Hanari Carnes",
                    ShipAddress = "Rua do Paço, 67",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "05454-876",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[10], UnitPrice = 31.00m, Quantity = 70, Discount = 0F},
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 35, Discount = 0F},
                    new OrderDetail {Product = products[77], UnitPrice = 13.00m, Quantity = 40, Discount = 0F}),

                new Order
                {
                    CustomerId = "GALED",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Feb 13 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 13 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 16 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 1.25m,
                    ShipName = "Galería del gastronómo",
                    ShipAddress = "Rambla de Cataluña, 23",
                    ShipCity = "Barcelona",
                    ShipRegion = "",
                    ShipPostalCode = "8022",
                    ShipCountry = "Spain",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[25], UnitPrice = 14.00m, Quantity = 5, Discount = 0F}),

                new Order
                {
                    CustomerId = "GODOS",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Feb 16 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 16 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 23 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 51.87m,
                    ShipName = "Godos Cocina Típica",
                    ShipAddress = "C/ Romero, 33",
                    ShipCity = "Sevilla",
                    ShipRegion = "",
                    ShipPostalCode = "41101",
                    ShipCountry = "Spain",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 19.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[68], UnitPrice = 12.50m, Quantity = 18, Discount = 0F}),

                new Order
                {
                    CustomerId = "RATTC",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Feb 16 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 16 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 23 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 280.61m,
                    ShipName = "Rattlesnake Canyon Grocery",
                    ShipAddress = "2817 Milton Dr.",
                    ShipCity = "Albuquerque",
                    ShipRegion = "NM",
                    ShipPostalCode = "87110",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 21.00m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[38], UnitPrice = 263.50m, Quantity = 40, Discount = 0F}),

                new Order
                {
                    CustomerId = "DUMON",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Feb 16 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 16 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 18 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 32.76m,
                    ShipName = "Du monde entier",
                    ShipAddress = "67, rue des Cinquante Otages",
                    ShipCity = "Nantes",
                    ShipRegion = "",
                    ShipPostalCode = "44000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[17], UnitPrice = 39.00m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[34], UnitPrice = 14.00m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 14, Discount = 0F}),

                new Order
                {
                    CustomerId = "LEHMS",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Feb 17 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 17 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 19 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 20.37m,
                    ShipName = "Lehmanns Marktstand",
                    ShipAddress = "Magazinweg 7",
                    ShipCity = "Frankfurt a.M.",
                    ShipRegion = "",
                    ShipPostalCode = "60528",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[30], UnitPrice = 25.89m, Quantity = 15, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "MAISD",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Feb 17 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 17 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 19 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 120.27m,
                    ShipName = "Maison Dewey",
                    ShipAddress = "Rue Joseph-Bens 532",
                    ShipCity = "Bruxelles",
                    ShipRegion = "",
                    ShipPostalCode = "B-1180",
                    ShipCountry = "Belgium",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 40, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "KOENE",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Feb 18 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 18 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 20 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 77.78m,
                    ShipName = "Königlich Essen",
                    ShipAddress = "Maubelstr. 90",
                    ShipCity = "Brandenburg",
                    ShipRegion = "",
                    ShipPostalCode = "14776",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[8], UnitPrice = 40.00m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[29], UnitPrice = 123.79m, Quantity = 24, Discount = 0F},
                    new OrderDetail {Product = products[30], UnitPrice = 25.89m, Quantity = 35, Discount = 0F},
                    new OrderDetail {Product = products[36], UnitPrice = 19.00m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "SAVEA",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Feb 18 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 18 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 20 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 116.13m,
                    ShipName = "Save-a-lot Markets",
                    ShipAddress = "187 Suffolk Ln.",
                    ShipCity = "Boise",
                    ShipRegion = "ID",
                    ShipPostalCode = "83720",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[13], UnitPrice = 6.00m, Quantity = 28, Discount = 0.05F},
                    new OrderDetail {Product = products[69], UnitPrice = 36.00m, Quantity = 50, Discount = 0.05F},
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 120, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "ERNSH",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Feb 18 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 18 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 23 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 162.75m,
                    ShipName = "Ernst Handel",
                    ShipAddress = "Kirchgasse 6",
                    ShipCity = "Graz",
                    ShipRegion = "",
                    ShipPostalCode = "8010",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 110, Discount = 0F},
                    new OrderDetail {Product = products[39], UnitPrice = 18.00m, Quantity = 45, Discount = 0F},
                    new OrderDetail {Product = products[40], UnitPrice = 18.40m, Quantity = 91, Discount = 0F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 100, Discount = 0F}),

                new Order
                {
                    CustomerId = "MAISD",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Feb 19 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 19 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 27 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 32.45m,
                    ShipName = "Maison Dewey",
                    ShipAddress = "Rue Joseph-Bens 532",
                    ShipCity = "Bruxelles",
                    ShipRegion = "",
                    ShipPostalCode = "B-1180",
                    ShipCountry = "Belgium",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[45], UnitPrice = 9.50m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 16, Discount = 0F}),

                new Order
                {
                    CustomerId = "HUNGO",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Feb 19 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 19 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 25 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 603.54m,
                    ShipName = "Hungry Owl All-Night Grocers",
                    ShipAddress = "8 Johnstown Road",
                    ShipCity = "Cork",
                    ShipRegion = "Co. Cork",
                    ShipPostalCode = "",
                    ShipCountry = "Ireland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[29], UnitPrice = 123.79m, Quantity = 80, Discount = 0F},
                    new OrderDetail {Product = products[30], UnitPrice = 25.89m, Quantity = 36, Discount = 0F}),

                new Order
                {
                    CustomerId = "OCEAN",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Feb 20 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 20 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar  6 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 1.27m,
                    ShipName = "Océano Atlántico Ltda.",
                    ShipAddress = "Ing. Gustavo Moncada 8585 Piso 20-A",
                    ShipCity = "Buenos Aires",
                    ShipRegion = "",
                    ShipPostalCode = "1010",
                    ShipCountry = "Argentina",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[13], UnitPrice = 6.00m, Quantity = 5, Discount = 0F}),

                new Order
                {
                    CustomerId = "LILAS",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Feb 20 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 20 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 26 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 1.21m,
                    ShipName = "LILA-Supermercado",
                    ShipAddress = "Carrera 52 con Ave. Bolívar #65-98 Llano Largo",
                    ShipCity = "Barquisimeto",
                    ShipRegion = "Lara",
                    ShipPostalCode = "3508",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[39], UnitPrice = 18.00m, Quantity = 8, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "WELLI",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Feb 20 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 20 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar  4 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 1.66m,
                    ShipName = "Wellington Importadora",
                    ShipAddress = "Rua do Mercado, 12",
                    ShipCity = "Resende",
                    ShipRegion = "SP",
                    ShipPostalCode = "08737-363",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[70], UnitPrice = 15.00m, Quantity = 3, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "HILAA",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Feb 23 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 23 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 26 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 62.09m,
                    ShipName = "HILARION-Abastos",
                    ShipAddress = "Carrera 22 con Ave. Carlos Soublette #8-35",
                    ShipCity = "San Cristóbal",
                    ShipRegion = "Táchira",
                    ShipPostalCode = "5022",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[71], UnitPrice = 21.50m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "FOLKO",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Feb 23 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 23 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar  3 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 44.15m,
                    ShipName = "Folk och fä HB",
                    ShipAddress = "Åkergatan 24",
                    ShipCity = "Bräcke",
                    ShipRegion = "",
                    ShipPostalCode = "S-844 67",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[55], UnitPrice = 24.00m, Quantity = 30, Discount = 0.15F},
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 6, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "HANAR",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Feb 24 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 24 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar  4 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 36.71m,
                    ShipName = "Hanari Carnes",
                    ShipAddress = "Rua do Paço, 67",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "05454-876",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[13], UnitPrice = 6.00m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[65], UnitPrice = 21.05m, Quantity = 21, Discount = 0F},
                    new OrderDetail {Product = products[68], UnitPrice = 12.50m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "WHITC",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Feb 24 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 24 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 27 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 162.95m,
                    ShipName = "White Clover Markets",
                    ShipAddress = "1029 - 12th Ave. S.",
                    ShipCity = "Seattle",
                    ShipRegion = "WA",
                    ShipPostalCode = "98124",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[58], UnitPrice = 13.25m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 35, Discount = 0F}),

                new Order
                {
                    CustomerId = "WELLI",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Feb 24 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 24 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar  6 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 13.72m,
                    ShipName = "Wellington Importadora",
                    ShipAddress = "Rua do Mercado, 12",
                    ShipCity = "Resende",
                    ShipRegion = "SP",
                    ShipPostalCode = "08737-363",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 18.00m, Quantity = 20, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "WOLZA",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Feb 25 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 11 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar  3 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 26.29m,
                    ShipName = "Wolski Zajazd",
                    ShipAddress = "ul. Filtrowa 68",
                    ShipCity = "Warszawa",
                    ShipRegion = "",
                    ShipPostalCode = "01-012",
                    ShipCountry = "Poland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[61], UnitPrice = 28.50m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "SPECD",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Feb 25 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 25 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Feb 27 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 9.19m,
                    ShipName = "Spécialités du monde",
                    ShipAddress = "25, rue Lauriston",
                    ShipCity = "Paris",
                    ShipRegion = "",
                    ShipPostalCode = "75016",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 14, Discount = 0F}),

                new Order
                {
                    CustomerId = "REGGC",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Feb 26 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 26 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar  6 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 32.96m,
                    ShipName = "Reggiani Caseifici",
                    ShipAddress = "Strada Provinciale 124",
                    ShipCity = "Reggio Emilia",
                    ShipRegion = "",
                    ShipPostalCode = "42100",
                    ShipCountry = "Italy",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[7], UnitPrice = 30.00m, Quantity = 20, Discount = 0.05F},
                    new OrderDetail {Product = products[52], UnitPrice = 7.00m, Quantity = 14, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "SANTG",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Feb 26 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 26 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 10 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 53.05m,
                    ShipName = "Santé Gourmet",
                    ShipAddress = "Erling Skakkes gate 78",
                    ShipCity = "Stavern",
                    ShipRegion = "",
                    ShipPostalCode = "4110",
                    ShipCountry = "Norway",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[7], UnitPrice = 30.00m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[16], UnitPrice = 17.45m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 5, Discount = 0F}),

                new Order
                {
                    CustomerId = "WILMK",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Feb 26 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 26 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar  4 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 38.11m,
                    ShipName = "Wilman Kala",
                    ShipAddress = "Keskuskatu 45",
                    ShipCity = "Helsinki",
                    ShipRegion = "",
                    ShipPostalCode = "21240",
                    ShipCountry = "Finland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[19], UnitPrice = 9.20m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[49], UnitPrice = 20.00m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[61], UnitPrice = 28.50m, Quantity = 5, Discount = 0F}),

                new Order
                {
                    CustomerId = "GODOS",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Feb 26 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 26 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar  5 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 38.19m,
                    ShipName = "Godos Cocina Típica",
                    ShipAddress = "C/ Romero, 33",
                    ShipCity = "Sevilla",
                    ShipRegion = "",
                    ShipPostalCode = "41101",
                    ShipCountry = "Spain",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 18.00m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[17], UnitPrice = 39.00m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[67], UnitPrice = 14.00m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "HUNGO",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Feb 26 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 26 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 18 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 580.91m,
                    ShipName = "Hungry Owl All-Night Grocers",
                    ShipAddress = "8 Johnstown Road",
                    ShipCity = "Cork",
                    ShipRegion = "Co. Cork",
                    ShipPostalCode = "",
                    ShipCountry = "Ireland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 21.00m, Quantity = 40, Discount = 0.25F},
                    new OrderDetail {Product = products[29], UnitPrice = 123.79m, Quantity = 60, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "QUEEN",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Feb 26 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 26 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar  4 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 33.05m,
                    ShipName = "Queen Cozinha",
                    ShipAddress = "Alameda dos Canàrios, 891",
                    ShipCity = "Sao Paulo",
                    ShipRegion = "SP",
                    ShipPostalCode = "05487-020",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[4], UnitPrice = 22.00m, Quantity = 30, Discount = 0.25F},
                    new OrderDetail {Product = products[33], UnitPrice = 2.50m, Quantity = 40, Discount = 0.25F},
                    new OrderDetail {Product = products[58], UnitPrice = 13.25m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "QUEEN",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Feb 27 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 27 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar  2 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 21.19m,
                    ShipName = "Queen Cozinha",
                    ShipAddress = "Alameda dos Canàrios, 891",
                    ShipCity = "Sao Paulo",
                    ShipRegion = "SP",
                    ShipPostalCode = "05487-020",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[71], UnitPrice = 21.50m, Quantity = 25, Discount = 0F}),

                new Order
                {
                    CustomerId = "TORTU",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Feb 27 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 27 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar  2 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 3.51m,
                    ShipName = "Tortuga Restaurante",
                    ShipAddress = "Avda. Azteca 123",
                    ShipCity = "México D.F.",
                    ShipRegion = "",
                    ShipPostalCode = "05033",
                    ShipCountry = "Mexico",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[17], UnitPrice = 39.00m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[33], UnitPrice = 2.50m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[54], UnitPrice = 7.45m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "RANCH",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Feb 27 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 27 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar  9 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 63.77m,
                    ShipName = "Rancho grande",
                    ShipAddress = "Av. del Libertador 900",
                    ShipCity = "Buenos Aires",
                    ShipRegion = "",
                    ShipPostalCode = "1010",
                    ShipCountry = "Argentina",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[16], UnitPrice = 17.45m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[32], UnitPrice = 32.00m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[57], UnitPrice = 19.50m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "ROMEY",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Mar  2 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 30 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 11 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 8.29m,
                    ShipName = "Romero y tomillo",
                    ShipAddress = "Gran Vía, 1",
                    ShipCity = "Madrid",
                    ShipRegion = "",
                    ShipPostalCode = "28001",
                    ShipCountry = "Spain",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[30], UnitPrice = 25.89m, Quantity = 1, Discount = 0F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "BOTTM",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Mar  2 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 30 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 11 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 48.83m,
                    ShipName = "Bottom-Dollar Markets",
                    ShipAddress = "23 Tsawassen Blvd.",
                    ShipCity = "Tsawassen",
                    ShipRegion = "BC",
                    ShipPostalCode = "T2F 8M4",
                    ShipCountry = "Canada",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 18.00m, Quantity = 60, Discount = 0.25F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 25, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "LINOD",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Mar  2 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 30 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar  4 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 19.80m,
                    ShipName = "LINO-Delicateses",
                    ShipAddress = "Ave. 5 de Mayo Porlamar",
                    ShipCity = "I. de Margarita",
                    ShipRegion = "Nueva Esparta",
                    ShipPostalCode = "4980",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[16], UnitPrice = 17.45m, Quantity = 24, Discount = 0F},
                    new OrderDetail {Product = products[25], UnitPrice = 14.00m, Quantity = 24, Discount = 0F},
                    new OrderDetail {Product = products[40], UnitPrice = 18.40m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "AROUT",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Mar  3 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 31 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar  9 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 29.61m,
                    ShipName = "Around the Horn",
                    ShipAddress = "Brook Farm Stratford St. Mary",
                    ShipCity = "Colchester",
                    ShipRegion = "Essex",
                    ShipPostalCode = "CO7 6JX",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[50], UnitPrice = 16.25m, Quantity = 24, Discount = 0F}),

                new Order
                {
                    CustomerId = "VAFFE",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Mar  3 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 14 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar  9 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 176.48m,
                    ShipName = "Vaffeljernet",
                    ShipAddress = "Smagsloget 45",
                    ShipCity = "Århus",
                    ShipRegion = "",
                    ShipPostalCode = "8200",
                    ShipCountry = "Denmark",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[35], UnitPrice = 18.00m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[63], UnitPrice = 43.90m, Quantity = 40, Discount = 0F}),

                new Order
                {
                    CustomerId = "HANAR",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Mar  3 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 31 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar  5 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 62.74m,
                    ShipName = "Hanari Carnes",
                    ShipAddress = "Rua do Paço, 67",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "05454-876",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[17], UnitPrice = 39.00m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 35, Discount = 0F}),

                new Order
                {
                    CustomerId = "LAMAI",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Mar  3 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 14 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 13 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 68.26m,
                    ShipName = "La maison d'Asie",
                    ShipAddress = "1 rue Alsace-Lorraine",
                    ShipCity = "Toulouse",
                    ShipRegion = "",
                    ShipPostalCode = "31000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[42], UnitPrice = 14.00m, Quantity = 10, Discount = 0.2F},
                    new OrderDetail {Product = products[43], UnitPrice = 46.00m, Quantity = 10, Discount = 0.2F},
                    new OrderDetail {Product = products[67], UnitPrice = 14.00m, Quantity = 24, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "BERGS",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Mar  4 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  1 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  8 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 151.52m,
                    ShipName = "Berglunds snabbköp",
                    ShipAddress = "Berguvsvägen  8",
                    ShipCity = "Luleå",
                    ShipRegion = "",
                    ShipPostalCode = "S-958 22",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[10], UnitPrice = 31.00m, Quantity = 20, Discount = 0.1F},
                    new OrderDetail {Product = products[28], UnitPrice = 45.60m, Quantity = 30, Discount = 0.1F},
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 6, Discount = 0F}),

                new Order
                {
                    CustomerId = "HANAR",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Mar  4 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  1 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 13 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 2.27m,
                    ShipName = "Hanari Carnes",
                    ShipAddress = "Rua do Paço, 67",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "05454-876",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[36], UnitPrice = 19.00m, Quantity = 25, Discount = 0.15F},
                    new OrderDetail {Product = products[52], UnitPrice = 7.00m, Quantity = 12, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "ANATR",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Mar  4 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  1 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 11 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 39.92m,
                    ShipName = "Ana Trujillo Emparedados y helados",
                    ShipAddress = "Avda. de la Constitución 2222",
                    ShipCity = "México D.F.",
                    ShipRegion = "",
                    ShipPostalCode = "05021",
                    ShipCountry = "Mexico",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 21.00m, Quantity = 2, Discount = 0F},
                    new OrderDetail {Product = products[13], UnitPrice = 6.00m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[19], UnitPrice = 9.20m, Quantity = 7, Discount = 0F},
                    new OrderDetail {Product = products[72], UnitPrice = 34.80m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "LACOR",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Mar  5 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  2 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  8 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 19.79m,
                    ShipName = "La corne d'abondance",
                    ShipAddress = "67, avenue de l'Europe",
                    ShipCity = "Versailles",
                    ShipRegion = "",
                    ShipPostalCode = "78000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[20], UnitPrice = 81.00m, Quantity = 5, Discount = 0F},
                    new OrderDetail {Product = products[52], UnitPrice = 7.00m, Quantity = 5, Discount = 0F},
                    new OrderDetail {Product = products[76], UnitPrice = 18.00m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "GALED",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Mar  5 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  2 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 18 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 1.36m,
                    ShipName = "Galería del gastronómo",
                    ShipAddress = "Rambla de Cataluña, 23",
                    ShipCity = "Barcelona",
                    ShipRegion = "",
                    ShipPostalCode = "8022",
                    ShipCountry = "Spain",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[47], UnitPrice = 9.50m, Quantity = 5, Discount = 0F},
                    new OrderDetail {Product = products[76], UnitPrice = 18.00m, Quantity = 5, Discount = 0F}),

                new Order
                {
                    CustomerId = "FRANK",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Mar  5 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  2 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 12 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 33.93m,
                    ShipName = "Frankenversand",
                    ShipAddress = "Berliner Platz 43",
                    ShipCity = "München",
                    ShipRegion = "",
                    ShipPostalCode = "80805",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[21], UnitPrice = 10.00m, Quantity = 60, Discount = 0F},
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 49, Discount = 0F},
                    new OrderDetail {Product = products[77], UnitPrice = 13.00m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "SUPRD",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Mar  6 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 17 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 18 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 15.55m,
                    ShipName = "Suprêmes délices",
                    ShipAddress = "Boulevard Tirou, 255",
                    ShipCity = "Charleroi",
                    ShipRegion = "",
                    ShipPostalCode = "B-6000",
                    ShipCountry = "Belgium",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[21], UnitPrice = 10.00m, Quantity = 36, Discount = 0F},
                    new OrderDetail {Product = products[27], UnitPrice = 43.90m, Quantity = 25, Discount = 0F},
                    new OrderDetail {Product = products[55], UnitPrice = 24.00m, Quantity = 25, Discount = 0.2F},
                    new OrderDetail {Product = products[58], UnitPrice = 13.25m, Quantity = 30, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "RICSU",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Mar  6 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 20 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 19 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 13.60m,
                    ShipName = "Richter Supermarkt",
                    ShipAddress = "Starenweg 5",
                    ShipCity = "Genève",
                    ShipRegion = "",
                    ShipPostalCode = "1204",
                    ShipCountry = "Switzerland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[13], UnitPrice = 6.00m, Quantity = 42, Discount = 0.15F},
                    new OrderDetail {Product = products[57], UnitPrice = 19.50m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "BONAP",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Mar  6 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  3 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 24 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 134.64m,
                    ShipName = "Bon app'",
                    ShipAddress = "12, rue des Bouchers",
                    ShipCity = "Marseille",
                    ShipRegion = "",
                    ShipPostalCode = "13008",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[16], UnitPrice = 17.45m, Quantity = 30, Discount = 0.1F},
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 14, Discount = 0.1F},
                    new OrderDetail {Product = products[72], UnitPrice = 34.80m, Quantity = 16, Discount = 0F},
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 20, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "ISLAT",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Mar  6 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  3 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 16 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 54.15m,
                    ShipName = "Island Trading",
                    ShipAddress = "Garden House Crowther Way",
                    ShipCity = "Cowes",
                    ShipRegion = "Isle of Wight",
                    ShipPostalCode = "PO31 7PJ",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[53], UnitPrice = 32.80m, Quantity = 2, Discount = 0F},
                    new OrderDetail {Product = products[61], UnitPrice = 28.50m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "LEHMS",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Mar  9 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  6 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 12 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 32.01m,
                    ShipName = "Lehmanns Marktstand",
                    ShipAddress = "Magazinweg 7",
                    ShipCity = "Frankfurt a.M.",
                    ShipRegion = "",
                    ShipPostalCode = "60528",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[6], UnitPrice = 25.00m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "WELLI",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Mar  9 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  6 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 18 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 47.59m,
                    ShipName = "Wellington Importadora",
                    ShipAddress = "Rua do Mercado, 12",
                    ShipCity = "Resende",
                    ShipRegion = "SP",
                    ShipPostalCode = "08737-363",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 18.00m, Quantity = 21, Discount = 0F},
                    new OrderDetail {Product = products[18], UnitPrice = 62.50m, Quantity = 4, Discount = 0.25F},
                    new OrderDetail {Product = products[23], UnitPrice = 9.00m, Quantity = 8, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "GREAL",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Mar  9 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  6 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 18 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 33.68m,
                    ShipName = "Great Lakes Food Market",
                    ShipAddress = "2732 Baker Blvd.",
                    ShipCity = "Eugene",
                    ShipRegion = "OR",
                    ShipPostalCode = "97403",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[36], UnitPrice = 19.00m, Quantity = 30, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "CACTU",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Mar 10 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 24 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 13 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 31.51m,
                    ShipName = "Cactus Comidas para llevar",
                    ShipAddress = "Cerrito 333",
                    ShipCity = "Buenos Aires",
                    ShipRegion = "",
                    ShipPostalCode = "1010",
                    ShipCountry = "Argentina",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[28], UnitPrice = 45.60m, Quantity = 8, Discount = 0F},
                    new OrderDetail {Product = products[34], UnitPrice = 14.00m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "QUICK",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Mar 10 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  7 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 16 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 31.89m,
                    ShipName = "QUICK-Stop",
                    ShipAddress = "Taucherstraße 10",
                    ShipCity = "Cunewalde",
                    ShipRegion = "",
                    ShipPostalCode = "01307",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[13], UnitPrice = 6.00m, Quantity = 20, Discount = 0.25F},
                    new OrderDetail {Product = products[43], UnitPrice = 46.00m, Quantity = 24, Discount = 0.25F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 49, Discount = 0.25F},
                    new OrderDetail {Product = products[71], UnitPrice = 21.50m, Quantity = 35, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "MAGAA",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Mar 10 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  7 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 13 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 76.33m,
                    ShipName = "Magazzini Alimentari Riuniti",
                    ShipAddress = "Via Ludovico il Moro 22",
                    ShipCity = "Bergamo",
                    ShipRegion = "",
                    ShipPostalCode = "24100",
                    ShipCountry = "Italy",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 19.00m, Quantity = 10, Discount = 0.15F},
                    new OrderDetail {Product = products[67], UnitPrice = 14.00m, Quantity = 40, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "BONAP",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Mar 11 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  8 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 23 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 19.77m,
                    ShipName = "Bon app'",
                    ShipAddress = "12, rue des Bouchers",
                    ShipCity = "Marseille",
                    ShipRegion = "",
                    ShipPostalCode = "13008",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[7], UnitPrice = 30.00m, Quantity = 8, Discount = 0F},
                    new OrderDetail {Product = products[13], UnitPrice = 6.00m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "SAVEA",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Mar 11 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  8 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 20 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 400.81m,
                    ShipName = "Save-a-lot Markets",
                    ShipAddress = "187 Suffolk Ln.",
                    ShipCity = "Boise",
                    ShipRegion = "ID",
                    ShipPostalCode = "83720",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 44, Discount = 0.25F},
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 30, Discount = 0.25F},
                    new OrderDetail {Product = products[68], UnitPrice = 12.50m, Quantity = 80, Discount = 0.25F},
                    new OrderDetail {Product = products[72], UnitPrice = 34.80m, Quantity = 50, Discount = 0F}),

                new Order
                {
                    CustomerId = "REGGC",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Mar 11 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  8 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 18 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 17.95m,
                    ShipName = "Reggiani Caseifici",
                    ShipAddress = "Strada Provinciale 124",
                    ShipCity = "Reggio Emilia",
                    ShipRegion = "",
                    ShipPostalCode = "42100",
                    ShipCountry = "Italy",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[49], UnitPrice = 20.00m, Quantity = 28, Discount = 0F}),

                new Order
                {
                    CustomerId = "BSBEV",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Mar 11 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  8 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 19 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 2.17m,
                    ShipName = "B's Beverages",
                    ShipAddress = "Fauntleroy Circus",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "EC2 5NT",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[13], UnitPrice = 6.00m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[22], UnitPrice = 21.00m, Quantity = 21, Discount = 0F},
                    new OrderDetail {Product = products[46], UnitPrice = 12.00m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "BOTTM",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Mar 12 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 26 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 13 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 52.92m,
                    ShipName = "Bottom-Dollar Markets",
                    ShipAddress = "23 Tsawassen Blvd.",
                    ShipCity = "Tsawassen",
                    ShipRegion = "BC",
                    ShipPostalCode = "T2F 8M4",
                    ShipCountry = "Canada",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 21.00m, Quantity = 5, Discount = 0.25F},
                    new OrderDetail {Product = products[44], UnitPrice = 19.45m, Quantity = 18, Discount = 0.25F},
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 18, Discount = 0F}),

                new Order
                {
                    CustomerId = "MORGK",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Mar 12 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  9 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 18 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 10.22m,
                    ShipName = "Morgenstern Gesundkost",
                    ShipAddress = "Heerstr. 22",
                    ShipCity = "Leipzig",
                    ShipRegion = "",
                    ShipPostalCode = "04179",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[13], UnitPrice = 6.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "VAFFE",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Mar 12 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  9 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 19 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 27.20m,
                    ShipName = "Vaffeljernet",
                    ShipAddress = "Smagsloget 45",
                    ShipCity = "Århus",
                    ShipRegion = "",
                    ShipPostalCode = "8200",
                    ShipCountry = "Denmark",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[10], UnitPrice = 31.00m, Quantity = 25, Discount = 0F},
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 25, Discount = 0F},
                    new OrderDetail {Product = products[77], UnitPrice = 13.00m, Quantity = 40, Discount = 0F}),

                new Order
                {
                    CustomerId = "BSBEV",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Mar 13 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 10 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 16 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 3.26m,
                    ShipName = "B's Beverages",
                    ShipAddress = "Fauntleroy Circus",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "EC2 5NT",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 4, Discount = 0F}),

                new Order
                {
                    CustomerId = "GODOS",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Mar 13 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 10 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 19 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 23.39m,
                    ShipName = "Godos Cocina Típica",
                    ShipAddress = "C/ Romero, 33",
                    ShipCity = "Sevilla",
                    ShipRegion = "",
                    ShipPostalCode = "41101",
                    ShipCountry = "Spain",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[50], UnitPrice = 16.25m, Quantity = 9, Discount = 0F},
                    new OrderDetail {Product = products[51], UnitPrice = 53.00m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[55], UnitPrice = 24.00m, Quantity = 4, Discount = 0F}),

                new Order
                {
                    CustomerId = "BOTTM",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Mar 13 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 10 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 17 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 74.44m,
                    ShipName = "Bottom-Dollar Markets",
                    ShipAddress = "23 Tsawassen Blvd.",
                    ShipCity = "Tsawassen",
                    ShipRegion = "BC",
                    ShipPostalCode = "T2F 8M4",
                    ShipCountry = "Canada",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[6], UnitPrice = 25.00m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[10], UnitPrice = 31.00m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[17], UnitPrice = 39.00m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 60, Discount = 0F}),

                new Order
                {
                    CustomerId = "MAGAA",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Mar 16 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 13 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 23 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 2.50m,
                    ShipName = "Magazzini Alimentari Riuniti",
                    ShipAddress = "Via Ludovico il Moro 22",
                    ShipCity = "Bergamo",
                    ShipRegion = "",
                    ShipPostalCode = "24100",
                    ShipCountry = "Italy",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[4], UnitPrice = 22.00m, Quantity = 5, Discount = 0F}),

                new Order
                {
                    CustomerId = "RICSU",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Mar 16 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 27 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  7 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 30.85m,
                    ShipName = "Richter Supermarkt",
                    ShipAddress = "Starenweg 5",
                    ShipCity = "Genève",
                    ShipRegion = "",
                    ShipPostalCode = "1204",
                    ShipCountry = "Switzerland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[33], UnitPrice = 2.50m, Quantity = 15, Discount = 0.05F},
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 6, Discount = 0.05F},
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 50, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "ALFKI",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Mar 16 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 27 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 24 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 40.42m,
                    ShipName = "Alfred's Futterkiste",
                    ShipAddress = "Obere Str. 57",
                    ShipCity = "Berlin",
                    ShipRegion = "",
                    ShipPostalCode = "12209",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[6], UnitPrice = 25.00m, Quantity = 16, Discount = 0.05F},
                    new OrderDetail {Product = products[28], UnitPrice = 45.60m, Quantity = 2, Discount = 0F}),

                new Order
                {
                    CustomerId = "AROUT",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Mar 16 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Mar 30 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 25 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 23.72m,
                    ShipName = "Around the Horn",
                    ShipAddress = "Brook Farm Stratford St. Mary",
                    ShipCity = "Colchester",
                    ShipRegion = "Essex",
                    ShipPostalCode = "CO7 6JX",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[20], UnitPrice = 81.00m, Quantity = 50, Discount = 0.05F},
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 50, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "LINOD",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Mar 17 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 28 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 20 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 27.91m,
                    ShipName = "LINO-Delicateses",
                    ShipAddress = "Ave. 5 de Mayo Porlamar",
                    ShipCity = "I. de Margarita",
                    ShipRegion = "Nueva Esparta",
                    ShipPostalCode = "4980",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[16], UnitPrice = 17.45m, Quantity = 28, Discount = 0.15F},
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 25, Discount = 0.15F},
                    new OrderDetail {Product = products[45], UnitPrice = 9.50m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 24, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "FOLKO",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Mar 17 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 14 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 20 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 3.26m,
                    ShipName = "Folk och fä HB",
                    ShipAddress = "Åkergatan 24",
                    ShipCity = "Bräcke",
                    ShipRegion = "",
                    ShipPostalCode = "S-844 67",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 12, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "BLAUS",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Mar 17 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 28 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 20 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 44.65m,
                    ShipName = "Blauer See Delikatessen",
                    ShipAddress = "Forsterstr. 57",
                    ShipCity = "Mannheim",
                    ShipRegion = "",
                    ShipPostalCode = "68306",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[21], UnitPrice = 10.00m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[47], UnitPrice = 9.50m, Quantity = 14, Discount = 0F},
                    new OrderDetail {Product = products[51], UnitPrice = 53.00m, Quantity = 8, Discount = 0F}),

                new Order
                {
                    CustomerId = "HILAA",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Mar 18 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 15 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 27 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 105.36m,
                    ShipName = "HILARION-Abastos",
                    ShipAddress = "Carrera 22 con Ave. Carlos Soublette #8-35",
                    ShipCity = "San Cristóbal",
                    ShipRegion = "Táchira",
                    ShipPostalCode = "5022",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[30], UnitPrice = 25.89m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[35], UnitPrice = 18.00m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[64], UnitPrice = 33.25m, Quantity = 8, Discount = 0F}),

                new Order
                {
                    CustomerId = "OCEAN",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Mar 18 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 15 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 27 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 49.56m,
                    ShipName = "Océano Atlántico Ltda.",
                    ShipAddress = "Ing. Gustavo Moncada 8585 Piso 20-A",
                    ShipCity = "Buenos Aires",
                    ShipRegion = "",
                    ShipPostalCode = "1010",
                    ShipCountry = "Argentina",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[5], UnitPrice = 21.35m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[7], UnitPrice = 30.00m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[72], UnitPrice = 34.80m, Quantity = 5, Discount = 0F}),

                new Order
                {
                    CustomerId = "GOURL",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Mar 18 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 29 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 23 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 4.98m,
                    ShipName = "Gourmet Lanchonetes",
                    ShipAddress = "Av. Brasil, 442",
                    ShipCity = "Campinas",
                    ShipRegion = "SP",
                    ShipPostalCode = "04876-786",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 20, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "HILAA",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Mar 19 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  2 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  8 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 2.08m,
                    ShipName = "HILARION-Abastos",
                    ShipAddress = "Carrera 22 con Ave. Carlos Soublette #8-35",
                    ShipCity = "San Cristóbal",
                    ShipRegion = "Táchira",
                    ShipPostalCode = "5022",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 10, Discount = 0.25F},
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 24, Discount = 0F}),

                new Order
                {
                    CustomerId = "QUEEN",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Mar 19 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 16 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 30 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 104.47m,
                    ShipName = "Queen Cozinha",
                    ShipAddress = "Alameda dos Canàrios, 891",
                    ShipCity = "Sao Paulo",
                    ShipRegion = "SP",
                    ShipPostalCode = "05487-020",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[52], UnitPrice = 7.00m, Quantity = 6, Discount = 0.05F},
                    new OrderDetail {Product = products[76], UnitPrice = 18.00m, Quantity = 60, Discount = 0F}),

                new Order
                {
                    CustomerId = "QUICK",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Mar 19 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 16 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 23 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 275.79m,
                    ShipName = "QUICK-Stop",
                    ShipAddress = "Taucherstraße 10",
                    ShipCity = "Cunewalde",
                    ShipRegion = "",
                    ShipPostalCode = "01307",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[7], UnitPrice = 30.00m, Quantity = 45, Discount = 0F},
                    new OrderDetail {Product = products[13], UnitPrice = 6.00m, Quantity = 77, Discount = 0F},
                    new OrderDetail {Product = products[53], UnitPrice = 32.80m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[69], UnitPrice = 36.00m, Quantity = 9, Discount = 0F},
                    new OrderDetail {Product = products[76], UnitPrice = 18.00m, Quantity = 44, Discount = 0F}),

                new Order
                {
                    CustomerId = "FURIB",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Mar 19 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 16 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 26 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 2.70m,
                    ShipName = "Furia Bacalhau e Frutos do Mar",
                    ShipAddress = "Jardim das rosas n. 32",
                    ShipCity = "Lisboa",
                    ShipRegion = "",
                    ShipPostalCode = "1675",
                    ShipCountry = "Portugal",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 2, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "SPECD",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Mar 20 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 17 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 24 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 87.38m,
                    ShipName = "Spécialités du monde",
                    ShipAddress = "25, rue Lauriston",
                    ShipCity = "Paris",
                    ShipRegion = "",
                    ShipPostalCode = "75016",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[18], UnitPrice = 62.50m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[38], UnitPrice = 263.50m, Quantity = 5, Discount = 0F},
                    new OrderDetail {Product = products[69], UnitPrice = 36.00m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "OLDWO",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Mar 20 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 17 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 30 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 144.38m,
                    ShipName = "Old World Delicatessen",
                    ShipAddress = "2743 Bering St.",
                    ShipCity = "Anchorage",
                    ShipRegion = "AK",
                    ShipPostalCode = "99508",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[51], UnitPrice = 53.00m, Quantity = 16, Discount = 0F}),

                new Order
                {
                    CustomerId = "CHOPS",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Mar 20 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 17 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  8 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 27.19m,
                    ShipName = "Chop-suey Chinese",
                    ShipAddress = "Hauptstr. 31",
                    ShipCity = "Bern",
                    ShipRegion = "",
                    ShipPostalCode = "3012",
                    ShipCountry = "Switzerland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[37], UnitPrice = 26.00m, Quantity = 8, Discount = 0F},
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 12, Discount = 0.15F},
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 12, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "TOMSP",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Mar 23 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 20 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  2 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 62.22m,
                    ShipName = "Toms Spezialitäten",
                    ShipAddress = "Luisenstr. 48",
                    ShipCity = "Münster",
                    ShipRegion = "",
                    ShipPostalCode = "44087",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[19], UnitPrice = 9.20m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[49], UnitPrice = 20.00m, Quantity = 40, Discount = 0F}),

                new Order
                {
                    CustomerId = "ERNSH",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Mar 23 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 20 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  1 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 74.60m,
                    ShipName = "Ernst Handel",
                    ShipAddress = "Kirchgasse 6",
                    ShipCity = "Graz",
                    ShipRegion = "",
                    ShipPostalCode = "8010",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[12], UnitPrice = 38.00m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[64], UnitPrice = 33.25m, Quantity = 4, Discount = 0F}),

                new Order
                {
                    CustomerId = "COMMI",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Mar 23 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 20 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 30 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 0.21m,
                    ShipName = "Comércio Mineiro",
                    ShipAddress = "Av. dos Lusíadas, 23",
                    ShipCity = "Sao Paulo",
                    ShipRegion = "SP",
                    ShipPostalCode = "05432-043",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[46], UnitPrice = 12.00m, Quantity = 9, Discount = 0F}),

                new Order
                {
                    CustomerId = "BOLID",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Mar 24 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  7 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 24 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 16.16m,
                    ShipName = "Bólido Comidas preparadas",
                    ShipAddress = "C/ Araquil, 67",
                    ShipCity = "Madrid",
                    ShipRegion = "",
                    ShipPostalCode = "28023",
                    ShipCountry = "Spain",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[52], UnitPrice = 7.00m, Quantity = 40, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "FRANR",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Mar 24 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 21 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  2 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 121.82m,
                    ShipName = "France restauration",
                    ShipAddress = "54, rue Royale",
                    ShipCity = "Nantes",
                    ShipRegion = "",
                    ShipPostalCode = "44000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[29], UnitPrice = 123.79m, Quantity = 14, Discount = 0F}),

                new Order
                {
                    CustomerId = "LACOR",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Mar 24 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 21 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 26 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 0.02m,
                    ShipName = "La corne d'abondance",
                    ShipAddress = "67, avenue de l'Europe",
                    ShipCity = "Versailles",
                    ShipRegion = "",
                    ShipPostalCode = "78000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[17], UnitPrice = 39.00m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[33], UnitPrice = 2.50m, Quantity = 7, Discount = 0F}),

                new Order
                {
                    CustomerId = "LACOR",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Mar 24 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 21 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 27 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 15.17m,
                    ShipName = "La corne d'abondance",
                    ShipAddress = "67, avenue de l'Europe",
                    ShipCity = "Versailles",
                    ShipRegion = "",
                    ShipPostalCode = "78000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[26], UnitPrice = 31.23m, Quantity = 5, Discount = 0F},
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "SPLIR",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Mar 25 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr  8 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  3 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 12.96m,
                    ShipName = "Split Rail Beer & Ale",
                    ShipAddress = "P.O. Box 555",
                    ShipCity = "Lander",
                    ShipRegion = "WY",
                    ShipPostalCode = "82520",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[63], UnitPrice = 43.90m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "BOTTM",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Mar 25 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 22 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 27 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 32.27m,
                    ShipName = "Bottom-Dollar Markets",
                    ShipAddress = "23 Tsawassen Blvd.",
                    ShipCity = "Tsawassen",
                    ShipRegion = "BC",
                    ShipPostalCode = "T2F 8M4",
                    ShipCountry = "Canada",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[8], UnitPrice = 40.00m, Quantity = 16, Discount = 0F},
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "HILAA",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Mar 25 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May  6 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  3 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 37.97m,
                    ShipName = "HILARION-Abastos",
                    ShipAddress = "Carrera 22 con Ave. Carlos Soublette #8-35",
                    ShipCity = "San Cristóbal",
                    ShipRegion = "Táchira",
                    ShipPostalCode = "5022",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[28], UnitPrice = 45.60m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "FOLKO",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Mar 26 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 23 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 10 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 208.50m,
                    ShipName = "Folk och fä HB",
                    ShipAddress = "Åkergatan 24",
                    ShipCity = "Bräcke",
                    ShipRegion = "",
                    ShipPostalCode = "S-844 67",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[39], UnitPrice = 18.00m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[47], UnitPrice = 9.50m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[51], UnitPrice = 53.00m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[63], UnitPrice = 43.90m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "MAISD",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Mar 26 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 23 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 23 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 32.82m,
                    ShipName = "Maison Dewey",
                    ShipAddress = "Rue Joseph-Bens 532",
                    ShipCity = "Bruxelles",
                    ShipRegion = "",
                    ShipPostalCode = "B-1180",
                    ShipCountry = "Belgium",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[8], UnitPrice = 40.00m, Quantity = 20, Discount = 0.15F},
                    new OrderDetail {Product = products[21], UnitPrice = 10.00m, Quantity = 40, Discount = 0.15F},
                    new OrderDetail {Product = products[40], UnitPrice = 18.40m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[44], UnitPrice = 19.45m, Quantity = 6, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "ERNSH",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Mar 26 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 23 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Mar 31 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 353.07m,
                    ShipName = "Ernst Handel",
                    ShipAddress = "Kirchgasse 6",
                    ShipCity = "Graz",
                    ShipRegion = "",
                    ShipPostalCode = "8010",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[7], UnitPrice = 30.00m, Quantity = 18, Discount = 0F},
                    new OrderDetail {Product = products[12], UnitPrice = 38.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 80, Discount = 0F},
                    new OrderDetail {Product = products[27], UnitPrice = 43.90m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 24, Discount = 0F},
                    new OrderDetail {Product = products[63], UnitPrice = 43.90m, Quantity = 35, Discount = 0F}),

                new Order
                {
                    CustomerId = "FOLKO",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Mar 27 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May  8 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 17 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 1.26m,
                    ShipName = "Folk och fä HB",
                    ShipAddress = "Åkergatan 24",
                    ShipCity = "Bräcke",
                    ShipRegion = "",
                    ShipPostalCode = "S-844 67",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 40, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "HANAR",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Mar 27 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 24 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  2 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 193.37m,
                    ShipName = "Hanari Carnes",
                    ShipAddress = "Rua do Paço, 67",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "05454-876",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[38], UnitPrice = 263.50m, Quantity = 60, Discount = 0F}),

                new Order
                {
                    CustomerId = "BOTTM",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Mar 27 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 24 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  8 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 14.01m,
                    ShipName = "Bottom-Dollar Markets",
                    ShipAddress = "23 Tsawassen Blvd.",
                    ShipCity = "Tsawassen",
                    ShipRegion = "BC",
                    ShipPostalCode = "T2F 8M4",
                    ShipCountry = "Canada",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[7], UnitPrice = 30.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[43], UnitPrice = 46.00m, Quantity = 9, Discount = 0F}),

                new Order
                {
                    CustomerId = "SAVEA",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Mar 27 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 24 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  6 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 657.54m,
                    ShipName = "Save-a-lot Markets",
                    ShipAddress = "187 Suffolk Ln.",
                    ShipCity = "Boise",
                    ShipRegion = "ID",
                    ShipPostalCode = "83720",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[13], UnitPrice = 6.00m, Quantity = 84, Discount = 0.15F},
                    new OrderDetail {Product = products[57], UnitPrice = 19.50m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "SAVEA",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Mar 30 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 27 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  3 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 211.22m,
                    ShipName = "Save-a-lot Markets",
                    ShipAddress = "187 Suffolk Ln.",
                    ShipCity = "Boise",
                    ShipRegion = "ID",
                    ShipPostalCode = "83720",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[16], UnitPrice = 17.45m, Quantity = 55, Discount = 0F},
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[36], UnitPrice = 19.00m, Quantity = 40, Discount = 0F}),

                new Order
                {
                    CustomerId = "HUNGO",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Mar 30 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 27 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  2 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 91.51m,
                    ShipName = "Hungry Owl All-Night Grocers",
                    ShipAddress = "8 Johnstown Road",
                    ShipCity = "Cork",
                    ShipRegion = "Co. Cork",
                    ShipPostalCode = "",
                    ShipCountry = "Ireland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[16], UnitPrice = 17.45m, Quantity = 36, Discount = 0.1F},
                    new OrderDetail {Product = products[18], UnitPrice = 62.50m, Quantity = 8, Discount = 0.1F},
                    new OrderDetail {Product = products[32], UnitPrice = 32.00m, Quantity = 35, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "OCEAN",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Mar 30 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 27 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 21 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 217.86m,
                    ShipName = "Océano Atlántico Ltda.",
                    ShipAddress = "Ing. Gustavo Moncada 8585 Piso 20-A",
                    ShipCity = "Buenos Aires",
                    ShipRegion = "",
                    ShipPostalCode = "1010",
                    ShipCountry = "Argentina",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 21.00m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[20], UnitPrice = 81.00m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[76], UnitPrice = 18.00m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[77], UnitPrice = 13.00m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "EASTC",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Mar 31 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 28 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  6 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 185.48m,
                    ShipName = "Eastern Connection",
                    ShipAddress = "35 King George",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "WX3 6FW",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[7], UnitPrice = 30.00m, Quantity = 60, Discount = 0F},
                    new OrderDetail {Product = products[43], UnitPrice = 46.00m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[72], UnitPrice = 34.80m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "RATTC",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Mar 31 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 28 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 10 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 61.14m,
                    ShipName = "Rattlesnake Canyon Grocery",
                    ShipAddress = "2817 Milton Dr.",
                    ShipCity = "Albuquerque",
                    ShipRegion = "NM",
                    ShipPostalCode = "87110",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[7], UnitPrice = 30.00m, Quantity = 60, Discount = 0F},
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 40, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "QUEDE",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Mar 31 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 28 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  2 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 34.76m,
                    ShipName = "Que Delícia",
                    ShipAddress = "Rua da Panificadora, 12",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "02389-673",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[6], UnitPrice = 25.00m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[11], UnitPrice = 21.00m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 4, Discount = 0F}),

                new Order
                {
                    CustomerId = "ERNSH",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Apr  1 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 13 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  7 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 117.61m,
                    ShipName = "Ernst Handel",
                    ShipAddress = "Kirchgasse 6",
                    ShipCity = "Graz",
                    ShipRegion = "",
                    ShipPostalCode = "8010",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[21], UnitPrice = 10.00m, Quantity = 65, Discount = 0F},
                    new OrderDetail {Product = products[34], UnitPrice = 14.00m, Quantity = 60, Discount = 0.15F},
                    new OrderDetail {Product = products[55], UnitPrice = 24.00m, Quantity = 65, Discount = 0.15F},
                    new OrderDetail {Product = products[61], UnitPrice = 28.50m, Quantity = 66, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "QUICK",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Apr  1 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 29 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  7 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 38.51m,
                    ShipName = "QUICK-Stop",
                    ShipAddress = "Taucherstraße 10",
                    ShipCity = "Cunewalde",
                    ShipRegion = "",
                    ShipPostalCode = "01307",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 19.00m, Quantity = 50, Discount = 0.2F},
                    new OrderDetail {Product = products[70], UnitPrice = 15.00m, Quantity = 20, Discount = 0.2F},
                    new OrderDetail {Product = products[76], UnitPrice = 18.00m, Quantity = 90, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "THEBI",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Apr  1 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 29 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  3 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 4.27m,
                    ShipName = "The Big Cheese",
                    ShipAddress = "89 Jefferson Way Suite 2",
                    ShipCity = "Portland",
                    ShipRegion = "OR",
                    ShipPostalCode = "97201",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[72], UnitPrice = 34.80m, Quantity = 2, Discount = 0F}),

                new Order
                {
                    CustomerId = "FOLKO",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Apr  1 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 29 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 10 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 8.81m,
                    ShipName = "Folk och fä HB",
                    ShipAddress = "Åkergatan 24",
                    ShipCity = "Bräcke",
                    ShipRegion = "",
                    ShipPostalCode = "S-844 67",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[29], UnitPrice = 123.79m, Quantity = 50, Discount = 0.25F},
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 35, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "VAFFE",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Apr  2 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 16 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  9 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 65.53m,
                    ShipName = "Vaffeljernet",
                    ShipAddress = "Smagsloget 45",
                    ShipCity = "Århus",
                    ShipRegion = "",
                    ShipPostalCode = "8200",
                    ShipCountry = "Denmark",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 18, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "PERIC",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Apr  2 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 30 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  6 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 46.00m,
                    ShipName = "Pericles Comidas clásicas",
                    ShipAddress = "Calle Dr. Jorge Cash 321",
                    ShipCity = "México D.F.",
                    ShipRegion = "",
                    ShipPostalCode = "05033",
                    ShipCountry = "Mexico",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[51], UnitPrice = 53.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 4, Discount = 0F}),

                new Order
                {
                    CustomerId = "QUICK",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Apr  2 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 30 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 10 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 1.12m,
                    ShipName = "QUICK-Stop",
                    ShipAddress = "Taucherstraße 10",
                    ShipCity = "Cunewalde",
                    ShipRegion = "",
                    ShipPostalCode = "01307",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[42], UnitPrice = 14.00m, Quantity = 40, Discount = 0F}),

                new Order
                {
                    CustomerId = "LILAS",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Apr  3 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 15 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 13 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 73.91m,
                    ShipName = "LILA-Supermercado",
                    ShipAddress = "Carrera 52 con Ave. Bolívar #65-98 Llano Largo",
                    ShipCity = "Barquisimeto",
                    ShipRegion = "Lara",
                    ShipPostalCode = "3508",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[32], UnitPrice = 32.00m, Quantity = 50, Discount = 0F},
                    new OrderDetail {Product = products[46], UnitPrice = 12.00m, Quantity = 20, Discount = 0.25F},
                    new OrderDetail {Product = products[52], UnitPrice = 7.00m, Quantity = 20, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "WOLZA",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Apr  3 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 17 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 17 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 20.31m,
                    ShipName = "Wolski Zajazd",
                    ShipAddress = "ul. Filtrowa 68",
                    ShipCity = "Warszawa",
                    ShipRegion = "",
                    ShipPostalCode = "01-012",
                    ShipCountry = "Poland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[61], UnitPrice = 28.50m, Quantity = 7, Discount = 0F},
                    new OrderDetail {Product = products[74], UnitPrice = 10.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "OTTIK",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Apr  3 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May  1 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 10 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 96.35m,
                    ShipName = "Ottilies Käseladen",
                    ShipAddress = "Mehrheimerstr. 369",
                    ShipCity = "Köln",
                    ShipRegion = "",
                    ShipPostalCode = "50739",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 20, Discount = 0.05F},
                    new OrderDetail {Product = products[51], UnitPrice = 53.00m, Quantity = 15, Discount = 0.05F},
                    new OrderDetail {Product = products[77], UnitPrice = 13.00m, Quantity = 21, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "RATTC",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Apr  6 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May  4 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 14 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 55.12m,
                    ShipName = "Rattlesnake Canyon Grocery",
                    ShipAddress = "2817 Milton Dr.",
                    ShipCity = "Albuquerque",
                    ShipRegion = "NM",
                    ShipPostalCode = "87110",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[4], UnitPrice = 22.00m, Quantity = 25, Discount = 0.25F},
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 30, Discount = 0.25F},
                    new OrderDetail {Product = products[77], UnitPrice = 13.00m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "FOLKO",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Apr  6 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May  4 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 14 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 197.30m,
                    ShipName = "Folk och fä HB",
                    ShipAddress = "Åkergatan 24",
                    ShipCity = "Bräcke",
                    ShipRegion = "",
                    ShipPostalCode = "S-844 67",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[7], UnitPrice = 30.00m, Quantity = 60, Discount = 0F},
                    new OrderDetail {Product = products[22], UnitPrice = 21.00m, Quantity = 25, Discount = 0F},
                    new OrderDetail {Product = products[46], UnitPrice = 12.00m, Quantity = 25, Discount = 0F},
                    new OrderDetail {Product = products[55], UnitPrice = 24.00m, Quantity = 6, Discount = 0F}),

                new Order
                {
                    CustomerId = "SAVEA",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Apr  6 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May  4 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 16 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 141.16m,
                    ShipName = "Save-a-lot Markets",
                    ShipAddress = "187 Suffolk Ln.",
                    ShipCity = "Boise",
                    ShipRegion = "ID",
                    ShipPostalCode = "83720",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[13], UnitPrice = 6.00m, Quantity = 56, Discount = 0F},
                    new OrderDetail {Product = products[35], UnitPrice = 18.00m, Quantity = 15, Discount = 0.15F},
                    new OrderDetail {Product = products[42], UnitPrice = 14.00m, Quantity = 24, Discount = 0.15F},
                    new OrderDetail {Product = products[55], UnitPrice = 24.00m, Quantity = 40, Discount = 0F}),

                new Order
                {
                    CustomerId = "THECR",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Apr  6 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May  4 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr  8 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 14.91m,
                    ShipName = "The Cracker Box",
                    ShipAddress = "55 Grizzly Peak Rd.",
                    ShipCity = "Butte",
                    ShipRegion = "MT",
                    ShipPostalCode = "59801",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 18.00m, Quantity = 4, Discount = 0F},
                    new OrderDetail {Product = products[40], UnitPrice = 18.40m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[52], UnitPrice = 7.00m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "MAISD",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Apr  7 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May  5 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 20 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 44.84m,
                    ShipName = "Maison Dewey",
                    ShipAddress = "Rue Joseph-Bens 532",
                    ShipCity = "Bruxelles",
                    ShipRegion = "",
                    ShipPostalCode = "B-1180",
                    ShipCountry = "Belgium",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[26], UnitPrice = 31.23m, Quantity = 6, Discount = 0F},
                    new OrderDetail {Product = products[76], UnitPrice = 18.00m, Quantity = 6, Discount = 0F}),

                new Order
                {
                    CustomerId = "WILMK",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Apr  7 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May  5 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 10 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 0.75m,
                    ShipName = "Wilman Kala",
                    ShipAddress = "Keskuskatu 45",
                    ShipCity = "Helsinki",
                    ShipRegion = "",
                    ShipPostalCode = "21240",
                    ShipCountry = "Finland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 18.00m, Quantity = 2, Discount = 0F},
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "GREAL",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Apr  7 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May  5 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 15 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 25.19m,
                    ShipName = "Great Lakes Food Market",
                    ShipAddress = "2732 Baker Blvd.",
                    ShipCity = "Eugene",
                    ShipRegion = "OR",
                    ShipPostalCode = "97403",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 18.00m, Quantity = 8, Discount = 0F},
                    new OrderDetail {Product = products[29], UnitPrice = 123.79m, Quantity = 2, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "PRINI",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Apr  8 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May  6 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 13 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 202.24m,
                    ShipName = "Princesa Isabel Vinhos",
                    ShipAddress = "Estrada da saúde n. 58",
                    ShipCity = "Lisboa",
                    ShipRegion = "",
                    ShipPostalCode = "1756",
                    ShipCountry = "Portugal",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[8], UnitPrice = 40.00m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[29], UnitPrice = 123.79m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[42], UnitPrice = 14.00m, Quantity = 14, Discount = 0F}),

                new Order
                {
                    CustomerId = "ERNSH",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Apr  8 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May  6 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 79.46m,
                    ShipName = "Ernst Handel",
                    ShipAddress = "Kirchgasse 6",
                    ShipCity = "Graz",
                    ShipRegion = "",
                    ShipPostalCode = "8010",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[28], UnitPrice = 45.60m, Quantity = 70, Discount = 0.05F},
                    new OrderDetail {Product = products[34], UnitPrice = 14.00m, Quantity = 90, Discount = 0.05F},
                    new OrderDetail {Product = products[71], UnitPrice = 21.50m, Quantity = 21, Discount = 0F}),

                new Order
                {
                    CustomerId = "GODOS",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Apr  8 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May  6 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 10 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 59.11m,
                    ShipName = "Godos Cocina Típica",
                    ShipAddress = "C/ Romero, 33",
                    ShipCity = "Sevilla",
                    ShipRegion = "",
                    ShipPostalCode = "41101",
                    ShipCountry = "Spain",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[36], UnitPrice = 19.00m, Quantity = 18, Discount = 0.25F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 9, Discount = 0F}),

                new Order
                {
                    CustomerId = "REGGC",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Apr  9 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May  7 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 21 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 28.71m,
                    ShipName = "Reggiani Caseifici",
                    ShipAddress = "Strada Provinciale 124",
                    ShipCity = "Reggio Emilia",
                    ShipRegion = "",
                    ShipPostalCode = "42100",
                    ShipCountry = "Italy",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[7], UnitPrice = 30.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "ALFKI",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Apr  9 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May  7 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 13 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 1.21m,
                    ShipName = "Alfred's Futterkiste",
                    ShipAddress = "Obere Str. 57",
                    ShipCity = "Berlin",
                    ShipRegion = "",
                    ShipPostalCode = "12209",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[58], UnitPrice = 13.25m, Quantity = 40, Discount = 0.05F},
                    new OrderDetail {Product = products[71], UnitPrice = 21.50m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "FRANK",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Apr  9 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 23 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 17 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 242.95m,
                    ShipName = "Frankenversand",
                    ShipAddress = "Berliner Platz 43",
                    ShipCity = "München",
                    ShipRegion = "",
                    ShipPostalCode = "80805",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[19], UnitPrice = 9.20m, Quantity = 50, Discount = 0.05F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 36, Discount = 0.05F},
                    new OrderDetail {Product = products[71], UnitPrice = 21.50m, Quantity = 60, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "ROMEY",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Apr  9 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May  7 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 10 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 32.99m,
                    ShipName = "Romero y tomillo",
                    ShipAddress = "Gran Vía, 1",
                    ShipCity = "Madrid",
                    ShipRegion = "",
                    ShipPostalCode = "28001",
                    ShipCountry = "Spain",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[23], UnitPrice = 9.00m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[42], UnitPrice = 14.00m, Quantity = 4, Discount = 0F},
                    new OrderDetail {Product = products[45], UnitPrice = 9.50m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[68], UnitPrice = 12.50m, Quantity = 2, Discount = 0F}),

                new Order
                {
                    CustomerId = "LINOD",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Apr 10 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May  8 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 15 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 23.60m,
                    ShipName = "LINO-Delicateses",
                    ShipAddress = "Ave. 5 de Mayo Porlamar",
                    ShipCity = "I. de Margarita",
                    ShipRegion = "Nueva Esparta",
                    ShipPostalCode = "4980",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 28, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "SANTG",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Apr 10 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 24 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 20 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 4.62m,
                    ShipName = "Santé Gourmet",
                    ShipAddress = "Erling Skakkes gate 78",
                    ShipCity = "Stavern",
                    ShipRegion = "",
                    ShipPostalCode = "4110",
                    ShipCountry = "Norway",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[30], UnitPrice = 25.89m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[77], UnitPrice = 13.00m, Quantity = 18, Discount = 0F}),

                new Order
                {
                    CustomerId = "AROUT",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Apr 10 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May  8 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 13 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 33.80m,
                    ShipName = "Around the Horn",
                    ShipAddress = "Brook Farm Stratford St. Mary",
                    ShipCity = "Colchester",
                    ShipRegion = "Essex",
                    ShipPostalCode = "CO7 6JX",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[36], UnitPrice = 19.00m, Quantity = 16, Discount = 0F}),

                new Order
                {
                    CustomerId = "ERNSH",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Apr 13 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 11 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 20 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 754.26m,
                    ShipName = "Ernst Handel",
                    ShipAddress = "Kirchgasse 6",
                    ShipCity = "Graz",
                    ShipRegion = "",
                    ShipPostalCode = "8010",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[3], UnitPrice = 10.00m, Quantity = 25, Discount = 0F},
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 110, Discount = 0F},
                    new OrderDetail {Product = products[70], UnitPrice = 15.00m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "LONEP",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Apr 13 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 11 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 16 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 11.65m,
                    ShipName = "Lonesome Pine Restaurant",
                    ShipAddress = "89 Chiaroscuro Rd.",
                    ShipCity = "Portland",
                    ShipRegion = "OR",
                    ShipPostalCode = "97219",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[12], UnitPrice = 38.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[18], UnitPrice = 62.50m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 5, Discount = 0F}),

                new Order
                {
                    CustomerId = "RANCH",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Apr 13 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 11 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 3.17m,
                    ShipName = "Rancho grande",
                    ShipAddress = "Av. del Libertador 900",
                    ShipCity = "Buenos Aires",
                    ShipRegion = "",
                    ShipPostalCode = "1010",
                    ShipCountry = "Argentina",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[46], UnitPrice = 12.00m, Quantity = 3, Discount = 0F},
                    new OrderDetail {Product = products[49], UnitPrice = 20.00m, Quantity = 2, Discount = 0F}),

                new Order
                {
                    CustomerId = "OTTIK",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Apr 14 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 12 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 16 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 43.30m,
                    ShipName = "Ottilies Käseladen",
                    ShipAddress = "Mehrheimerstr. 369",
                    ShipCity = "Köln",
                    ShipRegion = "",
                    ShipPostalCode = "50739",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[10], UnitPrice = 31.00m, Quantity = 24, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "QUICK",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Apr 14 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 12 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 21 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 297.18m,
                    ShipName = "QUICK-Stop",
                    ShipAddress = "Taucherstraße 10",
                    ShipCity = "Cunewalde",
                    ShipRegion = "",
                    ShipPostalCode = "01307",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 19.00m, Quantity = 11, Discount = 0.25F},
                    new OrderDetail {Product = products[20], UnitPrice = 81.00m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[26], UnitPrice = 31.23m, Quantity = 63, Discount = 0F},
                    new OrderDetail {Product = products[51], UnitPrice = 53.00m, Quantity = 44, Discount = 0.25F},
                    new OrderDetail {Product = products[72], UnitPrice = 34.80m, Quantity = 35, Discount = 0F}),

                new Order
                {
                    CustomerId = "HANAR",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Apr 14 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 12 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("May  4 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 6.27m,
                    ShipName = "Hanari Carnes",
                    ShipAddress = "Rua do Paço, 67",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "05454-876",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[19], UnitPrice = 9.20m, Quantity = 35, Discount = 0F},
                    new OrderDetail {Product = products[69], UnitPrice = 36.00m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "BSBEV",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Apr 14 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Apr 28 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 24 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 123.83m,
                    ShipName = "B's Beverages",
                    ShipAddress = "Fauntleroy Circus",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "EC2 5NT",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[7], UnitPrice = 30.00m, Quantity = 4, Discount = 0F},
                    new OrderDetail {Product = products[43], UnitPrice = 46.00m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "EASTC",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Apr 15 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 13 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 20 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 74.36m,
                    ShipName = "Eastern Connection",
                    ShipAddress = "35 King George",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "WX3 6FW",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[26], UnitPrice = 31.23m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[33], UnitPrice = 2.50m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[65], UnitPrice = 21.05m, Quantity = 21, Discount = 0F},
                    new OrderDetail {Product = products[71], UnitPrice = 21.50m, Quantity = 50, Discount = 0F}),

                new Order
                {
                    CustomerId = "WARTH",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Apr 15 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 13 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 24 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 29.17m,
                    ShipName = "Wartian Herkku",
                    ShipAddress = "Torikatu 38",
                    ShipCity = "Oulu",
                    ShipRegion = "",
                    ShipPostalCode = "90110",
                    ShipCountry = "Finland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 18.00m, Quantity = 10, Discount = 0.1F},
                    new OrderDetail {Product = products[13], UnitPrice = 6.00m, Quantity = 20, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "FRANS",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Apr 15 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 13 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 28 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 47.09m,
                    ShipName = "Franchi S.p.A.",
                    ShipAddress = "Via Monte Bianco 34",
                    ShipCity = "Torino",
                    ShipRegion = "",
                    ShipPostalCode = "10100",
                    ShipCountry = "Italy",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[18], UnitPrice = 62.50m, Quantity = 8, Discount = 0F},
                    new OrderDetail {Product = products[51], UnitPrice = 53.00m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "BOTTM",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Apr 16 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 14 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 20 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 52.52m,
                    ShipName = "Bottom-Dollar Markets",
                    ShipAddress = "23 Tsawassen Blvd.",
                    ShipCity = "Tsawassen",
                    ShipRegion = "BC",
                    ShipPostalCode = "T2F 8M4",
                    ShipCountry = "Canada",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 30, Discount = 0.25F},
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 21, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "KOENE",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Apr 16 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 14 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 22 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 29.59m,
                    ShipName = "Königlich Essen",
                    ShipAddress = "Maubelstr. 90",
                    ShipCity = "Brandenburg",
                    ShipRegion = "",
                    ShipPostalCode = "14776",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[55], UnitPrice = 24.00m, Quantity = 35, Discount = 0F},
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 24, Discount = 0F}),

                new Order
                {
                    CustomerId = "CHOPS",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Apr 16 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 14 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 27 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 47.84m,
                    ShipName = "Chop-suey Chinese",
                    ShipAddress = "Hauptstr. 31",
                    ShipCity = "Bern",
                    ShipRegion = "",
                    ShipPostalCode = "3012",
                    ShipCountry = "Switzerland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[56], UnitPrice = 38.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[63], UnitPrice = 43.90m, Quantity = 12, Discount = 0F}),

                new Order
                {
                    CustomerId = "SAVEA",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Apr 17 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 15 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 27 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 830.75m,
                    ShipName = "Save-a-lot Markets",
                    ShipAddress = "187 Suffolk Ln.",
                    ShipCity = "Boise",
                    ShipRegion = "ID",
                    ShipPostalCode = "83720",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 19.00m, Quantity = 100, Discount = 0.25F},
                    new OrderDetail {Product = products[5], UnitPrice = 21.35m, Quantity = 70, Discount = 0F},
                    new OrderDetail {Product = products[29], UnitPrice = 123.79m, Quantity = 60, Discount = 0.25F},
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 100, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "SAVEA",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Apr 17 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 15 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 24 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 227.22m,
                    ShipName = "Save-a-lot Markets",
                    ShipAddress = "187 Suffolk Ln.",
                    ShipCity = "Boise",
                    ShipRegion = "ID",
                    ShipPostalCode = "83720",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 18.00m, Quantity = 45, Discount = 0F},
                    new OrderDetail {Product = products[13], UnitPrice = 6.00m, Quantity = 80, Discount = 0F},
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 21, Discount = 0F},
                    new OrderDetail {Product = products[64], UnitPrice = 33.25m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[71], UnitPrice = 21.50m, Quantity = 16, Discount = 0F}),

                new Order
                {
                    CustomerId = "WHITC",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Apr 17 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 15 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 23 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 606.19m,
                    ShipName = "White Clover Markets",
                    ShipAddress = "1029 - 12th Ave. S.",
                    ShipCity = "Seattle",
                    ShipRegion = "WA",
                    ShipPostalCode = "98124",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[36], UnitPrice = 19.00m, Quantity = 35, Discount = 0F},
                    new OrderDetail {Product = products[38], UnitPrice = 263.50m, Quantity = 25, Discount = 0F},
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "RICSU",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Apr 17 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 15 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 23 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 84.74m,
                    ShipName = "Richter Supermarkt",
                    ShipAddress = "Starenweg 5",
                    ShipCity = "Genève",
                    ShipRegion = "",
                    ShipPostalCode = "1204",
                    ShipCountry = "Switzerland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[53], UnitPrice = 32.80m, Quantity = 70, Discount = 0.1F},
                    new OrderDetail {Product = products[69], UnitPrice = 36.00m, Quantity = 36, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "OLDWO",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Apr 20 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun  1 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 27 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 40.32m,
                    ShipName = "Old World Delicatessen",
                    ShipAddress = "2743 Bering St.",
                    ShipCity = "Anchorage",
                    ShipRegion = "AK",
                    ShipPostalCode = "99508",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[21], UnitPrice = 10.00m, Quantity = 15, Discount = 0.1F},
                    new OrderDetail {Product = products[44], UnitPrice = 19.45m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[61], UnitPrice = 28.50m, Quantity = 6, Discount = 0F}),

                new Order
                {
                    CustomerId = "SUPRD",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Apr 20 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 18 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 24 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 0.17m,
                    ShipName = "Suprêmes délices",
                    ShipAddress = "Boulevard Tirou, 255",
                    ShipCity = "Charleroi",
                    ShipRegion = "",
                    ShipPostalCode = "B-6000",
                    ShipCountry = "Belgium",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 18.00m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[35], UnitPrice = 18.00m, Quantity = 60, Discount = 0F},
                    new OrderDetail {Product = products[42], UnitPrice = 14.00m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[54], UnitPrice = 7.45m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "DRACD",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Apr 20 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 18 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 22 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 149.47m,
                    ShipName = "Drachenblut Delikatessen",
                    ShipAddress = "Walserweg 21",
                    ShipCity = "Aachen",
                    ShipRegion = "",
                    ShipPostalCode = "52066",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[13], UnitPrice = 6.00m, Quantity = 7, Discount = 0F},
                    new OrderDetail {Product = products[59], UnitPrice = 55.00m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "GODOS",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Apr 21 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 19 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 27 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 3.20m,
                    ShipName = "Godos Cocina Típica",
                    ShipAddress = "C/ Romero, 33",
                    ShipCity = "Sevilla",
                    ShipRegion = "",
                    ShipPostalCode = "41101",
                    ShipCountry = "Spain",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[70], UnitPrice = 15.00m, Quantity = 4, Discount = 0F}),

                new Order
                {
                    CustomerId = "SUPRD",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Apr 21 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 19 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 30 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 29.59m,
                    ShipName = "Suprêmes délices",
                    ShipAddress = "Boulevard Tirou, 255",
                    ShipCity = "Charleroi",
                    ShipRegion = "",
                    ShipPostalCode = "B-6000",
                    ShipCountry = "Belgium",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[40], UnitPrice = 18.40m, Quantity = 5, Discount = 0.2F},
                    new OrderDetail {Product = products[52], UnitPrice = 7.00m, Quantity = 2, Discount = 0F},
                    new OrderDetail {Product = products[71], UnitPrice = 21.50m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "LINOD",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("Apr 21 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 19 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 65.00m,
                    ShipName = "LINO-Delicateses",
                    ShipAddress = "Ave. 5 de Mayo Porlamar",
                    ShipCity = "I. de Margarita",
                    ShipRegion = "Nueva Esparta",
                    ShipPostalCode = "4980",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[28], UnitPrice = 45.60m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[35], UnitPrice = 18.00m, Quantity = 24, Discount = 0F},
                    new OrderDetail {Product = products[49], UnitPrice = 20.00m, Quantity = 60, Discount = 0F},
                    new OrderDetail {Product = products[57], UnitPrice = 19.50m, Quantity = 28, Discount = 0F}),

                new Order
                {
                    CustomerId = "GREAL",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Apr 22 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 20 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 18.84m,
                    ShipName = "Great Lakes Food Market",
                    ShipAddress = "2732 Baker Blvd.",
                    ShipCity = "Eugene",
                    ShipRegion = "OR",
                    ShipPostalCode = "97403",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[21], UnitPrice = 10.00m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "CHOPS",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Apr 22 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 20 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 28 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 48.22m,
                    ShipName = "Chop-suey Chinese",
                    ShipAddress = "Hauptstr. 31",
                    ShipCity = "Bern",
                    ShipRegion = "",
                    ShipPostalCode = "3012",
                    ShipCountry = "Switzerland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 19.00m, Quantity = 30, Discount = 0.2F},
                    new OrderDetail {Product = products[63], UnitPrice = 43.90m, Quantity = 30, Discount = 0F}),

                new Order
                {
                    CustomerId = "COMMI",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Apr 22 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May  6 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("May  1 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 29.99m,
                    ShipName = "Comércio Mineiro",
                    ShipAddress = "Av. dos Lusíadas, 23",
                    ShipCity = "Sao Paulo",
                    ShipRegion = "SP",
                    ShipPostalCode = "05432-043",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[44], UnitPrice = 19.45m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[61], UnitPrice = 28.50m, Quantity = 4, Discount = 0F}),

                new Order
                {
                    CustomerId = "SPECD",
                    Employee = employees[5],
                    OrderDate = DateTime.Parse("Apr 22 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 20 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 29 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 8.80m,
                    ShipName = "Spécialités du monde",
                    ShipAddress = "25, rue Lauriston",
                    ShipCity = "Paris",
                    ShipRegion = "",
                    ShipPostalCode = "75016",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 21.00m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "WOLZA",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Apr 23 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 21 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("May  1 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 8.72m,
                    ShipName = "Wolski Zajazd",
                    ShipAddress = "ul. Filtrowa 68",
                    ShipCity = "Warszawa",
                    ShipRegion = "",
                    ShipPostalCode = "01-012",
                    ShipCountry = "Poland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[62], UnitPrice = 49.30m, Quantity = 12, Discount = 0F}),

                new Order
                {
                    CustomerId = "BOTTM",
                    Employee = employees[6],
                    OrderDate = DateTime.Parse("Apr 23 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 21 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 70.58m,
                    ShipName = "Bottom-Dollar Markets",
                    ShipAddress = "23 Tsawassen Blvd.",
                    ShipCity = "Tsawassen",
                    ShipRegion = "BC",
                    ShipPostalCode = "T2F 8M4",
                    ShipCountry = "Canada",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[33], UnitPrice = 2.50m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[51], UnitPrice = 53.00m, Quantity = 24, Discount = 0F}),

                new Order
                {
                    CustomerId = "WANDK",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Apr 23 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 21 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 24 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 71.64m,
                    ShipName = "Die Wandernde Kuh",
                    ShipAddress = "Adenauerallee 900",
                    ShipCity = "Stuttgart",
                    ShipRegion = "",
                    ShipPostalCode = "70563",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[12], UnitPrice = 38.00m, Quantity = 20, Discount = 0.05F},
                    new OrderDetail {Product = products[32], UnitPrice = 32.00m, Quantity = 15, Discount = 0.05F},
                    new OrderDetail {Product = products[35], UnitPrice = 18.00m, Quantity = 18, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "EASTC",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Apr 24 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 22 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("May  1 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 46.62m,
                    ShipName = "Eastern Connection",
                    ShipAddress = "35 King George",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "WX3 6FW",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 18.00m, Quantity = 25, Discount = 0.25F},
                    new OrderDetail {Product = products[5], UnitPrice = 21.35m, Quantity = 30, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "BOTTM",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Apr 24 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 22 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 30 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 24.12m,
                    ShipName = "Bottom-Dollar Markets",
                    ShipAddress = "23 Tsawassen Blvd.",
                    ShipCity = "Tsawassen",
                    ShipRegion = "BC",
                    ShipPostalCode = "T2F 8M4",
                    ShipCountry = "Canada",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[68], UnitPrice = 12.50m, Quantity = 42, Discount = 0F}),

                new Order
                {
                    CustomerId = "GOURL",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Apr 24 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 22 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("May  4 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 8.34m,
                    ShipName = "Gourmet Lanchonetes",
                    ShipAddress = "Av. Brasil, 442",
                    ShipCity = "Campinas",
                    ShipRegion = "SP",
                    ShipPostalCode = "04876-786",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 19.00m, Quantity = 10, Discount = 0.2F},
                    new OrderDetail {Product = products[12], UnitPrice = 38.00m, Quantity = 4, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "FOLKO",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Apr 27 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 25 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("May  5 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 59.41m,
                    ShipName = "Folk och fä HB",
                    ShipAddress = "Åkergatan 24",
                    ShipCity = "Bräcke",
                    ShipRegion = "",
                    ShipPostalCode = "S-844 67",
                    ShipCountry = "Sweden",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[76], UnitPrice = 18.00m, Quantity = 50, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "LAMAI",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Apr 27 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 25 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 2.79m,
                    ShipName = "La maison d'Asie",
                    ShipAddress = "1 rue Alsace-Lorraine",
                    ShipCity = "Toulouse",
                    ShipRegion = "",
                    ShipPostalCode = "31000",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 10, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "HANAR",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Apr 27 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 25 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("May  1 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 67.26m,
                    ShipName = "Hanari Carnes",
                    ShipAddress = "Rua do Paço, 67",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "05454-876",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[43], UnitPrice = 46.00m, Quantity = 30, Discount = 0.2F},
                    new OrderDetail {Product = products[61], UnitPrice = 28.50m, Quantity = 10, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "PICCO",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Apr 27 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 25 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("Apr 29 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 53.05m,
                    ShipName = "Piccolo und mehr",
                    ShipAddress = "Geislweg 14",
                    ShipCity = "Salzburg",
                    ShipRegion = "",
                    ShipPostalCode = "5020",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[18], UnitPrice = 62.50m, Quantity = 35, Discount = 0.2F},
                    new OrderDetail {Product = products[32], UnitPrice = 32.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[64], UnitPrice = 33.25m, Quantity = 25, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "CACTU",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Apr 28 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 26 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 0.33m,
                    ShipName = "Cactus Comidas para llevar",
                    ShipAddress = "Cerrito 333",
                    ShipCity = "Buenos Aires",
                    ShipRegion = "",
                    ShipPostalCode = "1010",
                    ShipCountry = "Argentina",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[33], UnitPrice = 2.50m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[67], UnitPrice = 14.00m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "HILAA",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("Apr 28 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 26 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("May  5 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 120.92m,
                    ShipName = "HILARION-Abastos",
                    ShipAddress = "Carrera 22 con Ave. Carlos Soublette #8-35",
                    ShipCity = "San Cristóbal",
                    ShipRegion = "Táchira",
                    ShipPostalCode = "5022",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[25], UnitPrice = 14.00m, Quantity = 15, Discount = 0F},
                    new OrderDetail {Product = products[51], UnitPrice = 53.00m, Quantity = 20, Discount = 0F},
                    new OrderDetail {Product = products[57], UnitPrice = 19.50m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "EASTC",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("Apr 28 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 12 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("May  1 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 278.96m,
                    ShipName = "Eastern Connection",
                    ShipAddress = "35 King George",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "WX3 6FW",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[7], UnitPrice = 30.00m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[55], UnitPrice = 24.00m, Quantity = 35, Discount = 0F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 50, Discount = 0F}),

                new Order
                {
                    CustomerId = "NORTS",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Apr 29 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 27 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("May  1 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 4.13m,
                    ShipName = "North/South",
                    ShipAddress = "South House 300 Queensbridge",
                    ShipCity = "London",
                    ShipRegion = "",
                    ShipPostalCode = "SW7 1RZ",
                    ShipCountry = "UK",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[70], UnitPrice = 15.00m, Quantity = 3, Discount = 0F}),

                new Order
                {
                    CustomerId = "BLAUS",
                    Employee = employees[9],
                    OrderDate = DateTime.Parse("Apr 29 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 27 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 31.14m,
                    ShipName = "Blauer See Delikatessen",
                    ShipAddress = "Forsterstr. 57",
                    ShipCity = "Mannheim",
                    ShipRegion = "",
                    ShipPostalCode = "68306",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[21], UnitPrice = 10.00m, Quantity = 3, Discount = 0F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 21, Discount = 0F},
                    new OrderDetail {Product = products[61], UnitPrice = 28.50m, Quantity = 4, Discount = 0F}),

                new Order
                {
                    CustomerId = "RICAR",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Apr 29 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun 10 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 85.80m,
                    ShipName = "Ricardo Adocicados",
                    ShipAddress = "Av. Copacabana, 267",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "02389-890",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[13], UnitPrice = 6.00m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[17], UnitPrice = 39.00m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 35, Discount = 0F}),

                new Order
                {
                    CustomerId = "FRANS",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("Apr 30 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 28 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("May  4 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 10.98m,
                    ShipName = "Franchi S.p.A.",
                    ShipAddress = "Via Monte Bianco 34",
                    ShipCity = "Torino",
                    ShipRegion = "",
                    ShipPostalCode = "10100",
                    ShipCountry = "Italy",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 4, Discount = 0F},
                    new OrderDetail {Product = products[77], UnitPrice = 13.00m, Quantity = 10, Discount = 0F}),

                new Order
                {
                    CustomerId = "GREAL",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Apr 30 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun 11 1998 12:00AM"),
                    Shipper = shippers[3],
                    Freight = 14.01m,
                    ShipName = "Great Lakes Food Market",
                    ShipAddress = "2732 Baker Blvd.",
                    ShipCity = "Eugene",
                    ShipRegion = "OR",
                    ShipPostalCode = "97403",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 15, Discount = 0F}),

                new Order
                {
                    CustomerId = "REGGC",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("Apr 30 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 28 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 29.93m,
                    ShipName = "Reggiani Caseifici",
                    ShipAddress = "Strada Provinciale 124",
                    ShipCity = "Reggio Emilia",
                    ShipRegion = "",
                    ShipPostalCode = "42100",
                    ShipCountry = "Italy",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[53], UnitPrice = 32.80m, Quantity = 10, Discount = 0.2F},
                    new OrderDetail {Product = products[70], UnitPrice = 15.00m, Quantity = 12, Discount = 0.2F}),

                new Order
                {
                    CustomerId = "HUNGO",
                    Employee = employees[3],
                    OrderDate = DateTime.Parse("Apr 30 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 28 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("May  6 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 81.73m,
                    ShipName = "Hungry Owl All-Night Grocers",
                    ShipAddress = "8 Johnstown Road",
                    ShipCity = "Cork",
                    ShipRegion = "Co. Cork",
                    ShipPostalCode = "",
                    ShipCountry = "Ireland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[34], UnitPrice = 14.00m, Quantity = 30, Discount = 0F},
                    new OrderDetail {Product = products[40], UnitPrice = 18.40m, Quantity = 40, Discount = 0.1F},
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 30, Discount = 0.1F}),

                new Order
                {
                    CustomerId = "SAVEA",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("May  1 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 29 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("May  4 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 30.09m,
                    ShipName = "Save-a-lot Markets",
                    ShipAddress = "187 Suffolk Ln.",
                    ShipCity = "Boise",
                    ShipRegion = "ID",
                    ShipPostalCode = "83720",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[17], UnitPrice = 39.00m, Quantity = 77, Discount = 0.1F},
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 12, Discount = 0F},
                    new OrderDetail {Product = products[53], UnitPrice = 32.80m, Quantity = 25, Discount = 0.1F},
                    new OrderDetail {Product = products[55], UnitPrice = 24.00m, Quantity = 4, Discount = 0.1F},
                    new OrderDetail {Product = products[68], UnitPrice = 12.50m, Quantity = 55, Discount = 0F}),

                new Order
                {
                    CustomerId = "LILAS",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("May  1 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 29 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 12.91m,
                    ShipName = "LILA-Supermercado",
                    ShipAddress = "Carrera 52 con Ave. Bolívar #65-98 Llano Largo",
                    ShipCity = "Barquisimeto",
                    ShipRegion = "Lara",
                    ShipPostalCode = "3508",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[30], UnitPrice = 25.89m, Quantity = 4, Discount = 0.25F},
                    new OrderDetail {Product = products[54], UnitPrice = 7.45m, Quantity = 20, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "WHITC",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("May  1 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 29 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("May  4 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 44.72m,
                    ShipName = "White Clover Markets",
                    ShipAddress = "1029 - 12th Ave. S.",
                    ShipCity = "Seattle",
                    ShipRegion = "WA",
                    ShipPostalCode = "98124",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[16], UnitPrice = 17.45m, Quantity = 3, Discount = 0F},
                    new OrderDetail {Product = products[19], UnitPrice = 9.20m, Quantity = 42, Discount = 0F},
                    new OrderDetail {Product = products[34], UnitPrice = 14.00m, Quantity = 35, Discount = 0F}),

                new Order
                {
                    CustomerId = "DRACD",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("May  4 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("May 18 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("May  6 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 7.98m,
                    ShipName = "Drachenblut Delikatessen",
                    ShipAddress = "Walserweg 21",
                    ShipCity = "Aachen",
                    ShipRegion = "",
                    ShipPostalCode = "52066",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 9, Discount = 0F}),

                new Order
                {
                    CustomerId = "QUEEN",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("May  4 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun  1 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 81.75m,
                    ShipName = "Queen Cozinha",
                    ShipAddress = "Alameda dos Canàrios, 891",
                    ShipCity = "Sao Paulo",
                    ShipRegion = "SP",
                    ShipPostalCode = "05487-020",
                    ShipCountry = "Brazil",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[28], UnitPrice = 45.60m, Quantity = 8, Discount = 0.15F},
                    new OrderDetail {Product = products[43], UnitPrice = 46.00m, Quantity = 36, Discount = 0.15F},
                    new OrderDetail {Product = products[77], UnitPrice = 13.00m, Quantity = 28, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "TORTU",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("May  4 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun  1 1998 12:00AM"),
                    ShippedDate = DateTime.Parse("May  6 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 15.67m,
                    ShipName = "Tortuga Restaurante",
                    ShipAddress = "Avda. Azteca 123",
                    ShipCity = "México D.F.",
                    ShipRegion = "",
                    ShipPostalCode = "05033",
                    ShipCountry = "Mexico",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[39], UnitPrice = 18.00m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "LEHMS",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("May  5 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun  2 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 136.00m,
                    ShipName = "Lehmanns Marktstand",
                    ShipAddress = "Magazinweg 7",
                    ShipCity = "Frankfurt a.M.",
                    ShipRegion = "",
                    ShipPostalCode = "60528",
                    ShipCountry = "Germany",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[1], UnitPrice = 18.00m, Quantity = 40, Discount = 0.15F},
                    new OrderDetail {Product = products[2], UnitPrice = 19.00m, Quantity = 20, Discount = 0.15F},
                    new OrderDetail {Product = products[16], UnitPrice = 17.45m, Quantity = 30, Discount = 0.15F},
                    new OrderDetail {Product = products[31], UnitPrice = 12.50m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "LILAS",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("May  5 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun  2 1998 12:00AM"),
                    Shipper = shippers[1],
                    Freight = 0.93m,
                    ShipName = "LILA-Supermercado",
                    ShipAddress = "Carrera 52 con Ave. Bolívar #65-98 Llano Largo",
                    ShipCity = "Barquisimeto",
                    ShipRegion = "Lara",
                    ShipPostalCode = "3508",
                    ShipCountry = "Venezuela",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[7], UnitPrice = 30.00m, Quantity = 15, Discount = 0.05F},
                    new OrderDetail {Product = products[13], UnitPrice = 6.00m, Quantity = 10, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "ERNSH",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("May  5 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun  2 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 258.64m,
                    ShipName = "Ernst Handel",
                    ShipAddress = "Kirchgasse 6",
                    ShipCity = "Graz",
                    ShipRegion = "",
                    ShipPostalCode = "8010",
                    ShipCountry = "Austria",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 19.00m, Quantity = 8, Discount = 0F},
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 40, Discount = 0F},
                    new OrderDetail {Product = products[50], UnitPrice = 16.25m, Quantity = 22, Discount = 0F},
                    new OrderDetail {Product = products[64], UnitPrice = 33.25m, Quantity = 130, Discount = 0F}),

                new Order
                {
                    CustomerId = "PERIC",
                    Employee = employees[2],
                    OrderDate = DateTime.Parse("May  5 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun  2 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 24.95m,
                    ShipName = "Pericles Comidas clásicas",
                    ShipAddress = "Calle Dr. Jorge Cash 321",
                    ShipCity = "México D.F.",
                    ShipRegion = "",
                    ShipPostalCode = "05033",
                    ShipCountry = "Mexico",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[11], UnitPrice = 21.00m, Quantity = 10, Discount = 0F},
                    new OrderDetail {Product = products[24], UnitPrice = 4.50m, Quantity = 20, Discount = 0F}),

                new Order
                {
                    CustomerId = "SIMOB",
                    Employee = employees[7],
                    OrderDate = DateTime.Parse("May  6 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun  3 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 18.44m,
                    ShipName = "Simons bistro",
                    ShipAddress = "Vinbæltet 34",
                    ShipCity = "Kobenhavn",
                    ShipRegion = "",
                    ShipPostalCode = "1734",
                    ShipCountry = "Denmark",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[16], UnitPrice = 17.45m, Quantity = 14, Discount = 0.05F}),

                new Order
                {
                    CustomerId = "RICSU",
                    Employee = employees[8],
                    OrderDate = DateTime.Parse("May  6 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun  3 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 6.19m,
                    ShipName = "Richter Supermarkt",
                    ShipAddress = "Starenweg 5",
                    ShipCity = "Genève",
                    ShipRegion = "",
                    ShipPostalCode = "1204",
                    ShipCountry = "Switzerland",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 19.00m, Quantity = 10, Discount = 0.15F},
                    new OrderDetail {Product = products[46], UnitPrice = 12.00m, Quantity = 30, Discount = 0.15F},
                    new OrderDetail {Product = products[76], UnitPrice = 18.00m, Quantity = 2, Discount = 0.15F}),

                new Order
                {
                    CustomerId = "BONAP",
                    Employee = employees[4],
                    OrderDate = DateTime.Parse("May  6 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun  3 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 38.28m,
                    ShipName = "Bon app'",
                    ShipAddress = "12, rue des Bouchers",
                    ShipCity = "Marseille",
                    ShipRegion = "",
                    ShipPostalCode = "13008",
                    ShipCountry = "France",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[6], UnitPrice = 25.00m, Quantity = 20, Discount = 0.25F},
                    new OrderDetail {Product = products[14], UnitPrice = 23.25m, Quantity = 20, Discount = 0.25F},
                    new OrderDetail {Product = products[19], UnitPrice = 9.20m, Quantity = 10, Discount = 0.25F}),

                new Order
                {
                    CustomerId = "RATTC",
                    Employee = employees[1],
                    OrderDate = DateTime.Parse("May  6 1998 12:00AM"),
                    RequiredDate = DateTime.Parse("Jun  3 1998 12:00AM"),
                    Shipper = shippers[2],
                    Freight = 8.53m,
                    ShipName = "Rattlesnake Canyon Grocery",
                    ShipAddress = "2817 Milton Dr.",
                    ShipCity = "Albuquerque",
                    ShipRegion = "NM",
                    ShipPostalCode = "87110",
                    ShipCountry = "USA",
                }.AddOrderDetails(
                    new OrderDetail {Product = products[2], UnitPrice = 19.00m, Quantity = 24, Discount = 0.2F},
                    new OrderDetail {Product = products[3], UnitPrice = 10.00m, Quantity = 4, Discount = 0F},
                    new OrderDetail {Product = products[4], UnitPrice = 22.00m, Quantity = 1, Discount = 0F},
                    new OrderDetail {Product = products[6], UnitPrice = 25.00m, Quantity = 1, Discount = 0.02F},
                    new OrderDetail {Product = products[7], UnitPrice = 30.00m, Quantity = 1, Discount = 0.05F},
                    new OrderDetail {Product = products[8], UnitPrice = 40.00m, Quantity = 2, Discount = 0.1F},
                    new OrderDetail {Product = products[10], UnitPrice = 31.00m, Quantity = 1, Discount = 0F},
                    new OrderDetail {Product = products[12], UnitPrice = 38.00m, Quantity = 2, Discount = 0.05F},
                    new OrderDetail {Product = products[13], UnitPrice = 6.00m, Quantity = 4, Discount = 0F},
                    new OrderDetail {Product = products[14], UnitPrice = 23.25m, Quantity = 1, Discount = 0.03F},
                    new OrderDetail {Product = products[16], UnitPrice = 17.45m, Quantity = 2, Discount = 0.03F},
                    new OrderDetail {Product = products[20], UnitPrice = 81.00m, Quantity = 1, Discount = 0.04F},
                    new OrderDetail {Product = products[23], UnitPrice = 9.00m, Quantity = 2, Discount = 0F},
                    new OrderDetail {Product = products[32], UnitPrice = 32.00m, Quantity = 1, Discount = 0F},
                    new OrderDetail {Product = products[39], UnitPrice = 18.00m, Quantity = 2, Discount = 0.05F},
                    new OrderDetail {Product = products[41], UnitPrice = 9.65m, Quantity = 3, Discount = 0F},
                    new OrderDetail {Product = products[46], UnitPrice = 12.00m, Quantity = 3, Discount = 0.02F},
                    new OrderDetail {Product = products[52], UnitPrice = 7.00m, Quantity = 2, Discount = 0F},
                    new OrderDetail {Product = products[55], UnitPrice = 24.00m, Quantity = 2, Discount = 0F},
                    new OrderDetail {Product = products[60], UnitPrice = 34.00m, Quantity = 2, Discount = 0.06F},
                    new OrderDetail {Product = products[64], UnitPrice = 33.25m, Quantity = 2, Discount = 0.03F},
                    new OrderDetail {Product = products[66], UnitPrice = 17.00m, Quantity = 1, Discount = 0F},
                    new OrderDetail {Product = products[73], UnitPrice = 15.00m, Quantity = 2, Discount = 0.01F},
                    new OrderDetail {Product = products[75], UnitPrice = 7.75m, Quantity = 4, Discount = 0F},
                    new OrderDetail {Product = products[77], UnitPrice = 13.00m, Quantity = 2, Discount = 0F})
            });
      return orders;
    }

  }

  internal static class OrderExtensions
  {
    public static Order AddOrderDetails(this Order order, params OrderDetail[] orderDetails)
    {
      foreach (var orderDetail in orderDetails)
      {
        order.OrderDetails.Add(orderDetail);
      }

      return order;
    }
  }
}