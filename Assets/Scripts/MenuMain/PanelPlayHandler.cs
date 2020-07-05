using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelPlayHandler : MonoBehaviour
{
    /* Key */

    KeyManager keyMan;

    // Start is called before the first frame update
    void Start()
    {
        /* Key */

        keyMan = GameObject.Find("KeyManager").GetComponent<KeyManager>();
    }

    public void OnEventPanelPlayExit()
    {
        if (keyMan.GetHowToPlayShown() == false) {
            keyMan.SetLevelModeLast(LevelCollection.LEVEL_MODE_STAR);
            keyMan.SetLevelAlphabetLast(LevelCollection.LEVEL_ALPHABET_ALPHA);
            keyMan.SetLevelNumberLast(1);
            keyMan.SetSceneAfterHowToPlay(KeyManager.SceneAfterHowToPlay.LEVEL);
            SceneManager.LoadScene("HowToPlay");
        } else {
            keyMan.SetLevelModeLast(keyMan.GetLevelModeLast());
            keyMan.SetLevelAlphabetLast(keyMan.GetLevelAlphabetLast());
            keyMan.SetLevelNumberLast(keyMan.GetLevelNumberLast());
            SceneManager.LoadScene("Level");
        }
    }
}
