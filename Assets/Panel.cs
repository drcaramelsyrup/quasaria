using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Xml;

public class Panel : MonoBehaviour {
	
	public Conversation currentConvo; 
	UnityEngine.UI.Text panelText;
	public XmlNode currentNode;
	public ArrayList playerChoices;
	
	// Use this for initialization
	void Start () {
		panelText = GetComponentInChildren<UnityEngine.UI.Text>();
		if (currentConvo) {
			currentNode = currentConvo.conversationXml.GetElementsByTagName("ContentNode")[0];
		}
	}
	
	// Update is called once per frame
	void Update () {
		GetText ();
	}

	void GetText() {
		foreach (XmlNode node in currentNode.ChildNodes) {
			if (node.Name == "conversationText" && node.Attributes.Count > 0 && node.Attributes["nodeType"].Value == "npc") {
				panelText.text = node.InnerText;
			}
			if (node.Name == "subnodes") {
				foreach (XmlNode childNode in node.ChildNodes) {
					if (childNode.Name == "ContentNode" && childNode.Attributes["nodeType"].Value == "pc") {
						playerChoices.Add (childNode);
					}
				}
			}
		}
	}
}

