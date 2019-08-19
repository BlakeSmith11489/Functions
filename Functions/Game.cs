using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Game
    {
        int numberOne = 10;
        int numberTwo = 200;
    //    int playerHealth = 100;
    //    int monsterDamage = 30;

          public void Start()
          {
            int biggestNumber = /*ReturnBiggestNumber(numberOne,*/ numberTwo;

            Console.WriteLine("Of " + numberOne + " and " + numberTwo + " the biggest number is " + biggestNumber);
            Console.ReadKey();

    //        Console.WriteLine("My game has begun!");
    //        Console.ReadKey();

    //        MonsterEncounter();
    //        MonsterAttacks(monsterDamage * 2);
    //        MonsterAttacks(monsterDamage);
    //        MonsterAttacks(monsterDamage * 3);

    //        /damage = 5;
    //    }

    //    private void MonsterEncounter()
    //    {
    //        Console.WriteLine("A vicous monster appears!");
    //        Console.ReadKey();
    //    }

    //    //private void MonsterAttacks()
    //    private void MonsterAttacks(int damage)
    //    {
    //        int combo = 0;
    //        combo += 1;
    //        playerHealth -= monsterDamage;
    //        Console.WriteLine("The monster attacks you for " + monsterDamage + " points of damage. You have " + playerHealth + " health left.");
    //        Console.ReadKey();
          }
        int ReturnBiggestNumber(int first, int second)
        {
            if(first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
