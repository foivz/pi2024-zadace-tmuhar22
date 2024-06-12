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
    internal class UpdateRepository
    {
        public static Updates GetUpdate(Reviews review, Menus meni)
        {
            Updates updates = null;
            string sql = $"SELECT * FROM Updates WHERE idReviews = {review.Id} AND idMenus = { meni.Id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                updates = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return updates;
        }

        public static List<Updates> GetEvaluations(Reviews review)
        {
            List<Updates> updates = new List<Updates>();
            string sql = $"SELECT * FROM Updates WHERE idReviews = {review.Id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Updates update = CreateObject(reader);
                updates.Add(update);
            }
            reader.Close();
            DB.CloseConnection();
            return updates;
        }

        private static Updates CreateObject(SqlDataReader reader)
        {
            int idMenus = int.Parse(reader["idMenus"].ToString());
            var meni = MeniRepository.GetMeni(idMenus);
            int idReviews = int.Parse(reader["IdReviews"].ToString());
            var review = ReviewRepository.GetReview(idReviews);
            DateTime UpdateDate = DateTime.Parse(reader["updateDate"].ToString());
            var update = new Updates
            {
                Menus = meni,
                Reviews = review,
                UpdateDate = UpdateDate,

            };
            return update;
        }
    }
}
