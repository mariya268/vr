/*using UnityEngine;

public class ARController : MonoBehaviour
{
    [SerializeField] private Animator solderingStationAnimator; // Ссылка на Animator модели
    [SerializeField] private string animationTriggerName = "StartAnimation"; // Имя триггера анимации

    private void Update()
    {
        // Проверяем нажатие левой кнопки мыши
        if (Input.GetMouseButtonDown(0))
        {
            PlaySolderingStationAnimation();
        }
    }

    private void PlaySolderingStationAnimation()
    {
        // Проверяем, что аниматор присвоен
        if (solderingStationAnimator != null)
        {
            // Активируем триггер для запуска анимации
            solderingStationAnimator.SetTrigger(animationTriggerName);
        }
        else
        {
            Debug.LogWarning("Animator для паяльной станции не присвоен!");
        }
    }
}*/