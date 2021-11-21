using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Car_Player : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D colInfo)
    {
        if (colInfo.transform.tag == "Collidable") return;

        StartCoroutine(Restart());
    }

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(0.5f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
