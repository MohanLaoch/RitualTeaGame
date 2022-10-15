using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Transform[] Positions;
    [SerializeField] float Speed;
    int NextPosIndex;
    Transform NextPos;
    public bool Canleave = false;

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
          if (transform.position == NextPos.position)
          {
            if (Canleave == true)
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
                transform.position = Vector3.MoveTowards(transform.position, NextPos.position, Speed * Time.deltaTime);
          }
    }
}
