using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSpawner : MonoBehaviour
{
    BluePool objectPooler;
    private void Start()
    {
       // objectPooler = BluePool.Instance;
    }

    void FixedUpdate()
    {
        //objectPooler.SpawnFromPool("DoubleJump", transform.position, Quaternion.identity);
    }
}
