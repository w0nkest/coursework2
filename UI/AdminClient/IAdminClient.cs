using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal interface IAdminClient
    {
        void clientListSet(ClientFacade client);

        void clientListRemove(ClientFacade client);

        void clientListAdd(ClientFacade client);

        void textBoxNameSet(string msg);

        void textBoxCardSet(string msg);

        void textBoxCashSet(string msg);

        void textBoxBonusSet(string msg);

        void raiseMsgBox(string msg);

        void setMaxToNumerics(int maxcard, int maxcash);
    }
}
