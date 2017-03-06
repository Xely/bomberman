using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpfBomberman.entities.bases;

namespace wpfBomberman.entities
{
    public class Theme : BaseDBEntity
    {
        private String backgroundImage;
        private Color color;

        public string BackgroundImage
        {
            get
            {
                return backgroundImage;
            }

            set
            {
                backgroundImage = value;
                OnPropertyChanged("BackgroundImage");
            }
        }

        public Color Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
                OnPropertyChanged("Color");
            }
        }
    }
}
