using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject PrefabToInit;
    
    public static GameObject _initedPrefab;
    public KeyCode Spawn = KeyCode.Z;
    public KeyCode Destroy = KeyCode.X;

    private bool HasSpawned = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!HasSpawned && Input.GetKey(Spawn))
        {
          _initedPrefab = Instantiate(PrefabToInit);
            HasSpawned = true;
        }
        if (HasSpawned && Input.GetKey(Destroy))
        {
            Destroy(_initedPrefab);
            HasSpawned = false;
        }
    }
}