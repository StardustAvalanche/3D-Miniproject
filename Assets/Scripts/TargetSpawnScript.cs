using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawnScript : MonoBehaviour
{
    [Header("Spawn Settings")]
    public GameObject targetPrefab;

    [Header("Raycast Settings")]
    public float heightOfCheck = 10f, rangeOfCheck = 30f;
    public LayerMask layerMask;


    // Start is called before the first frame update
    void Start()
    {
        SpawnTarget();
    }

    void SpawnTarget()
    {
        RaycastHit hit;
        if (Physics.Raycast(new Vector3(Random.Range(-9, 12), heightOfCheck, Random.Range(-9, 23)), Vector3.down, out hit, rangeOfCheck, layerMask))
        {
                Instantiate(targetPrefab, hit.point, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), transform);
        }

    } 
   
}
