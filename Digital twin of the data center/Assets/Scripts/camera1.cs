using UnityEngine;

public class EditorCamera : MonoBehaviour
{
    public float moveSpeed = 10.0f; // Скорость перемещения
    public float rotationSpeed = 100.0f; // Скорость вращения
    public float zoomSpeed = 10.0f; // Скорость зума
    public float minZoom = 5.0f; // Минимальная дистанция
    public float maxZoom = 50.0f; // Максимальная дистанция
    public float verticalMoveSpeed = 10.0f; // Скорость вертикального перемещения

    private float currentZoom = 20.0f; // Текущая дистанция
    private float yaw = 0.0f; // Угол поворота по горизонтали
    private float pitch = 0.0f; // Угол поворота по вертикали

    void Update()
    {
        // Перемещение камеры с помощью клавиш WASD
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0, vertical);
        transform.Translate(direction * moveSpeed * Time.deltaTime, Space.Self);

        // Вращение камеры с помощью правой кнопки мыши
        if (Input.GetMouseButton(1)) // Правая кнопка мыши
        {
            yaw += Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
            pitch -= Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;
            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }

        // Зум с помощью колесика мыши
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        currentZoom -= scroll * zoomSpeed;
        currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);
        Camera.main.fieldOfView = currentZoom;

        // Вертикальное перемещение при нажатии на левую кнопку мыши
        if (Input.GetMouseButton(0)) // Левая кнопка мыши
        {
            float verticalMove = Input.GetAxis("Mouse Y");
            transform.Translate(Vector3.up * verticalMove * verticalMoveSpeed * Time.deltaTime, Space.World);
        }
    }
}