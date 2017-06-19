using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpfBomberman.entities;

namespace wpfBomberman.database.entitieslinks
{
    public class MySQLAddressManager : MySQLManager<Map>
    {
        public void GetStreetNumber(Map map)
        {
            bool isDetached = this.Entry(map).State == EntityState.Detached;
            if (isDetached)
                this.DbSetT.Attach(map);
            //this.Entry(map).Reference(x => x.StreetNumber).Load();
        }
    }
}
