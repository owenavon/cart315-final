using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadEndScreen : MonoBehaviour
{
    public PickerUpper player;
    void OnTriggerEnter()
    {
        SceneManager.LoadScene("End Screen");
    }    
}
