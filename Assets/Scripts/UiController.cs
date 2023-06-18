using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class UiController : MonoBehaviour
{
    public UnityEngine.UI.Slider _musicSlider, _sfxSlider;

    public void ActivateMenu(GameObject gameObject)

    {

        if (gameObject.activeSelf)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }

    }
    public void ToggleMusic()
        {
        AudioManager.instance.ToggleMusic();
        }

  
    public void ToggleSFX()
    {
        AudioManager.instance.ToggleSFX();
    }

    public void MusicVolume(float volume)
    {
        AudioManager.instance.MusicVolume(_musicSlider.value);
    }
    public void SFXVolume(float volume)
    {

        AudioManager.instance.SFXVolume(_sfxSlider.value);

    }


}
