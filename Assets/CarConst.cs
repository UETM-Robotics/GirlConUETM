using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarConst : MonoBehaviour
{
    [SerializeField] Sprite[] carBodySprites;
    [SerializeField] Sprite[] carWheelSprites;

    [SerializeField] float[] bodyMasses;
    [SerializeField] float[] wheelMasses;
    [SerializeField] float[] wheelRadii;

    static CarBody[] bodies;
    static CarWheel[] wheels;    

    private void Awake()
    {
        int num = carBodySprites.Length;

        bodies = new CarBody[num];
        wheels = new CarWheel[num];

        for (int i = 0; i < num; i++)
        {
            bodies[i] = new CarBody(carBodySprites[i], bodyMasses[i]);
            wheels[i] = new CarWheel(carWheelSprites[i], wheelMasses[i], wheelRadii[i]);
        }
    }
}
