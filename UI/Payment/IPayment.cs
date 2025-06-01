using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace UI
{
    internal interface IPayment
    {
        void userInfo_SetText(string msg);

        void userInfoLeft_SetText(string msg);

        void setSum(string msg);

        void setSumLeft(string sum);

        void setCardSum(int value);

        void setCashSum(int value);

        void setBonusSum(int value);

        List<Goods> getCart();

        List<int> numericValues();

        int getCardValue();

        int getBonusValue();

        int getCashValue();

        void raiseMsgBox(string msg);
    }
}
