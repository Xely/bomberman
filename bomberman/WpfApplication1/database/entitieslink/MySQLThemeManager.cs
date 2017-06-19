using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpfBomberman.entities;

namespace wpfBomberman.database.entitieslinks
{
    public class MySQLThemeManager : MySQLManager<Theme>
    {
        public void GetColor(Theme theme)
        {
            bool isDetached = this.Entry(theme).State == EntityState.Detached;
            if (isDetached)
                this.DbSetT.Attach(theme);
            this.Entry(theme).Reference(x => x.Color).Load();
        }
    }
}
