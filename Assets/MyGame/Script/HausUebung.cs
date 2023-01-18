using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HausUebung : MonoBehaviour
{

    public string[,] myArray = new string[3, 4]; //erste Zahl Reihen und zweite Spalten

    [SerializeField]
    private string[] alphabet = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L" };

    private int alphabetIndex = 0;

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

    }

    
}
