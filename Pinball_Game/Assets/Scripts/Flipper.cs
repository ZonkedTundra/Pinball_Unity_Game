using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    public bool isRight; // to determine which flipper is being used
    public HingeJoint2D joint; // reference to the HingeJoint2D on the flipper
    public float waitTime; // to be used in a coroutine

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRight == true)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                joint.useMotor = true;
                StartCoroutine(Wait());
                
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                joint.useMotor = true;
                StartCoroutine(Wait());
            }
        }
       
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitTime);
        joint.useMotor = false;
    }
}
