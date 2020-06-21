using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KistTriggerScript : MonoBehaviour
{
    public Animator KistjeAnimator;    
       
    private void OnMouseUp()
    {
        KistjeAnimator.SetTrigger("KistOpenTrigger");
    }
}