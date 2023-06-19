using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "GameObject Tag")]
public class GameObjectTag : ScriptableObject
{
    [Tooltip("GameObjects that will get destroyed by this GameObject on collision.")]
    public List<GameObjectTag> DestroyOnCollisionList = new List<GameObjectTag>();
}
