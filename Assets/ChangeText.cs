// Place this component on the object that is being animated.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeText : MonoBehaviour
{
    [Tooltip("The Text object that you'd like to alter.")]
    public TextMeshProUGUI textObject;
    [Tooltip("Each message you would like to display.")]
    public List<string> text = new List<string>  {"Red", "Blue", "Green"};

    private int counter = 0;
    
    void Start()
    {
        textObject.text = text[counter++];
    }

    public void ChangeTheText() {
        textObject.text = text[counter++ % text.Count];
    }
}
