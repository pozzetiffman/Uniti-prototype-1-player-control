using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera2 : MonoBehaviour
{

    public float speed = 20f;
    public float rotationSpeed = 20f;
    public Camera Player2Cam;
    public Camera HoodCamera1;
    public KeyCode switcKey;
    public string inputID;

    

        // Обновление вызывается один раз за кадр
        void FixedUpdate()
        {

            // получаем вертикальный ввод пользователя
            float v = Input.GetAxis("Vertical" + inputID);
            float h = Input.GetAxis("Horizontal" + inputID);


            // наклонить самолет вверх/вниз с помощью клавиш со стрелками вверх/вниз
            transform.Rotate(Vector3.up * rotationSpeed * h * Time.deltaTime);

            // перемещаем плоскость вперед с постоянной скоростью
            transform.Translate(Vector3.forward * speed * v * Time.deltaTime);


            if (Input.GetKeyDown(switcKey))
            {

                Player2Cam.enabled = !Player2Cam.enabled;
                HoodCamera1.enabled = !HoodCamera1.enabled;
            }
        }
    }


