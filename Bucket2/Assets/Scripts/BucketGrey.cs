using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



public class BucketGrey : MonoBehaviour
{
	public EventTrigger.TriggerEvent score1Trigger;



	private void OnCollisionEnter(Collision collisionInfo) {

		if (collisionInfo.collider.tag == "Ball")
		{
			Debug.Log("Cesto!");
			if (collisionInfo.collider.name == "Ball3(Clone)"){
				BaseEventData eventData = new BaseEventData(EventSystem.current);
				this.score1Trigger.Invoke(eventData);
			}
			else Debug.Log("Wrong Bucket!");
		}
	}
}
