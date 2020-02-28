using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public CameraMovement mainCamera;

    public int numOfTiles = 3;
    public float tileLength = 10f;
    public float spawnX = 0f;
    public float safeZone = 15f;

    Vector3 spawnVectorX = new Vector3(1, 0, 0);

    public GameObject[] tilePrefabs;
    public List<GameObject> activeTiles;

    public Transform cameraTransform;

	// Use this for initialization
	void Start () {
        activeTiles = new List<GameObject>();
        cameraTransform = GameObject.FindGameObjectWithTag("MainCamera").transform;
        for (int i = 0; i < numOfTiles; i++)
        {
            SpawnTile();
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (cameraTransform.position.x - safeZone > (spawnX - (numOfTiles * tileLength)))
        {
            SpawnTile();
            DeleteTile();
        }
	}

    void SpawnTile()
    {
        GameObject gameObject;
        gameObject = Instantiate(tilePrefabs[0]) as GameObject;
        gameObject.transform.SetParent(transform);
        gameObject.transform.position = spawnVectorX * spawnX;
        spawnX += tileLength;
        activeTiles.Add(gameObject);
    }

    void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
}
