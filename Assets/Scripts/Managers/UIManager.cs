using System.Collections;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private UIComponent uiComponent;
    [SerializeField] private ProgramComponent programComponent;

    /// <summary>
    /// Метод выбора объекта
    /// </summary>
    /// <param name="selectedObject">Объект для спавна</param>
    public void SelectObject(GameObject selectedObject)
    {
        programComponent.objectForSpawn = selectedObject;
        StartCoroutine("QuestionTimerActive");
    }

    /// <summary>
    /// Метод старта мини-игры
    /// </summary>
    public void StartMiniGame()
    {
        uiComponent.questionMenu.SetActive(false);
        uiComponent.gameMenu.SetActive(true);
    }

    /// <summary>
    /// Курутина для появления вопроса
    /// </summary>
    /// <returns></returns>
    IEnumerator QuestionTimerActive()
    {
        uiComponent.questionMenu.SetActive(true);
        yield return new WaitForSeconds(4);
        uiComponent.questionMenu.SetActive(false);
    }
}
