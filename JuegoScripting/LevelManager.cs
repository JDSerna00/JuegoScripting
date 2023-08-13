using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoScripting
{
    internal class LevelManager
    {
        int actualLevel;
        private List<Enemy> activeEnemies = new List<Enemy>();
        private List<Collectible> levelCollectibles = new List<Collectible>();
        public UIManager uiManager;

        public void LevelStart() 
        {

        }

        public bool EnemiesCleared()
        {
            return false;
        }

        public void NextLevel()
        {
            actualLevel++;
        }

        public void generateEnemies()
        {

        }
        public void GenerateCollectibles() 
        {

        }
    }
}
