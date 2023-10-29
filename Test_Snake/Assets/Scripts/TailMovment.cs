using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailMovment : MonoBehaviour
{
    public float Speed;
    public Vector3 tailTarget;
    public GameObject tailTargetObj;
    public SnakeMovment mainSnake;
    void Start()
    {
        mainSnake = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<SnakeMovment>();
        Speed = mainSnake.Speed;
        tailTargetObj = mainSnake.tailObjects[mainSnake.tailObjects.Count - 2];
        
    }

    void Update()
    {
        tailTarget = tailTargetObj.transform.position;
        transform.LookAt(tailTarget);
        transform.position = Vector3.Lerp(transform.position, tailTarget, Time.deltaTime * Speed);
    }
}
