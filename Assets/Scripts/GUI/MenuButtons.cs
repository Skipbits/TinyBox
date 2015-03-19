using UnityEngine;
using System.Collections;

public class MenuButtons : MonoBehaviour {

	public void GoToMainMenu()
	{
		Application.LoadLevel ("MainMenu");
	}

	public void GoToLevelMenu()
	{
		Application.LoadLevel("LevelMenu");
	}

	public void RetryLevel()
	{
        GameManager.Instance.ChangeLevel(int.Parse(Application.loadedLevelName.Substring(5)));
	}

    public void NextLevel()
    {
        GameManager.Instance.ChangeLevel(int.Parse(Application.loadedLevelName.Substring(5))+1);
    }

	public void QuitGame()
	{
		Debug.Log ("This is Exit button");
		Application.Quit ();
	}

}
