using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    void OnTriggerEnter()
    {
        SceneManager.LoadScene("Level 2");
    }
}
