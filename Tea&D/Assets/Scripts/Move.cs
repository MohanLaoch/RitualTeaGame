using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Vector3[] Positions;
    [SerializeField] float Speed;
    int NextPosIndex;
    Vector3 NextPos;
    public bool canLeave = false;

    // Start is called before the first frame update
    void Start()
    {
        NextPos = Positions[0];
    }

    // Update is called once per frame
    void Update()
    {
        MoveGameObject();
    }

    void MoveGameObject()
    {
          if (transform.position == NextPos)
          {
            if (canLeave == true)
            {
                NextPosIndex++;
                if (NextPosIndex >= Positions.Length)
                {
                    NextPosIndex = 0;
                }
                NextPos = Positions[NextPosIndex];
            }
          }
          else
          {
                transform.position = Vector3.MoveTowards(transform.position, NextPos, Speed * Time.deltaTime);
          }
    }
}
