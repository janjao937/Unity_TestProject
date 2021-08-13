using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pooling : MonoBehaviour
{
    [SerializeField] private GameObject objectToPool;
    [SerializeField] private int index = 0;
    private GameObject[] poolAray;
    private int controlPooling = 0;
 
    void Start()
    {
        poolAray = new GameObject[index];
        CreatePool();
    }

    private void CreatePool()
    {
        for(var i=0;i<index;i++)
        {
            poolAray[i] = Instantiate(objectToPool, transform.position, Quaternion.identity);
            poolAray[i].SetActive(false);
            
        } 
    }

    public void GetObj()
    {
        if(controlPooling==index)
        {
            controlPooling = 0;
        }
        poolAray[controlPooling].transform.position = transform.position;
        poolAray[controlPooling].SetActive(true);
        controlPooling++;
    }
}
