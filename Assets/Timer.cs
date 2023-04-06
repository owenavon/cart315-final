using UnityEngine;
using TMPro; // Import text mesh pro
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    private float timeDuration = 60f;
    private float timer;

    [SerializeField]
    private TextMeshProUGUI TimerOnScreen;

    // Start is called before the first frame update
    void Start()
    {
        ResetTimer();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            UpdateTimerDisplay(timer);
        }
        else
        {
            // Debug.Log("Time is up!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void ResetTimer()
    {
        timer = timeDuration;
    }

    private void UpdateTimerDisplay (float time)
    {
        // float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);

        string currentTime = string.Format("{00:00}", seconds);
        TimerOnScreen.text = "Timer: " + currentTime;
    }

    private void SetTextDisplay(bool enabled)
    {
        TimerOnScreen.enabled = enabled;
    }

}
