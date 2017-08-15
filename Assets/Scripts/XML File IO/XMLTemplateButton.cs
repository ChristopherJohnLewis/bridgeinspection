using System.Xml.Linq;

using UnityEngine;
using UnityEngine.UI;

public class XMLTemplateButton : MonoBehaviour {

    public string SettingsXMLName = "Test.xml";
    public string TemplateXMLName = "Template.xml";

    //Used just for a listener
    void Start() {
        gameObject.GetComponent<Button>().onClick.AddListener(delegate { ChangeToTemplate(); });
    }

    //ChangeToTemplate
    //
    //use: Resets the xml file that holds the game's settings with the default version
    //args:
    //ret:

    void ChangeToTemplate() {
        XElement ReadIn = XElement.Load(TemplateXMLName);
        ReadIn.Save(SettingsXMLName);
    }

}
