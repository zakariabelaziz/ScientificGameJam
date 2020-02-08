using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomInt : IRandomInterface
{
    string _RandomIntName = nameof(RandomInt);
    private List<int> _ListRandomInt;
    private static RandomInt _Instance = null;
   

    public static RandomInt GetInstance()
    {
            if (_Instance == null)
            {
                _Instance = new RandomInt();
            }
            return _Instance;
        

    }

   private RandomInt()
    {
        if(_ListRandomInt == null)
        {
            _ListRandomInt = new List<int>();
        }
    }

    public string RandomTypeName { get => _RandomIntName; set => _RandomIntName = value; }

    public void add<T>(T item)
    {
        if (item is int a)
        {
            _ListRandomInt.Add(a);
        }
     }

    public T getRandomObject<T>()
    {
        if (_ListRandomInt[Random.Range(0, max: _ListRandomInt.Capacity)] is T a)
        {
            return a;
        }

        throw new System.NotImplementedException();

    }

    public void remove<T>(T item)
    {
        throw new System.NotImplementedException();
    }

   
}