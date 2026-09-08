using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class MovimientoJugador : MonoBehaviour
{
    public float velocidad = 5f;

    [SerializeField] private float gravedad = -9.81f;
    [SerializeField] private float fuerzaSalto = 5f;

    private CharacterController controlador;
    private float velocidadVertical;

    private void Awake()
    {
        controlador = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector3 entrada = Vector3.zero;
        Keyboard teclado = Keyboard.current;

        if (teclado != null)
        {
            if (teclado.wKey.isPressed)
                entrada.z += 1f;
            if (teclado.sKey.isPressed)
                entrada.z -= 1f;
            if (teclado.aKey.isPressed)
                entrada.x -= 1f;
            if (teclado.dKey.isPressed)
                entrada.x += 1f;
        }

        entrada = Vector3.ClampMagnitude(entrada, 1f);

        Transform camara = Camera.main != null ? Camera.main.transform : transform;
        Vector3 adelante = camara.forward;
        adelante.y = 0f;
        adelante.Normalize();

        Vector3 derecha = camara.right;
        derecha.y = 0f;
        derecha.Normalize();

        Vector3 movimiento = (derecha * entrada.x + adelante * entrada.z) * velocidad;

        if (controlador.isGrounded)
        {
            if (velocidadVertical < 0f)
                velocidadVertical = -2f;

            if (teclado != null && teclado.spaceKey.wasPressedThisFrame)
                velocidadVertical = fuerzaSalto;
        }

        velocidadVertical += gravedad * Time.deltaTime;
        movimiento.y = velocidadVertical;

        controlador.Move(movimiento * Time.deltaTime);
    }
}