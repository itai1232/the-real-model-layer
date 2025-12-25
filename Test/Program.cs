using Model;
using ViewModel;
using AirportService;
using API_Airport_Project;
{
    
}

#region SELECT
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
//Worker-- WORKS
#endregion

#region UPDATE
//CountriesDB cdb = new();
//CountriesList cList = cdb.SelectAll();
//foreach (Countries c in cList)
//    Console.WriteLine(c.CountryName);
//Countries countryToUpdate = cList[cList.Count - 1];
//countryToUpdate.CountryName = "United States";
//cdb.Update(countryToUpdate);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");
//Update countries WORKS

//FlightCompanyDB cdb = new();
//FlightCompanyList cList = cdb.SelectAll();
//foreach (FlightCompany c in cList)
//    Console.WriteLine(c.FlightCompanyName);
//FlightCompany companyToUpdate = cList[cList.Count - 1];
//companyToUpdate.FlightCompanyName = "RyanAir";
//cdb.Update(companyToUpdate);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");
//Update FlightCompany WORKS

//MakeCompanyDB cdb = new();
//MakeCompanyList cList = cdb.SelectAll();
//foreach (MakeCompany c in cList)
//    Console.WriteLine(c.MakeCompanyName);
//MakeCompany companyToUpdate = cList[cList.Count - 1];
//companyToUpdate.MakeCompanyName = "AirBus";
//cdb.Update(companyToUpdate);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");
//Update MakeCompany WORKS

//RolesDB cdb = new();
//RolesList cList = cdb.SelectAll();
//foreach (Roles c in cList)
//    Console.WriteLine(c.RoleName);
//Roles companyToUpdate = cList[cList.Count - 1];
//companyToUpdate.RoleName = "Pilot";
//cdb.Update(companyToUpdate);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");
//Update Roles WORKS

//AirportsDB cdb = new();
//AirportsList cList = cdb.SelectAll();
//foreach (Airports c in cList)
//    Console.WriteLine(c.AirPortCountry.CountryName + "  " + c.AirportName);
//Airports companyToUpdate = cList[cList.Count - 1];
//companyToUpdate.AirportName = "ATL";
//cdb.Update(companyToUpdate);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");
//Update Airports WORKS

//PersonDB cdb = new();
//PersonList cList = cdb.SelectAll();
//foreach (Person c in cList)
//    Console.WriteLine(c.PersonCountry.CountryName + "  " + c.FirstName);
//Person companyToUpdate = cList[cList.Count - 1];
//companyToUpdate.FirstName = "Aviel";
//cdb.Update(companyToUpdate);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");
//Update Person WORKS

//FlightDB cdb = new();
//FlightList cList = cdb.SelectAll();
//foreach (Flight c in cList)
//    Console.WriteLine(c.PlaneType.Id + "  " + c.TakeOffTime);
//Flight companyToUpdate = cList[cList.Count - 1];
//companyToUpdate.Price = 1000;
//cdb.Update(companyToUpdate);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");
//Update Flight WORKS


//InvitationsDB cdb = new();
//InvitationsList cList = cdb.SelectAll();
//foreach (Invitations c in cList)
//    Console.WriteLine(c.InvitationPassenger.FirstName);
//Invitations companyToUpdate = cList[cList.Count - 1];
//companyToUpdate.InvitationFlight.Id = 1;
//cdb.Update(companyToUpdate);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");
//Update Invitations WORKS

//PassengerDB cdb = new();
//PassengerList cList = cdb.SelectAll();
//foreach (Passenger c in cList)
//    Console.WriteLine(c.FirstName);
//Passenger companyToUpdate = cList[cList.Count - 1];
//companyToUpdate.FirstName = "Yoni";
//cdb.Update(companyToUpdate);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");
//Update Passenger WORKS

//PlanesDB cdb = new();
//PlanesList cList = cdb.SelectAll();
//foreach (Planes c in cList)
//    Console.WriteLine(c.NumOfSeats);
//Planes companyToUpdate = cList[cList.Count - 1];
//companyToUpdate.NumOfSeats = "200";
//cdb.Update(companyToUpdate);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");
//Update Planes WORKS

//WorkerDB cdb = new();
//WorkerList cList = cdb.SelectAll();
//foreach (Worker c in cList)
//    Console.WriteLine(c.FirstName);
//Worker companyToUpdate = cList[cList.Count - 1];
//companyToUpdate.SalaryPerFlightHour = 100;
//cdb.Update(companyToUpdate);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");
//Update Worker WORKS
#endregion

