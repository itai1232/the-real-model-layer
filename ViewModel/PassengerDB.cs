using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class PassengerDB : PersonDB
    {
        public PassengerList SelectAll()
        {
            command.CommandText = $"SELECT    " +
                $"    PersonTBL.Id, PersonTBL.LastName, PersonTBL.FirstName, PersonTBL.Telephone, " +
                $"PersonTBL.Email, PersonTBL.Country\r\nFROM            (PersonTBL INNER JOIN\r\n                         PassengerTBL ON PersonTBL.Id = PassengerTBL.Id)";
            PassengerList pList = new PassengerList(base.Select());
            return pList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Passenger pe = entity as Passenger;
      
            base.CreateModel(entity);
            return pe;
        }
        public override BaseEntity NewEntity()
        {
            return new Passenger();
        }
        static private PassengerList list = new PassengerList();
        public static Passenger SelectById(int id)
        {
            PassengerDB db = new PassengerDB();
            list = db.SelectAll();

            Passenger g = list.Find(item => item.Id == id);
            return g;
        }

        //שלב ב
        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Passenger c = entity as Passenger;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM PassengerTBL where id=@pid";

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
               //  deleted.Add(new ChangeEntity(base.CreateDeletedSQL, entity));
               // when i delete a passenger the person wont be deleted
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Passenger c = entity as Passenger;
            if (c != null)
            {
                string sqlStr = $"Insert INTO  PassengerTBL (Id) VALUES (@id)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }

        //protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        //{
        //    Passenger c = entity as Passenger;
        //    if (c != null)
        //    {
        //        string sqlStr = $"UPDATE PassengerTBL set WHERE Id=@id";

        //        command.CommandText = sqlStr;

        //        command.Parameters.Add(new OleDbParameter("@id", c.Id));
        //    }
        //}
        public override void Insert(BaseEntity entity)
        {
            BaseEntity reqEntity = this.NewEntity();
            if (entity != null && entity.GetType() == reqEntity.GetType())
            {
                inserted.Add(new ChangeEntity(base.CreateInsertdSQL, entity));
                inserted.Add(new ChangeEntity(this.CreateInsertdSQL, entity));
            }//אין מה לשנות במחלקה אלא בפרסון ולכן אפשר לבטל את הפעולה השנייה והשורה הראשונה שנוגעות למחלקה פסנגר
        }
        public override void Update(BaseEntity entity)
        {
            Passenger student = entity as Passenger;
            if (student != null)
            {
              //  updated.Add(new ChangeEntity(this.CreateUpdatedSQL, entity));
                updated.Add(new ChangeEntity(base.CreateUpdatedSQL, entity));
            }
        }//אין מה לשנות במחלקה אלא בפרסון ולכן אפשר לבטל את הפעולה השנייה והשורה הראשונה שנוגעות למחלקה פסנגר

    }
}
