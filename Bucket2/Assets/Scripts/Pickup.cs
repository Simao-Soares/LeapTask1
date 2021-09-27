using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Transform theDest;
    private bool up = false;
    private void Update() {
        if (up)
        {
            this.transform.position = theDest.position;
            this.transform.parent = GameObject.Find("Destination").transform;
        }  
    }

    void OnMouseDown() {
        GetComponent<Rigidbody>().useGravity = false;
        up=true;
    }

    void OnMouseUp() {
        up=false;
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        
    }

}
