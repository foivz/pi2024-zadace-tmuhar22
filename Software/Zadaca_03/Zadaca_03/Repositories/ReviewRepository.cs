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
    internal class ReviewRepository
    {
        public static Reviews GetReview(int id)
        {
            Reviews review = null;
            string sql = $"SELECT r.*, m.Name AS MenuName FROM Reviews r JOIN Menus m ON r.IdMeni = m.Id WHERE r.Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                review = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return review;
        }

        public static List<Reviews> GetReviews()
        {
            List<Reviews> reviews = new List<Reviews>();
            string sql = "SELECT r.*, m.Name AS MenuName FROM Reviews r JOIN Menus m ON r.IdMeni = m.Id";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Reviews review = CreateObject(reader);
                reviews.Add(review);
            }
            reader.Close();
            DB.CloseConnection();
            return reviews;
        }

        private static Reviews CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            int meniId = int.Parse(reader["IdMeni"].ToString());
            int taste = int.Parse(reader["TasteGrade"].ToString());
            int quantity = int.Parse(reader["QuantityGrade"].ToString());
            string comment = reader["Comment"].ToString();
            DateTime dateOfReview = DateTime.Parse(reader["DateOfReview"].ToString());
            string menuName = reader["MenuName"].ToString();

            var review = new Reviews
            {
                Id = id,
                IdMeni = meniId,
                MenuName = menuName,
                TasteGrade = taste,
                QuantityGrade = quantity,
                Comment = comment,
                DateOfReview = dateOfReview
            };
            return review;
        }

        public static void DeleteReview(int id)
        {
            string sql = $"DELETE FROM Reviews WHERE Id = {id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static bool ReviewExists(int id)
        {
            bool exists = false;
            string sql = $"SELECT COUNT(*) FROM Reviews WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                int count = int.Parse(reader[0].ToString());
                exists = count > 0;
                reader.Close();
            }
            DB.CloseConnection();
            return exists;
        }

        public static void InsertReview(Reviews review)
        {
            if (ReviewExists(review.Id))
            {
                throw new Exception("Recenzija s tim id-em već postoji.");
            }
            string sql = $"INSERT INTO Reviews (Id, IdMeni, TasteGrade, QuantityGrade, Comment, DateOfReview) VALUES ({review.Id},{review.IdMeni}, {review.TasteGrade}, {review.QuantityGrade}, '{review.Comment}', '{review.DateOfReview:yyyy-MM-dd HH:mm:ss}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void UpdateReview(Reviews review)
        {
            string sql = $"UPDATE Reviews SET Id = {review.Id}, IdMeni = {review.IdMeni}, TasteGrade = {review.TasteGrade}, QuantityGrade = {review.QuantityGrade}, Comment = '{review.Comment}', DateOfReview = '{review.DateOfReview:yyyy-MM-dd HH:mm:ss}' WHERE Id = {review.Id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
