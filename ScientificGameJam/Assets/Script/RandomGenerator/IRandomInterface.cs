using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IRandomInterface 
{
   string RandomTypeName
    {
        get;
        set;
    }

    void add<T>(T item);
    void remove<T>(T item);
    T getRandomObject<T>();


}
