using UnityEngine;
using System.Collections;

public class Navigation : MonoBehaviour {

		Transform nexus;               // Reference to the player's position.
		
		NavMeshAgent nav;               // Reference to the nav mesh agent.
		
		
		void Awake ()
		{
			// Set up the references.
			nexus = GameObject.FindGameObjectWithTag ("nexus").transform;
			
			nav = GetComponent <NavMeshAgent> ();
		}
		
		
		void Update (){
			
				// ... set the destination of the nav mesh agent to the player.
				nav.SetDestination (nexus.position);
			
			

	}
}
