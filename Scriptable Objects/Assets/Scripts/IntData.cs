using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "New Int Data", menuName = "Int Data")]
public class IntData : ScriptableObject
{
    public UnityEvent onZeroEvent;
    
    public int value;

    public void UpdateValue(int number)
    {
        value += number;
    }


}
