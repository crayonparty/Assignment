using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIController : MonoBehaviour
{
    public GameObject InstructionsPanel;
    public GameObject IntroductionPanel;
    public GameObject SettingsPanel;
    public GameObject Panel;
    public GameObject ErrorPanel;


    public void LoadSettingPanel()
    {
        InstructionsPanel.gameObject.SetActive(false);
        IntroductionPanel.gameObject.SetActive(false);
        Panel.gameObject.SetActive(false);
        ErrorPanel.gameObject.SetActive(false);
        SettingsPanel.gameObject.SetActive(true);
    }

    public void LoadInstructionPanel()
    {
        SettingsPanel.gameObject.SetActive(false);
        InstructionsPanel.gameObject.SetActive(true);
        IntroductionPanel.gameObject.SetActive(false);
        Panel.gameObject.SetActive(true);
        ErrorPanel.gameObject.SetActive(false);
    }

    public void LoadIntroductionPanel()
    {
        InstructionsPanel.gameObject.SetActive(false);
        IntroductionPanel.gameObject.SetActive(false);
        Panel.gameObject.SetActive(false);
        ErrorPanel.gameObject.SetActive(false);
        SettingsPanel.gameObject.SetActive(true);
    }
    public void LoadClosePanel()
    {
        InstructionsPanel.gameObject.SetActive(false);
        IntroductionPanel.gameObject.SetActive(false);
        Panel.gameObject.SetActive(false);
        ErrorPanel.gameObject.SetActive(false);
        SettingsPanel.gameObject.SetActive(false);
    }

            /*    if()
            {
                public void LoadErrorPanel()
                {
                    InstructionsPanel.gameObject.SetActive(false);
                    IntroductionPanel.gameObject.SetActive(false);
                    Panel.gameObject.SetActive(false);
                    ErrorPanel.gameObject.SetActive(true);
                    SettingsPanel.gameObject.SetActive(false);
                }
            */
        }
