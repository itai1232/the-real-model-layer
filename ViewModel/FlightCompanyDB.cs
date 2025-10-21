using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class FlightCompanyDB : BaseDB
    {

        public FlightCompanyList SelectAll()
        {
            command.CommandText = $"SELECT *      FROM CompanyFlightTBL";

            FlightCompanyList FlightCompanyList = new FlightCompanyList(base.Select());
            return FlightCompanyList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            FlightCompany c = entity as FlightCompany;
            c.FlightCompanyName = reader["CompanyName"].ToString();
            base.CreateModel(entity);
            return entity;
        }
        public override BaseEntity NewEntity()
        {
            return new FlightCompany();
        }
        static private FlightCompanyList list = new FlightCompanyList();
        public static FlightCompany SelectById(int id)
        {
            FlightCompanyDB db = new FlightCompanyDB();
            list = db.SelectAll();
            FlightCompany g = list.Find(item => item.Id == id);
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
            FlightCompany c = entity as FlightCompany;
            if (c != null)
            {
                string sqlStr = $"UPDATE CompanyFlightTBL  SET CompanyName=@CompanyName WHERE Id=@Id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@CompanyName", c.FlightCompanyName));
                command.Parameters.Add(new OleDbParameter("@Id", c.Id));
            }
        }
    }
}
