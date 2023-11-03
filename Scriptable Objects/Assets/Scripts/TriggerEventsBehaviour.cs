using UnityEngine;
using UnityEngine.Events;


public class TriggerEventsBehaviour : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    public void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}
