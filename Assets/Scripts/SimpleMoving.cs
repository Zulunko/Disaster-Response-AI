using System;
using UnityEngine;
using UnityEngine.AI;

public class SimpleMoving : MonoBehaviour
{
    NavMeshAgent agent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();


    }

    // Update is called once per frame
    void Update()
    {
        // check if we received any commands from our main AI
        // do stuff for those commands
        // send any information back to the main AI that we need to send
        //   -> our position
        //   -> any updates (e.g. we cleared an obstacle)


        NavMeshPath path = new NavMeshPath();
        agent.CalculatePath(new Vector3(7, 0, -9), path);
        agent.SetPath(path);
       
    }

    public void MoveCommand() { }

    public void AddToCommandQueue() { }

    public void ReceiveMessage(string message)
    {
        Console.WriteLine(message);
    }
}
