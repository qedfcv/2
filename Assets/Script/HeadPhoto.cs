using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class HeadPhoto : MonoBehaviour
{
    public Image avatarImage;
    public Sprite[] avatarSprites;//´æ´¢Í·Ïñ
    public Text name1;
    string path;
    // Start is called before the first frame update
    void Start()
    {
        path = Application.dataPath + @"\IO\Load.txt";
        int randomIndex = Random.Range(0, avatarSprites.Length);
        avatarImage.sprite = avatarSprites[randomIndex];
        name1.text = File.ReadAllText(path);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
