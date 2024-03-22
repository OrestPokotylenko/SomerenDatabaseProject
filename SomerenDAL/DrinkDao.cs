﻿using SomerenModel;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class DrinkDao : BaseDao<Drink>
    {
        private protected override Drink Convert(DataRow reader)
        {
            int id = (int)reader["drink_id"];
            string name = (string)reader["name"];
            decimal price = (decimal)reader["price"];
            int stock = (int)reader["stock"];
            int vat = (int)reader["vat"];

            return new Drink(id, name, price, stock, vat);
        }

        private protected override string GetAllQuery()
        {
            return "SELECT drink_id, name, price, stock, vat FROM drink";
        }

        public void AddDrink(Drink drink)
        {
            string query = "INSERT drink(drink_id, name, price, stock, vat) VALUES (@drink_id, @name, @price, @stock, @vat)";
            
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@drink_id", SqlDbType.Int) {Value = drink.Id},
                new SqlParameter("@name", SqlDbType.VarChar) {Value = drink.Name},
                new SqlParameter("@price", SqlDbType.Decimal) {Value = drink.Price},
                new SqlParameter("@stock", SqlDbType.Int) {Value = drink.Stock},
                new SqlParameter("@vat", SqlDbType.Int) {Value = drink.Vat}
            };

            ExecuteEditQuery(query, parameters);
        }
        public void DeleteDrink(Drink drink)
        {
            string query = "DELETE FROM drink WHERE drink_id = @id";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", SqlDbType.Int) {Value = drink.Id}
            };

            ExecuteEditQuery(query, parameters);
        }
        public void UpdateDrink(Drink drink)
        {
            string query = "UPDATE drink SET name = @name, price = @price, stock = @stock, vat = @vat WHERE drink_id = @id";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", SqlDbType.Int) {Value = drink.Id},
                new SqlParameter("@name", SqlDbType.VarChar) {Value = drink.Name},
                new SqlParameter("@price", SqlDbType.Decimal) {Value = drink.Price},
                new SqlParameter("@stock", SqlDbType.Int) {Value = drink.Stock},
                new SqlParameter("@vat", SqlDbType.Int) {Value = drink.Vat}
            };

            ExecuteEditQuery(query, parameters);
        }
    }
}
