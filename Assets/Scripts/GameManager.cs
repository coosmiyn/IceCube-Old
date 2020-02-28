using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Transform player;
    public CameraMovement mainCamera;
    public PlayerStats stats;
    public GameObject ground;


    bool hasDied = false;

    Vector3 behindCamera = new Vector3(5f, 0f, 0f);
    Vector3 deathVector = new Vector3(0f,0f,0f);

    void FixedUpdate()
    {
        deathVector = mainCamera.cameraPosition - behindCamera;
        checkPlayerPosition();
        stats.healthPoints -= stats.healthLoss * Time.deltaTime;
    }






    void checkPlayerPosition()
    {
        if (player.position.x < deathVector.x)
        {
            if (hasDied == false)
            {
                hasDied = true;
                Debug.Log("You have died!");
            }
        }
    }
}
