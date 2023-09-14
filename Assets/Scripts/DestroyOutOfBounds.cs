using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (this.transform.localPosition.x < -10f)
        {
            Destroy(this.gameObject);
        }
    }
}
