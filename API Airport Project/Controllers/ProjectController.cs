using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;
namespace API_Airport_Project.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        [HttpGet]
        [ActionName("CountriesSelector")]
        public CountriesList SelectAllCountries()
        {
            CountriesDB dB = new CountriesDB();
            CountriesList countries = dB.SelectAll();
            return countries;
        }
        [HttpGet]
        [ActionName("MakeCompanySelector")]
        public MakeCompanyList SelectAllMakeCompany()
        {
            MakeCompanyDB dB = new MakeCompanyDB();
            MakeCompanyList makeCompanies = dB.SelectAll();
            return makeCompanies;
        }
        [HttpGet]
        [ActionName("FlightCompanySelector")]
        public FlightCompanyList SelectAllFlightCompany()
        {
            FlightCompanyDB dB = new FlightCompanyDB();
            FlightCompanyList flightCompanies = dB.SelectAll();
            return flightCompanies;
        }
        [HttpGet]
        [ActionName("RolesSelector")]
        public RolesList SelectAllRoles()
        {
            RolesDB dB = new RolesDB();
            RolesList roles = dB.SelectAll();
            return roles;
        }
        [HttpGet]
        [ActionName("AirportsSelector")]
        public AirportsList SelectAllAirports()
        {
            AirportsDB dB = new AirportsDB();
            AirportsList airports = dB.SelectAll();
            return airports;
        }
        [HttpGet]
        [ActionName("FlightSelector")]
        public FlightList SelectAllFlights()
        {
            FlightDB dB = new FlightDB();
            FlightList flights = dB.SelectAll();
            return flights;
        }
        [HttpGet]
        [ActionName("PlanesSelector")]
        public PlanesList SelectAllPlanes()
        {
            PlanesDB dB = new PlanesDB();
            PlanesList planes = dB.SelectAll();
            return planes;
        }
        [HttpGet]
        [ActionName("PersonSelector")]
        public PersonList SelectAllPersons()
        {
            PersonDB dB = new PersonDB();
            PersonList persons = dB.SelectAll();
            return persons;

        }
        [HttpGet]
        [ActionName("WorkerSelector")]
        public WorkerList SelectAllWorkers()
        {
            WorkerDB dB = new WorkerDB();
            WorkerList workers = dB.SelectAll();
            return workers;
        }
        [HttpGet]
        [ActionName("PassengerSelector")]
        public PassengerList SelectAllPassengers()
        {
            PassengerDB dB = new PassengerDB();
            PassengerList passengers = dB.SelectAll();
            return passengers;
        }
        [HttpGet]
        [ActionName("InvitationsSelector")]
        public InvitationsList SelectAllInvitations()
        {
            InvitationsDB dB = new InvitationsDB();
            InvitationsList invitations = dB.SelectAll();
            return invitations;
        }
        [HttpPost]
        public int InsertAWorker(Worker worker)
        {
            WorkerDB db = new WorkerDB();
            db.Insert(worker);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPost]
        public int InsertAPassenger(Passenger passenger)
        {
            PassengerDB db = new PassengerDB();
            db.Insert(passenger);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPost]
        public int InsertAnInvitation(Invitations invitation)
        {
            InvitationsDB db = new InvitationsDB();
            db.Insert(invitation);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPost]
        public int InsertAFlight(Flight flight)
        {
            FlightDB db = new FlightDB();
            db.Insert(flight);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPost]
        public int InsertAPlane(Planes plane)
        {
            PlanesDB db = new PlanesDB();
            db.Insert(plane);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPost]
        public int InsertAPerson(Person person)
        {
            PersonDB db = new PersonDB();
            db.Insert(person);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPost]
        public int InsertARole(Roles role)
        {
            RolesDB db = new RolesDB();
            db.Insert(role);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPost]
        public int InsertACountry(Countries country)
        {
            CountriesDB db = new CountriesDB();
            db.Insert(country);
            int x = db.SaveChanges();
            return x;

        }
        [HttpPost]
        public int InsertAFlightCompany(FlightCompany flightCompany)
        {
            FlightCompanyDB db = new FlightCompanyDB();
            db.Insert(flightCompany);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPost]
        public int InsertAMakeCompany(MakeCompany makeCompany)
        {
            MakeCompanyDB db = new MakeCompanyDB();
            db.Insert(makeCompany);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPost]
        public int InsertAnAirport(Airports airport)
        {
            AirportsDB db = new AirportsDB();
            db.Insert(airport);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPut]
        public int UpdateAWorker([FromBody] Worker worker)
        {
            WorkerDB db = new WorkerDB();
            db.Update(worker);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPut]
        public int UpdateAPassenger([FromBody] Passenger passenger)
        {
            PassengerDB db = new PassengerDB();
            db.Update(passenger);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPut]
        public int UpdateAFlight([FromBody] Flight flight)
        {
            FlightDB db = new FlightDB();
            db.Update(flight);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPut]
        public int UpdateAPlane([FromBody] Planes plane)
        {
            PlanesDB db = new PlanesDB();
            db.Update(plane);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPut]
        public int UpdateAPerson([FromBody] Person person)
        {
            PersonDB db = new PersonDB();
            db.Update(person);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPut]
        public int UpdateARole([FromBody] Roles role)
        {
            RolesDB db = new RolesDB();
            db.Update(role);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPut]
        public int UpdateACountry([FromBody] Countries country)
        {
            CountriesDB db = new CountriesDB();
            db.Update(country);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPut]
        public int UpdateAFlightCompany([FromBody] FlightCompany flightCompany)
        {
            FlightCompanyDB db = new FlightCompanyDB();
            db.Update(flightCompany);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPut]
        public int UpdateAMakeCompany([FromBody] MakeCompany makeCompany)
        {
            MakeCompanyDB db = new MakeCompanyDB();
            db.Update(makeCompany);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPut]
        public int UpdateAnAirport([FromBody] Airports airport)
        {
            AirportsDB db = new AirportsDB();
            db.Update(airport);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPut]
        public int UpdateAnInvitation([FromBody] Invitations invitation)
        {
            InvitationsDB db = new InvitationsDB();
            db.Update(invitation);
            int x = db.SaveChanges();
            return x;
        }
        [HttpDelete("{id}")]
        public int DeleteAWorker(int id)
        {
            WorkerDB db = new WorkerDB();
            Worker worker = WorkerDB.SelectById(id);
            db.Delete(worker);
            int x = db.SaveChanges();
            return x;
        }
        [HttpDelete("{id}")]
        public int DeleteAPassenger(int id)
        {
            PassengerDB db = new PassengerDB();
            Passenger passenger = PassengerDB.SelectById(id);
            db.Delete(passenger);
            int x = db.SaveChanges();
            return x;
        }
        [HttpDelete("{id}")]
        public int DeleteAFlight(int id)
        {
            FlightDB db = new FlightDB();
            Flight flight = FlightDB.SelectById(id);
            db.Delete(flight);
            int x = db.SaveChanges();
            return x;
        }
        [HttpDelete("{id}")]
        public int DeleteAPlane(int id)
        {
            PlanesDB db = new PlanesDB();
            Planes plane = PlanesDB.SelectById(id);
            db.Delete(plane);
            int x = db.SaveChanges();
            return x;
        }
        [HttpDelete("{id}")]
        public int DeleteAPerson(int id)
        {
            PersonDB db = new PersonDB();
            Person person = PersonDB.SelectById(id);
            db.Delete(person);
            int x = db.SaveChanges();
            return x;
        }
        [HttpDelete("{id}")]
        public int DeleteAnInvitation(int id)
        {
            InvitationsDB db = new InvitationsDB();
            Invitations invitation = InvitationsDB.SelectById(id);
            db.Delete(invitation);
            int x = db.SaveChanges();
            return x;
        }
        [HttpDelete("{id}")]
        public int DeleteARole(int id)
        {
            RolesDB db = new RolesDB();
            Roles role = RolesDB.SelectById(id);
            db.Delete(role);
            int x = db.SaveChanges();
            return x;
        }
        [HttpDelete("{id}")]
        public int DeleteACountry(int id)
        {
            CountriesDB db = new CountriesDB();
            Countries country = CountriesDB.SelectById(id);
            db.Delete(country);
            int x = db.SaveChanges();
            return x;
        }
        [HttpDelete("{id}")]
        public int DeleteAFlightCompany(int id)
        {
            FlightCompanyDB db = new FlightCompanyDB();
            FlightCompany flightCompany = FlightCompanyDB.SelectById(id);
            db.Delete(flightCompany);
            int x = db.SaveChanges();
            return x;
        }
        [HttpDelete("{id}")]
        public int DeleteAMakeCompany(int id)
        {
            MakeCompanyDB db = new MakeCompanyDB();
            MakeCompany makeCompany = MakeCompanyDB.SelectById(id);
            db.Delete(makeCompany);
            int x = db.SaveChanges();
            return x;
        }
        [HttpDelete("{id}")]
        public int DeleteAnAirport(int id)
        {
            AirportsDB db = new AirportsDB();
            Airports airport = AirportsDB.SelectById(id);
            db.Delete(airport);
            int x = db.SaveChanges();
            return x;
        }
    }



    }
