using UnityEngine;
using System.Collections;

public class PcUI 
{

	public static string InputField (Rect rect     // standard positioning rectangle
    , string text     // the string to start with
	, string textDefault // the string to default	
    , int maxLength 	// 0 indicates infinite
    , bool secure     // true will cause the keyboard to go in to password mode and the field to show only asterisks
	, GUIStyle style	
)     // returns the modified string
	{

		GUI.SetNextControlName ("text");
		if (UnityEngine.Event.current.type == EventType.Repaint) {
			if (GUI.GetNameOfFocusedControl () == "text") {
				if (text == textDefault) {
					text = "";
				} 
			} else if (text == "") {
				text = textDefault;
			}
			
		}
				
		if (secure) {
			if (maxLength > 0) {
				return GUI.PasswordField (rect, text, "*" [0], maxLength,style);
			} else {
				return GUI.PasswordField (rect, text, "*" [0],style);
			}
		} else {
			if (maxLength > 0) {
				return GUI.TextField (rect, text, maxLength,style);
			} else {
				return GUI.TextField (rect, text,style);
			}
		}
	}

	public static string InputField (Rect rect
	, string text
	, string textDefault
	, int maxLength
	, bool secure     
	)
	{
		GUIStyle style = new GUIStyle ("textfield");
		return InputField (rect, text, textDefault, maxLength, secure, style);
	}
		
	//PWFIELD
	public static string PWField (Rect rect
	, string text
	, string textDefault
	, int maxLength)
	{
		return InputField (rect, text, textDefault, maxLength, true);
	}

	public static string PWField (Rect rect
	, string text
	, string textDefault
	, int maxLength
	, GUIStyle style)
	{
		return InputField (rect, text, textDefault, maxLength, true, style);
	}


	//EMAILFIELD


	public static string EMailField (Rect rect
	, string text
	, string textDefault
	, int maxLength
    )
	{
		GUIStyle style = new GUIStyle ("textfield");
		return InputField (rect, text, textDefault, maxLength, false, style);
	}
	


	public static string EMailField (Rect rect
	, string text
	, string textDefault
	, int maxLength
	, GUIStyle style)
	{
		return InputField (rect, text, textDefault, maxLength, false, style);
	}


	//NAMEFIELD
	

	public static string NameField (Rect rect
	, string text
	, string textDefault
	, int maxLength
	)
	{
		GUIStyle style = new GUIStyle ("textfield");
		return InputField (rect, text, textDefault, maxLength, false, style);
	}
		


	public static string NameField (Rect rect
	, string text
	, string textDefault
	, int maxLength
	, GUIStyle style)
	{
		return InputField (rect, text, textDefault, maxLength,  false, style);
	}

}
