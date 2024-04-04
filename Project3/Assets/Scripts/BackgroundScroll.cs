using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float scrollSpeed = 1.0f; // Adjust this to control the speed of scrolling
    public float resetPoint = -10.0f; // Point at which the background should reset

    void Update()
    {
        // Calculate the amount to scroll based on time and scroll speed
        float scrollAmount = scrollSpeed * Time.deltaTime;

        // Move the background downwards
        transform.Translate(Vector3.down * scrollAmount);

        // Check if the background has scrolled past the reset point
        if (transform.position.y <= resetPoint)
        {
            // Reset the position of the background to the top
            ResetBackground();
        }
    }

    void ResetBackground()
    {
        // Find the highest background among the siblings
        float highestY = float.MinValue;
        foreach (Transform sibling in transform.parent)
        {
            if (sibling.position.y > highestY)
            {
                highestY = sibling.position.y;
            }
        }

        // Set the position of the background to be just above the highest background
        transform.position = new Vector3(transform.position.x, highestY + GetComponent<SpriteRenderer>().bounds.size.y, transform.position.z);
    }
}
