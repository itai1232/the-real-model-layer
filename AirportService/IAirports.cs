using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace AirportService
{
    public interface IAirports
    {
        public Task<CountriesList> GetAllCountries();
        public Task<MakeCompanyList> GetAllMakeCompanies();
        public Task<FlightCompanyList> GetAllFlightCompanies();
        public Task<AirportsList> GetAllAirports();
        public Task<FlightList> GetAllFlights();
        public Task<PersonList> GetAllPersons();
        public Task<PassengerList> GetAllPassengers();
        public Task<PlanesList> GetAllPlanes();
        public Task<RolesList> GetAllRoles();
        public Task<WorkerList> GetAllWorkers();
        public Task<InvitationsList> GetAllInvitations();


        public Task<int> InsertACountry(Countries c);
        public Task<int> InsertAnAirport(Airports c);
        public Task<int> InsertAMakeCompany(MakeCompany mc);
        public Task<int> InsertAFlightCompany(FlightCompany fc);
        public Task<int> InsertAFlight(Flight f);
        public Task<int> InsertAPassenger(Passenger p);
        public Task<int> InsertAPerson(Person p);
        public Task<int> InsertAPlane(Planes p);
        public Task<int> InsertARole(Roles r);
        public Task<int> InsertAWorker(Worker w);
        public Task<int> InsertAInvitation(Invitations i);


        public Task<int> UpdateACountry(Countries c);
        public Task<int> UpdateAnAirport(Airports c);
        public Task<int> UpdateAMakeCompany(MakeCompany c);
        public Task<int> UpdateAFlightCompany(FlightCompany c);
        public Task<int> UpdateAFlight(Flight c);
        public Task<int> UpdateAPassenger(Passenger c);
        public Task<int> UpdateAPerson(Person c);
        public Task<int> UpdateAPlane(Planes c);
        public Task<int> UpdateARole(Roles c);
        public Task<int> UpdateAWorker(Worker c);
        public Task<int> UpdateAInvitation(Invitations c);

        public Task<int> DeleteACountry(int t);
        public Task<int> DeleteAnAirport(int t);
        public Task<int> DeleteAMakeCompany(int t);
        public Task<int> DeleteAFlightCompany(int t);
        public Task<int> DeleteAFlight(int t);
        public Task<int> DeleteAPassenger(int t);
        public Task<int> DeleteAPerson(int t);
        public Task<int> DeleteAPlane(int t);
        public Task<int> DeleteARole(int t);
        public Task<int> DeleteAWorker(int t);
        public Task<int> DeleteAInvitation(int t);


    }
}
