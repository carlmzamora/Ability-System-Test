using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SpawningAbility : Ability
{
    public GameObject objectToSpawn;
    public TransformVariable spawnPoint;

    public override void Activate()
    {
        Instantiate(objectToSpawn, spawnPoint.transform.position, spawnPoint.transform.rotation);
    }
}