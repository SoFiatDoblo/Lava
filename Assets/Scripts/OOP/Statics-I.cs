using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class Enemy
    {
        public static int enemyCount = 0;

        public Enemy()
        {
            enemyCount++;
        }
    }

    public class Gaming
    {
        void Start () 
        {
            Enemy enemy1 = new Enemy();
            Enemy enemy2 = new Enemy();
            Enemy enemy3 = new Enemy();

            int x = Enemy.enemyCount;
        }
    }
    public class PlayerAndEnemy : MonoBehaviour
    {
        public static int playerCount = 0;
        //Static variables are shared across all instances of a class. 
        void Start()
        {            
            playerCount++;
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
    public class PlayerManager : MonoBehaviour 
    {
        void Start()
        {      
            int x = PlayerAndEnemy.playerCount;
        }
    }
    public class Utilities : MonoBehaviour 
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}