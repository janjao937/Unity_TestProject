using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField]private Pooling objPool;

    // Update is called once per frame
    void Update()
    {
        UseBullet();
    }
    private void UseBullet()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            objPool.GetObj();
        }
    }
}
