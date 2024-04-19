using System.Collections;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Camera camera;
    [SerializeField] private UIComponent uiComponent;
    [SerializeField] private ProgramComponent programComponent;

    /// <summary>
    /// Метод старта мини-игры
    /// </summary>
    public void StartMiniGame()
    {
        uiComponent.questionMenu.SetActive(false);
        if (programComponent.objectForSpawn.gameObject.name == "VideoCard")
        {
            uiComponent.videoCardDes.SetActive(true);
        }
        else if(programComponent.objectForSpawn.gameObject.name == "Ram")
        {
            uiComponent.ramDes.SetActive(true);

        }
        else if (programComponent.objectForSpawn.gameObject.name == "Teapot")
        {
            uiComponent.teapotDes.SetActive(true);
        }
        else if (programComponent.objectForSpawn.gameObject.name == "Processor")
        {
            uiComponent.processorDes.SetActive(true);
        }
        Instantiate(programComponent.objectForSpawn, camera.transform.forward, Quaternion.identity);
    }
    /// <summary>
    /// Метод закрытия меню
    /// </summary>
    public void CloseDescription(GameObject menuForClose)
    {
        menuForClose.SetActive(false);
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

    /// <summary>
    /// Метод выбора объекта
    /// </summary>
    /// <param name="selectedObject">Объект для спавна</param>
    public void SelectObject(GameObject selectedObject)
    {
        if(uiComponent.questionMenu.gameObject.activeSelf == false && (uiComponent.videoCardDes.activeSelf == false && uiComponent.ramDes.activeSelf == false && uiComponent.teapotDes.activeSelf == false && uiComponent.processorDes.activeSelf == false))
        {
            programComponent.objectForSpawn = selectedObject.gameObject;
            StartCoroutine("QuestionTimerActive");
        }
        
    }

}
