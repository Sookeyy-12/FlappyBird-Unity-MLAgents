using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Google.Protobuf.WellKnownTypes.Field;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipeUp, pipeDown;
    public GameObject pipeSpawner;
    public float spawnInterval = 1.5f;
    private AgentBehaviour agent;

    public List<GameObject> pipes = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnpipe", 1f, spawnInterval);
        GameObject agentObject = GameObject.Find("FlappyBird");
        agent = agentObject.GetComponent<AgentBehaviour>();
    }

    void spawnpipe()
    {
        float xPos = pipeSpawner.transform.position.x;
        float upPos = Random.Range(3f, 8f);
        Vector2 spawnUp = new Vector2(xPos, upPos);
        Vector2 spawnDown = new Vector2(xPos, upPos - 9f);

        GameObject pipeUpInstance = Instantiate(pipeUp, spawnUp, pipeUp.transform.localRotation);
        GameObject pipeDownInstance = Instantiate(pipeDown, spawnDown, pipeDown.transform.localRotation);

        // Set the parent of the instantiated pipes to the pipeSpawner
        pipeUpInstance.transform.parent = pipeSpawner.transform;
        pipeDownInstance.transform.parent = pipeSpawner.transform;

        pipes.Add(pipeUpInstance); pipes.Add(pipeDownInstance);
    }
    public void ResetEnvironment()
    {
        // Reset the environment here, including any pipes or obstacles
        for (int i = pipes.Count - 1; i >= 0; i--)
        {
            var pipe = pipes[i];
            pipes.RemoveAt(i);
            Destroy(pipe.gameObject);
        }
    }
}
