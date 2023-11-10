using UnityEngine.Events;
using UnityEngine;

public class MonoeventsBehaviour : MonoBehaviour
{
    public UnityEvent startEvent,awakeEvent,disableEvent;

    private void awake()
    {
        awakeEvent.Invoke();
    }

    private void start()
    {
        startEvent.Invoke();
    }

    private void OnDisable()
    {
        disableEvent.Invoke();
    }
}
