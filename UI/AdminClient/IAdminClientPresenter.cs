using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal interface IAdminClientPresenter
    {
        void productListLoad();

        void setSelectedData(ClientFacade client);

        void deletingClient(ClientFacade client);

        void addingClient(string name);

        void cardTransaction(ClientFacade client, int value, bool operation);

        void cashTransaction(ClientFacade client, int value, bool operation);
    }
}
