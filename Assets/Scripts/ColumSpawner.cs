using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumSpawner : MonoBehaviour
{
    public float maxSpawnTime = 1f; // seconds
    private float internalTimer = 0f;
    public GameObject column_pair;
    public float height = 0f;
    public float time_to_disappear = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(internalTimer > maxSpawnTime)
        {
            GameObject pipe = Instantiate(column_pair);
            pipe.transform.position = pipe.transform.position + new Vector3(0, Random.RandomRange(-height, height), 0);
            Destroy(pipe, time_to_disappear); // destroy the instantiated pipe after time_to_disappear seconds
            internalTimer = 0f;
        }
        internalTimer += Time.deltaTime;
    }
}
