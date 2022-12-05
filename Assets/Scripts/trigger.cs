using UnityEngine;
using UnityEngine.Events;

public class trigger : MonoBehaviour
{
    [SerializeField] private UnityEvent Trigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Trigger.Invoke();
        }
    }
}
