using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HausUebung : MonoBehaviour
{

    public string[,] myArray = new string[3, 4]; //erste Zahl Reihen und zweite Spalten

    [SerializeField]
    private string[] alphabet = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L" };

    private int alphabetIndex = 0;

    public string[,] array = new string[3, 4]
    {
        {"A", "B", "C", "D" },
        {"E", "F", "G", "H" },
        {"I", "J", "K", "L" }
    };




    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < myArray.GetLength(0); i++) //für Reihen
        {
            for (int j = 0; j < myArray.GetLength(1); j++) //für Spalten
            {
                string letter = alphabet[alphabetIndex];
                Debug.Log("Zeile:" + i + " Spalte:" + j + "   Alphabetindex:" + alphabetIndex + "   Letter:" + letter);
                myArray[i, j] = letter;
                alphabetIndex++;
            }
        }

        array[0, 0] = "A";
        array[0, 1] = "B";
        array[0, 2] = "C";
        array[0, 3] = "D";
        array[1, 0] = "E";
        array[1, 1] = "F";
        array[1, 2] = "G";
        array[1, 3] = "H";
        array[2, 0] = "I";
        array[2, 1] = "J";
        array[2, 2] = "K";
        array[2, 3] = "L";


    }


}
