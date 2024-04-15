using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    void Start()
    {
        transform.position = new Vector3(549f,-162.41f,-93f);
    }

    void Update()
    {
        transform.position += transform.forward * 0.05f;
    }

    void OnCollisionEnter(Collision collision)
    {
        transform.Rotate(Vector3.up, 0.05f);
    }
}
