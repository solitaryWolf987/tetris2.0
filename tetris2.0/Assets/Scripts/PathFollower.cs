using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : MonoBehaviour
{

    Node [] PathNode;
    //public GameObject StarExtraPoints;
    public float moveSpeed;
    float timer;
    int CurrentNode;
    static Vector3 CurrentPositionHolder;


    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        PathNode = GetComponentsInChildren<Node> ();
        CheckNode();
        /*
        foreach(Node n in PathNode) 
        {
            Debug.Log(n.name);
        }
        */
    }

    void CheckNode()
    {
        if (CurrentNode < PathNode.Length - 1)
        {
            CurrentPositionHolder = PathNode[CurrentNode].transform.position;
        }
        
    }


    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime * moveSpeed;
        if (transform.position != CurrentPositionHolder)
        {
            
            transform.position =
                Vector3.Lerp(transform.position, CurrentPositionHolder, moveSpeed+0.01f);
        }
        else
        {
            if (CurrentNode < PathNode.Length - 1)
            {
                CurrentNode++;
                CheckNode();
            }
        }

    }
}
