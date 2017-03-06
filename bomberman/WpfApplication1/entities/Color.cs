using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpfBomberman.entities.bases;

namespace wpfBomberman.entities
{
    public class Color : BaseDBEntity
    {
        private String name;
        private String hexCode;
        
        public String Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public String HexCode
        {
            get
            {
                return hexCode;
            }

            set
            {
                hexCode = value;
                OnPropertyChanged("HexCode");
            }
        }
    }
}
