using System.Collections.Generic;

namespace AbpNorthwindTraders.Domain.DataSeeder.Data
{
  public static class CustomerData
  {

    public static List<Customer> GetCustomers()
    {
      var customers = new List<Customer>();

      customers.AddRange(new[]
      {
                new Customer
                {
                    Id = "ALFKI", Address = "Obere Str. 57", City = "Berlin", CompanyName = "Alfreds Futterkiste",
                    ContactName = "Maria Anders", ContactTitle = "Sales Representative", Country = "Germany",
                    Fax = "030-0076545", Phone = "030-0074321", PostalCode = "12209"
                },
                new Customer
                {
                    Id = "ANATR", Address = "Avda. de la Constitución 2222", City = "México D.F.",
                    CompanyName = "Ana Trujillo Emparedados y helados", ContactName = "Ana Trujillo",
                    ContactTitle = "Owner", Country = "Mexico", Fax = "(5) 555-3745", Phone = "(5) 555-4729",
                    PostalCode = "05021"
                },
                new Customer
                {
                    Id = "ANTON", Address = "Mataderos  2312", City = "México D.F.",
                    CompanyName = "Antonio Moreno Taquería", ContactName = "Antonio Moreno", ContactTitle = "Owner",
                    Country = "Mexico", Fax = "", Phone = "(5) 555-3932", PostalCode = "05023"
                },
                new Customer
                {
                    Id = "AROUT", Address = "120 Hanover Sq.", City = "London", CompanyName = "Around the Horn",
                    ContactName = "Thomas Hardy", ContactTitle = "Sales Representative", Country = "UK",
                    Fax = "(171) 555-6750", Phone = "(171) 555-7788", PostalCode = "WA1 1DP"
                },
                new Customer
                {
                    Id = "BERGS", Address = "Berguvsvägen  8", City = "Luleå", CompanyName = "Berglunds snabbköp",
                    ContactName = "Christina Berglund", ContactTitle = "Order Administrator", Country = "Sweden",
                    Fax = "0921-12 34 67", Phone = "0921-12 34 65", PostalCode = "S-958 22"
                },
                new Customer
                {
                    Id = "BLAUS", Address = "Forsterstr. 57", City = "Mannheim",
                    CompanyName = "Blauer See Delikatessen", ContactName = "Hanna Moos",
                    ContactTitle = "Sales Representative", Country = "Germany", Fax = "0621-08924",
                    Phone = "0621-08460", PostalCode = "68306"
                },
                new Customer
                {
                    Id = "BLONP", Address = "24, place Kléber", City = "Strasbourg",
                    CompanyName = "Blondesddsl père et fils", ContactName = "Frédérique Citeaux",
                    ContactTitle = "Marketing Manager", Country = "France", Fax = "88.60.15.32", Phone = "88.60.15.31",
                    PostalCode = "67000"
                },
                new Customer
                {
                    Id = "BOLID", Address = "C/ Araquil, 67", City = "Madrid",
                    CompanyName = "Bólido Comidas preparadas", ContactName = "Martín Sommer", ContactTitle = "Owner",
                    Country = "Spain", Fax = "(91) 555 91 99", Phone = "(91) 555 22 82", PostalCode = "28023"
                },
                new Customer
                {
                    Id = "BONAP", Address = "12, rue des Bouchers", City = "Marseille", CompanyName = "Bon app'",
                    ContactName = "Laurence Lebihan", ContactTitle = "Owner", Country = "France", Fax = "91.24.45.41",
                    Phone = "91.24.45.40", PostalCode = "13008"
                },
                new Customer
                {
                    Id = "BOTTM", Address = "23 Tsawassen Blvd.", City = "Tsawassen",
                    CompanyName = "Bottom-Dollar Markets", ContactName = "Elizabeth Lincoln",
                    ContactTitle = "Accounting Manager", Country = "Canada", Fax = "(604) 555-3745",
                    Phone = "(604) 555-4729", PostalCode = "T2F 8M4", Region = "BC"
                },
                new Customer
                {
                    Id = "BSBEV", Address = "Fauntleroy Circus", City = "London", CompanyName = "B's Beverages",
                    ContactName = "Victoria Ashworth", ContactTitle = "Sales Representative", Country = "UK", Fax = "",
                    Phone = "(171) 555-1212", PostalCode = "EC2 5NT"
                },
                new Customer
                {
                    Id = "CACTU", Address = "Cerrito 333", City = "Buenos Aires",
                    CompanyName = "Cactus Comidas para llevar", ContactName = "Patricio Simpson",
                    ContactTitle = "Sales Agent", Country = "Argentina", Fax = "(1) 135-4892", Phone = "(1) 135-5555",
                    PostalCode = "1010"
                },
                new Customer
                {
                    Id = "CENTC", Address = "Sierras de Granada 9993", City = "México D.F.",
                    CompanyName = "Centro comercial Moctezuma", ContactName = "Francisco Chang",
                    ContactTitle = "Marketing Manager", Country = "Mexico", Fax = "(5) 555-7293",
                    Phone = "(5) 555-3392", PostalCode = "05022"
                },
                new Customer
                {
                    Id = "CHOPS", Address = "Hauptstr. 29", City = "Bern", CompanyName = "Chop-suey Chinese",
                    ContactName = "Yang Wang", ContactTitle = "Owner", Country = "Switzerland", Fax = "",
                    Phone = "0452-076545", PostalCode = "3012"
                },
                new Customer
                {
                    Id = "COMMI", Address = "Av. dos Lusíadas, 23", City = "Sao Paulo",
                    CompanyName = "Comércio Mineiro", ContactName = "Pedro Afonso", ContactTitle = "Sales Associate",
                    Country = "Brazil", Fax = "", Phone = "(11) 555-7647", PostalCode = "05432-043", Region = "SP"
                },
                new Customer
                {
                    Id = "CONSH", Address = "Berkeley Gardens 12  Brewery", City = "London",
                    CompanyName = "Consolidated Holdings", ContactName = "Elizabeth Brown",
                    ContactTitle = "Sales Representative", Country = "UK", Fax = "(171) 555-9199",
                    Phone = "(171) 555-2282", PostalCode = "WX1 6LT"
                },
                new Customer
                {
                    Id = "DRACD", Address = "Walserweg 21", City = "Aachen", CompanyName = "Drachenblut Delikatessen",
                    ContactName = "Sven Ottlieb", ContactTitle = "Order Administrator", Country = "Germany",
                    Fax = "0241-059428", Phone = "0241-039123", PostalCode = "52066"
                },
                new Customer
                {
                    Id = "DUMON", Address = "67, rue des Cinquante Otages", City = "Nantes",
                    CompanyName = "Du monde entier", ContactName = "Janine Labrune", ContactTitle = "Owner",
                    Country = "France", Fax = "40.67.89.89", Phone = "40.67.88.88", PostalCode = "44000"
                },
                new Customer
                {
                    Id = "EASTC", Address = "35 King George", City = "London", CompanyName = "Eastern Connection",
                    ContactName = "Ann Devon", ContactTitle = "Sales Agent", Country = "UK", Fax = "(171) 555-3373",
                    Phone = "(171) 555-0297", PostalCode = "WX3 6FW"
                },
                new Customer
                {
                    Id = "ERNSH", Address = "Kirchgasse 6", City = "Graz", CompanyName = "Ernst Handel",
                    ContactName = "Roland Mendel", ContactTitle = "Sales Manager", Country = "Austria",
                    Fax = "7675-3426", Phone = "7675-3425", PostalCode = "8010"
                },
                new Customer
                {
                    Id = "FAMIA", Address = "Rua Orós, 92", City = "Sao Paulo", CompanyName = "Familia Arquibaldo",
                    ContactName = "Aria Cruz", ContactTitle = "Marketing Assistant", Country = "Brazil", Fax = "",
                    Phone = "(11) 555-9857", PostalCode = "05442-030", Region = "SP"
                },
                new Customer
                {
                    Id = "FISSA", Address = "C/ Moralzarzal, 86", City = "Madrid",
                    CompanyName = "FISSA Fabrica Inter. Salchichas S.A.", ContactName = "Diego Roel",
                    ContactTitle = "Accounting Manager", Country = "Spain", Fax = "(91) 555 55 93",
                    Phone = "(91) 555 94 44", PostalCode = "28034"
                },
                new Customer
                {
                    Id = "FOLIG", Address = "184, chaussée de Tournai", City = "Lille",
                    CompanyName = "Folies gourmandes", ContactName = "Martine Rancé",
                    ContactTitle = "Assistant Sales Agent", Country = "France", Fax = "20.16.10.17",
                    Phone = "20.16.10.16", PostalCode = "59000"
                },
                new Customer
                {
                    Id = "FOLKO", Address = "Åkergatan 24", City = "Bräcke", CompanyName = "Folk och fä HB",
                    ContactName = "Maria Larsson", ContactTitle = "Owner", Country = "Sweden", Fax = "",
                    Phone = "0695-34 67 21", PostalCode = "S-844 67"
                },
                new Customer
                {
                    Id = "FRANK", Address = "Berliner Platz 43", City = "München", CompanyName = "Frankenversand",
                    ContactName = "Peter Franken", ContactTitle = "Marketing Manager", Country = "Germany",
                    Fax = "089-0877451", Phone = "089-0877310", PostalCode = "80805"
                },
                new Customer
                {
                    Id = "FRANR", Address = "54, rue Royale", City = "Nantes", CompanyName = "France restauration",
                    ContactName = "Carine Schmitt", ContactTitle = "Marketing Manager", Country = "France",
                    Fax = "40.32.21.20", Phone = "40.32.21.21", PostalCode = "44000"
                },
                new Customer
                {
                    Id = "FRANS", Address = "Via Monte Bianco 34", City = "Torino", CompanyName = "Franchi S.p.A.",
                    ContactName = "Paolo Accorti", ContactTitle = "Sales Representative", Country = "Italy",
                    Fax = "011-4988261", Phone = "011-4988260", PostalCode = "10100"
                },
                new Customer
                {
                    Id = "FURIB", Address = "Jardim das rosas n. 32", City = "Lisboa",
                    CompanyName = "Furia Bacalhau e Frutos do Mar", ContactName = "Lino Rodriguez",
                    ContactTitle = "Sales Manager", Country = "Portugal", Fax = "(1) 354-2535", Phone = "(1) 354-2534",
                    PostalCode = "1675"
                },
                new Customer
                {
                    Id = "GALED", Address = "Rambla de Cataluña, 23", City = "Barcelona",
                    CompanyName = "Galería del gastrónomo", ContactName = "Eduardo Saavedra",
                    ContactTitle = "Marketing Manager", Country = "Spain", Fax = "(93) 203 4561",
                    Phone = "(93) 203 4560", PostalCode = "08022"
                },
                new Customer
                {
                    Id = "GODOS", Address = "C/ Romero, 33", City = "Sevilla", CompanyName = "Godos Cocina Típica",
                    ContactName = "José Pedro Freyre", ContactTitle = "Sales Manager", Country = "Spain", Fax = "",
                    Phone = "(95) 555 82 82", PostalCode = "41101"
                },
                new Customer
                {
                    Id = "GOURL", Address = "Av. Brasil, 442", City = "Campinas", CompanyName = "Gourmet Lanchonetes",
                    ContactName = "André Fonseca", ContactTitle = "Sales Associate", Country = "Brazil", Fax = "",
                    Phone = "(11) 555-9482", PostalCode = "04876-786", Region = "SP"
                },
                new Customer
                {
                    Id = "GREAL", Address = "2732 Baker Blvd.", City = "Eugene",
                    CompanyName = "Great Lakes Food Market", ContactName = "Howard Snyder",
                    ContactTitle = "Marketing Manager", Country = "USA", Fax = "", Phone = "(503) 555-7555",
                    PostalCode = "97403", Region = "OR"
                },
                new Customer
                {
                    Id = "GROSR", Address = "5ª Ave. Los Palos Grandes", City = "Caracas",
                    CompanyName = "GROSELLA-Restaurante", ContactName = "Manuel Pereira", ContactTitle = "Owner",
                    Country = "Venezuela", Fax = "(2) 283-3397", Phone = "(2) 283-2951", PostalCode = "1081",
                    Region = "DF"
                },
                new Customer
                {
                    Id = "HANAR", Address = "Rua do Paço, 67", City = "Rio de Janeiro", CompanyName = "Hanari Carnes",
                    ContactName = "Mario Pontes", ContactTitle = "Accounting Manager", Country = "Brazil",
                    Fax = "(21) 555-8765", Phone = "(21) 555-0091", PostalCode = "05454-876", Region = "RJ"
                },
                new Customer
                {
                    Id = "HILAA", Address = "Carrera 22 con Ave. Carlos Soublette #8-35", City = "San Cristóbal",
                    CompanyName = "HILARION-Abastos", ContactName = "Carlos Hernández",
                    ContactTitle = "Sales Representative", Country = "Venezuela", Fax = "(5) 555-1948",
                    Phone = "(5) 555-1340", PostalCode = "5022", Region = "Táchira"
                },
                new Customer
                {
                    Id = "HUNGC", Address = "City Center Plaza 516 Main St.", City = "Elgin",
                    CompanyName = "Hungry Coyote Import Store", ContactName = "Yoshi Latimer",
                    ContactTitle = "Sales Representative", Country = "USA", Fax = "(503) 555-2376",
                    Phone = "(503) 555-6874", PostalCode = "97827", Region = "OR"
                },
                new Customer
                {
                    Id = "HUNGO", Address = "8 Johnstown Road", City = "Cork",
                    CompanyName = "Hungry Owl All-Night Grocers", ContactName = "Patricia McKenna",
                    ContactTitle = "Sales Associate", Country = "Ireland", Fax = "2967 3333", Phone = "2967 542",
                    PostalCode = "", Region = "Co. Cork"
                },
                new Customer
                {
                    Id = "ISLAT", Address = "Garden House Crowther Way", City = "Cowes", CompanyName = "Island Trading",
                    ContactName = "Helen Bennett", ContactTitle = "Marketing Manager", Country = "UK", Fax = "",
                    Phone = "(198) 555-8888", PostalCode = "PO31 7PJ", Region = "Isle of Wight"
                },
                new Customer
                {
                    Id = "KOENE", Address = "Maubelstr. 90", City = "Brandenburg", CompanyName = "Königlich Essen",
                    ContactName = "Philip Cramer", ContactTitle = "Sales Associate", Country = "Germany", Fax = "",
                    Phone = "0555-09876", PostalCode = "14776"
                },
                new Customer
                {
                    Id = "LACOR", Address = "67, avenue de l'Europe", City = "Versailles",
                    CompanyName = "La corne d'abondance", ContactName = "Daniel Tonini",
                    ContactTitle = "Sales Representative", Country = "France", Fax = "30.59.85.11",
                    Phone = "30.59.84.10", PostalCode = "78000"
                },
                new Customer
                {
                    Id = "LAMAI", Address = "1 rue Alsace-Lorraine", City = "Toulouse",
                    CompanyName = "La maison d'Asie", ContactName = "Annette Roulet", ContactTitle = "Sales Manager",
                    Country = "France", Fax = "61.77.61.11", Phone = "61.77.61.10", PostalCode = "31000"
                },
                new Customer
                {
                    Id = "LAUGB", Address = "1900 Oak St.", City = "Vancouver",
                    CompanyName = "Laughing Bacchus Wine Cellars", ContactName = "Yoshi Tannamuri",
                    ContactTitle = "Marketing Assistant", Country = "Canada", Fax = "(604) 555-7293",
                    Phone = "(604) 555-3392", PostalCode = "V3F 2K1", Region = "BC"
                },
                new Customer
                {
                    Id = "LAZYK", Address = "12 Orchestra Terrace", City = "Walla Walla",
                    CompanyName = "Lazy K Kountry Store", ContactName = "John Steel",
                    ContactTitle = "Marketing Manager", Country = "USA", Fax = "(509) 555-6221",
                    Phone = "(509) 555-7969", PostalCode = "99362", Region = "WA"
                },
                new Customer
                {
                    Id = "LEHMS", Address = "Magazinweg 7", City = "Frankfurt a.M.",
                    CompanyName = "Lehmanns Marktstand", ContactName = "Renate Messner",
                    ContactTitle = "Sales Representative", Country = "Germany", Fax = "069-0245874",
                    Phone = "069-0245984", PostalCode = "60528"
                },
                new Customer
                {
                    Id = "LETSS", Address = "87 Polk St. Suite 5", City = "San Francisco",
                    CompanyName = "Let's Stop N Shop", ContactName = "Jaime Yorres", ContactTitle = "Owner",
                    Country = "USA", Fax = "", Phone = "(415) 555-5938", PostalCode = "94117", Region = "CA"
                },
                new Customer
                {
                    Id = "LILAS", Address = "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", City = "Barquisimeto",
                    CompanyName = "LILA-Supermercado", ContactName = "Carlos González",
                    ContactTitle = "Accounting Manager", Country = "Venezuela", Fax = "(9) 331-7256",
                    Phone = "(9) 331-6954", PostalCode = "3508", Region = "Lara"
                },
                new Customer
                {
                    Id = "LINOD", Address = "Ave. 5 de Mayo Porlamar", City = "I. de Margarita",
                    CompanyName = "LINO-Delicateses", ContactName = "Felipe Izquierdo", ContactTitle = "Owner",
                    Country = "Venezuela", Fax = "(8) 34-93-93", Phone = "(8) 34-56-12", PostalCode = "4980",
                    Region = "Nueva Esparta"
                },
                new Customer
                {
                    Id = "LONEP", Address = "89 Chiaroscuro Rd.", City = "Portland",
                    CompanyName = "Lonesome Pine Restaurant", ContactName = "Fran Wilson",
                    ContactTitle = "Sales Manager", Country = "USA", Fax = "(503) 555-9646", Phone = "(503) 555-9573",
                    PostalCode = "97219", Region = "OR"
                },
                new Customer
                {
                    Id = "MAGAA", Address = "Via Ludovico il Moro 22", City = "Bergamo",
                    CompanyName = "Magazzini Alimentari Riuniti", ContactName = "Giovanni Rovelli",
                    ContactTitle = "Marketing Manager", Country = "Italy", Fax = "035-640231", Phone = "035-640230",
                    PostalCode = "24100"
                },
                new Customer
                {
                    Id = "MAISD", Address = "Rue Joseph-Bens 532", City = "Bruxelles", CompanyName = "Maison Dewey",
                    ContactName = "Catherine Dewey", ContactTitle = "Sales Agent", Country = "Belgium",
                    Fax = "(02) 201 24 68", Phone = "(02) 201 24 67", PostalCode = "B-1180"
                },
                new Customer
                {
                    Id = "MEREP", Address = "43 rue St. Laurent", City = "Montréal", CompanyName = "Mère Paillarde",
                    ContactName = "Jean Fresnière", ContactTitle = "Marketing Assistant", Country = "Canada",
                    Fax = "(514) 555-8055", Phone = "(514) 555-8054", PostalCode = "H1J 1C3", Region = "Québec"
                },
                new Customer
                {
                    Id = "MORGK", Address = "Heerstr. 22", City = "Leipzig", CompanyName = "Morgenstern Gesundkost",
                    ContactName = "Alexander Feuer", ContactTitle = "Marketing Assistant", Country = "Germany",
                    Fax = "", Phone = "0342-023176", PostalCode = "04179"
                },
                new Customer
                {
                    Id = "NORTS", Address = "South House 300 Queensbridge", City = "London",
                    CompanyName = "North/South", ContactName = "Simon Crowther", ContactTitle = "Sales Associate",
                    Country = "UK", Fax = "(171) 555-2530", Phone = "(171) 555-7733", PostalCode = "SW7 1RZ"
                },
                new Customer
                {
                    Id = "OCEAN", Address = "Ing. Gustavo Moncada 8585 Piso 20-A", City = "Buenos Aires",
                    CompanyName = "Océano Atlántico Ltda.", ContactName = "Yvonne Moncada",
                    ContactTitle = "Sales Agent", Country = "Argentina", Fax = "(1) 135-5535", Phone = "(1) 135-5333",
                    PostalCode = "1010"
                },
                new Customer
                {
                    Id = "OLDWO", Address = "2743 Bering St.", City = "Anchorage",
                    CompanyName = "Old World Delicatessen", ContactName = "Rene Phillips",
                    ContactTitle = "Sales Representative", Country = "USA", Fax = "(907) 555-2880",
                    Phone = "(907) 555-7584", PostalCode = "99508", Region = "AK"
                },
                new Customer
                {
                    Id = "OTTIK", Address = "Mehrheimerstr. 369", City = "Köln", CompanyName = "Ottilies Käseladen",
                    ContactName = "Henriette Pfalzheim", ContactTitle = "Owner", Country = "Germany",
                    Fax = "0221-0765721", Phone = "0221-0644327", PostalCode = "50739"
                },
                new Customer
                {
                    Id = "PARIS", Address = "265, boulevard Charonne", City = "Paris",
                    CompanyName = "Paris spécialités", ContactName = "Marie Bertrand", ContactTitle = "Owner",
                    Country = "France", Fax = "(1) 42.34.22.77", Phone = "(1) 42.34.22.66", PostalCode = "75012"
                },
                new Customer
                {
                    Id = "PERIC", Address = "Calle Dr. Jorge Cash 321", City = "México D.F.",
                    CompanyName = "Pericles Comidas clásicas", ContactName = "Guillermo Fernández",
                    ContactTitle = "Sales Representative", Country = "Mexico", Fax = "(5) 545-3745",
                    Phone = "(5) 552-3745", PostalCode = "05033"
                },
                new Customer
                {
                    Id = "PICCO", Address = "Geislweg 14", City = "Salzburg", CompanyName = "Piccolo und mehr",
                    ContactName = "Georg Pipps", ContactTitle = "Sales Manager", Country = "Austria", Fax = "6562-9723",
                    Phone = "6562-9722", PostalCode = "5020"
                },
                new Customer
                {
                    Id = "PRINI", Address = "Estrada da saúde n. 58", City = "Lisboa",
                    CompanyName = "Princesa Isabel Vinhos", ContactName = "Isabel de Castro",
                    ContactTitle = "Sales Representative", Country = "Portugal", Fax = "", Phone = "(1) 356-5634",
                    PostalCode = "1756"
                },
                new Customer
                {
                    Id = "QUEDE", Address = "Rua da Panificadora, 12", City = "Rio de Janeiro",
                    CompanyName = "Que Delícia", ContactName = "Bernardo Batista", ContactTitle = "Accounting Manager",
                    Country = "Brazil", Fax = "(21) 555-4545", Phone = "(21) 555-4252", PostalCode = "02389-673",
                    Region = "RJ"
                },
                new Customer
                {
                    Id = "QUEEN", Address = "Alameda dos Canàrios, 891", City = "Sao Paulo",
                    CompanyName = "Queen Cozinha", ContactName = "Lúcia Carvalho", ContactTitle = "Marketing Assistant",
                    Country = "Brazil", Fax = "", Phone = "(11) 555-1189", PostalCode = "05487-020", Region = "SP"
                },
                new Customer
                {
                    Id = "QUICK", Address = "Taucherstraße 10", City = "Cunewalde", CompanyName = "QUICK-Stop",
                    ContactName = "Horst Kloss", ContactTitle = "Accounting Manager", Country = "Germany", Fax = "",
                    Phone = "0372-035188", PostalCode = "01307"
                },
                new Customer
                {
                    Id = "RANCH", Address = "Av. del Libertador 900", City = "Buenos Aires",
                    CompanyName = "Rancho grande", ContactName = "Sergio Gutiérrez",
                    ContactTitle = "Sales Representative", Country = "Argentina", Fax = "(1) 123-5556",
                    Phone = "(1) 123-5555", PostalCode = "1010"
                },
                new Customer
                {
                    Id = "RATTC", Address = "2817 Milton Dr.", City = "Albuquerque",
                    CompanyName = "Rattlesnake Canyon Grocery", ContactName = "Paula Wilson",
                    ContactTitle = "Assistant Sales Representative", Country = "USA", Fax = "(505) 555-3620",
                    Phone = "(505) 555-5939", PostalCode = "87110", Region = "NM"
                },
                new Customer
                {
                    Id = "REGGC", Address = "Strada Provinciale 124", City = "Reggio Emilia",
                    CompanyName = "Reggiani Caseifici", ContactName = "Maurizio Moroni",
                    ContactTitle = "Sales Associate", Country = "Italy", Fax = "0522-556722", Phone = "0522-556721",
                    PostalCode = "42100"
                },
                new Customer
                {
                    Id = "RICAR", Address = "Av. Copacabana, 267", City = "Rio de Janeiro",
                    CompanyName = "Ricardo Adocicados", ContactName = "Janete Limeira",
                    ContactTitle = "Assistant Sales Agent", Country = "Brazil", Fax = "", Phone = "(21) 555-3412",
                    PostalCode = "02389-890", Region = "RJ"
                },
                new Customer
                {
                    Id = "RICSU", Address = "Grenzacherweg 237", City = "Genève", CompanyName = "Richter Supermarkt",
                    ContactName = "Michael Holz", ContactTitle = "Sales Manager", Country = "Switzerland", Fax = "",
                    Phone = "0897-034214", PostalCode = "1203"
                },
                new Customer
                {
                    Id = "ROMEY", Address = "Gran Vía, 1", City = "Madrid", CompanyName = "Romero y tomillo",
                    ContactName = "Alejandra Camino", ContactTitle = "Accounting Manager", Country = "Spain",
                    Fax = "(91) 745 6210", Phone = "(91) 745 6200", PostalCode = "28001"
                },
                new Customer
                {
                    Id = "SANTG", Address = "Erling Skakkes gate 78", City = "Stavern", CompanyName = "Santé Gourmet",
                    ContactName = "Jonas Bergulfsen", ContactTitle = "Owner", Country = "Norway", Fax = "07-98 92 47",
                    Phone = "07-98 92 35", PostalCode = "4110"
                },
                new Customer
                {
                    Id = "SAVEA", Address = "187 Suffolk Ln.", City = "Boise", CompanyName = "Save-a-lot Markets",
                    ContactName = "Jose Pavarotti", ContactTitle = "Sales Representative", Country = "USA", Fax = "",
                    Phone = "(208) 555-8097", PostalCode = "83720", Region = "ID"
                },
                new Customer
                {
                    Id = "SEVES", Address = "90 Wadhurst Rd.", City = "London", CompanyName = "Seven Seas Imports",
                    ContactName = "Hari Kumar", ContactTitle = "Sales Manager", Country = "UK", Fax = "(171) 555-5646",
                    Phone = "(171) 555-1717", PostalCode = "OX15 4NB"
                },
                new Customer
                {
                    Id = "SIMOB", Address = "Vinbæltet 34", City = "Kobenhavn", CompanyName = "Simons bistro",
                    ContactName = "Jytte Petersen", ContactTitle = "Owner", Country = "Denmark", Fax = "31 13 35 57",
                    Phone = "31 12 34 56", PostalCode = "1734"
                },
                new Customer
                {
                    Id = "SPECD", Address = "25, rue Lauriston", City = "Paris", CompanyName = "Spécialités du monde",
                    ContactName = "Dominique Perrier", ContactTitle = "Marketing Manager", Country = "France",
                    Fax = "(1) 47.55.60.20", Phone = "(1) 47.55.60.10", PostalCode = "75016"
                },
                new Customer
                {
                    Id = "SPLIR", Address = "P.O. Box 555", City = "Lander", CompanyName = "Split Rail Beer & Ale",
                    ContactName = "Art Braunschweiger", ContactTitle = "Sales Manager", Country = "USA",
                    Fax = "(307) 555-6525", Phone = "(307) 555-4680", PostalCode = "82520", Region = "WY"
                },
                new Customer
                {
                    Id = "SUPRD", Address = "Boulevard Tirou, 255", City = "Charleroi",
                    CompanyName = "Suprêmes délices", ContactName = "Pascale Cartrain",
                    ContactTitle = "Accounting Manager", Country = "Belgium", Fax = "(071) 23 67 22 21",
                    Phone = "(071) 23 67 22 20", PostalCode = "B-6000"
                },
                new Customer
                {
                    Id = "THEBI", Address = "89 Jefferson Way Suite 2", City = "Portland",
                    CompanyName = "The Big Cheese", ContactName = "Liz Nixon", ContactTitle = "Marketing Manager",
                    Country = "USA", Fax = "", Phone = "(503) 555-3612", PostalCode = "97201", Region = "OR"
                },
                new Customer
                {
                    Id = "THECR", Address = "55 Grizzly Peak Rd.", City = "Butte", CompanyName = "The Cracker Box",
                    ContactName = "Liu Wong", ContactTitle = "Marketing Assistant", Country = "USA",
                    Fax = "(406) 555-8083", Phone = "(406) 555-5834", PostalCode = "59801", Region = "MT"
                },
                new Customer
                {
                    Id = "TOMSP", Address = "Luisenstr. 48", City = "Münster", CompanyName = "Toms Spezialitäten",
                    ContactName = "Karin Josephs", ContactTitle = "Marketing Manager", Country = "Germany",
                    Fax = "0251-035695", Phone = "0251-031259", PostalCode = "44087"
                },
                new Customer
                {
                    Id = "TORTU", Address = "Avda. Azteca 123", City = "México D.F.",
                    CompanyName = "Tortuga Restaurante", ContactName = "Miguel Angel Paolino", ContactTitle = "Owner",
                    Country = "Mexico", Fax = "", Phone = "(5) 555-2933", PostalCode = "05033"
                },
                new Customer
                {
                    Id = "TRADH", Address = "Av. Inês de Castro, 414", City = "Sao Paulo",
                    CompanyName = "Tradição Hipermercados", ContactName = "Anabela Domingues",
                    ContactTitle = "Sales Representative", Country = "Brazil", Fax = "(11) 555-2168",
                    Phone = "(11) 555-2167", PostalCode = "05634-030", Region = "SP"
                },
                new Customer
                {
                    Id = "TRAIH", Address = "722 DaVinci Blvd.", City = "Kirkland",
                    CompanyName = "Trail's Head Gourmet Provisioners", ContactName = "Helvetius Nagy",
                    ContactTitle = "Sales Associate", Country = "USA", Fax = "(206) 555-2174", Phone = "(206) 555-8257",
                    PostalCode = "98034", Region = "WA"
                },
                new Customer
                {
                    Id = "VAFFE", Address = "Smagsloget 45", City = "Århus", CompanyName = "Vaffeljernet",
                    ContactName = "Palle Ibsen", ContactTitle = "Sales Manager", Country = "Denmark",
                    Fax = "86 22 33 44", Phone = "86 21 32 43", PostalCode = "8200"
                },
                new Customer
                {
                    Id = "VICTE", Address = "2, rue du Commerce", City = "Lyon", CompanyName = "Victuailles en stock",
                    ContactName = "Mary Saveley", ContactTitle = "Sales Agent", Country = "France", Fax = "78.32.54.87",
                    Phone = "78.32.54.86", PostalCode = "69004"
                },
                new Customer
                {
                    Id = "VINET", Address = "59 rue de l'Abbaye", City = "Reims",
                    CompanyName = "Vins et alcools Chevalier", ContactName = "Paul Henriot",
                    ContactTitle = "Accounting Manager", Country = "France", Fax = "26.47.15.11", Phone = "26.47.15.10",
                    PostalCode = "51100"
                },
                new Customer
                {
                    Id = "WANDK", Address = "Adenauerallee 900", City = "Stuttgart", CompanyName = "Die Wandernde Kuh",
                    ContactName = "Rita Müller", ContactTitle = "Sales Representative", Country = "Germany",
                    Fax = "0711-035428", Phone = "0711-020361", PostalCode = "70563"
                },
                new Customer
                {
                    Id = "WARTH", Address = "Torikatu 38", City = "Oulu", CompanyName = "Wartian Herkku",
                    ContactName = "Pirkko Koskitalo", ContactTitle = "Accounting Manager", Country = "Finland",
                    Fax = "981-443655", Phone = "981-443655", PostalCode = "90110"
                },
                new Customer
                {
                    Id = "WELLI", Address = "Rua do Mercado, 12", City = "Resende",
                    CompanyName = "Wellington Importadora", ContactName = "Paula Parente",
                    ContactTitle = "Sales Manager", Country = "Brazil", Fax = "", Phone = "(14) 555-8122",
                    PostalCode = "08737-363", Region = "SP"
                },
                new Customer
                {
                    Id = "WHITC", Address = "305 - 14th Ave. S. Suite 3B", City = "Seattle",
                    CompanyName = "White Clover Markets", ContactName = "Karl Jablonski", ContactTitle = "Owner",
                    Country = "USA", Fax = "(206) 555-4115", Phone = "(206) 555-4112", PostalCode = "98128",
                    Region = "WA"
                },
                new Customer
                {
                    Id = "WILMK", Address = "Keskuskatu 45", City = "Helsinki", CompanyName = "Wilman Kala",
                    ContactName = "Matti Karttunen", ContactTitle = "Owner/Marketing Assistant", Country = "Finland",
                    Fax = "90-224 8858", Phone = "90-224 8858", PostalCode = "21240"
                },
                new Customer
                {
                    Id = "WOLZA", Address = "ul. Filtrowa 68", City = "Warszawa", CompanyName = "Wolski  Zajazd",
                    ContactName = "Zbyszek Piestrzeniewicz", ContactTitle = "Owner", Country = "Poland",
                    Fax = "(26) 642-7012", Phone = "(26) 642-7012", PostalCode = "01-012"
                },
                new Customer
                {
                    Id = "JASON", Address = "ul. Filtrowa 68", City = "Warszawa", CompanyName = "Wolski  Zajazd",
                    ContactName = "Zbyszek Piestrzeniewicz", ContactTitle = "Owner", Country = "Poland",
                    Fax = "(26) 642-7012", Phone = "(26) 642-7012", PostalCode = "01-012"
                }
            });

      return customers;
    }



  }
}