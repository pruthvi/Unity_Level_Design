/*  Copyright (c) Pruthvi  |  http://pruthv.com  */

using UnityEngine;

public class CamMovement : MonoBehaviour {

    #region Variables
    public float speed;
    public Rigidbody rb;
    public float mouseSensitivity = 2f;
    public float yRot;
    public float xRot;

    //public Camera playerCamera;
    #endregion

    void Start ()
	{
        rb = this.gameObject.GetComponent<Rigidbody>();
	}
	
	void Update ()
	{
        yRot += Input.GetAxis("Mouse X") * mouseSensitivity;
       // xRot += Input.GetAxis("Mouse Y") * mouseSensitivity;
        //   transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, yRot, transform.localEulerAngles.z);
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, yRot, transform.localEulerAngles.z);
      //  playerCamera.transform.localEulerAngles = new Vector3(xRot, transform.localEulerAngles.y, transform.localEulerAngles.z);


        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            // transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime);
            rb.velocity = transform.right * Input.GetAxisRaw("Horizontal") * speed + transform.up * -9.81f;

        }
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            //transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime);
            rb.velocity = transform.forward * Input.GetAxisRaw("Vertical") * speed + transform.up * -9.81f;
        }


    }

}
