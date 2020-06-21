using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerInit : MonoBehaviour
{ 

    void Awake()
    {

        GetComponent<FirstPersonController>().enabled = true;
        GetComponent<CharacterController>().transform.position = PlayerPos.PlayerPosition;
        GetComponent<CharacterController>().transform.rotation = PlayerPos.PlayerRotation;
        GetComponent<CharacterController>().enabled = true;
        Camera.main.transform.rotation = PlayerPos.CameraRotation;
        
    }
}
