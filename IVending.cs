using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_machine
{
    public interface IVending
    {
        void showAll();

        int purchase(int balance);

        int insertMoney();

        void endTransaction(int remainder);
    }
}
