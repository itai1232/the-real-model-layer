using Model;
using ViewModel;


//CountriesDB cdb = new();
//CountriesList cList = cdb.SelectAll();
//foreach (Countries c in cList)
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
//fLIGHTCompany-- WORKS

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
//    Console.WriteLine(c.InvitationPassenger.FirstName + "  ,  " + c.InvitationFlight.Price);
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
//companyToUpdate.InvitationFlight.Id = 1;
//cdb.Update(companyToUpdate);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");
//Update Invitations WORKS

//PassengerDB cdb = new();
//PassengerList cList = cdb.SelectAll();
//foreach (Passenger c in cList)
//    Console.WriteLine(c.FirstName);
//Passenger companyToUpdate = cList[0];
//companyToUpdate.FirstName = "Yoni";
//cdb.Update(companyToUpdate);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");
//Update Passenger WORKS

//PlanesDB cdb = new();
//PlanesList cList = cdb.SelectAll();
//foreach (Planes c in cList)
//    Console.WriteLine(c.NumOfSeats);
//Planes companyToUpdate = cList[0];
//companyToUpdate.NumOfSeats = "200";
//cdb.Update(companyToUpdate);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");
//Update Planes WORKS

//WorkerDB cdb = new();
//WorkerList cList = cdb.SelectAll();
//foreach (Worker c in cList)
//    Console.WriteLine(c.FirstName);
//Worker companyToUpdate = cList[0];
//companyToUpdate.SalaryPerFlightHour = 100;
//cdb.Update(companyToUpdate);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");
//Update Worker WORKS

//CountriesDB cdb = new();
//Countries c1 = new Countries() { CountryName="sfdsgf"};
//cdb.Insert(c1);
//cdb.SaveChanges();
//CountriesList cList = cdb.SelectAll();
//foreach (Countries c in cList)
//    Console.WriteLine(c.CountryName);
//Insert Countries WORKS

//MakeCompanyDB cdb = new();
//MakeCompany c1 = new MakeCompany() { MakeCompanyName = "sfdsgf" };
//cdb.Insert(c1);
//cdb.SaveChanges();
//MakeCompanyList cList = cdb.SelectAll();
//foreach (MakeCompany c in cList)
//    Console.WriteLine(c.MakeCompanyName);
// Insert MakeCompany WORKS 

//FlightCompanyDB cdb = new();
//FlightCompany c1 = new FlightCompany() { FlightCompanyName = "sfdsgf" };
//cdb.Insert(c1);
//cdb.SaveChanges();
//FlightCompanyList cList = cdb.SelectAll();
//foreach (FlightCompany c in cList)
//    Console.WriteLine(c.FlightCompanyName);
// Insert FlightCompany WORKS 

//RolesDB cdb = new();
//Roles c1 = new Roles() { RoleName = "sfdsgf" };
//cdb.Insert(c1);
//cdb.SaveChanges();
//RolesList cList = cdb.SelectAll();
//foreach (Roles c in cList)
//    Console.WriteLine(c.RoleName);
// Insert Roles WORKS

//CountriesDB cdb = new();
//CountriesList cList = cdb.SelectAll();
//AirportsDB a1 = new();
//a1.Insert(new Airports { AirportName = "sssdsss", AirPortCountry = cList[0] });
//a1.SaveChanges();
// Insert Airports WORKS

//CountriesDB cdb = new();
//CountriesList cList = cdb.SelectAll();
//PersonDB a1 = new();
//a1.Insert(new Person { LastName = "sssdsss", FirstName="ahshdh",Telephone="0504937374",Email="random@gmail.com", PersonCountry = cList[0] });
//a1.SaveChanges();
// Insert Person WORKS

//AirportsDB cdb = new();
//AirportsList cList = cdb.SelectAll();
//PlanesDB cdb2 = new();
//PlanesList cList2 = cdb2.SelectAll();
//FlightDB a1 = new();
//a1.Insert(new Flight { TakeOffTime = DateTime.Parse("15/08/2025 12:00"), PlaneType = cList2[0], ArrivalTime = DateTime.Parse("15/08/2025 16:00"), DestinationAirport = cList[0], CurrentAirport = cList[1],Price=500,IsRelevant=true });
//a1.SaveChanges();
// Insert Flights WORKS

