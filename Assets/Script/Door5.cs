using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door5 : MonoBehaviour
{
    public Transform Player;
    public Transform Door1;
    public Text text;
    Animation ani;
    bool IsOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animation>();
        text = text.GetComponent<Text>();
        text.color = new Color(1, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float dis = Vector3.Distance(Player.position, Door1.position);
        if (dis < 2 && !IsOpen)
        {
            ani.Play("Open");
            text.text = "教师办公室";
            text.color = new Color(1, 0, 0, 1);
            IsOpen = true;
        }
        if (dis > 2 && IsOpen)
        {
            ani.Play("Close");

            text.color = new Color(1, 0, 0, 0);
            IsOpen = false;
        }

    }
}
