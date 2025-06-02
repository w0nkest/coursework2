using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal interface IClientChoosingPresenter
    {
        void closeTab(Form frm);

        void openNewTab(List<Goods> goods, Client client);
    }
}
