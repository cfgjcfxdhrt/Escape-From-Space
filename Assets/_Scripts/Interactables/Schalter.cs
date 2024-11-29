using UnityEngine;

public class Schalter : MonoBehaviour, IInteractable

{
    [SerializeField] private Transform door;
    private Animator animator;
    private bool isOpen = false;

    public void Start(){
        animator = door.GetComponent<Animator>();
    }

    public void Interact()
    {
        isOpen = !isOpen;
        animator.SetTrigger("oeffnen");
    }
}
