using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CangeOneCamera : MonoBehaviour
{
    //Переменная камер для закрепа камер в нутри обекта
    public Camera MainCameraPlTwo;
    public Camera NotCaneraPlTwo;
    //Переменная с выбором всех клавиш
    public KeyCode SwPlTwo;

    //Update вызывается каждый кадр, а FixedUpdate с фиксированной частотой
    private void Update()
    {
        // ели активен switchkey при нажатии ON && OFF камеры
        if (Input.GetKeyDown(SwPlTwo))
        {
            MainCameraPlTwo.enabled = !MainCameraPlTwo.enabled;
            NotCaneraPlTwo.enabled = !NotCaneraPlTwo.enabled;
        }
    }
}

