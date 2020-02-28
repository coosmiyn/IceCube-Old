
using UnityEngine;

public class Collision : MonoBehaviour
{

    public PlayerMovement movementScript;
    public PlayerStats stats;

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {        
        if (collisionInfo.collider.tag == "Ground")
        {
            movementScript.hasJumped = false;
        }    
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (stats.healthPoints <= stats.maxHealth)
        if (collision.GetComponent<Collider2D>().tag == "Regeneration")
        {
            stats.healthPoints += stats.healthRegeneration * Time.deltaTime;
        }
    }
}
