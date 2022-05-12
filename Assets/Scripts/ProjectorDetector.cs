using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ProjectorDetector class to solve the final puzzle
/// </summary>
public class ProjectorDetector : MonoBehaviour
{
    /// <summary>
    /// particles are the particles of the projector
    /// </summary>
    public GameObject particles;

    /// <summary>
    /// exitButton object 
    /// </summary>
    public GameObject ejectButton;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Key")
        {
            if(other.name == "Flashlight")
            {
                other.gameObject.SetActive(false);
                particles.SetActive(true);
                ejectButton.SetActive(true);
            }
        }
    }
}
