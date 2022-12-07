using UnityEngine;

public class GUIManager : MonoBehaviour
{
	public PowerUpTimer PowerUpTimer;

	public void StartPowerUpTimer(float time)
	{
		PowerUpTimer.totalTime = time;
		PowerUpTimer.gameObject.SetActive(true);
	}

}
