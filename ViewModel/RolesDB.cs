using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class RolesDB : BaseDB
    {

        public RolesList SelectAll()
        {
            command.CommandText = $"SELECT *      FROM RolesTBL";

            RolesList rolesList = new RolesList(base.Select());
            return rolesList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Roles c = entity as Roles;
            c.RoleName = reader["RoleName"].ToString();
            base.CreateModel(entity);
            return entity;
        }
        public override BaseEntity NewEntity()
        {
            return new Roles();
        }
        static private RolesList list = new RolesList();
        public static Roles SelectById(int id)
        {
            RolesDB db = new RolesDB();
            list = db.SelectAll();
            Roles g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Roles c = entity as Roles;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM RolesTBL WHERE id=@pid";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Roles c = entity as Roles;
            if (c != null)
            {
                string sqlStr = $"Insert INTO RolesTBL (RoleName) VALUES (@roleName)";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@roleName", c.RoleName));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Roles c = entity as Roles;
            if (c != null)
            {
                string sqlStr = $"UPDATE RolesTBL  SET RoleName=@roleName WHERE Id=@Id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@roleName", c.RoleName));
                command.Parameters.Add(new OleDbParameter("@Id", c.Id));
                }
            }
    }
}
