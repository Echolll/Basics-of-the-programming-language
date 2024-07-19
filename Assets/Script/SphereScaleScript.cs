using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScaleScript : MonoBehaviour
{
    public bool SphereRotate;
    static float _speed = 1.5f;
    void Update()
    {
        if (SphereRotate)
        {
            transform.localScale = transform.localScale + new Vector3(2, 2, 2) * (_speed * Time.deltaTime);
        }
    }
}
