using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorer : MonoBehaviour
{
    private AgentBehaviour bird;
    private void Start()
    {
        GameObject agentObject = GameObject.Find("FlappyBird");
        bird = agentObject.GetComponent<AgentBehaviour>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        bird.score++;
        bird.AddReward(1f);
        Debug.Log(bird.score);
    }
}
