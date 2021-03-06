using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

 

public class RowCollider : MonoBehaviour
{
    public EventTrigger.TriggerEvent RowLeft;
    public EventTrigger.TriggerEvent RowRight;
	private static GameObject gameManager;

    private void OnCollisionEnter(Collision collisionInfo) {
		
		if (collisionInfo.collider.tag == "Green")
        {
            Debug.Log("Left Row!");
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            this.RowLeft.Invoke(eventData);
        }

		else if (collisionInfo.collider.tag == "Green")
        {
             Debug.Log("Right Row!");
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            this.RowRight.Invoke(eventData);
        }
    }
}
