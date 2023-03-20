using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStart : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform StartPoint;
    public GameObject ballCall;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject ball = Instantiate(ballCall, StartPoint.position, Quaternion.identity);
        }

    }
}

