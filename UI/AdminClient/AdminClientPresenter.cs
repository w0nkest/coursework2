using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace UI
{
    internal class AdminClientPresenter
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
            }
            else view.raiseMsgBox("Клиент не выбран!");
        }
    }
}
