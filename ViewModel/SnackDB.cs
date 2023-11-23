using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel
{
    public class SnackDB : BaseDB
    {
        protected override BaseEntity NewEntity()
        {
            return new Snack();
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Snack snack = entity as Snack;
            snack.Id = int.Parse(reader["ID"].ToString());
            snack.Name = reader["SnackName"].ToString();
            snack.Sugar = int.Parse(reader["Sugar"].ToString());
            snack.Calories = int.Parse(reader["Calories"].ToString());
            snack.Company = reader["Company"].ToString();
            snack.Grams = int.Parse(reader["Grams"].ToString());
            snack.Price = int.Parse(reader["Price"].ToString());
            return snack;
        }

        public SnackList SelectAll()
        {
            this.command.CommandText = "SELECT * FROM TblSnacks";
            SnackList list = new SnackList(base.ExecuteCommand());
            return list;
        }

        public Snack SelectById(int id)
        {
            command.CommandText = $"SELECT * FROM TblSnacks WHERE ID = {id}";
            SnackList list = new SnackList(base.ExecuteCommand());
            if (list.Count == 1)
                return list[0];
            return null;
        }

        public SnackList SelectByUserId(int id)
        {
            command.CommandText = $"SELECT * FROM (TblSnacks INNER JOIN TblUsersSnacks ON TblSnacks.ID = TblUsersSnacks.SnackID) WHERE UserID = {id}";
            SnackList list = new SnackList(base.ExecuteCommand());
            return list;
        }

    }
}
