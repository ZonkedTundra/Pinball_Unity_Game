using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private KeepScore _ks;

    // Start is called before the first frame update
    void Start()
    {
        _ks = GameObject.Find("Ball").GetComponent<KeepScore>();
        if (_ks == null)
        {
            Debug.LogError("Cannot find AddScore method in Ball :(");
        }
        Debug.Log("Starting.");
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -16.7)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == MyTags.BALLEND_TAG)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected.");
        if (collision.collider.tag == "Bumper")
        {
            Debug.Log("Bump!");
            _ks.AddPoints(50);
        }
    }
}
