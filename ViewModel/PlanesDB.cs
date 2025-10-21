using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class PlanesDB : BaseDB
    {
        public PlanesList SelectAll()
        {
            command.CommandText = $"SELECT * FROM PlanesTBL";
            PlanesList pList = new PlanesList(base.Select());
            return pList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Planes pe = entity as Planes;
            pe.IsPlaneActive = (bool)reader["IsActive"];

            pe.NumOfSeats = reader["NumOfSeats"].ToString();
            pe.PlanesMakeCompany = MakeCompanyDB.SelectById((int)reader["MakerCompany"]);
            pe.PlanesFlightCompany = FlightCompanyDB.SelectById((int)reader["FlightCompany"]);
            pe.MakeDate = (DateTime)reader["MakeDate"];
            base.CreateModel(entity);
            return pe;
        }
        public override BaseEntity NewEntity()
        {
            return new Planes();
        }
        static private PlanesList list = new PlanesList();
        public static Planes SelectById(int id)
        {
            PlanesDB db = new PlanesDB();
            list = db.SelectAll();

            Planes g = list.Find(item => item.Id == id);
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
            throw new NotImplementedException();
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
