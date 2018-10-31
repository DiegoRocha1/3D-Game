using UnityEngine;

public class CarController : MonoBehaviour
{
	public Vector3 jump;
	public float jumpForce = 2.0f;
     
	public bool isGrounded;
	Rigidbody rb;

	void Start() {
		rb = GetComponent<Rigidbody>();
		jump = new Vector3(0.0f, 2.0f, 0.0f);
	}
	
	void OnCollisionStay() {
		isGrounded = true;
	}
	
	void Update() {
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 60.0f;

		transform.Rotate(0, x, 0);
		transform.Translate(0, 0, z);
		
		if (Input.GetKeyDown(KeyCode.Space) && isGrounded){
			rb.AddForce(jump * jumpForce, ForceMode.Impulse);
			isGrounded = false;
		}
		
		//if (Input.GetKeyDown ("space")){
		//	transform.Translate(Vector3.up * Time.deltaTime * 30, Space.World);
		//}	
	}
}