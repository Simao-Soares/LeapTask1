using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

 

public class Bucket : MonoBehaviour
{
    public EventTrigger.TriggerEvent score5Trigger;
    public EventTrigger.TriggerEvent score10Trigger;
    public EventTrigger.TriggerEvent score1Trigger;



    private void OnCollisionEnter(Collision collisionInfo) {

        if (collisionInfo.collider.tag == "Ball")
        {
            Debug.Log("Cesto!");
            if (collisionInfo.collider.name == "Ball1"){
                BaseEventData eventData = new BaseEventData(EventSystem.current);
                this.score5Trigger.Invoke(eventData);
            }

            if (collisionInfo.collider.name == "Ball2"){
                BaseEventData eventData = new BaseEventData(EventSystem.current);
                this.score10Trigger.Invoke(eventData);
            }

            if (collisionInfo.collider.name == "Ball3"){
                BaseEventData eventData = new BaseEventData(EventSystem.current);
                this.score1Trigger.Invoke(eventData);
            }

        }


        
    }
}
