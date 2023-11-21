using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 20f;
    public float rotationSpeed = 20f;

    //Update вызывается каждый кадр, а FixedUpdate с фиксированной частотой
    void Update()
    {

        // получаем вертикальный ввод пользователя
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");


        // наклонить самолет вверх/вниз с помощью клавиш со стрелками вверх/вниз
        transform.Rotate(Vector3.right * rotationSpeed * h * Time.deltaTime);

        // перемещаем плоскость вперед с постоянной скоростью
        transform.Translate(Vector3.forward * speed * v * Time.deltaTime);

       

      
        
    }
}



