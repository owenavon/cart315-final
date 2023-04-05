using UnityEngine;
using TMPro; // Import text mesh pro

public class Timer : MonoBehaviour
{
    private float timeDuration = 10f;

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
            Debug.Log("Time is up!");
            TimerOnScreen.text = "Time is up!";
        }
    }

    private void ResetTimer()
    {
        timer = timeDuration;
    }

    private void UpdateTimerDisplay (float time)
    {
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);

        string currentTime = string.Format("{00:00}{1:00}", minutes, seconds);
        TimerOnScreen.text = currentTime;    
    }

    private void SetTextDisplay(bool enabled)
    {
        TimerOnScreen.enabled = enabled;
    }

}
