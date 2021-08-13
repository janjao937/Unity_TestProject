using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;

    [SerializeField] private float timeCount = 0;

    private void Awake()
    {

        rb.velocity = new Vector3(1,0,0) * speed;
       
    }
    private void Update()
    {
        CountTime(1);
    }

    private void CountTime(int timeControl)
    {
        timeCount += Time.deltaTime;
        if(timeCount>=timeControl)
        {
            gameObject.SetActive(false);
            timeCount = 0;
        }

    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    gameObject.SetActive(false);
    //}


}
