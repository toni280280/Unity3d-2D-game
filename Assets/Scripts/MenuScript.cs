using UnityEngine;


public class MenuScript : MonoBehaviour {

    void OnGUI()
    {
        const int buttonWidth = 84;
        const int buttonHeight = 60;

        
        Rect buttonRect = new Rect(
              Screen.width / 2 - (buttonWidth / 2),
              (2 * Screen.height / 3) - (buttonHeight / 2),
              buttonWidth,
              buttonHeight
            );

        
        if (GUI.Button(buttonRect, "Start!"))
        {
            
            Application.LoadLevel("gameScene");
        }
    }
}
