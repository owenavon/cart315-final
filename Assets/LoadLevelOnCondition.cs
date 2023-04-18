using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Runtime.CompilerServices;

public class LoadLevelOnCondition : MonoBehaviour
{
    public PickerUpper player;
    void OnTriggerEnter()
    {
        if (player.count >= 5)
        {
            SceneManager.LoadScene("Level 2");
        }
        else
        {
            SceneManager.LoadScene("Level 1");
        }
    }
}
