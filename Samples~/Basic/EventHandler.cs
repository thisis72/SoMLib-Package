using UnityEngine;
using SoMLib.Event;

public class EventHandler : MonoBehaviour
{

    // 스트럭쳐 이벤트 핸들러 예제
    public void OnFixedEventReceived(SoMFixedEventData data)
    {
        Debug.Log($"[EventHandler] Fixed Event Received: int={data.intValue}, vector={data.vector3Value}, string={data.stringValue}");
    }

    // 문자열 이벤트 핸들러 예제
    public void OnStringEventReceived(string payload)
    {
        var eventData = SoMStringEventHelper.Parse(payload);
        Debug.Log($"[EventHandler] String Event Received: {payload}");
        Debug.Log("-> 데미지 : " + SoMStringEventHelper.GetFloat(eventData, "데미지"));
    }
}