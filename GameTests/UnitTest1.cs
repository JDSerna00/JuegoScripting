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
        public void TestHandleCollision_PlayerHasMorePower()
        {
            // Arrange
            GameManager gameManager = new GameManager();
            Player player = new Player(3);
            Enemy enemy = new Enemy(2); // Enemy con menos poder

            // Act
            gameManager.HandleCollision(player, enemy);

            // Assert          
            Assert.AreEqual(0, enemy.lives);
        }
    }
}