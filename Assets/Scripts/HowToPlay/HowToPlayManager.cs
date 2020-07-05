using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HowToPlayManager : MonoBehaviour
{
    /* Key */

    KeyManager keyMan;

    /* Audio */

    AudioManager audioMan;

    /* Animation constants */

    const float PANEL_OBJECTIVE_ENTER_DELAY = 2.0F;
    const float PANEL_CONTROLS_ENTER_DELAY = 5.0F;

    /* Panel Background */

    GameObject buttonBackgroundBack;
    GameObject buttonBackgroundExit;
    GameObject buttonBackgroundNext;
    GameObject textBackgroundNext;

    /* Panel Controls */

    GameObject panelControls;

    /* Panel Objective */

    GameObject panelObjective;

    /* Panel UI */

    GameObject panelUI;

    /* Panel Hint */

    GameObject panelHint;

    /* States */

    enum State {
        CONTROLS,
        OBJECTIVE,
        UI,
        HINT
    }

    State state;

    /* Start is called before the first frame update */

    void Start()
    {
        /* Key */

        keyMan = GameObject.Find("KeyManager").GetComponent<KeyManager>();

        /* Audio */

        audioMan = GameObject.Find("AudioManager").GetComponent<AudioManager>();

        /* Panel Background */

        buttonBackgroundBack = GameObject.Find("/UI/PanelBackground/ButtonBack");
        buttonBackgroundExit = GameObject.Find("/UI/PanelBackground/ButtonExit");
        buttonBackgroundNext = GameObject.Find("/UI/PanelBackground/ButtonNext");

        /* Panel Controls */

        panelControls = GameObject.Find("/UI/PanelControls");

        /* Panel Objective */

        panelObjective = GameObject.Find("/UI/PanelObjective");

        /* Panel UI */

        panelUI = GameObject.Find("/UI/PanelUI");

        /* Panel Hint */

        panelHint = GameObject.Find("UI/PanelHint");

        /* States */

        state = State.CONTROLS;

        /* Setup UI */

        buttonBackgroundBack.SetActive(false);
        buttonBackgroundNext.SetActive(true);
        
        if (keyMan.GetHowToPlayShown() == false)
            buttonBackgroundExit.SetActive(false);
        else
            buttonBackgroundExit.SetActive(true);
        

        panelControls.SetActive(true);
        panelControls.GetComponent<Animator>().Play("PanelControlsEnter");

        panelObjective.SetActive(false);
        panelUI.SetActive(false);
        panelHint.SetActive(false);
    }

    public void OnButtonExitPressed()
    {
        keyMan.SetHowToPlayShown(true);
        if (keyMan.GetSceneAfterHowToPlay() == KeyManager.SceneAfterHowToPlay.MAIN_MENU)
            SceneManager.LoadScene("MainMenu");
        else
            SceneManager.LoadScene("Level");
    }

    public void onButtonNextPressed()
    {
        if (state == State.CONTROLS) {
            state = State.OBJECTIVE;
            panelControls.SetActive(false);
            panelObjective.SetActive(true);
            panelObjective.GetComponent<Animator>().Play("PanelObjectiveEnter");
            buttonBackgroundBack.SetActive(true);
        } else if (state == State.OBJECTIVE) {
            state = State.UI;
            panelObjective.SetActive(false);
            panelUI.SetActive(true);
            panelUI.GetComponent<Animator>().Play("PanelUIEnter");
        } else if (state == State.UI) {
            state = State.HINT;
            panelUI.SetActive(false);
            panelHint.SetActive(true);
            panelHint.GetComponent<Animator>().Play("PanelHintEnter");
            buttonBackgroundExit.SetActive(true);
            buttonBackgroundNext.SetActive(false);
        }
    }

    public void onButtonBackPressed()
    {
        if (state == State.OBJECTIVE) {
            state = State.CONTROLS;
            panelObjective.SetActive(false);
            panelControls.SetActive(true);
            panelControls.GetComponent<Animator>().Play("PanelControlsEnter");
            buttonBackgroundBack.SetActive(false);
        } else if (state == State.UI) {
            state = State.OBJECTIVE;
            panelUI.SetActive(false);
            panelObjective.SetActive(true);
            panelObjective.GetComponent<Animator>().Play("PanelObjectiveEnter");
        } else if (state == State.HINT) {
            state = State.UI;
            panelHint.SetActive(false);
            panelUI.SetActive(true);
            panelUI.GetComponent<Animator>().Play("PanelUIEnter");
            buttonBackgroundNext.SetActive(true);
        }
    }

    public void PlayHowToPlayButtonAudio()
    {
        audioMan.PlayHowToPlayButtonAudio();
    }
}
