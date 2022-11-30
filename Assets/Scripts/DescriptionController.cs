using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class DescriptionController : XRSimpleInteractable
{
    [TextArea]
    public string descText;

    public string solarTitle;

    public TMP_Text descTextArea;
    public TMP_Text solarTitleText;

    [SerializeField]
    private DescAudioManager solarAudio;

    AudioSource descAudio;
    SolarIndex solarIndex;

    public static int currentAudioIndex;

    private void Start()
    {
        descAudio = GetComponent<AudioSource>();
        solarIndex = GetComponent<SolarIndex>();

        solarTitle = gameObject.name;
    }

    /*protected override void OnHoverEntered(HoverEnterEventArgs args)
    {
        base.OnHoverEntered(args);
        OnTextDisplayed();
        OnAudioPlay();
        DisplayTitle();
    }*/

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        OnTextDisplayed();
        OnAudioPlay();
        DisplayTitle();
    }

    /*protected override void OnActivated(ActivateEventArgs args)
    {
        base.OnActivated(args);
        OnTextDisplayed();
        OnAudioPlay();
        DisplayTitle();
    }*/

    private void OnTextDisplayed()
    {
        descTextArea.text = descText;
    }

    void DisplayTitle()
    {
        solarTitleText.text = solarTitle;
    }

    void OnAudioPlay()
    {
        solarAudio.PlaySolarAudio(solarIndex);
        currentAudioIndex = solarIndex.indexNumber;
        Debug.Log("Index Number = " + solarIndex.indexNumber);
    }
}
