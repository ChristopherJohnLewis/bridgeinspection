using System;
using System.Xml.Linq;

using UnityEngine;
using UnityEngine.UI;


public class XMLSlider : MonoBehaviour {

    public Slider slider;

    public string SettingsXMLName = "Test.xml";
    public string DefaultXMLName = "Template.xml";


    //Start
    //
    //use: sets the toggle's value to the value specified in the settings xml file
    //args:
    //ret:

    void Start () {
        XElement InitialVal = XElement.Load(SettingsXMLName);
        var InitialElement = InitialVal.Element(slider.name);

        slider.value = Convert.ToInt32(InitialElement.Value);
        slider.onValueChanged.AddListener(delegate { Changed(); });
	}

    //Changed
    //
    //use: loads in the settings xml and sets the element's (with the same name as the toggle) value that the toggle was just changed to and then saves it back into the settings xml
    //args
    //ret

    void Changed() {
        XElement ReadIn = XElement.Load(SettingsXMLName);
        var sliderElement = ReadIn.Element(slider.name);

        sliderElement.SetValue(slider.value);
        ReadIn.Save(SettingsXMLName);
    }

    //TemplateReset
    //
    //use: sets the value of the toggle to the value in the default xml
    //args
    //ret

    void TemplateReset() {
        XElement InitialVal = XElement.Load(DefaultXMLName);
        var InitialElement = InitialVal.Element(slider.name);

        slider.value = Convert.ToInt32(InitialElement.Value);
    }

}
