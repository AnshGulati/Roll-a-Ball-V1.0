using UnityEngine;

public class Player_Collision : MonoBehaviour
{
    // This is a reference of player collision to player movement.
    public PlayerMovement movement;

    void OnCollisionEnter(Collision CollisionInfo)
    {
        // Here we are extracting the information about the collison through collider.
        // The information extracted is tag of the object to which it collided and is being compared to "Obstacle"
        if (CollisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit an Obstacle!"); // Prints the text entered in the console.

            movement.enabled = false; // Here we are disabling the movement of the object which is linked to the script named Player_movement i.e. "Player".

            FindObjectOfType<GameManager>().EndGame(); // This will call the function called EndGame of the GameManager script.

        }
    }
}
