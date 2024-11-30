using UnityEngine;

public class KeyInteract : MonoBehaviour, IInteractable
{
    [SerializeField] private Transform point;
    [SerializeField] private GameObject keyPrefab;

    public void Interact()
    {
        if (!point)
        {
            Debug.LogError("Point is not assigned in the inspector");
            return;
        }

        var key = Instantiate(keyPrefab, point.position, Quaternion.identity, point);
        key.transform.localPosition = Vector3.zero;
        key.transform.localRotation = keyPrefab.transform.rotation;

        Destroy(gameObject);
    }
}
