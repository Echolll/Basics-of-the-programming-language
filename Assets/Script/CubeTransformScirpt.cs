using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CubeTransformScirpt : MonoBehaviour
{
    public bool CubeTransform;
    static float _speed = 2f;
    void Update()
    {
        if (CubeTransform)
        {
            transform.position = transform.position + new Vector3(0, 0, 1) * (_speed * Time.deltaTime);
        }
    }
}
