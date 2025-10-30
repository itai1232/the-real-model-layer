using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class InvitationsDB : BaseDB
    {
        public InvitationsList SelectAll()
        {
            command.CommandText = $"SELECT * FROM InvitationsTBL";
            InvitationsList pList = new InvitationsList(base.Select());
            return pList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Invitations pe = entity as Invitations;
            pe.InvitationFlight = FlightDB.SelectById((int)reader["IdFlight"]);
            pe.InvitationPassenger = PassengerDB.SelectById((int)reader["IdPassenger"]);
            
            base.CreateModel(entity);
            return pe;
        }
        public override BaseEntity NewEntity()
        {
            return new Invitations();
        }
        static private InvitationsList list = new InvitationsList();
        public static Invitations SelectById(int id)
        {
            InvitationsDB db = new InvitationsDB();
            list = db.SelectAll();

            Invitations g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Invitations c = entity as Invitations;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM InvitationsTBL  WHERE id=@pid";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Invitations c = entity as Invitations;
            if (c != null)
            {
                string sqlStr = $"Insert INTO InvitationsTBL (IdFlight,IdPassenger) VALUES (@idflight,@idpassenger)";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@idflight", c.InvitationFlight.Id));
                command.Parameters.Add(new OleDbParameter("@idpassenger", c.InvitationPassenger.Id));

            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Invitations c = entity as Invitations;
            if (c != null)
            {
                string sqlStr = $"UPDATE InvitationsTBL  SET IdFlight=@invFlight,IdPassenger=@invPassenger" +
                    $" WHERE Id=@Id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@invFlight", c.InvitationFlight.Id));
                command.Parameters.Add(new OleDbParameter("@invPassenger", c.InvitationPassenger.Id));
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
