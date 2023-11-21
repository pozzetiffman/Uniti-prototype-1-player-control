using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    // переменная player для закрепа обекта к камере
    public GameObject player;
    // Переменная vector новой позиции камеры с публичным изменением 
    public Vector3 vector = new Vector3(0, 0, 0);

    //Update вызывается каждый кадр, а FixedUpdate с фиксированной частотой
    private void Update()
    {
        // статичная позиция камеры по оси 
        transform.position = player.transform.position + vector;
    }
}
