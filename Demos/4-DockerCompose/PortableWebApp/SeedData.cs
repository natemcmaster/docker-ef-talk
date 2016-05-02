namespace PortableWebApp
{
    public class SeedData
    {
         public static Customer[] CreateCustomers()
            => new[]
            {
                new Customer
                {
                    CustomerID = "ALFKI",
                    CompanyName = "Alfreds Futterkiste",
                    ContactName = "Maria Anders",
                    ContactTitle = "Sales Representative",
                    Address = "Obere Str. 57",
                    City = "Berlin",
                    Region = null,
                    PostalCode = "12209",
                    Country = "Germany",
                    Phone = "030-0074321",
                    Fax = "030-0076545"
                },
                new Customer
                {
                    CustomerID = "ANATR",
                    CompanyName = "Ana Trujillo Emparedados y helados",
                    ContactName = "Ana Trujillo",
                    ContactTitle = "Owner",
                    Address = "Avda. de la Constitución 2222",
                    City = "México D.F.",
                    Region = null,
                    PostalCode = "05021",
                    Country = "Mexico",
                    Phone = "(5) 555-4729",
                    Fax = "(5) 555-3745"
                },
                new Customer
                {
                    CustomerID = "ANTON",
                    CompanyName = "Antonio Moreno Taquería",
                    ContactName = "Antonio Moreno",
                    ContactTitle = "Owner",
                    Address = "Mataderos  2312",
                    City = "México D.F.",
                    Region = null,
                    PostalCode = "05023",
                    Country = "Mexico",
                    Phone = "(5) 555-3932",
                    Fax = null
                },
                new Customer
                {
                    CustomerID = "AROUT",
                    CompanyName = "Around the Horn",
                    ContactName = "Thomas Hardy",
                    ContactTitle = "Sales Representative",
                    Address = "120 Hanover Sq.",
                    City = "London",
                    Region = null,
                    PostalCode = "WA1 1DP",
                    Country = "UK",
                    Phone = "(171) 555-7788",
                    Fax = "(171) 555-6750"
                },
                new Customer
                {
                    CustomerID = "BERGS",
                    CompanyName = "Berglunds snabbköp",
                    ContactName = "Christina Berglund",
                    ContactTitle = "Order Administrator",
                    Address = "Berguvsvägen  8",
                    City = "Luleå",
                    Region = null,
                    PostalCode = "S-958 22",
                    Country = "Sweden",
                    Phone = "0921-12 34 65",
                    Fax = "0921-12 34 67"
                },
                new Customer
                {
                    CustomerID = "BLAUS",
                    CompanyName = "Blauer See Delikatessen",
                    ContactName = "Hanna Moos",
                    ContactTitle = "Sales Representative",
                    Address = "Forsterstr. 57",
                    City = "Mannheim",
                    Region = null,
                    PostalCode = "68306",
                    Country = "Germany",
                    Phone = "0621-08460",
                    Fax = "0621-08924"
                },
                new Customer
                {
                    CustomerID = "BLONP",
                    CompanyName = "Blondesddsl père et fils",
                    ContactName = "Frédérique Citeaux",
                    ContactTitle = "Marketing Manager",
                    Address = "24, place Kléber",
                    City = "Strasbourg",
                    Region = null,
                    PostalCode = "67000",
                    Country = "France",
                    Phone = "88.60.15.31",
                    Fax = "88.60.15.32"
                },
                new Customer
                {
                    CustomerID = "BOLID",
                    CompanyName = "Bólido Comidas preparadas",
                    ContactName = "Martín Sommer",
                    ContactTitle = "Owner",
                    Address = "C/ Araquil, 67",
                    City = "Madrid",
                    Region = null,
                    PostalCode = "28023",
                    Country = "Spain",
                    Phone = "(91) 555 22 82",
                    Fax = "(91) 555 91 99"
                },
                new Customer
                {
                    CustomerID = "BONAP",
                    CompanyName = "Bon app'",
                    ContactName = "Laurence Lebihan",
                    ContactTitle = "Owner",
                    Address = "12, rue des Bouchers",
                    City = "Marseille",
                    Region = null,
                    PostalCode = "13008",
                    Country = "France",
                    Phone = "91.24.45.40",
                    Fax = "91.24.45.41"
                },
                new Customer
                {
                    CustomerID = "BOTTM",
                    CompanyName = "Bottom-Dollar Markets",
                    ContactName = "Elizabeth Lincoln",
                    ContactTitle = "Accounting Manager",
                    Address = "23 Tsawassen Blvd.",
                    City = "Tsawassen",
                    Region = "BC",
                    PostalCode = "T2F 8M4",
                    Country = "Canada",
                    Phone = "(604) 555-4729",
                    Fax = "(604) 555-3745"
                },
                new Customer
                {
                    CustomerID = "BSBEV",
                    CompanyName = "B's Beverages",
                    ContactName = "Victoria Ashworth",
                    ContactTitle = "Sales Representative",
                    Address = "Fauntleroy Circus",
                    City = "London",
                    Region = null,
                    PostalCode = "EC2 5NT",
                    Country = "UK",
                    Phone = "(171) 555-1212",
                    Fax = null
                },
                new Customer
                {
                    CustomerID = "CACTU",
                    CompanyName = "Cactus Comidas para llevar",
                    ContactName = "Patricio Simpson",
                    ContactTitle = "Sales Agent",
                    Address = "Cerrito 333",
                    City = "Buenos Aires",
                    Region = null,
                    PostalCode = "1010",
                    Country = "Argentina",
                    Phone = "(1) 135-5555",
                    Fax = "(1) 135-4892"
                },
                new Customer
                {
                    CustomerID = "CENTC",
                    CompanyName = "Centro comercial Moctezuma",
                    ContactName = "Francisco Chang",
                    ContactTitle = "Marketing Manager",
                    Address = "Sierras de Granada 9993",
                    City = "México D.F.",
                    Region = null,
                    PostalCode = "05022",
                    Country = "Mexico",
                    Phone = "(5) 555-3392",
                    Fax = "(5) 555-7293"
                },
                new Customer
                {
                    CustomerID = "CHOPS",
                    CompanyName = "Chop-suey Chinese",
                    ContactName = "Yang Wang",
                    ContactTitle = "Owner",
                    Address = "Hauptstr. 29",
                    City = "Bern",
                    Region = null,
                    PostalCode = "3012",
                    Country = "Switzerland",
                    Phone = "0452-076545",
                    Fax = null
                },
                new Customer
                {
                    CustomerID = "COMMI",
                    CompanyName = "Comércio Mineiro",
                    ContactName = "Pedro Afonso",
                    ContactTitle = "Sales Associate",
                    Address = "Av. dos Lusíadas, 23",
                    City = "Sao Paulo",
                    Region = "SP",
                    PostalCode = "05432-043",
                    Country = "Brazil",
                    Phone = "(11) 555-7647",
                    Fax = null
                },
                new Customer
                {
                    CustomerID = "CONSH",
                    CompanyName = "Consolidated Holdings",
                    ContactName = "Elizabeth Brown",
                    ContactTitle = "Sales Representative",
                    Address = "Berkeley Gardens 12  Brewery",
                    City = "London",
                    Region = null,
                    PostalCode = "WX1 6LT",
                    Country = "UK",
                    Phone = "(171) 555-2282",
                    Fax = "(171) 555-9199"
                },
                new Customer
                {
                    CustomerID = "DRACD",
                    CompanyName = "Drachenblut Delikatessen",
                    ContactName = "Sven Ottlieb",
                    ContactTitle = "Order Administrator",
                    Address = "Walserweg 21",
                    City = "Aachen",
                    Region = null,
                    PostalCode = "52066",
                    Country = "Germany",
                    Phone = "0241-039123",
                    Fax = "0241-059428"
                },
                new Customer
                {
                    CustomerID = "DUMON",
                    CompanyName = "Du monde entier",
                    ContactName = "Janine Labrune",
                    ContactTitle = "Owner",
                    Address = "67, rue des Cinquante Otages",
                    City = "Nantes",
                    Region = null,
                    PostalCode = "44000",
                    Country = "France",
                    Phone = "40.67.88.88",
                    Fax = "40.67.89.89"
                },
                new Customer
                {
                    CustomerID = "EASTC",
                    CompanyName = "Eastern Connection",
                    ContactName = "Ann Devon",
                    ContactTitle = "Sales Agent",
                    Address = "35 King George",
                    City = "London",
                    Region = null,
                    PostalCode = "WX3 6FW",
                    Country = "UK",
                    Phone = "(171) 555-0297",
                    Fax = "(171) 555-3373"
                },
                new Customer
                {
                    CustomerID = "ERNSH",
                    CompanyName = "Ernst Handel",
                    ContactName = "Roland Mendel",
                    ContactTitle = "Sales Manager",
                    Address = "Kirchgasse 6",
                    City = "Graz",
                    Region = null,
                    PostalCode = "8010",
                    Country = "Austria",
                    Phone = "7675-3425",
                    Fax = "7675-3426"
                },
                new Customer
                {
                    CustomerID = "FAMIA",
                    CompanyName = "Familia Arquibaldo",
                    ContactName = "Aria Cruz",
                    ContactTitle = "Marketing Assistant",
                    Address = "Rua Orós, 92",
                    City = "Sao Paulo",
                    Region = "SP",
                    PostalCode = "05442-030",
                    Country = "Brazil",
                    Phone = "(11) 555-9857",
                    Fax = null
                },
                new Customer
                {
                    CustomerID = "FISSA",
                    CompanyName = "FISSA Fabrica Inter. Salchichas S.A.",
                    ContactName = "Diego Roel",
                    ContactTitle = "Accounting Manager",
                    Address = "C/ Moralzarzal, 86",
                    City = "Madrid",
                    Region = null,
                    PostalCode = "28034",
                    Country = "Spain",
                    Phone = "(91) 555 94 44",
                    Fax = "(91) 555 55 93"
                },
                new Customer
                {
                    CustomerID = "FOLIG",
                    CompanyName = "Folies gourmandes",
                    ContactName = "Martine Rancé",
                    ContactTitle = "Assistant Sales Agent",
                    Address = "184, chaussée de Tournai",
                    City = "Lille",
                    Region = null,
                    PostalCode = "59000",
                    Country = "France",
                    Phone = "20.16.10.16",
                    Fax = "20.16.10.17"
                },
                new Customer
                {
                    CustomerID = "FOLKO",
                    CompanyName = "Folk och fä HB",
                    ContactName = "Maria Larsson",
                    ContactTitle = "Owner",
                    Address = "Åkergatan 24",
                    City = "Bräcke",
                    Region = null,
                    PostalCode = "S-844 67",
                    Country = "Sweden",
                    Phone = "0695-34 67 21",
                    Fax = null
                },
                new Customer
                {
                    CustomerID = "FRANK",
                    CompanyName = "Frankenversand",
                    ContactName = "Peter Franken",
                    ContactTitle = "Marketing Manager",
                    Address = "Berliner Platz 43",
                    City = "München",
                    Region = null,
                    PostalCode = "80805",
                    Country = "Germany",
                    Phone = "089-0877310",
                    Fax = "089-0877451"
                },
                new Customer
                {
                    CustomerID = "FRANR",
                    CompanyName = "France restauration",
                    ContactName = "Carine Schmitt",
                    ContactTitle = "Marketing Manager",
                    Address = "54, rue Royale",
                    City = "Nantes",
                    Region = null,
                    PostalCode = "44000",
                    Country = "France",
                    Phone = "40.32.21.21",
                    Fax = "40.32.21.20"
                },
                new Customer
                {
                    CustomerID = "FRANS",
                    CompanyName = "Franchi S.p.A.",
                    ContactName = "Paolo Accorti",
                    ContactTitle = "Sales Representative",
                    Address = "Via Monte Bianco 34",
                    City = "Torino",
                    Region = null,
                    PostalCode = "10100",
                    Country = "Italy",
                    Phone = "011-4988260",
                    Fax = "011-4988261"
                },
                new Customer
                {
                    CustomerID = "FURIB",
                    CompanyName = "Furia Bacalhau e Frutos do Mar",
                    ContactName = "Lino Rodriguez",
                    ContactTitle = "Sales Manager",
                    Address = "Jardim das rosas n. 32",
                    City = "Lisboa",
                    Region = null,
                    PostalCode = "1675",
                    Country = "Portugal",
                    Phone = "(1) 354-2534",
                    Fax = "(1) 354-2535"
                },
                new Customer
                {
                    CustomerID = "GALED",
                    CompanyName = "Galería del gastrónomo",
                    ContactName = "Eduardo Saavedra",
                    ContactTitle = "Marketing Manager",
                    Address = "Rambla de Cataluña, 23",
                    City = "Barcelona",
                    Region = null,
                    PostalCode = "08022",
                    Country = "Spain",
                    Phone = "(93) 203 4560",
                    Fax = "(93) 203 4561"
                },
                new Customer
                {
                    CustomerID = "GODOS",
                    CompanyName = "Godos Cocina Típica",
                    ContactName = "José Pedro Freyre",
                    ContactTitle = "Sales Manager",
                    Address = "C/ Romero, 33",
                    City = "Sevilla",
                    Region = null,
                    PostalCode = "41101",
                    Country = "Spain",
                    Phone = "(95) 555 82 82",
                    Fax = null
                },
                new Customer
                {
                    CustomerID = "GOURL",
                    CompanyName = "Gourmet Lanchonetes",
                    ContactName = "André Fonseca",
                    ContactTitle = "Sales Associate",
                    Address = "Av. Brasil, 442",
                    City = "Campinas",
                    Region = "SP",
                    PostalCode = "04876-786",
                    Country = "Brazil",
                    Phone = "(11) 555-9482",
                    Fax = null
                },
                new Customer
                {
                    CustomerID = "GREAL",
                    CompanyName = "Great Lakes Food Market",
                    ContactName = "Howard Snyder",
                    ContactTitle = "Marketing Manager",
                    Address = "2732 Baker Blvd.",
                    City = "Eugene",
                    Region = "OR",
                    PostalCode = "97403",
                    Country = "USA",
                    Phone = "(503) 555-7555",
                    Fax = null
                },
                new Customer
                {
                    CustomerID = "GROSR",
                    CompanyName = "GROSELLA-Restaurante",
                    ContactName = "Manuel Pereira",
                    ContactTitle = "Owner",
                    Address = "5ª Ave. Los Palos Grandes",
                    City = "Caracas",
                    Region = "DF",
                    PostalCode = "1081",
                    Country = "Venezuela",
                    Phone = "(2) 283-2951",
                    Fax = "(2) 283-3397"
                },
                new Customer
                {
                    CustomerID = "HANAR",
                    CompanyName = "Hanari Carnes",
                    ContactName = "Mario Pontes",
                    ContactTitle = "Accounting Manager",
                    Address = "Rua do Paço, 67",
                    City = "Rio de Janeiro",
                    Region = "RJ",
                    PostalCode = "05454-876",
                    Country = "Brazil",
                    Phone = "(21) 555-0091",
                    Fax = "(21) 555-8765"
                },
                new Customer
                {
                    CustomerID = "HILAA",
                    CompanyName = "HILARION-Abastos",
                    ContactName = "Carlos Hernández",
                    ContactTitle = "Sales Representative",
                    Address = "Carrera 22 con Ave. Carlos Soublette #8-35",
                    City = "San Cristóbal",
                    Region = "Táchira",
                    PostalCode = "5022",
                    Country = "Venezuela",
                    Phone = "(5) 555-1340",
                    Fax = "(5) 555-1948"
                },
                new Customer
                {
                    CustomerID = "HUNGC",
                    CompanyName = "Hungry Coyote Import Store",
                    ContactName = "Yoshi Latimer",
                    ContactTitle = "Sales Representative",
                    Address = "City Center Plaza 516 Main St.",
                    City = "Elgin",
                    Region = "OR",
                    PostalCode = "97827",
                    Country = "USA",
                    Phone = "(503) 555-6874",
                    Fax = "(503) 555-2376"
                },
                new Customer
                {
                    CustomerID = "HUNGO",
                    CompanyName = "Hungry Owl All-Night Grocers",
                    ContactName = "Patricia McKenna",
                    ContactTitle = "Sales Associate",
                    Address = "8 Johnstown Road",
                    City = "Cork",
                    Region = "Co. Cork",
                    PostalCode = null,
                    Country = "Ireland",
                    Phone = "2967 542",
                    Fax = "2967 3333"
                },
                new Customer
                {
                    CustomerID = "ISLAT",
                    CompanyName = "Island Trading",
                    ContactName = "Helen Bennett",
                    ContactTitle = "Marketing Manager",
                    Address = "Garden House Crowther Way",
                    City = "Cowes",
                    Region = "Isle of Wight",
                    PostalCode = "PO31 7PJ",
                    Country = "UK",
                    Phone = "(198) 555-8888",
                    Fax = null
                },
                new Customer
                {
                    CustomerID = "KOENE",
                    CompanyName = "Königlich Essen",
                    ContactName = "Philip Cramer",
                    ContactTitle = "Sales Associate",
                    Address = "Maubelstr. 90",
                    City = "Brandenburg",
                    Region = null,
                    PostalCode = "14776",
                    Country = "Germany",
                    Phone = "0555-09876",
                    Fax = null
                },
                new Customer
                {
                    CustomerID = "LACOR",
                    CompanyName = "La corne d'abondance",
                    ContactName = "Daniel Tonini",
                    ContactTitle = "Sales Representative",
                    Address = "67, avenue de l'Europe",
                    City = "Versailles",
                    Region = null,
                    PostalCode = "78000",
                    Country = "France",
                    Phone = "30.59.84.10",
                    Fax = "30.59.85.11"
                },
                new Customer
                {
                    CustomerID = "LAMAI",
                    CompanyName = "La maison d'Asie",
                    ContactName = "Annette Roulet",
                    ContactTitle = "Sales Manager",
                    Address = "1 rue Alsace-Lorraine",
                    City = "Toulouse",
                    Region = null,
                    PostalCode = "31000",
                    Country = "France",
                    Phone = "61.77.61.10",
                    Fax = "61.77.61.11"
                },
                new Customer
                {
                    CustomerID = "LAUGB",
                    CompanyName = "Laughing Bacchus Wine Cellars",
                    ContactName = "Yoshi Tannamuri",
                    ContactTitle = "Marketing Assistant",
                    Address = "1900 Oak St.",
                    City = "Vancouver",
                    Region = "BC",
                    PostalCode = "V3F 2K1",
                    Country = "Canada",
                    Phone = "(604) 555-3392",
                    Fax = "(604) 555-7293"
                },
                new Customer
                {
                    CustomerID = "LAZYK",
                    CompanyName = "Lazy K Kountry Store",
                    ContactName = "John Steel",
                    ContactTitle = "Marketing Manager",
                    Address = "12 Orchestra Terrace",
                    City = "Walla Walla",
                    Region = "WA",
                    PostalCode = "99362",
                    Country = "USA",
                    Phone = "(509) 555-7969",
                    Fax = "(509) 555-6221"
                },
                new Customer
                {
                    CustomerID = "LEHMS",
                    CompanyName = "Lehmanns Marktstand",
                    ContactName = "Renate Messner",
                    ContactTitle = "Sales Representative",
                    Address = "Magazinweg 7",
                    City = "Frankfurt a.M.",
                    Region = null,
                    PostalCode = "60528",
                    Country = "Germany",
                    Phone = "069-0245984",
                    Fax = "069-0245874"
                },
                new Customer
                {
                    CustomerID = "LETSS",
                    CompanyName = "Let's Stop N Shop",
                    ContactName = "Jaime Yorres",
                    ContactTitle = "Owner",
                    Address = "87 Polk St. Suite 5",
                    City = "San Francisco",
                    Region = "CA",
                    PostalCode = "94117",
                    Country = "USA",
                    Phone = "(415) 555-5938",
                    Fax = null
                },
                new Customer
                {
                    CustomerID = "LILAS",
                    CompanyName = "LILA-Supermercado",
                    ContactName = "Carlos González",
                    ContactTitle = "Accounting Manager",
                    Address = "Carrera 52 con Ave. Bolívar #65-98 Llano Largo",
                    City = "Barquisimeto",
                    Region = "Lara",
                    PostalCode = "3508",
                    Country = "Venezuela",
                    Phone = "(9) 331-6954",
                    Fax = "(9) 331-7256"
                },
                new Customer
                {
                    CustomerID = "LINOD",
                    CompanyName = "LINO-Delicateses",
                    ContactName = "Felipe Izquierdo",
                    ContactTitle = "Owner",
                    Address = "Ave. 5 de Mayo Porlamar",
                    City = "I. de Margarita",
                    Region = "Nueva Esparta",
                    PostalCode = "4980",
                    Country = "Venezuela",
                    Phone = "(8) 34-56-12",
                    Fax = "(8) 34-93-93"
                },
                new Customer
                {
                    CustomerID = "LONEP",
                    CompanyName = "Lonesome Pine Restaurant",
                    ContactName = "Fran Wilson",
                    ContactTitle = "Sales Manager",
                    Address = "89 Chiaroscuro Rd.",
                    City = "Portland",
                    Region = "OR",
                    PostalCode = "97219",
                    Country = "USA",
                    Phone = "(503) 555-9573",
                    Fax = "(503) 555-9646"
                },
                new Customer
                {
                    CustomerID = "MAGAA",
                    CompanyName = "Magazzini Alimentari Riuniti",
                    ContactName = "Giovanni Rovelli",
                    ContactTitle = "Marketing Manager",
                    Address = "Via Ludovico il Moro 22",
                    City = "Bergamo",
                    Region = null,
                    PostalCode = "24100",
                    Country = "Italy",
                    Phone = "035-640230",
                    Fax = "035-640231"
                },
                new Customer
                {
                    CustomerID = "MAISD",
                    CompanyName = "Maison Dewey",
                    ContactName = "Catherine Dewey",
                    ContactTitle = "Sales Agent",
                    Address = "Rue Joseph-Bens 532",
                    City = "Bruxelles",
                    Region = null,
                    PostalCode = "B-1180",
                    Country = "Belgium",
                    Phone = "(02) 201 24 67",
                    Fax = "(02) 201 24 68"
                },
                new Customer
                {
                    CustomerID = "MEREP",
                    CompanyName = "Mère Paillarde",
                    ContactName = "Jean Fresnière",
                    ContactTitle = "Marketing Assistant",
                    Address = "43 rue St. Laurent",
                    City = "Montréal",
                    Region = "Québec",
                    PostalCode = "H1J 1C3",
                    Country = "Canada",
                    Phone = "(514) 555-8054",
                    Fax = "(514) 555-8055"
                },
                new Customer
                {
                    CustomerID = "MORGK",
                    CompanyName = "Morgenstern Gesundkost",
                    ContactName = "Alexander Feuer",
                    ContactTitle = "Marketing Assistant",
                    Address = "Heerstr. 22",
                    City = "Leipzig",
                    Region = null,
                    PostalCode = "04179",
                    Country = "Germany",
                    Phone = "0342-023176",
                    Fax = null
                },
                new Customer
                {
                    CustomerID = "NORTS",
                    CompanyName = "North/South",
                    ContactName = "Simon Crowther",
                    ContactTitle = "Sales Associate",
                    Address = "South House 300 Queensbridge",
                    City = "London",
                    Region = null,
                    PostalCode = "SW7 1RZ",
                    Country = "UK",
                    Phone = "(171) 555-7733",
                    Fax = "(171) 555-2530"
                },
                new Customer
                {
                    CustomerID = "OCEAN",
                    CompanyName = "Océano Atlántico Ltda.",
                    ContactName = "Yvonne Moncada",
                    ContactTitle = "Sales Agent",
                    Address = "Ing. Gustavo Moncada 8585 Piso 20-A",
                    City = "Buenos Aires",
                    Region = null,
                    PostalCode = "1010",
                    Country = "Argentina",
                    Phone = "(1) 135-5333",
                    Fax = "(1) 135-5535"
                },
                new Customer
                {
                    CustomerID = "OLDWO",
                    CompanyName = "Old World Delicatessen",
                    ContactName = "Rene Phillips",
                    ContactTitle = "Sales Representative",
                    Address = "2743 Bering St.",
                    City = "Anchorage",
                    Region = "AK",
                    PostalCode = "99508",
                    Country = "USA",
                    Phone = "(907) 555-7584",
                    Fax = "(907) 555-2880"
                },
                new Customer
                {
                    CustomerID = "OTTIK",
                    CompanyName = "Ottilies Käseladen",
                    ContactName = "Henriette Pfalzheim",
                    ContactTitle = "Owner",
                    Address = "Mehrheimerstr. 369",
                    City = "Köln",
                    Region = null,
                    PostalCode = "50739",
                    Country = "Germany",
                    Phone = "0221-0644327",
                    Fax = "0221-0765721"
                },
                new Customer
                {
                    CustomerID = "PARIS",
                    CompanyName = "Paris spécialités",
                    ContactName = "Marie Bertrand",
                    ContactTitle = "Owner",
                    Address = "265, boulevard Charonne",
                    City = "Paris",
                    Region = null,
                    PostalCode = "75012",
                    Country = "France",
                    Phone = "(1) 42.34.22.66",
                    Fax = "(1) 42.34.22.77"
                },
                new Customer
                {
                    CustomerID = "PERIC",
                    CompanyName = "Pericles Comidas clásicas",
                    ContactName = "Guillermo Fernández",
                    ContactTitle = "Sales Representative",
                    Address = "Calle Dr. Jorge Cash 321",
                    City = "México D.F.",
                    Region = null,
                    PostalCode = "05033",
                    Country = "Mexico",
                    Phone = "(5) 552-3745",
                    Fax = "(5) 545-3745"
                },
                new Customer
                {
                    CustomerID = "PICCO",
                    CompanyName = "Piccolo und mehr",
                    ContactName = "Georg Pipps",
                    ContactTitle = "Sales Manager",
                    Address = "Geislweg 14",
                    City = "Salzburg",
                    Region = null,
                    PostalCode = "5020",
                    Country = "Austria",
                    Phone = "6562-9722",
                    Fax = "6562-9723"
                },
                new Customer
                {
                    CustomerID = "PRINI",
                    CompanyName = "Princesa Isabel Vinhos",
                    ContactName = "Isabel de Castro",
                    ContactTitle = "Sales Representative",
                    Address = "Estrada da saúde n. 58",
                    City = "Lisboa",
                    Region = null,
                    PostalCode = "1756",
                    Country = "Portugal",
                    Phone = "(1) 356-5634",
                    Fax = null
                },
                new Customer
                {
                    CustomerID = "QUEDE",
                    CompanyName = "Que Delícia",
                    ContactName = "Bernardo Batista",
                    ContactTitle = "Accounting Manager",
                    Address = "Rua da Panificadora, 12",
                    City = "Rio de Janeiro",
                    Region = "RJ",
                    PostalCode = "02389-673",
                    Country = "Brazil",
                    Phone = "(21) 555-4252",
                    Fax = "(21) 555-4545"
                },
                new Customer
                {
                    CustomerID = "QUEEN",
                    CompanyName = "Queen Cozinha",
                    ContactName = "Lúcia Carvalho",
                    ContactTitle = "Marketing Assistant",
                    Address = "Alameda dos Canàrios, 891",
                    City = "Sao Paulo",
                    Region = "SP",
                    PostalCode = "05487-020",
                    Country = "Brazil",
                    Phone = "(11) 555-1189",
                    Fax = null
                },
                new Customer
                {
                    CustomerID = "QUICK",
                    CompanyName = "QUICK-Stop",
                    ContactName = "Horst Kloss",
                    ContactTitle = "Accounting Manager",
                    Address = "Taucherstraße 10",
                    City = "Cunewalde",
                    Region = null,
                    PostalCode = "01307",
                    Country = "Germany",
                    Phone = "0372-035188",
                    Fax = null
                },
                new Customer
                {
                    CustomerID = "RANCH",
                    CompanyName = "Rancho grande",
                    ContactName = "Sergio Gutiérrez",
                    ContactTitle = "Sales Representative",
                    Address = "Av. del Libertador 900",
                    City = "Buenos Aires",
                    Region = null,
                    PostalCode = "1010",
                    Country = "Argentina",
                    Phone = "(1) 123-5555",
                    Fax = "(1) 123-5556"
                },
                new Customer
                {
                    CustomerID = "RATTC",
                    CompanyName = "Rattlesnake Canyon Grocery",
                    ContactName = "Paula Wilson",
                    ContactTitle = "Assistant Sales Representative",
                    Address = "2817 Milton Dr.",
                    City = "Albuquerque",
                    Region = "NM",
                    PostalCode = "87110",
                    Country = "USA",
                    Phone = "(505) 555-5939",
                    Fax = "(505) 555-3620"
                },
                new Customer
                {
                    CustomerID = "REGGC",
                    CompanyName = "Reggiani Caseifici",
                    ContactName = "Maurizio Moroni",
                    ContactTitle = "Sales Associate",
                    Address = "Strada Provinciale 124",
                    City = "Reggio Emilia",
                    Region = null,
                    PostalCode = "42100",
                    Country = "Italy",
                    Phone = "0522-556721",
                    Fax = "0522-556722"
                },
                new Customer
                {
                    CustomerID = "RICAR",
                    CompanyName = "Ricardo Adocicados",
                    ContactName = "Janete Limeira",
                    ContactTitle = "Assistant Sales Agent",
                    Address = "Av. Copacabana, 267",
                    City = "Rio de Janeiro",
                    Region = "RJ",
                    PostalCode = "02389-890",
                    Country = "Brazil",
                    Phone = "(21) 555-3412",
                    Fax = null
                },
                new Customer
                {
                    CustomerID = "RICSU",
                    CompanyName = "Richter Supermarkt",
                    ContactName = "Michael Holz",
                    ContactTitle = "Sales Manager",
                    Address = "Grenzacherweg 237",
                    City = "Genève",
                    Region = null,
                    PostalCode = "1203",
                    Country = "Switzerland",
                    Phone = "0897-034214",
                    Fax = null
                },
                new Customer
                {
                    CustomerID = "ROMEY",
                    CompanyName = "Romero y tomillo",
                    ContactName = "Alejandra Camino",
                    ContactTitle = "Accounting Manager",
                    Address = "Gran Vía, 1",
                    City = "Madrid",
                    Region = null,
                    PostalCode = "28001",
                    Country = "Spain",
                    Phone = "(91) 745 6200",
                    Fax = "(91) 745 6210"
                },
                new Customer
                {
                    CustomerID = "SANTG",
                    CompanyName = "Santé Gourmet",
                    ContactName = "Jonas Bergulfsen",
                    ContactTitle = "Owner",
                    Address = "Erling Skakkes gate 78",
                    City = "Stavern",
                    Region = null,
                    PostalCode = "4110",
                    Country = "Norway",
                    Phone = "07-98 92 35",
                    Fax = "07-98 92 47"
                },
                new Customer
                {
                    CustomerID = "SAVEA",
                    CompanyName = "Save-a-lot Markets",
                    ContactName = "Jose Pavarotti",
                    ContactTitle = "Sales Representative",
                    Address = "187 Suffolk Ln.",
                    City = "Boise",
                    Region = "ID",
                    PostalCode = "83720",
                    Country = "USA",
                    Phone = "(208) 555-8097",
                    Fax = null
                },
                new Customer
                {
                    CustomerID = "SEVES",
                    CompanyName = "Seven Seas Imports",
                    ContactName = "Hari Kumar",
                    ContactTitle = "Sales Manager",
                    Address = "90 Wadhurst Rd.",
                    City = "London",
                    Region = null,
                    PostalCode = "OX15 4NB",
                    Country = "UK",
                    Phone = "(171) 555-1717",
                    Fax = "(171) 555-5646"
                },
                new Customer
                {
                    CustomerID = "SIMOB",
                    CompanyName = "Simons bistro",
                    ContactName = "Jytte Petersen",
                    ContactTitle = "Owner",
                    Address = "Vinbæltet 34",
                    City = "Kobenhavn",
                    Region = null,
                    PostalCode = "1734",
                    Country = "Denmark",
                    Phone = "31 12 34 56",
                    Fax = "31 13 35 57"
                },
                new Customer
                {
                    CustomerID = "SPECD",
                    CompanyName = "Spécialités du monde",
                    ContactName = "Dominique Perrier",
                    ContactTitle = "Marketing Manager",
                    Address = "25, rue Lauriston",
                    City = "Paris",
                    Region = null,
                    PostalCode = "75016",
                    Country = "France",
                    Phone = "(1) 47.55.60.10",
                    Fax = "(1) 47.55.60.20"
                },
                new Customer
                {
                    CustomerID = "SPLIR",
                    CompanyName = "Split Rail Beer & Ale",
                    ContactName = "Art Braunschweiger",
                    ContactTitle = "Sales Manager",
                    Address = "P.O. Box 555",
                    City = "Lander",
                    Region = "WY",
                    PostalCode = "82520",
                    Country = "USA",
                    Phone = "(307) 555-4680",
                    Fax = "(307) 555-6525"
                },
                new Customer
                {
                    CustomerID = "SUPRD",
                    CompanyName = "Suprêmes délices",
                    ContactName = "Pascale Cartrain",
                    ContactTitle = "Accounting Manager",
                    Address = "Boulevard Tirou, 255",
                    City = "Charleroi",
                    Region = null,
                    PostalCode = "B-6000",
                    Country = "Belgium",
                    Phone = "(071) 23 67 22 20",
                    Fax = "(071) 23 67 22 21"
                },
                new Customer
                {
                    CustomerID = "THEBI",
                    CompanyName = "The Big Cheese",
                    ContactName = "Liz Nixon",
                    ContactTitle = "Marketing Manager",
                    Address = "89 Jefferson Way Suite 2",
                    City = "Portland",
                    Region = "OR",
                    PostalCode = "97201",
                    Country = "USA",
                    Phone = "(503) 555-3612",
                    Fax = null
                },
                new Customer
                {
                    CustomerID = "THECR",
                    CompanyName = "The Cracker Box",
                    ContactName = "Liu Wong",
                    ContactTitle = "Marketing Assistant",
                    Address = "55 Grizzly Peak Rd.",
                    City = "Butte",
                    Region = "MT",
                    PostalCode = "59801",
                    Country = "USA",
                    Phone = "(406) 555-5834",
                    Fax = "(406) 555-8083"
                },
                new Customer
                {
                    CustomerID = "TOMSP",
                    CompanyName = "Toms Spezialitäten",
                    ContactName = "Karin Josephs",
                    ContactTitle = "Marketing Manager",
                    Address = "Luisenstr. 48",
                    City = "Münster",
                    Region = null,
                    PostalCode = "44087",
                    Country = "Germany",
                    Phone = "0251-031259",
                    Fax = "0251-035695"
                },
                new Customer
                {
                    CustomerID = "TORTU",
                    CompanyName = "Tortuga Restaurante",
                    ContactName = "Miguel Angel Paolino",
                    ContactTitle = "Owner",
                    Address = "Avda. Azteca 123",
                    City = "México D.F.",
                    Region = null,
                    PostalCode = "05033",
                    Country = "Mexico",
                    Phone = "(5) 555-2933",
                    Fax = null
                },
                new Customer
                {
                    CustomerID = "TRADH",
                    CompanyName = "Tradição Hipermercados",
                    ContactName = "Anabela Domingues",
                    ContactTitle = "Sales Representative",
                    Address = "Av. Inês de Castro, 414",
                    City = "Sao Paulo",
                    Region = "SP",
                    PostalCode = "05634-030",
                    Country = "Brazil",
                    Phone = "(11) 555-2167",
                    Fax = "(11) 555-2168"
                },
                new Customer
                {
                    CustomerID = "TRAIH",
                    CompanyName = "Trail's Head Gourmet Provisioners",
                    ContactName = "Helvetius Nagy",
                    ContactTitle = "Sales Associate",
                    Address = "722 DaVinci Blvd.",
                    City = "Kirkland",
                    Region = "WA",
                    PostalCode = "98034",
                    Country = "USA",
                    Phone = "(206) 555-8257",
                    Fax = "(206) 555-2174"
                },
                new Customer
                {
                    CustomerID = "VAFFE",
                    CompanyName = "Vaffeljernet",
                    ContactName = "Palle Ibsen",
                    ContactTitle = "Sales Manager",
                    Address = "Smagsloget 45",
                    City = "Århus",
                    Region = null,
                    PostalCode = "8200",
                    Country = "Denmark",
                    Phone = "86 21 32 43",
                    Fax = "86 22 33 44"
                },
                new Customer
                {
                    CustomerID = "VICTE",
                    CompanyName = "Victuailles en stock",
                    ContactName = "Mary Saveley",
                    ContactTitle = "Sales Agent",
                    Address = "2, rue du Commerce",
                    City = "Lyon",
                    Region = null,
                    PostalCode = "69004",
                    Country = "France",
                    Phone = "78.32.54.86",
                    Fax = "78.32.54.87"
                },
                new Customer
                {
                    CustomerID = "VINET",
                    CompanyName = "Vins et alcools Chevalier",
                    ContactName = "Paul Henriot",
                    ContactTitle = "Accounting Manager",
                    Address = "59 rue de l'Abbaye",
                    City = "Reims",
                    Region = null,
                    PostalCode = "51100",
                    Country = "France",
                    Phone = "26.47.15.10",
                    Fax = "26.47.15.11"
                },
                new Customer
                {
                    CustomerID = "WANDK",
                    CompanyName = "Die Wandernde Kuh",
                    ContactName = "Rita Müller",
                    ContactTitle = "Sales Representative",
                    Address = "Adenauerallee 900",
                    City = "Stuttgart",
                    Region = null,
                    PostalCode = "70563",
                    Country = "Germany",
                    Phone = "0711-020361",
                    Fax = "0711-035428"
                },
                new Customer
                {
                    CustomerID = "WARTH",
                    CompanyName = "Wartian Herkku",
                    ContactName = "Pirkko Koskitalo",
                    ContactTitle = "Accounting Manager",
                    Address = "Torikatu 38",
                    City = "Oulu",
                    Region = null,
                    PostalCode = "90110",
                    Country = "Finland",
                    Phone = "981-443655",
                    Fax = "981-443655"
                },
                new Customer
                {
                    CustomerID = "WELLI",
                    CompanyName = "Wellington Importadora",
                    ContactName = "Paula Parente",
                    ContactTitle = "Sales Manager",
                    Address = "Rua do Mercado, 12",
                    City = "Resende",
                    Region = "SP",
                    PostalCode = "08737-363",
                    Country = "Brazil",
                    Phone = "(14) 555-8122",
                    Fax = null
                },
                new Customer
                {
                    CustomerID = "WHITC",
                    CompanyName = "White Clover Markets",
                    ContactName = "Karl Jablonski",
                    ContactTitle = "Owner",
                    Address = "305 - 14th Ave. S. Suite 3B",
                    City = "Seattle",
                    Region = "WA",
                    PostalCode = "98128",
                    Country = "USA",
                    Phone = "(206) 555-4112",
                    Fax = "(206) 555-4115"
                },
                new Customer
                {
                    CustomerID = "WILMK",
                    CompanyName = "Wilman Kala",
                    ContactName = "Matti Karttunen",
                    ContactTitle = "Owner/Marketing Assistant",
                    Address = "Keskuskatu 45",
                    City = "Helsinki",
                    Region = null,
                    PostalCode = "21240",
                    Country = "Finland",
                    Phone = "90-224 8858",
                    Fax = "90-224 8858"
                },
                new Customer
                {
                    CustomerID = "WOLZA",
                    CompanyName = "Wolski  Zajazd",
                    ContactName = "Zbyszek Piestrzeniewicz",
                    ContactTitle = "Owner",
                    Address = "ul. Filtrowa 68",
                    City = "Warszawa",
                    Region = null,
                    PostalCode = "01-012",
                    Country = "Poland",
                    Phone = "(26) 642-7012",
                    Fax = "(26) 642-7012"
                }
            };
    }
}