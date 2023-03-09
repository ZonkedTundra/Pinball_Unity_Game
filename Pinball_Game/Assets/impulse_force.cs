using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class impulse_force : MonoBehaviour
{
    //Give it a momentary force of 5 in the X direction but you can change this in unity to apply
//an impulse force in any direction.
public Vector3 impulseMagnitude = new Vector3(5.0f, 0.0f, 0.0f);

bool m_oneTime = true;

// Use this for initialization
void Start () {

}

// Update is called once per frame
void FixedUpdate()
{
if (m_oneTime)
{
GetComponent<Rigidbody>().AddForce(impulseMagnitude, ForceMode.Impulse);
m_oneTime = false;
Debug.Log("Here");
}
}
}
