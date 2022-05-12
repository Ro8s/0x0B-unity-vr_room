using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Teleportanim class that defines the animation
/// of the teleportation
/// </summary>
public class TeleportAnim : MonoBehaviour
{
    /// <summary>
    /// Animator of the panel
    /// </summary>
    public Animator animator;

    /// <summary>
    /// OnTeleport event
    /// </summary>
    public void OnTeleport()
    {
        animator.Play("FadeOut");
        Invoke("OnFadeIn", 0.2f);
    }

    /// <summary>
    /// OnFadeIn event
    /// </summary>
    public void OnFadeIn()
    {
        animator.Play("FadeIn");
    }
}
