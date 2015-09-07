using UnityEngine;
using System.Xml;
using System.Text;
using System.IO;

public class Conversation : MonoBehaviour {
	public TextAsset conversationXmlFile;
	public XmlDocument conversationXml;
	public UnityEngine.UI.Text npcText;
	public UnityEngine.UI.Text playerChoices;

	// Initialization
	void Start()
	{
		conversationXml = new XmlDocument ();
		conversationXml.LoadXml (conversationXmlFile.text);
	}
}
