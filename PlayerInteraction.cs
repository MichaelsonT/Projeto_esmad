using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private bool isInteracting = false;
    private ItemInteraction currentInteraction;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (isInteracting)
            {
                currentInteraction.ContinueInteraction();
            }
            else
            {
                RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.forward, out hit, 2f))
                {
                    ItemInteraction itemInteraction = hit.collider.GetComponent<ItemInteraction>();

                    if (itemInteraction != null)
                    {
                        itemInteraction.StartInteraction();
                        currentInteraction = itemInteraction;
                        isInteracting = true;
                    }
                }
            }
        }
    }
}
