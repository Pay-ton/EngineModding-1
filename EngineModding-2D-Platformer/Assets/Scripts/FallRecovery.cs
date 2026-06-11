using UnityEngine;

public class FallRecovery : MonoBehaviour
{
    // Allows setting recovery point in Unity
    // I suck at arrays, I know theres a way to make a recovery point array with []
    // but I have no clue how, so Im just going to take the lazy approach because I only need 3 recovery triggers. 
    public Transform RecoveryPoint1;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Turn the Collider into a trigger for this script to transform location to associated recovery point.
        // So long as only one recovery point is set, this will just check for all 3 and respawn the player accordingly.
        // Yes it isn't scalable, I'm bad at coding.

        // APPARENTLY IT WAS ALWAYS INHERENTLY SCALED, IM JUST DUMB.
        collision.gameObject.transform.position = RecoveryPoint1.position;
    
    }
}
