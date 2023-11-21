using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CangeTwoCamera : MonoBehaviour
{
    //Переменная камер для закрепа камер в нутри обекта
    public Camera MainCameraPlOne;
    public Camera NotCaneraPlOne;
    //Переменная с выбором всех клавиш
    public KeyCode SwPlOne;

    //Update вызывается каждый кадр, а FixedUpdate с фиксированной частотой
    private void Update()
    {
        // ели активен switchkey при нажатии ON && OFF камеры
        if (Input.GetKeyDown(SwPlOne))
        {
            MainCameraPlOne.enabled = !MainCameraPlOne.enabled;
            NotCaneraPlOne.enabled = !NotCaneraPlOne.enabled;
        }
    }
}
