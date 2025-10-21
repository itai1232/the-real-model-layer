using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class WorkerDB : PersonDB
    {
        public WorkerList SelectAll()
        {
            command.CommandText = $"SELECT   " +
                $"     PersonTBL.LastName, PersonTBL.Id, PersonTBL.FirstName, PersonTBL.Telephone," +
                $" PersonTBL.Email, PersonTBL.Country, WorkerTBL.IdRole, WorkerTBL.IsActive, WorkerTBL.SalaryPerFlightHour\r\nFROM      " +
                $"      (WorkerTBL INNER JOIN\r\n                         PersonTBL ON WorkerTBL.Id = PersonTBL.Id)";
            WorkerList pList = new WorkerList(base.Select());
            return pList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Worker pe = entity as Worker;
            
            pe.IsWorkerActive = (bool)reader["IsActive"];
            pe.WorkerRole = RolesDB.SelectById((int)reader["IdRole"]);
            pe.SalaryPerFlightHour = (double)reader["SalaryPerFlightHour"];
            base.CreateModel(entity);
            return pe;
        }
        public override BaseEntity NewEntity()
        {
            return new Worker();
        }
        static private WorkerList list = new WorkerList();
        public static Worker SelectById(int id)
        {
            WorkerDB db = new WorkerDB();
            list = db.SelectAll();

            Worker g = list.Find(item => item.Id == id);
            return g;
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
