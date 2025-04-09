using BethanysPieShopHRM.HR;

Console.WriteLine("Creating an Employee");
Console.WriteLine("---------------------------");

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(2002, 6, 13), 25, EmployeeType.Manager);

bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();
bethany.ReceiveWage();
bethany.DisplayEmployeeDetails();

Console.WriteLine("Creating an Employee");
Console.WriteLine("---------------------------");
Employee george = new Employee("George", "Jones", "georgey@snowball.be", new DateTime(1984, 3, 28), 30, EmployeeType.Research);



george.PerformWork(10);
george.PerformWork();
george.PerformWork();
george.ReceiveWage();
george.DisplayEmployeeDetails();


// double receivedBethany = bethany.ReceiveWage(true);

// double receivedGeorge = george.ReceiveWage(true);
