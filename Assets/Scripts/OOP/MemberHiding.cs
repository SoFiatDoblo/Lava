using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humanoid
{    
    public void Yell()
    {
        Debug.Log ("Humanoid version of the Yell() method");
    }
}
public class Enemy : Humanoid
{    
    new public void Yell()
    {
        Debug.Log ("Enemy version of the Yell() method");
    }
}

public class Orc : Enemy
{    
    new public void Yell()
    {
        Debug.Log ("Orc version of the Yell() method");
    }
}

public class HidingParticipants : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Humanoid human = new Humanoid();
        Humanoid enemy = new Enemy();
        Humanoid orc = new Orc();
        
        human.Yell();
        enemy.Yell();
        orc.Yell();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
