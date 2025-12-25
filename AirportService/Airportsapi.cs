using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace AirportService
{
    public class Airportsapi : IAirports
    {
        string uri = "http://localhost:5186";
        HttpClient client = new HttpClient();
        public async Task<int> DeleteACountry(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Project/DeleteACountry/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAFlight(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Project/DeleteAWorker/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAFlightCompany(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Project/DeleteAFlightCompany/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAInvitation(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Project/DeleteAnInvitation/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAMakeCompany(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Project/DeleteAMakeCompany/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAnAirport(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Project/DeleteAnAirport/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAPassenger(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Project/DeleteAPassenger/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAPerson(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Project/DeleteAPerson/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAPlane(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Project/DeleteAPlane/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteARole(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Project/DeleteARole/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

       

        public async Task<int> DeleteAWorker(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Project/DeleteAWorker/" + id)).IsSuccessStatusCode ? 1:0;
        }
        

        public async Task<AirportsList> GetAllAirports()
        {
            return await client.GetFromJsonAsync<AirportsList>(uri + "/api/Project/AirportsSelector");
        }

        public async Task<CountriesList> GetAllCountries()
        {
            return await client.GetFromJsonAsync<CountriesList>(uri+ "/api/Project/CountriesSelector");
        }

        public async Task<FlightCompanyList> GetAllFlightCompanies()
        {
            return await client.GetFromJsonAsync<FlightCompanyList>(uri + "/api/Project/FlightCompanySelector");
        }

        public async Task<FlightList> GetAllFlights()
        {
            return await client.GetFromJsonAsync<FlightList>(uri + "/api/Project/FlightSelector");
        }

        public async Task<InvitationsList> GetAllInvitations()
        {
            return await client.GetFromJsonAsync<InvitationsList>(uri + "/api/Project/InvitationsSelector");
        }

        public async Task<MakeCompanyList> GetAllMakeCompanies()
        {
            return await client.GetFromJsonAsync<MakeCompanyList>(uri + "/api/Project/MakeCompanySelector");
         
        }

        public async Task<PassengerList> GetAllPassengers()
        {
            return await client.GetFromJsonAsync<PassengerList>(uri + "/api/Project/PassengerSelector");
        }

        public async Task<PersonList> GetAllPersons()
        {
            return await client.GetFromJsonAsync<PersonList>(uri + "/api/Project/PersonSelector");
        }

        public async Task<PlanesList> GetAllPlanes()
        {
            return await client.GetFromJsonAsync<PlanesList>(uri + "/api/Project/PlanesSelector");
        }

        public async Task<RolesList> GetAllRoles()
        {
            return await client.GetFromJsonAsync<RolesList>(uri + "/api/Project/RolesSelector");
        }

        public async Task<WorkerList> GetAllWorkers()
        {
            return await client.GetFromJsonAsync<WorkerList>(uri + "/api/Project/WorkerSelector");
        }

        public async Task<int> InsertACountry(Countries c)
        {
            return (await client.PostAsJsonAsync<Countries>(uri + "/api/Project/InsertACountry", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAFlight(Flight f)
        {
            return (await client.PostAsJsonAsync<Flight>(uri + "/api/Project/InsertAFlight", f)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAFlightCompany(FlightCompany fc)
        {
            return (await client.PostAsJsonAsync<FlightCompany>(uri + "/api/Project/InsertAFlightCompany", fc)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAInvitation(Invitations c)
        {
            return (await client.PostAsJsonAsync<Invitations>(uri + "/api/Project/InsertAnInvitation", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAMakeCompany(MakeCompany c)
        {
            return (await client.PostAsJsonAsync<MakeCompany>(uri + "/api/Project/InsertAMakeCompany", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAnAirport(Airports c)
        {
            return (await client.PostAsJsonAsync<Airports>(uri + "/api/Project/InsertAnAirport", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAPassenger(Passenger c)
        {
            return (await client.PostAsJsonAsync<Passenger>(uri + "/api/Project/InsertAPassenger", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAPerson(Person c)
        {
            return (await client.PostAsJsonAsync<Person>(uri + "/api/Project/InsertAPerson", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAPlane(Planes c)
        {
            return (await client.PostAsJsonAsync<Planes>(uri + "/api/Project/InsertAPlane", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertARole(Roles c)
        {
            return (await client.PostAsJsonAsync<Roles>(uri + "/api/Project/InsertARole", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAWorker(Worker c)
        {
            return (await client.PostAsJsonAsync<Worker>(uri + "/api/Project/InsertAWorker", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateACountry(Countries c)
        {
            return (await client.PutAsJsonAsync<Countries>(uri + "/api/Project/UpdateACountry", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAFlight(Flight c)
        {
            return (await client.PutAsJsonAsync<Flight>(uri + "/api/Project/UpdateAFlight", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAFlightCompany(FlightCompany c)
        {
            return (await client.PutAsJsonAsync<FlightCompany>(uri + "/api/Project/UpdateAFlightCompany", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAInvitation(Invitations c)
        {
            return (await client.PutAsJsonAsync<Invitations>(uri + "/api/Project/UpdateAnInvitation", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAMakeCompany(MakeCompany c)
        {
            return (await client.PutAsJsonAsync<MakeCompany>(uri + "/api/Project/UpdateAMakeCompany", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAnAirport(Airports c)
        {
            return (await client.PutAsJsonAsync<Airports>(uri + "/api/Project/UpdateAnAirport", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAPassenger(Passenger c)
        {
            return (await client.PutAsJsonAsync<Passenger>(uri + "/api/Project/UpdateAPassenger", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAPerson(Person c)
        {
            return (await client.PutAsJsonAsync<Person>(uri + "/api/Project/UpdateAPerson", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAPlane(Planes c)
        {
            return (await client.PutAsJsonAsync<Planes>(uri + "/api/Project/UpdateAPlane", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateARole(Roles c)
        {
            return (await client.PutAsJsonAsync<Roles>(uri + "/api/Project/UpdateARole", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAWorker(Worker c)
        {
            return (await client.PutAsJsonAsync<Worker>(uri + "/api/Project/UpdateAWorker", c)).IsSuccessStatusCode ? 1 : 0;
        }
    }
}
