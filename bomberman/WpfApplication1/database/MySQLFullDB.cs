using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpfBomberman.entities;
using wpfBomberman.json;

namespace wpfBomberman.database
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class MySQLFullDB : DbContext
    {
        public DbSet<Bonus> BonusTable { get; set; }
        public DbSet<BonusType> BonusTypeTable { get; set; }
        public DbSet<Character> CharacterTable { get; set; }
        public DbSet<Color> ColorTable { get; set; }
        public DbSet<Map> MapTable { get; set; }
        public DbSet<Npc> NpcTable { get; set; }
        public DbSet<Theme> ThemeTable { get; set; }
        public DbSet<Wall> WallTable { get; set; }

        public MySQLFullDB() : base(JsonManager.Instance.ReadFile<ConnectionString>(@"D:\Documents\Cours\c#\bomberman\jsonconfig\", @"MysqlConfig.json").ToString())
        {
            InitLocalMySQL();
        }

        public void InitLocalMySQL()
        {
            this.Database.CreateIfNotExists();            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
