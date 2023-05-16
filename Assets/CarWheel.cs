using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarWheel
{
    public Sprite sprite { get; }
    public float mass { get; }
    public float radius { get; }

    public CarWheel(Sprite sprite, float mass, float radius)
    {
        this.sprite = sprite;
        this.mass = mass;
        this.radius = radius;
    }
}
