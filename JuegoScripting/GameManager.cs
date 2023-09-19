namespace JuegoScripting
{
    public class GameManager
    {
        public Player goo;
        public LevelManager levelManager;
        bool IsGamePaused;

        public bool EndGameCalled { get; private set; }

        public void EndGame()
        {
            Console.WriteLine("Game Ended");

            EndGameCalled = true;
        }
        public void PauseGame()
        {

        }
        public void HandleCollision(Character character, Character otherCharacter)
        {
            if (character is IDealDamage && otherCharacter is IDealDamage)
            {
                IDealDamage attacker = character as IDealDamage;
                IDealDamage target = otherCharacter as IDealDamage;

                int attackerPower = attacker.GetPower();
                int targetPower = target.GetPower();

                if (attackerPower > targetPower)
                {
                    // El personaje con más poder ataca
                    attacker.DealDamage(target);
                }
                else
                {
                    // El personaje con menos poder recibe daño
                    target.DealDamage(attacker);
                }
            }
        }
        public void RestartLevel()
        {

        }
           
    }
}