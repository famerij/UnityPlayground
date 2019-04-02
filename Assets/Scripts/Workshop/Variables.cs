using UnityEngine;

public class Variables : MonoBehaviour
{
    int intValue; // integer value
    float floatValue; // floating point (decimal value)
    bool booleanValue; // true or false
    string textValue;

    private int privateInt; // Only accessible within this class (script) Variables
    public int publicInt; // Accessible to other classes and Unity editor

    // Start is called before the first frame update
    void Start()
    {
        // Float values can have decimals and have f suffix in C#
        floatValue = 1.5f;

        print("Float value is " + floatValue);

        intValue = 20;

        print("Integer value is " + intValue);

        // Variables can be introduced here too!
        string hello = "hello";

        print(hello);
    }
}
