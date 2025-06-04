using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;
using Microsoft.Data.Sqlite;
using SQLitePCL;

namespace UI
{
    internal class AdminClientPresenter : IAdminClientPresenter
    {
        private IAdminClient view;
        private List<ClientFacade> clients;

        public AdminClientPresenter(IAdminClient view, List<ClientFacade> clients) { this.view = view; this.clients = clients; productListLoad(); }

        public void productListLoad()
        {
            foreach (var client in clients)
            {
                view.clientListSet(client);
            }
        }

        public void setSelectedData(ClientFacade client)
        {
            if (clients is not null)
            {
                view.textBoxNameSet(client.GetName());
                view.textBoxCardSet(client.GetCardMoney().ToString());
                view.textBoxCashSet(client.GetCash().ToString());
                view.textBoxBonusSet(client.GetBonus().ToString());

                //view.setMaxToNumerics(client.GetCardMoney(), client.GetCash());
            }
            else view.raiseMsgBox("Клиент не выбран");
        }

        public void deletingClient(ClientFacade client)
        {
            if (client is not null)
            {
                view.clientListRemove(client);
                view.textBoxNameSet("");
                view.textBoxCardSet("");
                view.textBoxCashSet("");
                view.textBoxBonusSet("");
                clientDeleting(client);
            }
            else view.raiseMsgBox("Клиент не выбран");
        }

        public void addingClient(string name)
        {
            if (name.Length == 0)
                view.raiseMsgBox("Имя нового клиета не установлено!");
            else
            {
                ClientFacade c = new ClientFacade(new Client(name));
                view.clientListAdd(c);

                newClientAdding(c);
            }
        }

        public void cardTransaction(ClientFacade client, int value, bool operation)     // operation = true iquals adding money, othervise false = withdrawing
        {
            if (client is not null)
            {
                if (value > 0)
                {
                    if (operation)
                        client.AddCardMoney(value);
                    else
                    {
                        if (value > client.GetCardMoney())
                        {
                            view.raiseMsgBox("Не может быть снято больше денег, чем есть на счету!");
                        }
                        else client.WithdrawCardMoney(value);
                    }
                }
                else
                {
                    view.raiseMsgBox("Значние для транзакции не может быть нулевым или отрицательным!");
                }
                view.textBoxCardSet(client.GetCardMoney().ToString());
                clientUpdating(client);
            }
            else view.raiseMsgBox("Клиент не выбран!");
        }

        public void cashTransaction(ClientFacade client, int value, bool operation)     // operation = true iquals adding money, othervise false = withdrawing
        {
            if (client is not null)
            {
                if (value > 0)
                {
                    if (operation)
                        client.AddCash(value);
                    else
                    {
                        if (value > client.GetCash())
                        {
                            view.raiseMsgBox("Не может быть снято больше денег, чем есть на счету!");
                        }
                        else client.WithdrawCash(value);
                    }
                }
                else
                {
                    view.raiseMsgBox("Значние для транзакции не может быть нулевым или отрицательным!");
                }
                view.textBoxCashSet(client.GetCash().ToString());
                clientUpdating(client);
            }
            else view.raiseMsgBox("Клиент не выбран!");
        }

        private void newClientAdding(ClientFacade client)
        {
            Batteries.Init();
            string pathdb = @"..\..\..\Resources\product_database.db";
            using (var connection = new SqliteConnection($"Data Source={pathdb}"))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        int cardID = bankCardAddSQL(client, connection);

                        using (var command = connection.CreateCommand())
                        {
                            command.CommandText = "INSERT INTO clients (name, card_id, cash)" +
                                $"VALUES ('{client.GetName()}', {cardID}, {client.GetCash()})";
                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch
                    { 
                        transaction.Rollback();
                    }
                }
                connection.Close();
            }
        }

        private int bankCardAddSQL(ClientFacade c, SqliteConnection con)
        {
            using (var command = con.CreateCommand())
            {
                Wallet w = c.GetWallet();

                command.CommandText = "INSERT INTO bankcards (bank_name, number, cvc, money)" +
                    $"VALUES ('{w.bankCard.Bank}', '{w.bankCard.Number}', '{w.bankCard.CVC}', {w.bankCard.Money});" +
                    $"SELECT last_insert_rowid();";

                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        private void clientDeleting(ClientFacade client)
        {
            Batteries.Init();
            string pathdb = @"..\..\..\Resources\product_database.db";
            int cid = client.IDs()["cID"];

            using (var connection = new SqliteConnection($"Data Source={pathdb}"))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        int cardid = -1;
                        using (var searchcard = connection.CreateCommand())
                        {
                            searchcard.CommandText = $"SELECT card_id FROM clients WHERE ID = {cid}";
                            var result = searchcard.ExecuteScalar();
                            cardid = Convert.ToInt32(result);
                        }

                        using (var deletebonus = connection.CreateCommand())
                        {
                            deletebonus.CommandText = $"DELETE FROM bonus_transaction WHERE bonus = {cid}";
                            deletebonus.ExecuteNonQuery();
                        }

                        using (var deleteclient = connection.CreateCommand())
                        {
                            deleteclient.CommandText = $"DELETE FROM clients WHERE ID = {cid}";
                            int rowsAffected = deleteclient.ExecuteNonQuery();
                        }

                        if (cardid != -1)
                        {
                            using (var deletecard = connection.CreateCommand())
                            {
                                deletecard.CommandText = $"DELETE FROM bankcards WHERE ID = {cardid}";
                                deletecard.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                    }
                }
                connection.Close();
            }
        }

        private void clientUpdating(ClientFacade client)
        {
            Batteries.Init();
            string pathdb = @"..\..\..\Resources\product_database.db";
            int cid = client.IDs()["cID"];
            int cardId = client.IDs()["bID"];

            using (var connection = new SqliteConnection($"Data Source={pathdb}"))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (var updateClient = connection.CreateCommand())
                        {
                            updateClient.CommandText = $"UPDATE clients SET name = '{client.GetName()}', cash = {client.GetCash()} WHERE ID = {cid}";
                            updateClient.ExecuteNonQuery();
                        }

                        using (var updateCard = connection.CreateCommand())
                        {
                            updateCard.CommandText = $"UPDATE bankcards SET money = {client.GetCardMoney()} WHERE ID = {cardId}";
                            updateCard.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                    }
                }
            }
        }
    }
}
