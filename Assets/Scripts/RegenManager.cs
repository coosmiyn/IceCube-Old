using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegenManager : MonoBehaviour {

    public CameraMovement mainCamera;

    public int numOfRegens = 2;
    public float spawnX = 0f;
    public float regenObjectX;

    Vector3 spawnVectorX = new Vector3(1, 0, 0);
    Vector3 behindCamera = new Vector3(7f, 0f, 0f);
    Vector3 spawnVector = new Vector3(0f, 0f, 0f);

    public GameObject[] regenPrefabs;
    public List<GameObject> activeRegens;



	// Use this for initialization
	void Start () {
        SpawnRegen();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        spawnVector = mainCamera.cameraPosition - behindCamera;
        if (activeRegens[0].transform.position.x < spawnVector.x)
        {
            SpawnRegen();
            DeleteRegen();
        }
    }

    void SpawnRegen()
    {
        Debug.Log("A regen has been spawned!");
        GameObject regenObject;
        regenObject = Instantiate(regenPrefabs[0]) as GameObject;
        regenObject.transform.SetParent(transform);
        regenObject.transform.position = spawnVectorX * (mainCamera.cameraPosition.x + Random.Range(5, 25));
        activeRegens.Add(regenObject);
        
}

    void DeleteRegen()
    {
        Debug.Log("A regen has been deleted!");
        Destroy(activeRegens[0]);
        activeRegens.RemoveAt(0);
    }
}
