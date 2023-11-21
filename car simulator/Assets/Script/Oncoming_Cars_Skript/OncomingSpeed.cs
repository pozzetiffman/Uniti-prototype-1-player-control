using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OncomingSpeed : MonoBehaviour
{
    // переменная скорости публичная 
    public float speed = 0f;

    //Update вызывается каждый кадр, а FixedUpdate с фиксированной частотой
    private void Update()
    {
        // перемещение обекта строго по одной оси + скорсость + сглаживание 
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
