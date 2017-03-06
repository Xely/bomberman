using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpfBomberman.entities.bases;

namespace wpfBomberman.entities
{
    public class Map : BaseDBEntity
    {
        private int height;
        private int width;

        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
                OnPropertyChanged("Height");
            }
        }

        public int Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
                OnPropertyChanged("Width");
            }
        }
    }
}
