using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, ITaggable
{
    [SerializeField] private List<GameObjectTag> tags;
    public List<GameObjectTag> Tags
    {
        get { return tags; }
    }

    private void OnCollisionEnter(Collision col)
    {
        ITaggable taggable = col.gameObject.GetComponent<ITaggable>();
        if(taggable != null )
        {
            foreach(GameObjectTag ownTag in tags)
            {
                foreach(GameObjectTag otherTag in taggable.Tags)
                {
                    if(ownTag.DestroyOnCollisionList.Contains(otherTag))
                    {
                        Destroy(col.gameObject);
                    }
                }
            }
        }

        Projectile projectile = col.gameObject.GetComponent<Projectile>();
        if(projectile != null)
        {
            TakeDamage(projectile.Damage);
        }
    }

    private void TakeDamage(int amount)
    {
        Debug.Log("Damage taken: " + amount);
    }
}
