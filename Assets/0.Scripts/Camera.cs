using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform player; // 카메라 딱 이동
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vec3 = transform.position;
        vec3.x = 1;
        vec3.y = 1;
        vec3.z = 1;

        vec3 = transform.position;
    }
}
