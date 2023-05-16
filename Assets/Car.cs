using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public CarBody body { get; set; }
    public CarWheel wheel { get; set; }

    public Car(CarBody body, CarWheel wheel)
    {
        this.body = body;
        this.wheel = wheel;
    }

    public float getMass()
    {
        return body.mass + wheel.mass;
    }
}
