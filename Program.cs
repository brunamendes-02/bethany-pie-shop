using BethanysPieShopHRM;

Console.WriteLine("Creating an Employee");
Console.WriteLine("---------------------------");

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(2002, 6, 13), 25, EmployeeType.Manager);
Employee george = new Employee("George", "Jones", "georgey@snowball.be", new DateTime(1984, 3, 28), 30, EmployeeType.Research);

bethany.PerformWork(5);
george.PerformWork(5);

double receivedBethany = bethany.ReceiveWage(true);

double receivedGeorge = george.ReceiveWage(true);


WorkTask task;
task.description = "Bake delicious pies";
task.hours = 3;

task.PerformWorkTask();