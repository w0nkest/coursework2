using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace UI
{
    internal class ClientChoosingPresenter : IClientChoosingPresenter
    {
        private IClientChoosing view;

        public ClientChoosingPresenter(IClientChoosing form, List<ClientFacade> clients) 
        { 
            view = form; 
            foreach (var client in clients)
                view.clientListUpdate(client);
        }

        public void closeTab(Form frm)
        {
            view.raiseMsgBox("Обратитесь к администратору для регистрации!");
            frm.Close();
        }
        
        public void openNewTab(List<Goods> goods, ClientFacade client)
        {
            if (client is not null)
                (new ClientForm(goods, client)).ShowDialog();
            else view.raiseMsgBox("Никто не был выбран!");
        }
    }
}
