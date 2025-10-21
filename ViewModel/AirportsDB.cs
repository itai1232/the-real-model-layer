using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class AirportsDB : BaseDB
    {
        public AirportsList SelectAll()
        {
            command.CommandText = $"SELECT * FROM AirportsTBL";
            AirportsList pList = new AirportsList(base.Select());
            return pList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Airports p = entity as Airports;
            p.AirportName = reader["AirportName"].ToString();
            p.AirPortCountry = CountriesDB.SelectById((int)reader["AirportCountry"]);
            base.CreateModel(entity);
            return p;
        }
        public override BaseEntity NewEntity()
        {
            return new Airports();
        }
        static private AirportsList list = new AirportsList();
        public static Airports SelectById(int id)
        {
            AirportsDB db = new AirportsDB();
            list = db.SelectAll();

            Airports g = list.Find(item => item.Id == id);
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
            Airports c = entity as Airports;
            if (c != null)
            {
                string sqlStr = $"UPDATE AirportsTBL  SET AirportName=@AirportName, AirportCountry=@CountryName WHERE Id=@Id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@AirportName", c.AirportName));
                command.Parameters.Add(new OleDbParameter("@CountryName", c.AirPortCountry.Id));
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
