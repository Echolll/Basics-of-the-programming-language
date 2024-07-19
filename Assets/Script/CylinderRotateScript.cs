using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderRotateScript : MonoBehaviour
{
    public bool CylinderRotate;
    void Update()
    {
        if (CylinderRotate)
        {
            Quaternion Rotate = Quaternion.AngleAxis(-5 * Time.deltaTime, Vector3.right);
            transform.rotation = transform.rotation * Rotate;
        }
    }
}
