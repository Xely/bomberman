using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpfBomberman.entities.bases;

namespace wpfBomberman.entities
{
    public class Wall : BaseDBEntity
    {
        private int xCoor;
        private int yCoor;

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
    }
}
