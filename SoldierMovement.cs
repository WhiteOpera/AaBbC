using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierMovement : MonoBehaviour
{
    public float speed;
    public Transform[] checkpoints;
    private int checkpointId;
    float step;


    // Start is called before the first frame update
    void Start()
    {
        step = speed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(checkpointId < checkpoints.Length)
        {
            Transform currentCheckpoint = checkpoints[checkpointId];

                transform.position = Vector3.MoveTowards(transform.position, currentCheckpoint.position, step);

            if (Vector3.Distance(transform.position, currentCheckpoint.position) < 0.25f)
            {
                checkpointId++;

                if (checkpointId >= checkpoints.Length)
                {
                    checkpointId = checkpoints.Length;
                }
            }
        }
    }
}
