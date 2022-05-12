using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ObjectDetector class that defines when the player
/// can pass trought the door 
/// </summary>
public class ObjectDetector : MonoBehaviour
{
    /// <summary>
    /// Array images that contains the images
    /// </summary>
    public GameObject[] images;

    /// <summary>
    /// audioSource that takes the audioSource to play music
    /// </summary>
    public AudioSource audioSource;
    /// <summary>
    /// Array of audioClips that thakes the audios to play
    /// </summary>
    public AudioClip[] audioClips;

    /// <summary>
    /// array of buttons    
    /// </summary>
    public GameObject[] b;

    /// <summary>
    /// Array of messages
    /// </summary>
    public GameObject[] messages;

    /// <summary>
    /// Collider detector of objects
    /// </summary>
    public Collider col;

    private int check = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key")
        {
            audioSource.clip = audioClips[1];
            audioSource.Play();
            switch(other.name)
            {
                case "rope":
                    images[0].SetActive(false);
                    other.gameObject.SetActive(false);
                    check++;
                    break;
                case "KnightLight":
                    if (images[1].activeSelf == true)
                    {
                        images[1].SetActive(false);
                        check++;
                    }
                    break;
                case "RookDark":
                    if (images[2].activeSelf == true)
                    {
                        images[2].SetActive(false);
                        check++;
                    }
                    break;
            }
        }
        else
        {
            audioSource.clip = audioClips[2];
            audioSource.Play();
        }

        if (check == 3)
        {
            col.enabled = false;
            b[0].SetActive(false);
            messages[0].SetActive(false);
            b[1].SetActive(true);
            messages[1].SetActive(true);
        }
    }

    /// <summary>
    /// OnPress event
    /// </summary>
    public void OnPress()
    {
        audioSource.loop = false;
        audioSource.playOnAwake = false;
        audioSource.clip = audioClips[1];
        audioSource.Play();
        b[0].SetActive(false);
        messages[0].SetActive(true);
        this.gameObject.GetComponent<Collider>().enabled = true;
        foreach (var img in images)
        {
            img.gameObject.SetActive(true);
        }
    }

}
