using UnityEngine;
using System.Collections;

public class RestartGame : MonoBehaviour {
    public Texture gameOverTexture;
    void OnGUI()
    {
        
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), gameOverTexture);
        if (GUI.Button(new Rect(Screen.width / 2 - 60, Screen.height / 2 + 30, 150, 25), "Play Again!"))
        {
            Application.LoadLevel("gameScene");
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 60, Screen.height / 2 + 70, 150, 25), "Quit!"))
        {
            Application.Quit();
        }
    }
}
