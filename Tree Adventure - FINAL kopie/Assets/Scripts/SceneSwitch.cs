using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{

    public AudioClip MagicSound;

    public void NightSwitch()
    {
        PlayerPos.PlayerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
        PlayerPos.PlayerRotation = GameObject.FindGameObjectWithTag("Player").transform.rotation;
        PlayerPos.CameraRotation = Camera.main.transform.rotation;
        SceneManager.LoadSceneAsync(1);
        
    }

    public void AudioAfspelen()
    {
        GetComponent<AudioSource>().PlayOneShot(MagicSound);
    }

}
