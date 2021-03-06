using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



public class BucketGrey : MonoBehaviour
{
	public EventTrigger.TriggerEvent score1Trigger;
	private static GameManager gameManager;

	private void OnCollisionEnter(Collision collisionInfo) {

		if (collisionInfo.collider.tag == "Green" || collisionInfo.collider.tag == "Yellow" || collisionInfo.collider.tag == "Grey")
		{
			if (collisionInfo.collider.tag == "Grey"){
				BaseEventData eventData = new BaseEventData(EventSystem.current);
				this.score1Trigger.Invoke(eventData);
			}
			else {
				Debug.Log("Wrong Bucket!");
				gameManager = FindObjectOfType<GameManager>();
				gameManager.newBall();
			}
		}
		Destroy(collisionInfo.gameObject);
	}
}
