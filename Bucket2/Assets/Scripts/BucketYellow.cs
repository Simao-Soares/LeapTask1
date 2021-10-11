using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BucketYellow : MonoBehaviour
{
	public EventTrigger.TriggerEvent score10Trigger;
	private static GameManager gameManager;

	private void OnCollisionEnter(Collision collisionInfo) {

		if (collisionInfo.collider.tag == "Green" || collisionInfo.collider.tag == "Yellow" || collisionInfo.collider.tag == "Grey")
		{
			Debug.Log("Cesto!");
			if (collisionInfo.collider.tag == "Yellow"){
				BaseEventData eventData = new BaseEventData(EventSystem.current);
				this.score10Trigger.Invoke(eventData);
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
