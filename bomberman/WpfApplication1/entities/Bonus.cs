using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpfBomberman.entities.bases;

namespace wpfBomberman.entities
{
    public class Bonus : BaseDBEntity
    {
        private int xCoor;
        private int yCoor;
        private BonusType bonusType;
        private int value;

        public int XCoor
        {
            get
            {
                return xCoor;
            }

            set
            {
                xCoor = value;
                OnPropertyChanged("XCoor");
            }
        }

        public int YCoor
        {
            get
            {
                return yCoor;
            }

            set
            {
                yCoor = value;
                OnPropertyChanged("YCoor");
            }
        }

        public BonusType BonusType
        {
            get
            {
                return bonusType;
            }

            set
            {
                bonusType = value;
                OnPropertyChanged("BonusType");
            }
        }

        public int Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
                OnPropertyChanged("Value");
            }
        }
    }
}
