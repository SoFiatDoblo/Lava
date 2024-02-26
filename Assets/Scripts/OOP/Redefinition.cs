using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits 
{
    public Fruits ()
    {
        Debug.Log("1st Fruits Constructor Called");
    }

    public virtual void Chop ()
    {
        Debug.Log("The fruits has been chopped.");        
    }

    public virtual void SayHello ()
    {
        Debug.Log("Hello, I am a fruit.");
    }
}
public class Grape : Fruits 
{
    public Grape ()
    {
        Debug.Log("1st Grape Constructor Called");
    }

    public override void Chop ()
    {
        base.Chop();
        Debug.Log("The grape has been chopped.");        
    }

    public override void SayHello ()
    {
        base.SayHello();
        Debug.Log("Hello, I am a grape.");
    }
}
public class Redefinition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Grape myGrape = new Grape();

        myGrape.SayHello();
        myGrape.Chop();    

        Fruits myFruits = new Grape();
        myFruits.SayHello();
        myFruits.Chop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
