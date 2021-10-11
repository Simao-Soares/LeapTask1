using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FloorCollision : MonoBehaviour
{
	public EventTrigger.TriggerEvent missTrigger;
	private static GameManager gameManager;

	private void OnCollisionEnter(Collision collisionInfo) {

		if (collisionInfo.collider.tag == "Green" || collisionInfo.collider.tag == "Yellow" || collisionInfo.collider.tag == "Grey")
		{
			Destroy(collisionInfo.gameObject);
			gameManager = FindObjectOfType<GameManager>();
			gameManager.newBall();

		}

	}
}
