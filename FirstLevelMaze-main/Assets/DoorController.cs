using UnityEngine;

public class DoorController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // GameEvents.current.onDoorwayTriggerEnter += onDoorwayOpen;
        GameEvents.current.onDoorwayTriggerExit += onDoorwayClose;
    }

    private void onDoorwayOpen()
    {
        // LeanTween.moveLocalY(gameObject, 8f, 1f).setEaseOutQuad();
    }

    private void onDoorwayClose()
    {
        LeanTween.moveLocalY(gameObject, 8f, 1f).setEaseInQuad();
    }

    private void OnDestroy()
    {
        GameEvents.current.onDoorwayTriggerEnter -= onDoorwayOpen;
        GameEvents.current.onDoorwayTriggerExit -= onDoorwayClose;
    }
}
