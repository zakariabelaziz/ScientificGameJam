using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvPlateform : MonoBehaviour
{
    public float speed;
    public Transform targetObj;
    private Vector3 target;
    private Vector3 origin;
    public bool activeplat;
    private bool forward;
    void Start()
    {
        target = targetObj.position;
        origin = transform.position;
        activeplat = false;
        forward = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (activeplat && forward) {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            if (transform.position == target)
                forward = false;
        }
        else if (activeplat && !forward) {
            transform.position = Vector3.MoveTowards(transform.position, origin, speed * Time.deltaTime);
            if (transform.position == origin)
                forward = true ;
        }
    }
}
