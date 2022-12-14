using UnityEngine;

public class HelloVariablen : MonoBehaviour
{
    // Value Types: Wert wird im Speicher direkt hinterlegt
    int myint = 0;
    bool mybool = true;

    int[] myArray = new int[3] { 0, 0, 0 };

    string a = "Hallo ";
    
    void Start()
    {
        Debug.Log(sizeof(int));
        Debug.Log(sizeof(bool));

        //Value Type
        int tmp = myint;
        myint++;
        Debug.Log("myInt: " + myint + "tmp: " + tmp);

        //Reference Type
        int[] tmpArray = myArray;
        myArray[0] = 1;
        myArray[1] = 2;
        myArray[2] = 3;

        Debug.Log("----------tmpArray");
        foreach(int a in tmpArray)
        {
            Debug.Log(a);
        }

        Debug.Log("----------myArray");
        foreach (int a in myArray)
        {
            Debug.Log(a);
        }

        string tmpString = a;
        a = "hello ";
        Debug.Log("a: " + a + "tmpString: " + tmpString);
    }


    void Update()
    {
        
    }
}
