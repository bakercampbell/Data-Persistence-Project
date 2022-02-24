using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class NameHandler : MonoBehaviour
{

    public static NameHandler nameHandler;
    public  TextMeshProUGUI nameField;
    public static string userName;

    
    void Awake()
    {        
        if (nameHandler == null)
        {
            nameHandler = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);        
        
        if (userName != nameField.text)
        {
            userName = nameField.text;
        }
    }

   
}
