using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            // Kamera objesini al�n
            Camera camera = Camera.main;

            // Kamera pozisyonunu al�n
            Vector3 cameraPos = camera.transform.position;

            // Kamera y ekseninde 1 birim yukar� ��k�n
            cameraPos.y += 0.002f;

            // Kamera pozisyonunu g�ncelleyin
            camera.transform.position = cameraPos;
        }
    }
}
