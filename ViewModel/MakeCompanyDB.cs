using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class MakeCompanyDB : BaseDB
    {

        public MakeCompanyList SelectAll()
        {
            command.CommandText = $"SELECT *      FROM CompanyMakeTBL";

            MakeCompanyList MakeCompanyList = new MakeCompanyList(base.Select());
            return MakeCompanyList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            MakeCompany c = entity as MakeCompany;
            c.MakeCompanyName = reader["CompanyName"].ToString();
            base.CreateModel(entity);
            return entity;
        }
        public override BaseEntity NewEntity()
        {
            return new MakeCompany();
        }
        static private MakeCompanyList list = new MakeCompanyList();
        public static MakeCompany SelectById(int id)
        {
            MakeCompanyDB db = new MakeCompanyDB();
            list = db.SelectAll();
            MakeCompany g = list.Find(item => item.Id == id);
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
            MakeCompany c = entity as MakeCompany;
            if (c != null)
            {
                string sqlStr = $"UPDATE CompanyMakeTBL  SET CompanyName=@CompanyName WHERE Id=@Id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@CompanyName", c.MakeCompanyName));
                command.Parameters.Add(new OleDbParameter("@Id", c.Id));
            }
        }
    }
}