#region INSERT
//CountriesDB cdb = new();
//Countries c1 = new Countries() { CountryName = "sfdsgf" };
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
//a1.Insert(new Person { LastName = "sssdsss", FirstName = "ahshdh", Telephone = "0504937374", Email = "random@gmail.com", PersonCountry = cList[0] });
//a1.SaveChanges();
// Insert Person WORKS

//AirportsDB cdb = new();
//AirportsList cList = cdb.SelectAll();
//PlanesDB cdb2 = new();
//PlanesList cList2 = cdb2.SelectAll();
//FlightDB a1 = new();
//a1.Insert(new Flight { TakeOffTime = DateTime.Parse("15/08/2025 12:00"), PlaneType = cList2[0], ArrivalTime = DateTime.Parse("15/08/2025 16:00"), DestinationAirport = cList[0], CurrentAirport = cList[1], Price = 500, IsRelevant = true });
//a1.SaveChanges();
// Insert Flights WORKS

//MakeCompanyDB cdb = new();
//MakeCompanyList cList = cdb.SelectAll();
//FlightCompanyDB cdb2 = new();
//FlightCompanyList cList2 = cdb2.SelectAll();
//PlanesDB a1 = new();
//a1.Insert(new Planes { NumOfSeats = "201", MakeDate = DateTime.Parse("15/08/2000"), PlanesMakeCompany = cList[0], PlanesFlightCompany = cList2[1], IsPlaneActive = true });
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
#endregion

#region DELETE
//CountriesDB cdb = new();
//CountriesList cList = cdb.SelectAll();
//cdb.Delete(cList[cList.Count - 1]);
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
#endregion

#region SELECTAPI

//Airportsapi airservice = new Airportsapi();

//// Airports
//AirportsList airports = await airservice.GetAllAirports();
//foreach (Airports a in airports)
//{
//    await Console.Out.WriteLineAsync(a.AirportName);
//}

//// Countries
//CountriesList countries = await airservice.GetAllCountries();
//foreach (Countries c in countries)
//{
//    await Console.Out.WriteLineAsync(c.CountryName);
//}

////FlightCompany
//FlightCompanyList flightCompanies = await airservice.GetAllFlightCompanies();
//foreach (FlightCompany fc in flightCompanies)
//{
//    await Console.Out.WriteLineAsync(fc.FlightCompanyName);
//}

//// Flight
//FlightList flights = await airservice.GetAllFlights();
//foreach (Flight f in flights)
//{
//    await Console.Out.WriteLineAsync(f.Id.ToString());
//}

//// Invitations
//InvitationsList invitations = await airservice.GetAllInvitations();
//foreach (Invitations i in invitations)
//{
//    await Console.Out.WriteLineAsync(i.Id.ToString());
//}

////MakeCompany
//MakeCompanyList makeCompanies = await airservice.GetAllMakeCompanies();
//foreach (MakeCompany mc in makeCompanies)
//{
//    await Console.Out.WriteLineAsync(mc.MakeCompanyName);
//}

//// Passenger
//PassengerList passengers = await airservice.GetAllPassengers();
//foreach (Passenger p in passengers)
//{
//    await Console.Out.WriteLineAsync(p.FirstName);
//}

//// Person
//PersonList persons = await airservice.GetAllPersons();
//foreach (Person p in persons)
//{
//    await Console.Out.WriteLineAsync(p.FirstName);
//}

//// Planes
//PlanesList planes = await airservice.GetAllPlanes();
//foreach (Planes p in planes)
//{
//    await Console.Out.WriteLineAsync(p.NumOfSeats);
//}

//// Roles
//RolesList roles = await airservice.GetAllRoles();
//foreach (Roles r in roles)
//{
//    await Console.Out.WriteLineAsync(r.RoleName);
//}

//// Worker
//WorkerList workers = await airservice.GetAllWorkers();
//foreach (Worker w in workers)
//{
//    await Console.Out.WriteLineAsync(w.FirstName);
//}

//Console.ReadLine();
#endregion


