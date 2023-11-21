using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCange : MonoBehaviour
{
    //Переменная камер для закрепа камер в нутри обекта
    public Camera MainCamera;
    public Camera NotMaincamera;
    //Переменная с выбором всех клавиш
    public KeyCode Swith;

    //Update вызывается каждый кадр, а FixedUpdate с фиксированной частотой
    private void Update()
    {
        // ели активен switchkey при нажатии ON && OFF камеры 
        if (Input.GetKeyDown(Swith))
        {
            MainCamera.enabled = !MainCamera.enabled;
            NotMaincamera.enabled = !MainCamera.enabled;
        }
    }
}
