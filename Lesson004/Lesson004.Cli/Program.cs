using Classes;

var mech = PersonFactory.Create("m");
var senior = PersonFactory.Create("s");

PersonFactory.WritePerson(mech);
PersonFactory.WritePerson(senior);

ChangeName(ref mech, "Jill Robbins");
PersonFactory.WritePerson(mech);

void ChangeName(ref Person? p, string newName)
{
    if (p != null)
    {
        p.Name = newName;
    }
}

//var mike = new Mechanic("Mike Jones", new DateOnly(1990, 6, 5));

//var john = new SeniorMechanic("John Jones");

//var mikeCopy = Mechanic.Copy(mike);

//Console.WriteLine(mike);
//Console.WriteLine(mikeCopy);
//Console.WriteLine(john);

//if (mike == mike2)
//{
//    Console.WriteLine("Equal");
//}
//else
//{
//    Console.WriteLine("Not Equal");
//}

//if (mike.Equals(mike2))
//{
//    Console.WriteLine("Equal");
//}
//else
//{
//    Console.WriteLine("Not Equal");
//}