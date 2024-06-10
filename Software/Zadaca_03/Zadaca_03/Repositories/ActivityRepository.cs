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
    internal class ActivityRepository
    {
        public static Activity GetActivity(int id)
        {
            Activity activity = null;
            string sql = $"SELECT * FROM Orders WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                activity = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return activity;
        }

        public static List<Activity> GetActivities()
        {
            List<Activity> activities = new List<Activity>();
            string sql = "SELECT * FROM Orders";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Activity activity = CreateObject(reader);
                activities.Add(activity);
            }
            reader.Close();
            DB.CloseConnection();
            return activities;
        }

        private static Activity CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["OrderId"].ToString());
            string name = reader["OrderName"].ToString();
            string description = reader["OrderDescription"].ToString();
            int maxPoints = int.Parse(reader["MaxGrade"].ToString());
            int minPoints = int.Parse(reader["MinGrade"].ToString());
            var activity = new Activity
            {
                OrderId = id,
                OrderName = name,
                OrderDescription = description,
                MaxGrade = maxPoints,
                MinGrade = minPoints,
            };
            return activity;
        }

    }
}
