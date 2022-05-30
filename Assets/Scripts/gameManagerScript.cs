using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManagerScript : MonoBehaviour
{
    [SerializeField]
    Animator transitionAnim;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            int sceneBuildIndex = SceneManager.GetActiveScene().buildIndex;

            if(sceneBuildIndex == 0)
            {
                StartCoroutine(ChangeToSceneB());
            }
            else
            {
                StartCoroutine(ChangeToSceneA());
            }
        }
    }

    IEnumerator ChangeToSceneB()
    {
        transitionAnim.SetTrigger("exit");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(1);
    }

    IEnumerator ChangeToSceneA()
    {
        transitionAnim.SetTrigger("exit");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(0);
    }
}
