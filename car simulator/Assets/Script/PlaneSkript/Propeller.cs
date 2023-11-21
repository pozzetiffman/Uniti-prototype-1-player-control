using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{
    // Публичная переменная скорости вращения винта 
    public float rotationSpeed = 20f;

    //Update вызывается каждый кадр, а FixedUpdate с фиксированной частотой
    private void Update()
    {
        //Перемещение обекта по вертикали (0,0,1) + управление + скорость + сглаживание
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
