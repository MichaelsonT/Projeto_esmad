using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemInteraction : MonoBehaviour
{
    public string interactionText = "";
    public TMP_Text interactionUIText;

    private bool isInteracting = false;

    private void Start()
    {
        interactionUIText.text = "";
    }

    public void StartInteraction()
    {
        interactionUIText.text = interactionText;
    }

    public void ContinueInteraction()
    {
        EndInteraction();
    }

    public void EndInteraction()
    {
        interactionUIText.text = "";
        isInteracting = false;
    }
}
