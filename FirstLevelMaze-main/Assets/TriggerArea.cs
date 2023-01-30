using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        GameEvents.current.DoorwayTriggerEnter();
    }

    public void OnTriggerExit(Collider other)
    {
        GameEvents.current.DoorwayTriggerExit();
    }
}
