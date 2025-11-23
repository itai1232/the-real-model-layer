using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace ViewModel
{
    public class WorkerDB : PersonDB
    {
        public WorkerList SelectAll()
        {
            command.CommandText = $"SELECT   " +
                $"     PersonTBL.LastName, PersonTBL.Id, PersonTBL.FirstName, PersonTBL.Telephone," +
                $" PersonTBL.Email, PersonTBL.Country, WorkerTBL.IdRole, WorkerTBL.IsActive, WorkerTBL.SalaryPerFlightHour FROM      " +
                $"      (WorkerTBL INNER JOIN                         PersonTBL ON WorkerTBL.Id = PersonTBL.Id)";
            WorkerList pList = new WorkerList(base.Select());
            return pList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Worker pe = entity as Worker;
            
            pe.IsWorkerActive = (bool)reader["IsActive"];
            pe.WorkerRole = RolesDB.SelectById((int)reader["IdRole"]);
            pe.SalaryPerFlightHour = double.Parse(reader["SalaryPerFlightHour"].ToString());
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
        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Worker c = entity as Worker;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM WorkerTBL where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }
        public override void Delete(BaseEntity entity)
        {
            BaseEntity reqEntity = this.NewEntity();
            if (entity != null && entity.GetType() == reqEntity.GetType())
            {
                deleted.Add(new ChangeEntity(this.CreateDeletedSQL, entity));
                deleted.Add(new ChangeEntity(base.CreateDeletedSQL, entity));
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Worker c = entity as Worker;
            if (c != null)
            {
                string sqlStr = $"Insert INTO  WorkerTBL (Id,IdRole,SalaryPerFlightHour,IsActive) VALUES (@id,@role,@salary,@status)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
                command.Parameters.Add(new OleDbParameter("@role", c.WorkerRole.Id));
                command.Parameters.Add(new OleDbParameter("@salary", c.SalaryPerFlightHour));
                command.Parameters.Add(new OleDbParameter("@status", c.IsWorkerActive));
            }
        }
        public override void Insert(BaseEntity entity)
        {
            BaseEntity reqEntity = this.NewEntity();
            if (entity != null && entity.GetType() == reqEntity.GetType())
            {
                inserted.Add(new ChangeEntity(base.CreateInsertdSQL, entity));
                inserted.Add(new ChangeEntity(this.CreateInsertdSQL, entity));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Worker c = entity as Worker;
            if (c != null)
            {
                string sqlStr = $"UPDATE WorkerTBL  SET IdRole=@role, SalaryPerFlightHour=@salary,IsActive=@status WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@role", c.WorkerRole.Id));
                command.Parameters.Add(new OleDbParameter("@salary", c.SalaryPerFlightHour));
                command.Parameters.Add(new OleDbParameter("@status", c.IsWorkerActive));
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }
        public override void Update(BaseEntity entity)
        {
            Worker student = entity as Worker;
            if (student != null)
            {
                updated.Add(new ChangeEntity(this.CreateUpdatedSQL, entity));
                updated.Add(new ChangeEntity(base.CreateUpdatedSQL, entity));
            }
        }
    }
}
