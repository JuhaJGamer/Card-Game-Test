using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public NetworkPlayer[] players;
    public GameObject[] places;
    public GameObject cardStock;
    public Sprite[] cards;
    public GameObject card;

	// Use this for initialization
	void Start () {
        //Not needed but just in case
		if(!Network.isClient)
        {
            Destroy(gameObject);
        }

        //Get players
        players = Network.connections;
    }

    // Update is called once per frame
    void Update () {
        //Get players
        players = Network.connections;
        //Set player positions

	}
}
