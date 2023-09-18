using System.Numerics;
using System;
using JuegoScripting;

namespace GameTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void TestHandleCollision_PlayerHasMorePower()
        {
            GameManager gameManager = new GameManager();
            LevelManager levelManager = new LevelManager();
            Player player = new Player(3, gameManager);
            Enemy enemy = new Enemy(2, levelManager); // Enemy con menos poder
            int initialLives = enemy.lives;
            gameManager.HandleCollision(player, enemy);         
            Assert.Less(enemy.lives,initialLives);
        }
    }
}