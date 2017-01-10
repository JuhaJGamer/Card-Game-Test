using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public NetworkPlayer[] players;
    public GameObject[] places;
    

    // Use this for initialization
    void Start()
    {
        //If client, destroy
        if (Network.isClient)
        {
            Destroy(gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        //get all players
        players = Network.connections;
        //
        
    }
}
