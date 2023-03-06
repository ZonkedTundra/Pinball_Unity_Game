using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    public bool isRight;
    public HingeJoint2D joint;
    public float waitTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRight == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                joint.useMotor = true;
                StartCoroutine(Wait());
                
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
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
