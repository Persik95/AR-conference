using System.Collections;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private UIComponent uiComponent;
    [SerializeField] private ProgramComponent programComponent;

    /// <summary>
    /// ����� ������ �������
    /// </summary>
    /// <param name="selectedObject">������ ��� ������</param>
    public void SelectObject(GameObject selectedObject)
    {
        programComponent.objectForSpawn = selectedObject;
        StartCoroutine("QuestionTimerActive");
    }

    /// <summary>
    /// ����� ������ ����-����
    /// </summary>
    public void StartMiniGame()
    {
        uiComponent.questionMenu.SetActive(false);
        uiComponent.gameMenu.SetActive(true);
    }

    /// <summary>
    /// �������� ��� ��������� �������
    /// </summary>
    /// <returns></returns>
    IEnumerator QuestionTimerActive()
    {
        uiComponent.questionMenu.SetActive(true);
        yield return new WaitForSeconds(4);
        uiComponent.questionMenu.SetActive(false);
    }
}
