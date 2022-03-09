using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player; // create a reference to the player 
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position); // every frame, the console will update and print out the position of the player 
        transform.position = player.position + offset; // transform with lower case t is refering to the transform of this current object (aka the camera)
    }
}
