using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    private bool isOpen = false;

    public void Interact()
    {
        isOpen = !isOpen;
        Debug.Log($"The door is now {(isOpen ? "open" : "closed")}.");
    }
}
