using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloSchleifen : MonoBehaviour
{
    public int[,] meineSchleife = new int[3, 5]; //3 Reihen und 5 Spalten   

    public int[] arrayX = new int[10];

    // int[,] für 2 dimensionale Array
    // int[,,] für 3 dimensionale Array


    // Start is called before the first frame update
    void Start()
    {

        for (int y = 0; y < meineSchleife.GetLength(1); y++) //1 is for second dimension colums Spalten
        {
            Debug.Log(y);

            for (int x = 0; x < meineSchleife.GetLength(0); x++) //0 is for first dimension rows Reihen
            {
                Debug.Log(x);
            }
        }

        for (int i = 0; i < arrayX.Length; i++)
        {
            arrayX[i] = i;
            Debug.Log(i + "huuuuuuuuuu");

        }


    }

    // Update is called once per frame
    void Update()
    {
      

    }
}