#region InsertAPI
//Airportsapi apiservice = new();
//CountriesDB cdb = new();
//CountriesList cList = cdb.SelectAll();
//RolesDB cdb1 = new();
//RolesList RList = cdb1.SelectAll();
//FlightDB cdb2 = new();
//FlightList FList = cdb2.SelectAll();
//PassengerDB cdb3 = new();
//PassengerList PList = cdb3.SelectAll();
//MakeCompanyDB cdb4 = new();
//MakeCompanyList MCList = cdb4.SelectAll();
//FlightCompanyDB cdb5 = new();
//FlightCompanyList FCList = cdb5.SelectAll();
//AirportsDB cdb6 = new();
//AirportsList AList = cdb6.SelectAll();
//PlanesDB cdb7 = new();
//PlanesList PList2 = cdb7.SelectAll();
//// 1. Countries
//await apiservice.InsertACountry(new Countries { CountryName = "API" });

//// 2. Airports
//await apiservice.InsertAnAirport(new Airports { AirportName = "api", AirPortCountry = cList[0] });

//// 3. FlightCompany
//await apiservice.InsertAFlightCompany(new FlightCompany { FlightCompanyName = "API" });

//// 4. Flight
//await apiservice.InsertAFlight(new Flight { TakeOffTime = DateTime.Parse("15/08/2025 12:00"), PlaneType = PList2[0], ArrivalTime = DateTime.Parse("15/08/2025 16:00"), DestinationAirport = AList[0], CurrentAirport = AList[1], Price = 500, IsRelevant = true });

//// 5. Planes
//await apiservice.InsertAPlane(new Planes { NumOfSeats = "201000", MakeDate = DateTime.Parse("15/08/2000"), PlanesMakeCompany = MCList[0], PlanesFlightCompany = FCList[1], IsPlaneActive = true });

//// 6. Passenger
//await apiservice.InsertAPassenger(new Passenger { LastName = "passengerrAPI", FirstName = "realtestAPI", Telephone = "0537587374", Email = "randompassengerreal@gmail.com", PersonCountry = cList[0] });

//// 7. Person
//await apiservice.InsertAPerson(new Person { LastName = "sssdsssAPI", FirstName = "ahshdhAPI", Telephone = "0504937374", Email = "random@gmail.com", PersonCountry = cList[0] });

//// 8. Worker
//await apiservice.InsertAWorker(new Worker { WorkerRole = RList[0], SalaryPerFlightHour = 10000, IsWorkerActive = true, LastName = "workerrrAPI", FirstName = "test", Telephone = "0547587374", Email = "randomworkerAPI@gmail.com", PersonCountry = cList[0] });

//// 9. Roles
//await apiservice.InsertARole(new Roles { RoleName = "AdminAPI" });

//// 10. Invitations
//await apiservice.InsertAInvitation(new Invitations { InvitationFlight = FList[0], InvitationPassenger = PList[0] });

//// 11. MakeCompany
//await apiservice.InsertAMakeCompany(new MakeCompany { MakeCompanyName = "APITEST" });
#endregion

#region UpdateAPI
//Airportsapi apiservice = new();
//CountriesList cList = new CountriesDB().SelectAll();
//RolesList RList = new RolesDB().SelectAll();
//FlightList FList = new FlightDB().SelectAll();
//PassengerList PList = new PassengerDB().SelectAll();
//MakeCompanyList MCList = new MakeCompanyDB().SelectAll();
//FlightCompanyList FCList = new FlightCompanyDB().SelectAll();
//AirportsList AList = new AirportsDB().SelectAll();
//PlanesList PList2 = new PlanesDB().SelectAll();
//PersonList PersonList = new PersonDB().SelectAll();
//WorkerList WList = new WorkerDB().SelectAll();
//InvitationsList IList = new InvitationsDB().SelectAll();
//// UPDATE LAST IN EACH CLASS

//// 1. Countries
//Countries country = cList.Last();
//country.CountryName = "APIUPDATE";
//await apiservice.UpdateACountry(country);

//// 2. Airports
//Airports airport = AList.Last();
//airport.AirportName = "apiupdate";
//await apiservice.UpdateAnAirport(airport);

//// 3. FlightCompany
//FlightCompany fc = FCList.Last();
//fc.FlightCompanyName = "APIUPDATE";
//await apiservice.UpdateAFlightCompany(fc);

//// 4. Flight
//Flight flight = FList.Last();
//flight.Price = 999;
//flight.IsRelevant = false;
//await apiservice.UpdateAFlight(flight);

//// 5. Planes
//Planes plane = PList2.Last();
//plane.NumOfSeats = "APIUPDATE";
//plane.IsPlaneActive = false;
//await apiservice.UpdateAPlane(plane);

//// 6. Passenger
//Passenger passenger = PList.Last();
//passenger.LastName = "passengerAPIUPDATE";
//passenger.FirstName = "realtestAPIUPDATE";
//await apiservice.UpdateAPassenger(passenger);

