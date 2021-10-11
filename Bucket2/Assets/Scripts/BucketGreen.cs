using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

 

public class BucketGreen : MonoBehaviour
{
    public EventTrigger.TriggerEvent score5Trigger;

    private void OnCollisionEnter(Collision collisionInfo) {

        if (collisionInfo.collider.tag == "Ball")
        {
            Debug.Log("Cesto!");
			if (collisionInfo.collider.name == "Ball1(Clone)"){
                BaseEventData eventData = new BaseEventData(EventSystem.current);
                this.score5Trigger.Invoke(eventData);
            }

			else Debug.Log("Wrong Bucket!");

        }


        
    }
}
