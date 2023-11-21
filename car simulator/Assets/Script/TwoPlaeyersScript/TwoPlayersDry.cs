using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TwoPlayersDry : MonoBehaviour
{
    // переменная скорости 
    public float speed = 0f;
    // Переменная разворота 
    public float rotateSpeed = 0f;
    // Переменная ID Пользовтаеля для упровления 
    public string InpudID;

    //Update вызывается каждый кадр, а FixedUpdate с фиксированной частотой
    private void Update()
    {
        // Переменные для гаризонтального и вертикального управления + ID Пользовтаеля
        float h = Input.GetAxis("Horizontal" + InpudID);
        float v = Input.GetAxis("Vertical" + InpudID);

        //Перемещение обекта по горизонтали (0,1,0) + управление + скорость + сглаживание 
        transform.Rotate(Vector3.up * h * rotateSpeed * Time.deltaTime);
        //Перемещение обекта по вертикали (0,0,1) + управление + скорость + сглаживание
        transform.Translate(Vector3.forward * v * rotateSpeed * Time.deltaTime);
    }
}
