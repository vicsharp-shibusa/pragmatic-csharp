using Lesson008.Cli;

var person = new Person()
{
    Name = "Mike",
    Age = 127
};

try
{
    if (person.Age > 120)
    {
        throw new AgeTooOldException("This person is too old");
    }
    Console.WriteLine(person.Name.ToCharArray()[0]);
}
catch (AgeTooOldException)
{
    Console.WriteLine("That person is too old.");
}
catch (NullReferenceException exc)
{
    Console.WriteLine("null ref");
    Console.WriteLine(exc);
}
catch (Exception exc)
{
    Console.WriteLine("other");
    Console.WriteLine(exc);
}
finally
{
    Console.WriteLine("This line always happens.");
}

// Never do this

//try
//{
//    // Insert a record into the database.
//}
//catch
//{
//    // Update the record in the database.
//}
