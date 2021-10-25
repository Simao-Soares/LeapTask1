using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIRow : MonoBehaviour
{
    public GameObject LeftRow;
    public GameObject RightRow; 
    
    IEnumerator LeftRowUI(){
        LeftRow.SetActive(true);
        yield return new WaitForSecondsRealtime(0.5f);
        LeftRow.SetActive(false);
    }

    IEnumerator RightRowUI(){
        RightRow.SetActive(true);
        yield return new WaitForSecondsRealtime(0.5f);
        RightRow.SetActive(false);
    }


}
