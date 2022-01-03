using ThreadSafeTaskStudy;

PersonClass unsafePerson = new PersonClass();
PersonClass safePerson = new PersonClass();

Task task1 = Task.Run(() => unsafePerson.UnsafeIncrementCode(1));
Task task2 = Task.Run(() => unsafePerson.UnsafeIncrementCode(2));

Task.WaitAll(task1, task2);

Console.WriteLine($"\n\nUnsafe person's Code: {unsafePerson.Code}\n");
Console.WriteLine(new string('-', 50));

Task task3 = Task.Run(() => safePerson.SafeIncrementCode(3));
Task task4 = Task.Run(() => safePerson.SafeIncrementCode(4));

Task.WaitAll(task3, task4);

Console.WriteLine($"\n\nSafe person's Code: {safePerson.Code}\n");
Console.WriteLine(new string('-', 50));