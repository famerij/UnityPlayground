using UnityEngine;

public class Functions : MonoBehaviour
{
    private string helloString = "Hello";

    // The Start() and Update() are functions!
    // Called by Unity

    // Start is called before the first frame update
    void Start()
    {
        // Function call
        print(StringToPrint());

        // Alternatively

        PrintString(StringToPrint());

        // void means doesn't return anything
        return;
    }

    // Returns string
    string StringToPrint()
    {
        return helloString;
    }

    // Functions can have parameters (values they take in)
    void PrintString(string toPrint)
    {
        print(toPrint);
    }

    // Update is called once per frame
    void Update()
    {
        PrintString("Update is called once per frame");
    }
}
