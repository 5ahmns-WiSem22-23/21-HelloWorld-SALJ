using UnityEngine;

public class HelloOperatoren : MonoBehaviour
{
    //unäre Operatoren Beispiel: -1
    //binäre Operatoren Beispiel: 1 + 2


    public int a = 2;
    public int b = 4;

    
    void Start()
    {
        //Arithmetische Operatoren unär:
        a++;
        Debug.Log(a);

        a--;
        Debug.Log(a);

        //Arithmetische Operatoren binär:
        Debug.Log(a * b);
        Debug.Log(a / b);
        Debug.Log(a + b);
        Debug.Log(a - b);
        Debug.Log(a % b);

        //Logische Operatoren:

        bool c = true;
        bool d = false;

        if (c&d)
        {
            Debug.Log("False");
        }

        if (c | d)
        {
            Debug.Log("True");
        }

        if (c ^ d)
        {
            Debug.Log("True");
        }

        if (!c)
        {
            Debug.Log("False");
        }

        if (!d)
        {
            Debug.Log("True");
        }

        if (c && d)
        {
            Debug.Log("False");
        }

        if (c || d)
        {
            Debug.Log("True");
        }

        bool x = true;
        bool y = true;

        if ((c || d) && (x || y))
        {
            Debug.Log("True");
        }

        //Gleichheits Operatoren:

        int e = 5;
        int f = 5;

        if (e == f)
        {
            Debug.Log("True");
        }

        if (e != f)
        {
            Debug.Log("False");
        }

        //Vergleichsoperatoren:

        int g = 10;
        int h = 5;

        if (g < 20)
        {
            Debug.Log("True");
        }

        if (h > 3)
        {
            Debug.Log("True");
        }

        if (g <= 10)
        {
            Debug.Log("True");
        }

        if (h >= 5)
        {
            Debug.Log("True");
        }

        //Zuweisungsoperatoren:

        int i = 5;

        Debug.Log(i += 3);
        Debug.Log(i -= 3);
        Debug.Log(i *= 3);
        Debug.Log(i /= 3);
        Debug.Log(i %= 3);
        Debug.Log(i &= 3);
        Debug.Log(i |= 3);
        Debug.Log(i ^= 3);


    }

    
    void Update()
    {
          
    }
}
