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
        public DbSet<Theme> ThemeTable { get; set; }
        public DbSet<Map> MapTable { get; set; }
        public DbSet<Cell> CellTable { get; set; }
        public DbSet<Character> CharacterTable { get; set; }
        public DbSet<Color> ColorTable { get; set; }

        public MySQLFullDB() : base(JsonManager.Instance.ReadFile<ConnectionString>(@"..\..\..\jsonconfig\", @"MysqlConfig.json").ToString())
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
