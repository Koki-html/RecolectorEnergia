using UnityEngine;
using UnityEngine.InputSystem;

public class CamaraJugador : MonoBehaviour
{
	[SerializeField] private float sensibilidad = 100f;
	[SerializeField] private float limiteVertical = 85f;

	private float rotacionVertical;
	private float rotacionHorizontal;

	private void Awake()
	{
		Vector3 rotacionInicial = transform.localEulerAngles;
		rotacionVertical = NormalizarAngulo(rotacionInicial.x);
		rotacionHorizontal = NormalizarAngulo(rotacionInicial.y);
	}

	private void OnEnable()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	private void OnDisable()
	{
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
	}

	private void Update()
	{
		if (Cursor.lockState != CursorLockMode.Locked)
			return;

		if (Mouse.current == null)
			return;

		Vector2 movimientoMouse = Mouse.current.delta.ReadValue();
		rotacionHorizontal += movimientoMouse.x * sensibilidad * Time.deltaTime;
		rotacionVertical -= movimientoMouse.y * sensibilidad * Time.deltaTime;
		rotacionVertical = Mathf.Clamp(rotacionVertical, -limiteVertical, limiteVertical);

		transform.localRotation = Quaternion.Euler(rotacionVertical, rotacionHorizontal, 0f);
	}

	private float NormalizarAngulo(float angulo)
	{
		return angulo > 180f ? angulo - 360f : angulo;
	}
}
