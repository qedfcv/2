using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text;
using UnityEngine.SceneManagement;

public class sceneLoad : MonoBehaviour
{
    public InputField name1;
    public InputField id1;
    string path;
    // Start is called before the first frame update
    void Start()
    {
        path = Application.dataPath + @"\IO\Load.txt";
    }

    // Update is called once per frame
    public void button1()
    {
        if (name1.text != "" && id1.text != "")
        {
            File.WriteAllText(path, name1.text);
            SceneManager.LoadScene(1);
        }
    }
    void Update()
    {
        
    }
}
