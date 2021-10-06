using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLogic : MonoBehaviour
{
    
    Vector3 originalPos;
    // Start is called before the first frame update

    void Start()
    {
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        //simpler alternative: originalPos = gameObject.transform.position;
		//GetComponent<Rigidbody>().useGravity = false;

    
    }

    public void ResetPos()
    {
        this.transform.position = originalPos;
    }

}