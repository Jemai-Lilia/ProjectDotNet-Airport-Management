// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;

Console.WriteLine("Hello, World!");
Plane plane = new Plane();
plane.Capacity = 20;
plane.ManufactureDate = DateTime.Now;
plane.PlaneType = PlaneType.Airbus;
Console.WriteLine(plane);

//Plane Plane2 = new Plane
//{
//    Capacity = 10,
//    ManufactureDate = new DateTime(2025, 01, 01)

//};
//Console.WriteLine(Plane2.ToString());

//Passenger p = new Passenger { FirstName = "lilia", LastName = "Jemai", EmailAddress = "lilia.jemai@esprit.tn" };
//Console.WriteLine(p.CheckProfile("lilia", "Jemai"));
//Console.WriteLine(p.CheckProfile("lilia", "Jemai", "lilia.jemai@esprit.tn"));

//Staff staff = new Staff();
//staff.PassengerType();
//Traveller traveller = new Traveller();      
//traveller.PassengerType();