using Model;
using ViewModel;


//CountriesDB cdb = new();
//CountriesList cList = cdb.SelectAll();
//foreach(Countries c in cList)
//    Console.WriteLine(c.CountryName);
//COUNTRIES-- WORKS

//MakeCompanyDB cdb = new();
//MakeCompanyList cList = cdb.SelectAll();
//foreach (MakeCompany c in cList)
//    Console.WriteLine(c.MakeCompanyName);
//MakeCompany-- WORKS

//FlightCompanyDB cdb = new();
//FlightCompanyList cList = cdb.SelectAll();
//foreach (FlightCompany c in cList)
//    Console.WriteLine(c.FlightCompanyName);
//MakeCompany-- WORKS

//RolesDB cdb = new();
//RolesList cList = cdb.SelectAll();
//foreach (Roles c in cList)
//    Console.WriteLine(c.RoleName);
//ROLES--WORKS


//PersonDB pdb = new PersonDB();
//PersonList pList = pdb.SelectAll();
//foreach (Person c in pList)
//{
//    Console.WriteLine(c.FirstName + " " + c.LastName);
//}
//PERSON--WORKS

//AirportsDB pdb = new AirportsDB();
//AirportsList pList = pdb.SelectAll();
//foreach (Airports c in pList)
//{
//    Console.WriteLine(c.AirportName + "  " + c.AirPortCountry.CountryName);
//}
//AirPorts--WORKS

//PlanesDB pdb = new PlanesDB();
//PlanesList pList = pdb.SelectAll();
//foreach (Planes c in pList)
//{
//    Console.WriteLine(c.PlanesMakeCompany.MakeCompanyName + " " + c.PlanesFlightCompany.FlightCompanyName);
//}
//Planes--WORKS

//FlightDB pdb = new FlightDB();
//FlightList pList = pdb.SelectAll();
//foreach (Flight c in pList)
//{
//    Console.WriteLine(c.Price + " " + c.DestinationAirport.AirportName + " " + c.DestinationAirport.AirPortCountry.CountryName);
//}
//Flight--WORKS

//InvitationsDB pdb = new InvitationsDB();
//InvitationsList pList = pdb.SelectAll();
//foreach (Invitations c in pList)
//{
//    Console.WriteLine(c.InvitationPassenger.FirstName+"  ,  "+c.InvitationFlight.Price);
//}
//Invitations--WORKS

//PassengerDB pdb = new PassengerDB();
//PassengerList pList = pdb.SelectAll();
//foreach (Passenger c in pList)
//{
//    Console.WriteLine(c.FirstName + " " + c.LastName);
//}
//Passenger-- WORKS


//WorkerDB pdb = new WorkerDB();
//WorkerList pList = pdb.SelectAll();
//foreach (Worker c in pList)
//{
//    Console.WriteLine(c.FirstName + " " + c.SalaryPerFlightHour);
//}
//Worker--NOT WORKS

//CountriesDB cdb = new();
//CountriesList cList = cdb.SelectAll();
//foreach (Countries c in cList)
//    Console.WriteLine(c.CountryName);

//Countries countryToUpdate = cList[0];
//countryToUpdate.CountryName = "United States";
//cdb.Update(countryToUpdate);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");
//Update countries WORKS

//FlightCompanyDB cdb = new();
//FlightCompanyList cList = cdb.SelectAll();
//foreach (FlightCompany c in cList)
//    Console.WriteLine(c.FlightCompanyName);
//FlightCompany companyToUpdate = cList[0];
//companyToUpdate.FlightCompanyName = "RyanAir";
//cdb.Update(companyToUpdate);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");
//Update FlightCompany WORKS

//MakeCompanyDB cdb = new();
//MakeCompanyList cList = cdb.SelectAll();
//foreach (MakeCompany c in cList)
//    Console.WriteLine(c.MakeCompanyName);
//MakeCompany companyToUpdate = cList[0];
//companyToUpdate.MakeCompanyName = "AirBus";
//cdb.Update(companyToUpdate);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");
//Update MakeCompany WORKS

//RolesDB cdb = new();
//RolesList cList = cdb.SelectAll();
//foreach (Roles c in cList)
//    Console.WriteLine(c.RoleName);
//Roles companyToUpdate = cList[0];
//companyToUpdate.RoleName = "Pilot";
//cdb.Update(companyToUpdate);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");
//Update Roles WORKS

//AirportsDB cdb = new();
//AirportsList cList = cdb.SelectAll();
//foreach (Airports c in cList)
//    Console.WriteLine(c.AirPortCountry.CountryName+"  "+c.AirportName);
//Airports companyToUpdate = cList[0];
//companyToUpdate.AirportName = "ATL";
//cdb.Update(companyToUpdate);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");
//Update Airports WORKS

//PersonDB cdb = new();
//PersonList cList = cdb.SelectAll();
//foreach (Person c in cList)
//    Console.WriteLine(c.PersonCountry.CountryName + "  " + c.FirstName);
//Person companyToUpdate = cList[0];
//companyToUpdate.FirstName = "Aviel";
//cdb.Update(companyToUpdate);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");
//Update Person WORKS

//FlightDB cdb = new();
//FlightList cList = cdb.SelectAll();
//foreach (Flight c in cList)
//    Console.WriteLine(c.PlaneType.Id + "  " + c.TakeOffTime);
//Flight companyToUpdate = cList[0];
//companyToUpdate.Price = 1000;
//cdb.Update(companyToUpdate);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");
//Update Flight WORKS


//InvitationsDB cdb = new();
//InvitationsList cList = cdb.SelectAll();
//foreach (Invitations c in cList)
//    Console.WriteLine(c.InvitationPassenger.FirstName);
//Invitations companyToUpdate = cList[0];
//companyToUpdate.InvitationPassenger.FirstName = "123dee";
//cdb.Update(companyToUpdate);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");
//Update Flight WORKS
