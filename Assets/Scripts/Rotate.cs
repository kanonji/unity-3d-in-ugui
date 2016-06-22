using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	[SerializeField]
	private float rotateSpeed;
	private Vector3 defaultMousePosition;
	private bool isSwiping = false;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update()
	{
		if (false == IsPressed())
		{
			isSwiping = false;
			return;
		}
		if (true == IsPressed())
		{
            if (false == isSwiping)
            {
                defaultMousePosition = Input.mousePosition;
                isSwiping = true;
            }
			Vector3 mousePos = Input.mousePosition;
			Vector3 distanceMousePos = mousePos - defaultMousePosition;
			float angleY = distanceMousePos.x * rotateSpeed;
			transform.Rotate(new Vector3(transform.eulerAngles.x, angleY, 0));
			defaultMousePosition = mousePos;
		}
	}

    private bool IsPressed()
    {
        if (IsTouchPlatform())
        {
            if (0 == Input.touchCount)
            {
                return false;
            }
            return true;
        } else
        {
            return Input.GetMouseButton(0);
        }

    }

    private bool IsTouchPlatform()
    {
        if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
        {
            return true;
        }
        return false;
    }
}
