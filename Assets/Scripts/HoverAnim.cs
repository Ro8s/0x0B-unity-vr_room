using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// HoverAnim class that defines when important objects
/// are hovered
/// </summary>
public class HoverAnim : MonoBehaviour
{
    public GameObject children;
    /// <summary>
    /// OnHover activates the children of the object
    /// </summary>
    public void OnHover()
    {
        children.SetActive(true);
    }

    /// <summary>
    /// ExitHover desactivates the children of the object
    /// </summary>
    public void ExitHover()
    {
        children.SetActive(false);

    }
}
