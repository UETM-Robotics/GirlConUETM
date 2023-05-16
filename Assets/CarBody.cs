using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBody
{
    public Sprite sprite { get; }
    public float mass { get; }
    public float boxColliderHeight { get; }
    
    public CarBody(Sprite sprite, float mass, float boxColliderHeight)
    {
        this.sprite = sprite;
        this.mass = mass;
    }
}
