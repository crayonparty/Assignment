using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public GameObject InstructionsPanel;
    public GameObject IntroductionPanel;
    public GameObject SettingsPanel;
    public GameObject Panel;
    public GameObject ErrorPanel;
    public GameObject ResultsPanel;
  //  UnityEngine.XR.Interaction.Toolkit.XRRayInteractor:Awake();
   
    void Start()
    {
        InstructionsPanel.gameObject.SetActive(false);
        IntroductionPanel.gameObject.SetActive(true);
        Panel.gameObject.SetActive(true);
        ErrorPanel.gameObject.SetActive(false);
        SettingsPanel.gameObject.SetActive(false);
        ResultsPanel.gameObject.SetActive(false);
    }

    public void LoadSettingPanel()
    {
        InstructionsPanel.gameObject.SetActive(false);
        IntroductionPanel.gameObject.SetActive(false);
        Panel.gameObject.SetActive(true);
        ErrorPanel.gameObject.SetActive(false);
        SettingsPanel.gameObject.SetActive(true);
        ResultsPanel.gameObject.SetActive(false);
    }

    public void LoadInstructionPanel()
    {
        ResultsPanel.gameObject.SetActive(false);
        SettingsPanel.gameObject.SetActive(false);
        InstructionsPanel.gameObject.SetActive(true);
        IntroductionPanel.gameObject.SetActive(false);
        Panel.gameObject.SetActive(true);
        ErrorPanel.gameObject.SetActive(false);
    }

    public void ClosePanel()
    {
        ResultsPanel.gameObject.SetActive(false);
        Panel.gameObject.SetActive(true);
        SettingsPanel.gameObject.SetActive(false);
        InstructionsPanel.gameObject.SetActive(false);
        IntroductionPanel.gameObject.SetActive(false);
        ErrorPanel.gameObject.SetActive(false);
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }

}
