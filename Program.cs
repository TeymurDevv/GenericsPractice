using GenericPractice.Domain.Models;
Book book1 = new("Test1", 18, "Test3", 400, 3);
book1.Sell();
book1.Sell();
book1.ShowInfo();
Book book2 = new("Test2", 15, "Test4", 700, 1);
book2.Sell();
book2.ShowInfo();
Book.Income();



