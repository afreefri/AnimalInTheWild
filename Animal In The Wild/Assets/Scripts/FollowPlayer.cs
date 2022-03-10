using UnityEngine;

/*
 Goes on the main camera object
 will follow the player 
 */

public class FollowPlayer : MonoBehaviour
{

    public Transform player; // create a reference to the player 
    public Vector3 offset;
    public bool lookAt = true;
    public Space offsetPositionSpace = Space.Self;

    void Update()
    {
        Refresh();
    }

    void Refresh()
    {
        // compute position
        if (offsetPositionSpace == Space.Self)
        {
            transform.position = player.TransformPoint(offset);
        }
        else
        {
            transform.position = player.position + offset;
        }

        // compute rotation
        if (lookAt)
        {
            transform.LookAt(player);
        }
        else
        {
            transform.rotation = player.rotation;
        }
    }
}
