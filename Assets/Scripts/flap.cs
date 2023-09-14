using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flap : MonoBehaviour
{
    Rigidbody2D rBody;
    public float flapVel = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            flapBird();
        }
    }

    void flapBird()
    {
        rBody.velocity = Vector2.up * flapVel;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision");
    }
}
