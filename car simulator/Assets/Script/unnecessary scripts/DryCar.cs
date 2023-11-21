using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DryCar : MonoBehaviour
{
    public float speed = 20f;
    private void FixedUpdate()
    {
        transform.Translate(new Vector3 (0, 0, 1)* speed * Time.deltaTime);
    }
}
