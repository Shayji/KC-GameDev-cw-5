using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brick : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D Collision)
    {
        Destroy(this.gameObject);
    }
}
