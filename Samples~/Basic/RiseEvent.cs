using UnityEngine;
using SoMLib.Event;

public class RiseEvent : MonoBehaviour
{
    [Header("Fixed Event Test")]
    public SoMFixedEvent testFixedEvent;
    public SoMFixedEventData testFixedEventData;

    [Header("String Event Test")]
    public SoMStringEvent testStringEvent;
    [TextArea(3, 10)]
    public string testStringPayload = "type=test|value=100|active=true";

    [ContextMenu("Raise Fixed Event")]
    public void RaiseFixedEvent()
    {
        if (testFixedEvent != null)
        {
            testFixedEvent.Raise(testFixedEventData);
        }
    }

    [ContextMenu("Raise String Event")]
    public void RaiseStringEvent()
    {
        if (testStringEvent != null)
        {
            testStringEvent.Raise(testStringPayload);
        }
    }

}
