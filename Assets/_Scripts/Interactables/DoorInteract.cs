using UnityEngine;

public class DoorInteract : MonoBehaviour, IInteractable
{
    [SerializeField] private Transform point;
    private Animator animator;
    private bool isOpen = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Interact()
    {
        if (!isOpen && point.childCount > 0)
        {
            animator.SetTrigger("oeffnen");
            gameObject.layer = LayerMask.NameToLayer("Default");
            Destroy(point.GetChild(0).gameObject);

            isOpen = true;
        }
    }
}
