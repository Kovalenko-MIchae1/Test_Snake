using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {

           
            other.GetComponent<SnakeMovment>().AddTail();
            Destroy(gameObject);

        }
    }
}
