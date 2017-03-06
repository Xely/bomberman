using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpfBomberman.entities.bases;
using wpfBomberman.entities.enums;

namespace wpfBomberman.entities
{
    public class Character : BaseDBEntity
    {
        private Gender gender;
        private String name;

        public Gender Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
                OnPropertyChanged("Gender");
            }
        }

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
    }
}
