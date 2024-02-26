using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class 
{
    public T GenericMethod<T>(T param)
    {
        return param;
    }
}
public class OtherClass : MonoBehaviour 
{
    void Start () 
    {
        Class myClass = new Class();
        myClass.GenericMethod<int>(5);
    }
}
public class GenericClass <T>
{
    T item;

    public void UpdateItem(T newItem)
    {
        item = newItem;
    }
}
public class Generics : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GenericClass<int> myClass = new GenericClass<int>();
        myClass.UpdateItem(5);
    }
}
