using System.Collections;
using System.Collections.Generic;
using Unity.MLAgents;
using UnityEngine;
using UnityEngine.Animations;

public class MovePipe : MonoBehaviour
{
    public float moveSpeed = 3f;

    void Update()
    {
        this.transform.Translate(Vector2.left *Time.deltaTime * moveSpeed);
    }
}
