using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ChessDetector class that defines what pass trougth
/// the chess
/// </summary>
public class ChessDetector : MonoBehaviour
{
    /// <summary>
    /// particles object
    /// </summary>
    public GameObject particles;

    private int piecesCount;

    /// <summary>
    /// button of the console of the main stage
    /// </summary>
    public GameObject exitbutton;
    /// <summary>
    /// rookDark pize
    /// </summary>
    public GameObject rookDark;

    /// <summary>
    /// collider trigger
    /// </summary>
    public Collider col;

    /// <summary>
    /// pawnDark pize
    /// </summary>
    public GameObject pawnDark;

    /// <summary>
    /// bishopLight pize
    /// </summary>
    public GameObject bishopLight;

    /// <summary>
    /// knightLight piece
    /// </summary>
    public GameObject knightLight;

    /// <summary>
    /// ExitMens for the text after press exit
    /// </summary>
    public GameObject exitmensg;

    /// <summary>
    /// LeaveButton leave button
    /// </summary>
    public GameObject leaveButton;

    /// <summary>
    /// leavemensg for the text after press leave
    /// </summary>
    public GameObject leavemensg;

    /// <summary>
    /// ejectButton to end the game
    /// </summary>
    public GameObject ejectButton;

    /// <summary>
    /// lightTable gameobject (talbe of the center)
    /// </summary>
    public GameObject lightTable;

    /// <summary>
    /// ejectmensg for the final game
    /// </summary>
    public GameObject ejectmensg;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key")
        {
            switch(other.name)
            {
                case "PawnDark":
                    other.gameObject.SetActive(false);
                    pawnDark.gameObject.SetActive(true);
                    piecesCount++;
                    break;
                case "BishopLight":
                    other.gameObject.SetActive(false);
                    bishopLight.gameObject.SetActive(true);
                    piecesCount++;
                    break;
                case "KnightLight":
                    other.gameObject.SetActive(false);
                    knightLight.gameObject.SetActive(true);
                    piecesCount++;
                    break;
                case "RookDark":
                    other.gameObject.SetActive(false);
                    rookDark.gameObject.SetActive(true);
                    piecesCount++;
                    break;
            }
        }
        if (piecesCount == 4)
        {
            col.enabled = false;
            particles.SetActive(false);
            leaveButton.SetActive(true);
        }
    }

    /// <summary>
    /// Event OntryingExit that triggers when the button
    /// of the computer is clicked
    /// </summary>
    public void OnTryingExit()
    {
        col.enabled = true;
        particles.SetActive(true);
        exitmensg.SetActive(true);
        exitbutton.SetActive(false);
    }

    /// <summary>
    /// OnTryingLeaving event that triggers a new trial after
    /// solve the chess puzzle
    /// </summary>
    public void OnTryingLeaving()
    {
        lightTable.SetActive(true);
        leavemensg.SetActive(true);
        leaveButton.SetActive(false);
    }

    /// <summary>
    /// OnEjectButton ends the game
    /// </summary>
    public void OnEjectButton()
    {
        ejectButton.SetActive(false);
        ejectmensg.SetActive(true);
        CountDown();
    }

    /// <summary>
    /// CountDown for the end of the game
    /// </summary>
    public void CountDown()
    {
        StartCoroutine(Eject());
    }

    /// <summary>
    /// Eject that defines the end of the game
    /// </summary>
    /// <returns>void</returns>
    IEnumerator Eject()
    {
        yield return new WaitForSeconds(3f);
        Application.Quit();
    }

}
