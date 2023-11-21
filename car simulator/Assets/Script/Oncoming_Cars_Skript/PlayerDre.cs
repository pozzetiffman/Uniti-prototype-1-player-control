using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDre : MonoBehaviour
{
    // переменная скорости 
    public float speed = 0f;
    // Переменная разворота 
    public float rotateSpeed = 0f;

    //Update вызывается каждый кадр, а FixedUpdate с фиксированной частотой
    private void Update()
    {
        // Переменные для гаризонтального и вертикального управления 
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //Перемещение обекта по вертикали (0,1,0) + управление + скорость + сглаживание
        transform.Rotate(Vector3.up * h * rotateSpeed * Time.deltaTime);
        //Перемещение обекта по вертикали (0,0,1) + управление + скорость + сглаживание
        transform.Translate(Vector3.forward * v * speed * Time.deltaTime);
    }
}
