using UnityEngine;
using System.Collections;

public class createObject : MonoBehaviour
{
    public Transform Spawnpoint;
    public GameObject Prefab;

    void OnTriggerEnter()
    {
        Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
        Debug.Log("Spawn");
    }
}
