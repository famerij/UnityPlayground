using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    public float Speed = 5f;

    private Vector2 movement;
    private float moveHorizontal;
    private float moveVertical;

    // Update is called once per frame
    void Update()
    {
        // Move in 4 directions based on arrow keys
        if (Input.GetKey(KeyCode.UpArrow))
            moveVertical = 1f;
        else if (Input.GetKey(KeyCode.DownArrow))
            moveVertical = -1f;
        else
            moveVertical = 0f;

        if (Input.GetKey(KeyCode.LeftArrow))
            moveHorizontal = -1f;
        else if (Input.GetKey(KeyCode.RightArrow))
            moveHorizontal = 1f;
        else
            moveHorizontal = 0f;

        movement = new Vector2(moveHorizontal, moveVertical);
    }

    // FixedUpdate is called every time the physic simulation updates
    void FixedUpdate()
    {
        // Rigidbody is a component in 2D physics
        GetComponent<Rigidbody2D>().AddForce(movement * Speed * 10f);
    }
}
