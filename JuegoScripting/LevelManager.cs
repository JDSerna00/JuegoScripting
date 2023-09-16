using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoScripting
{
    public class LevelManager
    {
        int actualLevel = 1;
        public List<Enemy> activeEnemies = new List<Enemy>();

        public void LevelStart()
        {
            LoadLevel(actualLevel);
        }


        public void NextLevel()
        {
            actualLevel++;
            LoadLevel(actualLevel);
        }

        public void LoadLevel(int level)
        {
            Console.WriteLine($"level {level} loaded");
        }
        public void RestartLevel()
        {
            LoadLevel(actualLevel);
        }
        public void AddActiveEnemy(Enemy enemy)
        {
            activeEnemies.Add(enemy);
        }

        public void RemoveActiveEnemy(Enemy enemy)
        {
            activeEnemies.Remove(enemy);

            // Verificar si la lista de enemigos está vacía
            if (activeEnemies.Count == 0)
            {
                // Si no hay enemigos activos, avanzar al siguiente nivel
                NextLevel();
            }
        }
        // Start is called before the first frame update
        void Start()
        {
            LoadLevel(actualLevel);
        }
    }
}
