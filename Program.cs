using BethanysPieShopHRM.HR;


Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);
Manager mary = new Manager("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30);
Employee george = new Employee("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30,  "New street", "123", "12345", "Pie Vile");
JuniorResearcher bobJunior = new JuniorResearcher("Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17);

bethany.DisplayEmployeeDetails();
bethany.GiveBonus();

mary.DisplayEmployeeDetails();
mary.GiveBonus();

george.DisplayEmployeeDetails();