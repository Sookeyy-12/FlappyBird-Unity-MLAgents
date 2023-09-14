using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using Unity.VisualScripting;
using Unity.MLAgents.Integrations.Match3;
using UnityEngine.SocialPlatforms.Impl;

public class AgentBehaviour : Agent
{
    public int agentID;
    Rigidbody2D rBody;
    public float flapVel = 15f;
    public GameObject spawn;
    private float rewardPerFrame = 0.001f;
    public int score = 0;
    //public List<GameObject> pipes = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    public override void OnEpisodeBegin()
    {
        ResetEnv();
        score = 0;
        //ResetEnvironment();
    }

    public override void CollectObservations(VectorSensor sensor)
    {

    }

    public override void OnActionReceived(ActionBuffers actions)
    {
        AddReward(rewardPerFrame);
        FlapAgent(actions.DiscreteActions);
    }

    public override void Heuristic(in ActionBuffers actionsOut)
    {
        var discreteActionsOut = actionsOut.DiscreteActions;
        if (Input.GetKey(KeyCode.Space))
        {
            discreteActionsOut[0] = 1;
        }
    }

    void ResetEnv()
    {
        // reset the player's position
        this.transform.localPosition = spawn.transform.localPosition;
        rBody.velocity = Vector2.zero;
        rBody.angularVelocity = 0f;
        this.transform.localRotation = Quaternion.Euler(0f, 0f, -90f);
        /*
        for (int i = pipes.Count - 1; i >= 0; i--)
        {
            var pipe = pipes[i];
            pipes.RemoveAt(i);
            Destroy(pipe.gameObject);
        }
        */
    }
    /*
    public void ResetEnvironment()
    {
        // Reset the environment here, including any pipes or obstacles
        for (int i = pipes.Count - 1; i >= 0; i--)
        {
            var pipe = pipes[i];
            pipes.RemoveAt(i);
            Destroy(pipe.gameObject);
        }
    }*/

    void FlapAgent(ActionSegment<int> act)
    {
        var flapDir = Vector2.zero;
        var flap = act[0];
        switch (flap)
        {
            case 1:
                flapDir = Vector2.up;
                break;
        }
        rBody.velocity = flapDir * flapVel;
    }
}
