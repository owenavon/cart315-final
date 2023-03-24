using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel1 : MonoBehaviour
{
    public PickerUpper player;
    void OnTriggerEnter()
    {
        SceneManager.LoadScene("Level 1");
    }    
}
