using UnityEngine;

public class Loops : MonoBehaviour
{
    private int counter = 0;

    // Loops allow code to be executed repeatedly

    // Start is called before the first frame update
    void Start()
    {
        // While is looped until the condition is met
        // Syntax: while (condition), like in if (condition)
        // "While counter is less than 50"
        print("While loop");
        while (counter < 50)
        {
            print(counter);
            counter = counter + 1;
        }

        // For-loop adds iterator that defines when the loop is repeated
        // Syntax: for (initialisation, condition, iteration)
        print("for loop");
        for (int i = 0; i < 50; i++)
        {
            print(i);
        }
    }
}
