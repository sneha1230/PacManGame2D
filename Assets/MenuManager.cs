using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject optionPanel;
    public GameObject topPanel, middlePanel;
    public GameObject helpPanel;
    public void OptionsMenu()
    {
        optionPanel.SetActive(true);
        topPanel.SetActive(false);
        middlePanel.SetActive(false);
    }
    public void HelpMenu()
    {
        helpPanel.SetActive(true);
        optionPanel.SetActive(false);
        topPanel.SetActive(false);
        middlePanel.SetActive(false);
    }

    public void Back()
    {
        optionPanel.SetActive(false);
        topPanel.SetActive(true);
        middlePanel.SetActive(true);
    }
    public void back()
    {
        helpPanel.SetActive(false);
        topPanel.SetActive(true);
        middlePanel.SetActive(true);
    }
}
