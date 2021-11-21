using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D colInfo)
    {
        if (colInfo.transform.tag == "Car") StartCoroutine(MoveToNextLevel());
    }

    IEnumerator MoveToNextLevel()
    {
        // As there are no more levels, i'm just going to restart
        yield return new WaitForSeconds(0.5f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
