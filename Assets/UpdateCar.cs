using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class updateSprite : MonoBehaviour
{
    public TMP_Dropdown BodyDropdown;
    public TMP_Dropdown WheelDropdown;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        sprite.sprite = sprites[dropdown.value];
    }
}
