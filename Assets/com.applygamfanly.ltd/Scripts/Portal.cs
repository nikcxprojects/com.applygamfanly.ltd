using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] Transform b;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.attachedRigidbody.position = b.position;
    }
}
