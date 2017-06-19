using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpfBomberman.entities;

namespace wpfBomberman.database.entitieslinks
{
    public class MySQLBonusManager : MySQLManager<Bonus>
    {
        public void GetBonusType(Bonus bonus)
        {
            bool isDetached = this.Entry(bonus).State == EntityState.Detached;
            if (isDetached)
                this.DbSetT.Attach(bonus);
            this.Entry(bonus).Reference(x => x.BonusType).Load();
        }
    }
}
