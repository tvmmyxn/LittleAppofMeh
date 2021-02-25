using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public string fileName = "default.txt";
    public Text displayName;

    private string[] StudentNames;
    // Start is called before the first frame update
    void Start()
    {
        LoadStudentNames();
        ButtonClick();
    }

    private void LoadStudentNames()
    {
        this.StudentNames = File.ReadAllLines(fileName);
    }

    public void ButtonClick()
    {
        int i = UnityEngine.Random.Range(0, this.StudentNames.Length);
        string name = this.StudentNames[i];
        displayName.text = name;
    }


}