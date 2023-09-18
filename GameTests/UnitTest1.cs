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
        public void TestHandleCollision_EnemyDies()
        {
            GameManager gameManager = new GameManager();
            LevelManager levelManager = new LevelManager();
            Player player = new Player(3, gameManager);
            Enemy enemy = new Enemy(2, levelManager); // Enemy con menos poder
            gameManager.HandleCollision(player, enemy);         
            Assert.AreEqual(0,enemy.lives);
        }

        [Test]

        public void TestHandleCollision_PlayerGainsPower()
        {
            GameManager gameManager = new GameManager();
            LevelManager levelManager = new LevelManager();
            Player player = new Player(3, gameManager);
            Enemy enemy = new Enemy(2, levelManager); // Enemy con menos poder
            gameManager.HandleCollision(player, enemy);
            Assert.AreEqual(5, player.power);
        }

        [Test]
        public void TestPickUp()
        {
            GameManager gameManager = new GameManager();
            Player player = new Player(3,gameManager);
            Collectible pickup = new Collectible(4);
            pickup.PickUp(player);
            Assert.AreEqual(7, player.power);
        }

        [Test]

        public void TestLives()
        {
            GameManager gameManager = new GameManager();
            int LivesNum = 3;
            var player = new Player (3,gameManager);
            Assert.AreEqual(LivesNum, player.lives);

        }

        [Test]

        public void TestDamageHurtPlayer()
        {
            GameManager gameManager = new GameManager();
            var player = new Player(3,gameManager);
            player.TakeDamage(1);
            Assert.AreEqual (2, player.lives);

        }

        [Test]

        public void TestInvinciblePlayer()
        {
            GameManager gameManager = new GameManager();
            var player = new Player (3, gameManager);
            player.TakeDamage(-1);
            player.TakeDamage(1);
            Assert.AreEqual(3, player.lives);

        }

        [Test]
        public void TestEnemyDamage()
        {
            var levelManager = new LevelManager();
            var enemy = new Enemy(2, levelManager);

            enemy.TakeDamage(1);

            Assert.AreEqual(0, enemy.lives);



        }
    }
}