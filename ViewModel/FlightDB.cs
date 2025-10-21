using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class FlightDB : BaseDB
    {
        public FlightList SelectAll()
        {
            command.CommandText = $"SELECT * FROM FlightsTBL";
            FlightList pList = new FlightList(base.Select());
            return pList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Flight pe = entity as Flight;
            pe.TakeOffTime = (DateTime)reader["TakeoffTime"];
            pe.ArrivalTime = (DateTime)reader["ArrivalTime"];
            pe.CurrentAirport = AirportsDB.SelectById((int)reader["CurrentAirport"]);
            pe.DestinationAirport = AirportsDB.SelectById((int)reader["DestinationAirport"]);
            pe.Price = (int)reader["Price"];
            pe.PlaneType = PlanesDB.SelectById((int)reader["PlaneType"]);
            base.CreateModel(entity);
            return pe;
        }
        public override BaseEntity NewEntity()
        {
            return new Flight();
        }
        static private FlightList list = new FlightList();
        public static Flight SelectById(int id)
        {
            FlightDB db = new FlightDB();
            list = db.SelectAll();

            Flight g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Flight c = entity as Flight;
            if (c != null)
            {
                string sqlStr = $"UPDATE FlightsTBL  SET TakeoffTime=@takeoff,PlaneType=@planetype,ArrivalTime=@ArrivalTime,DestinationAirport=@Destination,CurrentAirport=@Current,Price=@price" +
                    $" WHERE Id=@Id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@takeoff", c.TakeOffTime));
                command.Parameters.Add(new OleDbParameter("@planetype", c.PlaneType.Id));
                command.Parameters.Add(new OleDbParameter("@ArrivalTime", c.ArrivalTime));
                command.Parameters.Add(new OleDbParameter("@Destination", c.DestinationAirport.Id));
                command.Parameters.Add(new OleDbParameter("@Current", c.CurrentAirport.Id));
                command.Parameters.Add(new OleDbParameter("@price", c.Price));
                command.Parameters.Add(new OleDbParameter("@Id", c.Id));
            }
        }

        //שלב ב
        //protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        //{
        //    Person c = entity as Person;
        //    if (c != null)
        //    {
        //        string sqlStr = $"DELETE FROM PersonTbl where id=@pid";

        //        command.CommandText = sqlStr;
        //        command.Parameters.Add(new OleDbParameter("@pid", c.Id));
        //    }
        //}
        //protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        //{
        //    Person c = entity as Person;
        //    if (c != null)
        //    {
        //        string sqlStr = $"Insert INTO  PersonTbl (PersonName) VALUES (@cName)";

        //        command.CommandText = sqlStr;
        //        command.Parameters.Add(new OleDbParameter("@cName", c.PersonName));
        //    }
        //}

        //protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        //{
        //    Person c = entity as Person;
        //    if (c != null)
        //    {
        //        string sqlStr = $"UPDATE PersonTbl  SET PersonName=@cName WHERE ID=@id";

        //        command.CommandText = sqlStr;
        //        command.Parameters.Add(new OleDbParameter("@cName", c.PersonName));
        //        command.Parameters.Add(new OleDbParameter("@id", c.Id));
        //    }
        //}
    }
}
