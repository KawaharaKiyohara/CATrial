using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorController : MonoBehaviour
{
    // ”wŒi(°)ƒXƒNƒ[ƒ‹‚Ìˆ—
    void Update()
    {
        transform.Translate(-0.01f, 0, 0);
        if (transform.position.x <= -18.944f)
        {
            transform.position = new Vector3(18.944f, -4.7f, -1.0f);
        }
    }
}