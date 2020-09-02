using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Vortex : MonoBehaviour
{
    public float speed = 3;
    public GameObject player;
    public bool pulling = false;
    // Start is called before the first frame update
    void Start()
    {
        Timer.pull += VortexPull;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        if (pulling)
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, transform.position, step);
        }
        else
        {
            player.transform.position = player.transform.position;
        }
    }
    void VortexPull()
    {
        StartCoroutine(Pull());
    }
    IEnumerator Pull()
    {
        pulling = false;
        yield return new WaitForSeconds(5);
        pulling = true;

    }
}
