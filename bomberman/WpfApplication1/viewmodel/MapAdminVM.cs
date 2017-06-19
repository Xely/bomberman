using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpfBomberman.database;
using wpfBomberman.entities;
using wpfBomberman.views.admin;

namespace wpfBomberman.viewmodel
{
    class MapAdminVM
    {

        private Map currentMap;
        private MapAdmin mapAdmin;
        MySQLManager<Map> mapManager = new MySQLManager<Map>();
        ObservableCollection<Map> mapList = new ObservableCollection<Map>();

        public object UCMapList { get; private set; }

        public MapAdminVM(MapAdmin mapAdmin)
        {
            this.mapAdmin = mapAdmin;

            InitUC();
            InitActions();
        }

        
        private void InitUC()
        {
            currentMap = new Map();
            this.mapAdmin.ucMap.Map = currentMap;
        }

        private void InitActions()
        {
            
        }
    }
}
