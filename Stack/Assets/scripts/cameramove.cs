using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            // Kamera objesini alýn
            Camera camera = Camera.main;

            // Kamera pozisyonunu alýn
            Vector3 cameraPos = camera.transform.position;

            // Kamera y ekseninde 1 birim yukarý çýkýn
            cameraPos.y += 0.002f;

            // Kamera pozisyonunu güncelleyin
            camera.transform.position = cameraPos;
        }
    }
}
