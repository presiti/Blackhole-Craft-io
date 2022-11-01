using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_Scale : MonoBehaviour
{
    Score sc = new Score();

    private static float initX = 0.15f, initY = 0.15f;
    private float x, y, z = 0f;


    // Update is called once per frame
    void Update()
    {
        x = initX * (sc.score % 10 == 0 && sc.score != 0 ? 1.5f : 1f);
        y = initY * (sc.score % 10 == 0 && sc.score != 0 ? 1.5f : 1f);
        transform.localScale = new Vector3(x, y, z);
    }
}
