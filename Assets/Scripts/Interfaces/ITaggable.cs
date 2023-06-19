using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITaggable
{
    List<GameObjectTag> Tags { get; }
}
