
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	 bool gameHasEnded = false;

	public void EndGame()
	{
		if (gameHasEnded == false)
		{
			gameHasEnded = true;
			Debug.Log("Game OVER");
			
			//restart  game
			RestartGame();
		}

		
	}

	void RestartGame()
	{
		SceneManager.LoadScene("Level01");
	}



}
