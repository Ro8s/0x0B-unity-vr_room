using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

/// <summary>
/// MainRoomHandler class thath defines when the door is open
/// and when the player can pass to the another room
/// </summary>
public class MainRoomHandler : MonoBehaviour
{
    /// <summary>
    /// Animator of door
    /// </summary>
    public Animator animatorDoor;
    /// <summary>
    /// Array of teleportationArea to activate when the player ends
    /// the first trial
    /// </summary>
    public TeleportationArea[] teleportAreas;

    /// <summary>
    /// Array of teleportationAnchor to activate when the player ends
    /// the first trial
    /// </summary>
    public TeleportationAnchor[] teleportationAnchors;

    /// <summary>
    /// GameObject button
    /// </summary>
    public GameObject button;

    /// <summary>
    /// AudioSource that makes the sound when the door opens
    /// </summary>
    public AudioSource doorOpenSound;

    /// <summary>
    /// OnFirstTrailEnds Event that frees the new zone
    /// </summary>
    public void OnFirstTrialEnds()
    {
        animatorDoor.Play("glass_door_open");
        doorOpenSound.Play();
        foreach (var floor in teleportationAnchors)
        {
            floor.enabled = true;
        }
        foreach (var flora in teleportAreas)
        {
            flora.enabled = true;
        }
        button.SetActive(false);
    }

}
