using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boarder : MonoBehaviour
{
    private void OnCollision2D(Collision2D collision)
    {
        SceneManager.LoadScene(0);
    }
}
