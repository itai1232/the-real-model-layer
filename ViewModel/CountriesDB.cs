using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;

namespace ViewModel
{
    public class CountriesDB:BaseDB
    {

        public CountriesList SelectAll()
        {
            command.CommandText = $"SELECT *      FROM CountriesTBL";

          CountriesList countriesList = new CountriesList(base.Select());
            return countriesList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Countries c = entity as Countries;
            c.CountryName = reader["CountryName"].ToString();
            base.CreateModel(entity);
            return entity;
        }
        public override BaseEntity NewEntity()
        {
            return new Countries();
        }
        static private CountriesList list = new CountriesList();
        public static Countries SelectById(int id)
        {
            CountriesDB db = new CountriesDB();
            list = db.SelectAll();
            Countries g = list.Find(item => item.Id == id);
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
            Countries c = entity as Countries;
            if (c != null)
            {
                string sqlStr = $"UPDATE CountriesTBL  SET CountryName=@CountryName WHERE Id=@Id";
                command.CommandText = sqlStr ;
                command.Parameters.Add(new OleDbParameter("@CountryName", c.CountryName));
                command.Parameters.Add(new OleDbParameter("@Id",c.Id));
            }
        }
    }
}
