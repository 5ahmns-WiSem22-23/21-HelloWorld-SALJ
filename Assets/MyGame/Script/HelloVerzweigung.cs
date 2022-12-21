using System;
using UnityEngine;

public class HelloVerzweigung : MonoBehaviour
{

    public int a = 10;
    public int b = 5;
    public int c = 2;
    public int d = 12;
    
    void Start()
    {
        if (a<b)
        {
            Debug.Log("a<b");

        }
        else
        {
            Debug.Log("a!<b");
        }


        if (b==c)
        {
            Debug.Log("b==c");
        }
        else if(c<d)
        {
            Debug.Log("c<d");
        }

        if (a>b)
        {
            return;
            Debug.Log("a>b");
        }

        int i = 2;

        switch (i)
        {
            case 1:
                Debug.Log("1");
                break;

            case 2:
                Debug.Log("2");
                break;

            case 3:
                Debug.Log("3");
                break;
        }

        if (d>c)
        {
            if (a>b)
            {
                Debug.Log("a>b");
            }
            else
            {
                Debug.Log("a!>b");
            }
        }
    }

    
    void Update()
    {
        
    }
}
