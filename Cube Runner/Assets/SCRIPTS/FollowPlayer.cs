using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public float offset;
    public Transform PlayerTransform;
    void Start()
    {
        
    }

   
    void Update()
    {

        Vector3 camerapos = transform.position;
        camerapos.z = PlayerTransform.position.z + offset; ;
        transform.position = camerapos;
    }
}
