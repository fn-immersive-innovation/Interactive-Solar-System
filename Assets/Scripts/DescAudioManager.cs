using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DescAudioManager : MonoBehaviour
{
    [SerializeField]
    AudioSource[] allAudio;

    bool audioOff = false;

    [SerializeField] TMP_Text audioStatus;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StopAllAudio()
    {
        for(int i = 0; i < allAudio.Length; i++)
        {
            allAudio[i].Stop();
        }
    }

    public void PlaySolarAudio(SolarIndex solarIndex)
    {
        for (int i = 0; i < allAudio.Length; i++)
        {
            allAudio[i].Stop();
            allAudio[solarIndex.indexNumber].Play();
            audioOff = false;
            audioStatus.SetText("Pause Audio");
        }
    }

    public void ToggleAudio()
    {
        if(!audioOff)
        {
            allAudio[DescriptionController.currentAudioIndex].Pause();
            audioOff = true;
            audioStatus.SetText("Play Audio");
        }
        else
        {
            allAudio[DescriptionController.currentAudioIndex].Play();
            audioOff = false;
            audioStatus.SetText("Pause Audio");
        }

    }
}
