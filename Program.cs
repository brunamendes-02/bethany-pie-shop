using BethanysPieShopHRM;

Console.WriteLine("Creating an Employee");
Console.WriteLine("---------------------------");

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(2002, 6, 13), 25);

bethany.DisplayEmployeeDetails();
bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();

double receivedBethany = bethany.ReceiveWage(true);
Console.WriteLine($"Wage paid (message from Program): {receivedBethany}");


Console.WriteLine("\nCreating an Employee");
Console.WriteLine("---------------------------");
Employee george = new Employee("George", "Jones", "georgey@snowball.be", new DateTime(1984, 3, 28), 30);

george.DisplayEmployeeDetails();
george.PerformWork();
george.PerformWork();
george.PerformWork(3);
george.PerformWork();
george.PerformWork(8);

double receivedGeorge = george.ReceiveWage(true);
Console.WriteLine($"Wage paid (message from Program): {receivedGeorge}");

