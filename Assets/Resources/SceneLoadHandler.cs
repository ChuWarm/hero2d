using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadHandler : MonoBehaviour
{
    public CanvasGroup fadePanel;
    void Awake()
    {
        //씬이 변경될때 실행
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode) // 페이드 인,아웃 효과
    {
        fadePanel.alpha = 1;
        fadePanel.DOFade(0, 5f).SetEase(Ease.InOutQuad); // 처음엔 느리고 점점빨라짐
    }
    void OnDestroy()
    {
        // 씬이 변경될 때 메모리 누수를 방지하기 위해 이벤트 해제
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
