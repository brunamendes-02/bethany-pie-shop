using BethanysPieShopHRM.HR;

List<Employee> employees = new List<Employee>();

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);
Manager mary = new Manager("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30);
// Employee george = new Employee("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30);
JuniorResearcher bobJunior = new JuniorResearcher("Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17);
// Employee kevin = new Employee("Kevin", "Marks", "kevin@snowball.be", new DateTime(1953, 12, 12), 10);
// Employee kate = new Employee("Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10);
// Employee kim = new Employee("Kim", "Jacobs", "kim@snowball.be", new DateTime(1975, 5, 14), 22);

// employees.Add(bethany);
// employees.Add(mary);
// employees.Add(george);
// employees.Add(bobJunior);
// employees.Add(kevin);
// employees.Add(kate);
// employees.Add(kim);

// foreach(Employee employee in employees) {
//     employee.DisplayEmployeeDetails();
// }


bethany.DisplayEmployeeDetails();
bethany.PerformWork(8);
bethany.PerformWork();
bethany.PerformWork(3);
bethany.ReceiveWage();

mary.DisplayEmployeeDetails();
mary.PerformWork(25);
mary.PerformWork();
mary.PerformWork();
mary.ReceiveWage();
mary.AttendManagementMeeting();

bobJunior.ResearchNewPieTastes(5);
bobJunior.ResearchNewPieTastes(5);