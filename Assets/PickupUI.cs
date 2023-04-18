using System.Collections;
using System.Collections.Generic;
using TMPro; // Import text mesh pro
using UnityEngine;

public class PickupUI : MonoBehaviour
{
    public PickerUpper player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<TextMeshProUGUI>().text = "Collect at least 5 snowballs. Avoid the trees. Snowball Count: " + player.count;
    }
}