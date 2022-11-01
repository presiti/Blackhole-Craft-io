using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMoving : MonoBehaviour
{

    private Transform target;

    private Vector3 lastMovingVelocity;
    private Vector3 targetPosition;

    private Camera cam;
    private float targetZoomSize = 5f;

    void Awake()
    {
        cam = GetComponentInChildren<Camera>(); //Ãß°¡
    }

        // Start is called before the first frame update
        void Start()
    {
        target = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        targetPosition = new Vector3();
        targetPosition.x = target.transform.position.x;
        targetPosition.y = target.transform.position.y;
        targetPosition.z = transform.position.z;

        transform.position = targetPosition;
    }
}
