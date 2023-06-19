using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour, ITaggable
{
    [SerializeField] private List<GameObjectTag> tags;
    public List<GameObjectTag> Tags
    {
        get { return tags; }
    }

    [SerializeField] private IntReference defaultDamage;
    private int currentDamage;
    public int Damage
    {
        get { return currentDamage; }
    }

    [SerializeField] private float defaultTravelSpeed = 1;
    private float travelSpeed;

    private Rigidbody rb;  

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        travelSpeed = defaultTravelSpeed;
        currentDamage = defaultDamage;
    }

    private void OnEnable()
    {
        rb.AddForce(transform.forward * travelSpeed);
    }
}
