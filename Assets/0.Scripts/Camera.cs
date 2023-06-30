using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform player;
    Vector3 camera;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        camera = transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + camera;
    }
}
