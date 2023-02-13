using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class settingsmenu : MonoBehaviour

{
    [SerializeField] Slider volumeSlider;
    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
    }
}
