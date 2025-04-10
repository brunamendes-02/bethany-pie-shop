using BethanysPieShopHRM.HR;

// int[] sampleArray1 = new int[5];
// int[] sampleArray2 = new int[] { 1, 2, 3, 4, 5 };
// Console.WriteLine("How many employees IDs you want to register?");

// int length = int.Parse(Console.ReadLine());
// int[] ids = new int[length];

// for (int i = 0; i < length; i++)
// {
//     Console.WriteLine("Enter the employee id");
//     int id = int.Parse(Console.ReadLine());
//     ids[i] = id;

// }


// for (int i = 0; i < length; i++)
// {
//     Console.WriteLine($"Id: " + ids[i]);
// }

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);
Employee george = new Employee("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30, EmployeeType.Research);
Employee mary = new Employee("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30, EmployeeType.Manager);
Employee bobJunior = new Employee("Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17, EmployeeType.Research);
Employee kevin = new Employee("Kevin", "Marks", "kevin@snowball.be", new DateTime(1953, 12, 12), 10, EmployeeType.StoreManager);
Employee kate = new Employee("Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10, EmployeeType.StoreManager);
Employee kim = new Employee("Kim", "Jacobs", "kim@snowball.be", new DateTime(1975, 5, 14), 22, EmployeeType.StoreManager);

Employee[] employees = new Employee[7];
employees[0] = bethany;
employees[1] = george;
employees[2] = mary;
employees[3] = bobJunior;
employees[4] = kevin;
employees[5] = kate;
employees[6] = kim;

foreach(Employee e in employees) {
    e.DisplayEmployeeDetails();
    var numberOfHoursWorked = new Random().Next(25);
    e.PerformWork(numberOfHoursWorked);
}
