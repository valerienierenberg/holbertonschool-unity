using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public GameObject invertYToggle;
    public bool isInverted;
    public AudioMixer BGM;
    public AudioMixer SFX;
    public Slider BGMSlider;
    public Slider SFXSlider;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("isInvertedY") == 1)
        {
            invertYToggle.GetComponent<UnityEngine.UI.Toggle>().isOn = true;
            isInverted = true;
        }
        else
        {
            invertYToggle.GetComponent<UnityEngine.UI.Toggle>().isOn = false;
            isInverted = false;
        }
        BGMSlider.value = PlayerPrefs.GetFloat("BGMVol", 0.75f);
        SFXSlider.value = PlayerPrefs.GetFloat("SFXVol", 0.75f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Back()
    {
        int previous = PlayerPrefs.GetInt("Scene");
        SceneManager.LoadScene(previous);
    }

    public void Apply()
    {
        if (isInverted == true)
        {
            PlayerPrefs.SetInt("isInvertedY", 1);
        }
        else
        {
            PlayerPrefs.SetInt("isInvertedY", 0);
        }
    }

    public void ToggleInvert()
    {
        isInverted = !isInverted;
    }

    public void SetBGMToggle(float sliderValue)
    {
        BGM.SetFloat("BGMVol", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("BGMVol", sliderValue);
    }

    public void SetSFXToggle(float sliderValue)
    {
        SFX.SetFloat("SFXVol", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("SFXVol", sliderValue);
    }
}
