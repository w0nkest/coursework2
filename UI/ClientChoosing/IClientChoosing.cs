using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace UI
{
    internal interface IClientChoosing
    {
        void clientListUpdate(Client client);

        void raiseMsgBox(string msg);
    }
}
