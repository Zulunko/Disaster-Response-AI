using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System;

public class BasicAI : MonoBehaviour
{
    List<GameObject> robots;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Get some references to all of our "robots"
        robots.Add(GameObject.Find("Robot1"));
    }

    // Update is called once per frame
    void Update()
    {
        robots[0].GetComponent<SimpleMoving>().ReceiveMessage("hi!");
    }
}
