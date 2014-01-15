using UnityEngine;
using System.Collections;

public class MobileUI 
{

	#if UNITY_IPHONE || UNITY_ANDROID 
	private static TouchScreenKeyboard kb = null;

	public static string InputField (Rect rect     // standard positioning rectangle
    , string text     // the string to start with
	, string textDefault // the string to default	
    , int maxLength 	// 0 indicates infinite
    , TouchScreenKeyboardType keyboardType 
    , bool secure     // true will cause the keyboard to go in to password mode and the field to show only asterisks
    , bool autocorrect     // false will disable autocorrect, useful for fields where a user types in a name
	, bool multiline
	, GUIStyle style	
)     // returns the modified string
	{


    string displayText ;

	if(secure)
    {
        displayText = "";
        for(int i  = 0; i < text.Length; ++i) {displayText += "*";}
    }
    else
    {
		if(text==""){
			displayText = textDefault;	
		}else{
        	displayText = text;
    	}
	}
 	
    if(GUI.Button(rect, displayText, style))
    {
        if(text==textDefault){
			kb = TouchScreenKeyboard.Open("", keyboardType, autocorrect, multiline, secure, false, textDefault); 
		}else{
			kb = TouchScreenKeyboard.Open(text, keyboardType, autocorrect, multiline, secure, false, textDefault); 	
		}
    }
 
    if(kb!= null  && kb.done &&!kb.wasCanceled)
    {
        if(maxLength == 0 || text.Length <= maxLength)
        {
             text = kb.text;
        }
        else
        {
            text = kb.text.Substring(0, maxLength);
        }
    }
 
		
	
    return text;

	}

	public static string InputField (Rect rect
	, string text
	, string textDefault
	, int maxLength
	, bool secure     
    , bool autocorrect     
	, bool multiline)
	{
		GUIStyle style = new GUIStyle ("textfield");
		return InputField (rect, text, textDefault, maxLength, TouchScreenKeyboardType.Default, secure, autocorrect, multiline, style);
	}
	
	public static string InputField (Rect rect
	, string text
	, string textDefault
	, int maxLength
	, bool secure     
    , bool autocorrect)
	{
		return InputField (rect, text, textDefault, maxLength, secure, autocorrect, false);
	}

	public static string InputField (Rect rect
	, string text
	, string textDefault
	, int maxLength
	, bool secure)
	{
		return InputField (rect, text, textDefault, maxLength, secure, false);
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
		return InputField (rect, text, textDefault, maxLength, TouchScreenKeyboardType.Default, true, false, false, style);
	}

	public static string PWField (Rect rect
	, string text
	, string textDefault
	, int maxLength
	, bool autocorrect
	, GUIStyle style)
	{
		return InputField (rect, text, textDefault, maxLength, TouchScreenKeyboardType.Default, true, autocorrect, false, style);
	}

	//EMAILFIELD


	public static string EMailField (Rect rect
	, string text
	, string textDefault
	, int maxLength
    , bool autocorrect)
	{
		GUIStyle style = new GUIStyle ("textfield");
		return InputField (rect, text, textDefault, maxLength, TouchScreenKeyboardType.EmailAddress, false, autocorrect, false, style);
	}
	
	public static string EMailField (Rect rect
	, string text
	, string textDefault
	, int maxLength)
	{
		return EMailField (rect, text, textDefault, maxLength, false);
	}

	public static string EMailField (Rect rect
	, string text
	, string textDefault
	, int maxLength
	, GUIStyle style)
	{
		return InputField (rect, text, textDefault, maxLength, TouchScreenKeyboardType.EmailAddress, false, false, false, style);
	}

	public static string EMailField (Rect rect
	, string text
	, string textDefault
	, int maxLength
	, bool autocorrect
	, GUIStyle style)
	{
		return InputField (rect, text, textDefault, maxLength, TouchScreenKeyboardType.EmailAddress, false, autocorrect, false, style);
	}
	//NAMEFIELD
	

	public static string NameField (Rect rect
	, string text
	, string textDefault
	, int maxLength
    , bool autocorrect)
	{
		GUIStyle style = new GUIStyle ("textfield");
		return InputField (rect, text, textDefault, maxLength, TouchScreenKeyboardType.Default, false, autocorrect, false, style);
	}
		
	public static string NameField (Rect rect
	, string text
	, string textDefault
	, int maxLength)
	{
		return NameField (rect, text, textDefault, maxLength, false);
	}

	public static string NameField (Rect rect
	, string text
	, string textDefault
	, int maxLength
	, GUIStyle style)
	{
		return InputField (rect, text, textDefault, maxLength, TouchScreenKeyboardType.Default, false, false, false, style);
	}

	public static string NameField (Rect rect
	, string text
	, string textDefault
	, int maxLength
	, bool autocorrect
	, GUIStyle style)
	{
		return InputField (rect, text, textDefault, maxLength, TouchScreenKeyboardType.Default, false, autocorrect, false, style);
	}
#endif	
}
