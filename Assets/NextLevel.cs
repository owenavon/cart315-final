using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Runtime.CompilerServices;

public class NextLevel : MonoBehaviour
{

    public PickerUpper player;

    void OnTriggerEnter()
    {
        if (player.count >= 2)
        {
            SceneManager.LoadScene("Level 2");
        }
        else
        {
            SceneManager.LoadScene("Level 1");
        }
    }
}
