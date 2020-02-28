using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public Transform mainCamera;

    public Vector3 cameraPosition;

    [SerializeField]
    Vector3 cameraSpeed = new Vector3(0.075f, 0, 0);
    


    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	public void FixedUpdate () {
        updateCamera();
    }

    public void updateCamera()
    {
        mainCamera.position += cameraSpeed;
        cameraPosition = mainCamera.position;
    }
    
}
