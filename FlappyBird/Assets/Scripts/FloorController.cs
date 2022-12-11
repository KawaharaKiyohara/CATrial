using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorController : MonoBehaviour
{
    // ”wŒi(°)ƒXƒNƒ[ƒ‹‚Ìˆ—
    void Update()
    {
        transform.Translate(-0.01f, 0, 0);
        if (transform.position.x <= -20.72f)
        {
            transform.position = new Vector3(20.72f, -4.7f, -2.0f);
        }
    }
}