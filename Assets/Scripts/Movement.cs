using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    //public CharacterController player;
    public float speed;
    private bool isMoving = false;
    public float mouseSensitivity = 2f;
    public float yRot;
    public float xRot;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        yRot += Input.GetAxis("Mouse X") * mouseSensitivity;
        xRot += Input.GetAxis("Mouse Y") * mouseSensitivity;
     //   transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, yRot, transform.localEulerAngles.z);
        transform.localEulerAngles = new Vector3(xRot, yRot, transform.localEulerAngles.z);

        isMoving = false;

        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime);
            //rb.velocity = transform.right * Input.GetAxisRaw("Horizontal") * speed;
            isMoving = true;
        }
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime);
            //rb.velocity = transform.forward * Input.GetAxisRaw("Vertical") * speed;
            isMoving = true;
        }





        //float moveHorizontal = Input.GetAxisRaw("Horizontal");
        //float moveVertical = Input.GetAxisRaw("Vertical");

        //Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        //player.transform.rotation = Quaternion.LookRotation(movement);



        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    player.transform.Translate(Vector3.forward * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    player.transform.Translate(Vector3.back * Time.deltaTime);
        //}

        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    float angle = player.transform.rotation.y;
        //    float newAngle = angle + 10;
        //    player.transform.rotation = Quaternion.AngleAxis(newAngle, Vector3.up);
        //}
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    player.transform.Translate(Vector3.left * Time.deltaTime);
        //}
    }

}

