using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformUpdater : MonoBehaviour
{
    [SerializeField] private TransformVariable toUpdate;

    private void Awake()
    {
        toUpdate.transform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        toUpdate.transform = transform;
    }
}
