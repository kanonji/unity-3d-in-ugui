using UnityEngine;
using UnityEngine.EventSystems;

public class RotateByTrigger : MonoBehaviour {
	[SerializeField]
	private float rotateSpeed = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Rotate(BaseEventData baseEvent)
    {
        PointerEventData pointerEvent = baseEvent as PointerEventData;
        float angleY = pointerEvent.delta.x * rotateSpeed;
        transform.Rotate(new Vector3(transform.eulerAngles.x, angleY, 0));
    }
}