//// 7. Person
//Person person = PersonList.Last();
//person.LastName = "sssdsssAPIUPDATE";
//person.FirstName = "ahshdhAPIUPDATE";
//await apiservice.UpdateAPerson(person);

//// 8. Worker
//Worker worker = WList.Last();
//worker.SalaryPerFlightHour = 20000;
//worker.IsWorkerActive = false;
//await apiservice.UpdateAWorker(worker);

//// 9. Roles
//Roles role = RList.Last();
//role.RoleName = "AdminAPIUPDATE";
//await apiservice.UpdateARole(role);

//// 10. Invitations
//Invitations invitation = IList.Last();
//await apiservice.UpdateAInvitation(invitation);

//// 11. MakeCompany
//MakeCompany mc = MCList.Last();
//mc.MakeCompanyName = "APIUPDATE";
//await apiservice.UpdateAMakeCompany(mc);
//#endregion
//Console.WriteLine("Done");
//Console.ReadLine();
#endregion

#region DELETEAPI

Airportsapi apiservice = new();
////DELETE LAST IN EACH CLASS

//// 1. Countries
//CountriesList countries = await apiservice.GetAllCountries();
//Console.WriteLine(countries.Count);
//int countryId = countries.Last().Id;
//await apiservice.DeleteACountry(countryId);
//Console.WriteLine(countries.Count + " deleted a country");


//// 2. Airports
//AirportsList airports = await apiservice.GetAllAirports();
//Console.WriteLine(airports.Count);
//int airportId = airports.Last().Id;
//await apiservice.DeleteAnAirport(airportId);
//Console.WriteLine(airports.Count + " deleted an airport");


//// 3. FlightCompany
//FlightCompanyList flightCompanies = await apiservice.GetAllFlightCompanies();
//Console.WriteLine(flightCompanies.Count);
//int flightCompanyId = flightCompanies.Last().Id;
//await apiservice.DeleteAFlightCompany(flightCompanyId);
//Console.WriteLine(flightCompanies.Count + " deleted a flight company");


//// 4. Flight
//FlightList flights = await apiservice.GetAllFlights();
//Console.WriteLine(flights.Count);
//int flightId = flights.Last().Id;
//await apiservice.DeleteAFlight(flightId);
//Console.WriteLine(flights.Count + " deleted a flight");


//// 5. Planes
//PlanesList planes = await apiservice.GetAllPlanes();
//Console.WriteLine(planes.Count);
//int planeId = planes.Last().Id;
//await apiservice.DeleteAPlane(planeId);
//Console.WriteLine(planes.Count + " deleted a plane");


//// 6. Passenger
//PassengerList passengers = await apiservice.GetAllPassengers();
//Console.WriteLine(passengers.Count);
//int passengerId = passengers.Last().Id;
//await apiservice.DeleteAPassenger(passengerId);
//Console.WriteLine(passengers.Count + " deleted a passenger");


// 7. Person
PersonList persons = await apiservice.GetAllPersons();
Console.WriteLine(persons.Count);
int personId = persons.Last().Id;
await apiservice.DeleteAPerson(personId);
Console.WriteLine(persons.Count + " deleted a person");


// 8. Worker
WorkerList workers = await apiservice.GetAllWorkers();
Console.WriteLine(workers.Count);
int workerId = workers.Last().Id;
await apiservice.DeleteAWorker(workerId);
Console.WriteLine(workers.Count + " deleted a worker");


// 9. Roles
RolesList roles = await apiservice.GetAllRoles();
Console.WriteLine(roles.Count);
int roleId = roles.Last().Id;
await apiservice.DeleteARole(roleId);
Console.WriteLine(roles.Count + " deleted a role");


// 10. Invitations
InvitationsList invitations = await apiservice.GetAllInvitations();
Console.WriteLine(invitations.Count);
int invitationId = invitations.Last().Id;
await apiservice.DeleteAInvitation(invitationId);
Console.WriteLine(invitations.Count + " deleted an invitation");


// 11.MakeCompany
MakeCompanyList makeCompanies = await apiservice.GetAllMakeCompanies();
Console.WriteLine(makeCompanies.Count);
int makeCompanyId = makeCompanies.Last().Id;
await apiservice.DeleteAMakeCompany(makeCompanyId);
Console.WriteLine(makeCompanies.Count + " deleted a make company");
Console.ReadLine();
#endregion
