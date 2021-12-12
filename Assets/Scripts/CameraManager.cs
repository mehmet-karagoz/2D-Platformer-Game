using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float cameraSpeed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
            transform.position = Vector3.Slerp(transform.position, new Vector3(target.position.x, target.position.y + 1, transform.position.z), cameraSpeed);
    }
}
