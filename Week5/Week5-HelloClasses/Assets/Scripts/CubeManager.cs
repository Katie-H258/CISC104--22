using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CubeManager : MonoBehaviour
{
    private Cube myCube;

    public Slider heightSlider;
    public Slider widthSlider;
    public Slider lengthSlider; 

    public GameObject heightTextObject;
    public GameObject widthTextObject;
    public GameObject lengthSliderTextObject;
    public GameObject edgeLengthTextObject;
    public GameObject volumeTextObject;

    private TextMeshProUGUI heightText { get; set; }
    private TextMeshProUGUI widthText { get; set; }
    private TextMeshProUGUI lengthSliderText { get; set; }
    private TextMeshProUGUI edgeLengthText { get; set; }
    private TextMeshProUGUI volumeText { get; set; }


    // Start is called before the first frame update
    void Start()
    {
        heightText = heightTextObject.GetComponent<TextMeshProUGUI>();
        widthText = widthTextObject.GetComponent<TextMeshProUGUI>();
        lengthSliderText = lengthSliderTextObject.GetComponent<TextMeshProUGUI>();
        edgeLengthText = edgeLengthTextObject.GetComponent<TextMeshProUGUI>();
        volumeText = volumeTextObject.GetComponent<TextMeshProUGUI>();

        // Calls basic constructor, but sets height, width, and length to 0
        myCube = new Cube();

        GetValuesFromSliders();
    }

    // Update is called once per frame
    void Update()
    {
        heightText.text = "Cuboid Height: " + myCube.GetHeight().ToString();
        widthText.text = "Cuboid Width: " + myCube.GetWidth().ToString();
        lengthSliderText.text = "Cuboid Length: " + myCube.GetLength().ToString();
        edgeLengthText.text = "Cuboid Edge Length: " + myCube.GetEdgeLength().ToString();
        volumeText.text = "Cuboid Volume: " + myCube.GetVolume().ToString(); 
    }

    public void SliderChanged(float newValue)
    {
        GetValuesFromSliders();
    }

    private void GetValuesFromSliders()
    {
        myCube.SetHeight(heightSlider.value);
        myCube.SetWidth(widthSlider.value);
        myCube.SetLength(lengthSlider.value);
    }
}
