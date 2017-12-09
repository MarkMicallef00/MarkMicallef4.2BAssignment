using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{

    void Update()
    {
        float mousePos = (Input.mousePosition.y / Screen.height * 28f)-14f;

        Vector3 paddlePosition = new Vector3(22f, mousePos, 0f);
        paddlePosition.y = Mathf.Clamp(mousePos, -12f, 12f);
        this.transform.position = paddlePosition;
    }
}
