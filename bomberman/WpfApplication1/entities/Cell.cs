using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpfBomberman.entities.bases;

namespace wpfBomberman.entities
{
    public class Cell : BaseDBEntity
    {
        private int xCoor;
        private int yCoor;
        private Boolean isAWall;
        private Map map;

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

        public Boolean IsAWall
        {
            get
            {
                return isAWall;
            }

            set
            {
                isAWall = value;
                OnPropertyChanged("IsAWall");
            }
        }

        public Map Map
        {
            get
            {
                return map;
            }

            set
            {
                map = value;
                OnPropertyChanged("Map");
            }
        }
    }
}
