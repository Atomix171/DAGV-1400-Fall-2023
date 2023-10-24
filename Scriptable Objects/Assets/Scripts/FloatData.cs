using UnityEngine;

using UnityEngine.Events;

[CreateAssetMenu(fileName = "New Float Data", menuName = "Float Data")]
public class FloatData : ScriptableObject
{
   public UnityEvent onZeroEvent;

   public float value;

   public void UpdateValue(float number)
   {
        value += number;
   }


}
