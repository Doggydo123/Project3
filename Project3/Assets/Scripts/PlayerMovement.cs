using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this to control the speed of movement
    public float leftBoundary = -5f; // Left boundary for player movement
    public float rightBoundary = 5f; // Right boundary for player movement

    void Update()
    {
        // Get the horizontal input from the arrow keys (left and right)
        float moveInput = Input.GetAxis("Horizontal");

        // Calculate the movement amount based on input and speed
        float moveAmount = moveInput * moveSpeed * Time.deltaTime;

        // Calculate the target position after movement
        float targetX = transform.position.x + moveAmount;

        // Clamp the target position to stay within the boundaries
        targetX = Mathf.Clamp(targetX, leftBoundary, rightBoundary);

        // Move the player horizontally
        transform.position = new Vector3(targetX, transform.position.y, transform.position.z);
    }
}