using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public float Power = 1f;

	void FixedUpdate ()
	{
	    if (Input.GetKey(KeyCode.LeftShift))
	    {
	        AddRotation();
	    }
	    else
	    {
            AddForce();
	    }
        
	}

    private void AddRotation()
    {
        float x = Input.GetAxis("Vertical");
        float y = Input.GetAxis("Horizontal");
        
        Vector3 torque = new Vector3(x, y, 0f);
        rigidbody.AddRelativeTorque(torque);
    }

    private void AddForce()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        Vector3 direction = new Vector3(h, 0f, v);
        rigidbody.AddRelativeForce(direction*Power, ForceMode.Acceleration);
    }
}