//MakeCompanyDB cdb = new();
//MakeCompanyList cList = cdb.SelectAll();
//FlightCompanyDB cdb2 = new();
//FlightCompanyList cList2 = cdb2.SelectAll();
//PlanesDB a1 = new();
//a1.Insert(new Planes {  NumOfSeats="201" , MakeDate = DateTime.Parse("15/08/2000"), PlanesMakeCompany = cList[0], PlanesFlightCompany = cList2[1], IsPlaneActive = true });
//a1.SaveChanges();
// Insert Planes WORKS

//RolesDB cdb = new();
//RolesList cList = cdb.SelectAll();
//CountriesDB cdb1 = new();
//CountriesList cList1 = cdb1.SelectAll();
//WorkerDB a1 = new();
//a1.Insert(new Worker { WorkerRole = cList[0], SalaryPerFlightHour = 200, IsWorkerActive = true, LastName = "workerrr", FirstName = "test", Telephone = "0547587374", Email = "randomworker@gmail.com", PersonCountry = cList1[0] });
//a1.SaveChanges();
//insert worker works

//CountriesDB cdb1 = new();
//CountriesList cList1 = cdb1.SelectAll();
//PassengerDB a1 = new();
//a1.Insert(new Passenger { LastName = "passengerr", FirstName = "realtest", Telephone = "0537587374", Email = "randompassengerreal@gmail.com", PersonCountry = cList1[0] });
//a1.SaveChanges();
//insert Passenger works

//FlightDB cdb = new();
//FlightList cList = cdb.SelectAll();
//PassengerDB cdb2 = new();
//PassengerList cList2 = cdb2.SelectAll();
//InvitationsDB a1 = new();
//a1.Insert(new Invitations { InvitationFlight = cList[0], InvitationPassenger = cList2[0] });
//a1.SaveChanges();
// Insert Invitations WORKS

//CountriesDB cdb = new();
//CountriesList cList = cdb.SelectAll();
//cdb.Delete(cList[cList.Count-1]);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were deleted");
//Delete Countries WORKS

//FlightCompanyDB cdb = new();
//FlightCompanyList cList = cdb.SelectAll();
//cdb.Delete(cList[cList.Count - 1]);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were deleted");
//Delete FlightCompany WORKS

//MakeCompanyDB cdb = new();
//MakeCompanyList cList = cdb.SelectAll();
//cdb.Delete(cList[cList.Count - 1]);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were deleted");
//Delete MakeCompany WORKS

//RolesDB cdb = new();
//RolesList cList = cdb.SelectAll();
//cdb.Delete(cList[cList.Count - 1]);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were deleted");
//Delete Roles WORKS

//AirportsDB cdb = new();
//AirportsList cList = cdb.SelectAll();
//cdb.Delete(cList[cList.Count - 1]);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were deleted");
//Delete Airports WORKS

//FlightDB cdb = new();
//FlightList cList = cdb.SelectAll();
//cdb.Delete(cList[cList.Count - 1]);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were deleted");
//Delete Flights WORKS

//InvitationsDB cdb = new();
//InvitationsList cList = cdb.SelectAll();
//cdb.Delete(cList[cList.Count - 1]);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were deleted");
//Delete Invitations WORKS

//PersonDB cdb = new();
//PersonList cList = cdb.SelectAll();
//cdb.Delete(cList[cList.Count - 1]);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were deleted");
//Delete Person WORKS

//PlanesDB cdb = new();
//PlanesList cList = cdb.SelectAll();
//cdb.Delete(cList[cList.Count - 1]);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were deleted");
//Delete Planes WORKS

//PassengerDB cdb = new();
//PassengerList cList = cdb.SelectAll();
//cdb.Delete(cList[cList.Count - 1]);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were deleted");
//Delete passenger WORKS

//WorkerDB cdb = new();
//WorkerList cList = cdb.SelectAll();
//cdb.Delete(cList[cList.Count - 1]);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were deleted");
//Delete Worker WORKS

