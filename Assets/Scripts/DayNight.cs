using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour
{
    public float angle;
    public Transform trans;
    Vector3 rot;
    // Start is called before the first frame update
    void Start()
    {
        angle = 0;
        trans = this.gameObject.transform;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(angle == 360){
            angle = 0;
        }
        angle += 0.1f;
        rot = new Vector3(angle, 10, 0);
        this.gameObject.transform.eulerAngles = rot;

    }
}
