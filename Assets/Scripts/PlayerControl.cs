using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 20.0f;
    public float turnSpeed  = 45.0f;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal")*turnSpeed;
        verticalInput = Input.GetAxis("Vertical")*speed;
     
    }
    private void FixedUpdate()
    {
        Vector3 rotation = Vector3.up * horizontalInput;
        Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);
        rb.MovePosition(this.transform.position + this.transform.forward * verticalInput * Time.fixedDeltaTime);
        rb.MoveRotation(rb.rotation * angleRot);
    }
}
