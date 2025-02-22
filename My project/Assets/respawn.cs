using UnityEngine;

public class respawn : MonoBehaviour
{
    public float fallThreshold = -150f;                                                                                     // The height at which the player respawns
    public Vector3 respawnPoint = new Vector3(0, -14, 0);                                                                   // The respawn position

    void Update()
    {
        if (transform.position.y < fallThreshold)
        {
            Respawn();
        }
    }

    void Respawn()
    {
        CharacterController controller = GetComponent<CharacterController>();
        if (controller != null)
        {
            controller.enabled = false;                                                                                     // Disable controller to reset position
            transform.position = respawnPoint;
            controller.enabled = true;                                                                                      // Re-enable controller after resetting
        }
        else
        {
            transform.position = respawnPoint;                                                                              // Just reset position if no CharacterController
        }
    }
}
