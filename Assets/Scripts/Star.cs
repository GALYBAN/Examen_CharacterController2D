using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Star : MonoBehaviour
{

void OnTriggerEnter2D(Collider2D collider)
{
    if(collider.gameObject.CompareTag("Player"))
    {
        SceneManager.LoadScene("Victory");
    }
}

}
