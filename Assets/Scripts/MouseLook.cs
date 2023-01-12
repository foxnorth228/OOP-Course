using UnityEngine;

public class MouseLook : MonoBehaviour 
{
	public float sensitivityHor = 9.0f;
	public float sensitivityVert = 9.0f;
	public float minimumVert = -45.0f;
	public float maximumVert = 45.0f;

	private float _rotationX = 0;

	void Start()
	{
		Rigidbody body = GetComponent<Rigidbody>();
		if (body != null)
			body.freezeRotation = true;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}

	void Update()
	{
		if (Input.GetKey(KeyCode.Escape))
        {
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
		}
		if (Input.GetMouseButtonDown(0))
		{
			Cursor.visible = false;
			Cursor.lockState = CursorLockMode.Locked;
		}

		_rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
		_rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);
		float delta = Input.GetAxis("Mouse X") * sensitivityHor;
		float rotationY = transform.localEulerAngles.y + delta;
		transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
	}
}
