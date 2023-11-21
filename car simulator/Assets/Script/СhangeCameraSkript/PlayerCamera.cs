using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    // переменная player для закрепа обекта к камере 
    public GameObject player;
    // Новая позиция камеры с публичной переменной 
    public Vector3 stat = new Vector3(0, 4, -9);

    //Update вызывается каждый кадр, а FixedUpdate с фиксированной частотой
    void Update()
    {
        // статичная позиция камеры по оси 
        transform.position = player.transform.position + stat;
    }
}
