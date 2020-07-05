using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    static AudioManager instance = null;

    public static AudioManager Instance
    {
        get { return instance; }
    }

    KeyManager keyMan;

    AudioSource audioSrc;

    public AudioClip panelPlayEnterAudio;

    public AudioClip audioStartPressedAudio;

    public AudioClip boundEnterAudio;
    public AudioClip boundExitAudio;

    public AudioClip levelStartAudio;

    public AudioClip rlEnterAudio;
    public AudioClip rlExitAudio;
    
    public AudioClip buttonAudio;
    public AudioClip buttonAudio1;

    public AudioClip howToPlayButtonAudio;

    public AudioClip moveStartToEndAudio;
    public AudioClip movePreEndToEndAudio;

    public AudioClip hintOnEnterAudio;
    public AudioClip hintOnExitAudio;
    
    public AudioClip winAudio;

    public AudioClip star0Audio;
    public AudioClip star1Audio;
    public AudioClip star2Audio;

    public AudioClip newRecordAudio;

    public AudioClip rewardAudio;

    bool enable;

    void Awake()
    {
        /* Ensure that there is only a single instance of AudioManager for the
           entire game */
        
        if (instance != null & instance != this) {
            Destroy(this);
            return;
        }

        instance = this;
        DontDestroyOnLoad(this);
    }

    /* Start is called before the first frame update */

    void Start()
    {
        keyMan = GameObject.Find("KeyManager").GetComponent<KeyManager>();

        audioSrc = GetComponent<AudioSource>();

        enable = keyMan.GetAudio() == KeyManager.Audio.ON ? true : false;
    }

    /* Play Audio */

    public void PlayPanelPlayEnterAudio()
    {
        if (enable == true)
            audioSrc.PlayOneShot(panelPlayEnterAudio);
    }

    public void PlayAudioStartPressedAudio()
    {
        if (enable == true)
            audioSrc.PlayOneShot(audioStartPressedAudio);
    }

    public void PlayBoundEnterAudio()
    {
        if (enable == true)
            audioSrc.PlayOneShot(boundEnterAudio);
    }

    public void PlayBoundExitAudio()
    {
        if (enable == true)
            audioSrc.PlayOneShot(boundExitAudio);
    }

    public void PlayLevelStartAudio()
    {
        if (enable == true)
            audioSrc.PlayOneShot(levelStartAudio);
    }

    public void PlayRLEnterAudio()
    {
        if (enable == true)
            audioSrc.PlayOneShot(rlEnterAudio);
    }

    public void PlayRLExitAudio()
    {
        if (enable == true)
            audioSrc.PlayOneShot(rlExitAudio);
    }

    public void PlayButtonAudio()
    {
        if (enable == true)
            audioSrc.PlayOneShot(buttonAudio);
    }

    public void PlayButtonAudio1()
    {
        if (enable == true)
            audioSrc.PlayOneShot(buttonAudio1);
    }

    public void PlayHowToPlayButtonAudio()
    {
        if (enable == true)
            audioSrc.PlayOneShot(howToPlayButtonAudio);
    }

    public void PlayMoveStartToEndAudio()
    {
        if (enable == true)
            audioSrc.PlayOneShot(moveStartToEndAudio);
    }

    public void PlayMovePreEndToEndAudio()
    {
        if (enable == true)
            audioSrc.PlayOneShot(movePreEndToEndAudio);
    }

    public void PlayHintOnEnterAudio()
    {
        if (enable == true)
            audioSrc.PlayOneShot(hintOnEnterAudio);
    }

    public void PlayHintOnExitAudio()
    {
        if (enable == true)
            audioSrc.PlayOneShot(hintOnExitAudio);
    }

    public void PlayWinAudio()
    {
        if (enable == true)
            audioSrc.PlayOneShot(winAudio);
    }

    public void PlayStarAudio(int index)
    {
        if (enable == true) {
            if (index == 0)
                audioSrc.PlayOneShot(star0Audio);
            else if (index == 1)
                audioSrc.PlayOneShot(star1Audio);
            else if (index == 2)
                audioSrc.PlayOneShot(star2Audio);
        }
    }

    public void PlayNewRecordAudio()
    {
        if (enable == true)
            audioSrc.PlayOneShot(newRecordAudio);
    }

    public void PlayRewardAudio()
    {
        if (enable == true)
            audioSrc.PlayOneShot(rewardAudio);
    }

    /* Check if playing */

    public bool IsPlaying()
    {
        return audioSrc.isPlaying;
    }

    /* Pause Audio Button */

    public void OnButtonAudioPressed()
    {
        if (enable) {
            keyMan.SetAudio(KeyManager.Audio.OFF);
            enable = false;
        } else {
            keyMan.SetAudio(KeyManager.Audio.ON);
            enable = true;
            PlayButtonAudio();
        }
    }
}
