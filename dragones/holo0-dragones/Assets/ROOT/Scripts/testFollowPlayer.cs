using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class testFollowPlayer : MonoBehaviour {

	public Transform player;
	public float speed =5f;
	NavMeshAgent agent;
	public bool move = false;
	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();

	}
	
	// Update is called once per frame
	void Update () {
		agent.destination = player.position;
		if (move) {


		}
	}
}
