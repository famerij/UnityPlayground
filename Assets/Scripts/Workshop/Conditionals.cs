using UnityEngine;

public class Conditionals : MonoBehaviour
{
    public int value = 50;

    // Update is called once per frame
    void Start()
    {
        if (value == 50) // See difference between assign '=' and equal comparison '=='
        {
            print("Value is 50");
        }
        else if (value > 0) // Greater than compare
        {
            print("Value " + value + " is positive");
        }
        else if (value < 0) // Less than compare
        {
            print("Value " + value + " is negative");
        }
        else // Could also be if (value == 0)
        {
            print("Value is zero");
        }

        switch(value)
        {
            case 0:
                print("Value is zero");
                break;
            case 50:
                print("Value is 50");
                break;
        }
    }
}
