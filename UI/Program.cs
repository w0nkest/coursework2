using Classes;
using Microsoft.Data.Sqlite;
using System.Globalization;

namespace UI
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            List<Goods> productList = new List<Goods>();
            List<Client> clientList = new List<Client>();   

            SQLitePCL.Batteries.Init();

            string pathdb = @"..\..\..\Resources\product_database.db";

            using (var connection = new SqliteConnection($"Data Source={pathdb}"))
            {
                connection.Open();
                var command = connection.CreateCommand();

                command.CommandText =
                    "SELECT * FROM single_products";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        productList.Add(new SingleGoods(reader["product"].ToString(), Convert.ToInt32(reader["price"])));
                    }
                }

                command.CommandText =
                    "SELECT * FROM time_products";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        productList.Add(new TimeGoods(reader["product"].ToString(), Convert.ToInt32(reader["price_per_hour"])));
                    }
                }

                command.CommandText =
                    "SELECT * FROM clients";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        BankCard card = createCardViaSQL(Convert.ToInt32(reader["card_id"]), connection);
                        Bonus bonus = getBonusAddingHistory(Convert.ToInt32(reader["ID"]), connection);

                        Wallet wallet = new Wallet(card, bonus);
                        wallet.Cash = Convert.ToInt32(reader["cash"]);

                        Client c = new Client(reader["name"].ToString(), wallet);

                        clientList.Add(c);
                    }
                }
            }

            Form menu = new MenuForm(clientList, productList);
            menu.ShowDialog();
        }

        private static BankCard createCardViaSQL(int cardID, SqliteConnection con)
        {
            using (var command = con.CreateCommand())
            {
                command.CommandText = $"SELECT * FROM bankcards WHERE ID = {cardID}";
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        BankCard c = new BankCard(reader["bank_name"].ToString(), reader["number"].ToString(), reader["cvc"].ToString());
                        c.Money = Convert.ToInt32(reader["money"]);

                        return c;
                    }
                }
            }
            return null;
        }

        private static Bonus getBonusAddingHistory(int bonusID, SqliteConnection con)
        {
            using (var command = con.CreateCommand())
            {
                command.CommandText = $"SELECT * FROM bonus_transaction WHERE bonus = {bonusID}";
                using (var reader = command.ExecuteReader())
                {
                    Bonus b = new Bonus();

                    while (reader.Read())
                    {
                        b.AddBonuses(DateTime.ParseExact(reader["datetime"].ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture), Convert.ToInt32(reader["value"]));
                    }

                    b.ClearBonuses();

                    return b;
                }
            }
        }
    }
}