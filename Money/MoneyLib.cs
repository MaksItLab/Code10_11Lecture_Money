using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    public class MoneyLib
    {
        private int _rub;
        private int _cop;

        public int Rub { 
            get
            {
                return _rub;
            }
            set 
            {
                _rub = value;
            }

        }
        public int Cop { 
            get
            {
                return _cop;
            }
            set
            {
                if (value >= 0 && value < 100) _cop = value;
                else _cop = 0;
            }
        }
        public MoneyLib() { }
        public MoneyLib(int rub, int cop)
        {
            Rub = rub;
            Cop = cop;
        }

        public static MoneyLib operator +(MoneyLib money1, MoneyLib money2)
        {
            int first_part = money1.Rub + money2.Rub;
            int second_part = money1.Cop + money2.Cop;
            bool secondPartMore = second_part >= 100 ? true : false;
            if (secondPartMore)
            {
                first_part++;
                second_part = second_part % 100;
            }

            return new MoneyLib { Rub = first_part, Cop = second_part };
        }
        
        //TODO: вычитание и метод для преобразования копеек в рубли

    }
}
