using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderClass : MonoBehaviour
{
    public Slider rotateSlider;
    public Slider VerRotateSlider;
    public Slider scaleSlider;

    public GameObject house1;
    public GameObject house2;
    public GameObject house3;
    public GameObject house4;
    public GameObject house5;
    public GameObject house6;



    private float previousValue;

    void Awake()
    {
        // Assign a callback for when this slider changes
        rotateSlider.onValueChanged.AddListener(this.OnSliderChanged);
        VerRotateSlider.onValueChanged.AddListener(this.OnSliderChangedVer);
        scaleSlider.onValueChanged.AddListener(this.OnSliderChangedScale);

        // And current value
        this.previousValue = rotateSlider.value;
    }

    void OnSliderChangedScale(float value)
    {
        house1.transform.localScale = new Vector3(value, value, value);
        house2.transform.localScale = new Vector3(value, value, value);
        house3.transform.localScale = new Vector3(value, value, value);
        house4.transform.localScale = new Vector3(value, value, value);
        house5.transform.localScale = new Vector3(value, value, value);
        house6.transform.localScale = new Vector3(value, value, value);
    }
    void OnSliderChanged(float value)
    {
        // How much we've changed
        float delta = value - this.previousValue;
        house1.transform.Rotate(Vector3.forward * delta * 180);
        house2.transform.Rotate(Vector3.forward * delta * 180);
        house3.transform.Rotate(Vector3.forward * delta * 180);
        house4.transform.Rotate(Vector3.forward * delta * 180);
        house5.transform.Rotate(Vector3.forward * delta * 180);
        house6.transform.Rotate(Vector3.forward * delta * 180);

        // Set our previous value for the next change
        this.previousValue = value;
    }

    void OnSliderChangedVer(float value)
    {
        // How much we've changed
        float delta = value - this.previousValue;
        house1.transform.Rotate(Vector3.left * delta * 180);
        house2.transform.Rotate(Vector3.left * delta * 180);
        house3.transform.Rotate(Vector3.left * delta * 180);
        house4.transform.Rotate(Vector3.left * delta * 180);
        house5.transform.Rotate(Vector3.left * delta * 180);
        house6.transform.Rotate(Vector3.left * delta * 180);

        // Set our previous value for the next change
        this.previousValue = value;
    }



}
