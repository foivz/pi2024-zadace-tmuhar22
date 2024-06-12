using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using Zadaca_03.Models;

namespace Zadaca_03.Repositories
{
    internal class MeniRepository
    {
        public static Menus GetMeni(int id)
        {
            Menus meni = null;
            string sql = $"SELECT * FROM Menus";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                meni = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return meni;
        }

        public static List<Menus> GetMenus()
        {
            List<Menus> menus = new List<Menus>();
            string sql = $"SELECT * FROM Menus";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Menus meni = CreateObject(reader);
                menus.Add(meni);
            }
            reader.Close();
            DB.CloseConnection();
            return menus;
        }

        private static Menus CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string name = reader["Name"].ToString();
            string ingredients = reader["Ingredients"].ToString();
            string description = reader["Description"].ToString();
            var meni = new Menus
            {
                Id = id,
                Name = name,
                Ingredients = ingredients,
                Description = description
            };
            return meni;
        }

        public static int GetMenuIdByName(string menuName)
        {
            int menuId = -1;
            string sql = $"SELECT Id FROM Menus WHERE Name = '{menuName}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                menuId = int.Parse(reader["Id"].ToString());
                reader.Close();
            }
            DB.CloseConnection();
            return menuId;
        }
    }
}
