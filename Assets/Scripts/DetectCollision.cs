using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public AgentBehaviour agent;
    public PipeSpawner spawner;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision");
        agent.AddReward(-10f);
        agent.EndEpisode();
        spawner.ResetEnvironment();
    }
}
