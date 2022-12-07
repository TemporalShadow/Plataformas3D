using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class PowerUpTimer : MonoBehaviour
{

	public float totalTime;

	private float remainingTime;
	private Image image;

	// Use this for initialization
	void Start ()
	{
		image = GetComponent<Image>();
	}

	void OnEnable()
	{
		// Al activarlo reseteamos el tiempo total que dura el powerup
		remainingTime = totalTime;
	}

	// Update is called once per frame
	void Update () {
		// Comprobamos si se ha acabado el tiempo
		if (remainingTime <= 0)
		{
			// Desactivamos el gameobject para que no se pinte
			gameObject.SetActive(false);
		}
		else
		{
			// Si no calculamos cuánto powerup hay que pintar
			float portion = Mathf.InverseLerp(0, totalTime, remainingTime);
			// Y se lo ponemos en el fillAmount de la imagen
			image.fillAmount = portion;

			// Restamos al tiempo restante el tiempo que ha pasado
			remainingTime -= Time.deltaTime;
		}
	}
}
