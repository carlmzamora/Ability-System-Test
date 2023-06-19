using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private TransformVariable target;
    [SerializeField] private Vector3 offset;

    void Start()
    {
        transform.position = target.transform.position + offset;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position + offset;
    }
}
