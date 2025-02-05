using System;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour
{
    public Button button;
    
    void Start()
    {
        ScaleTween();// Start버튼 애니메이션 실행
        button.onClick.AddListener(ChangeScene);
    }

    private void ScaleTween()
    {
        //0.5초 마다 커졌다 작아졌다를 반복하는 애니메이션 구현
        transform.DOScale(new Vector3(1.5f, 1.5f, 0f), 0.5f).SetRelative(true).SetLoops(-1, LoopType.Yoyo);
    }
    
    void ChangeScene()
    {
        DOVirtual.DelayedCall(2f, () => SceneManager.LoadScene("LoadingScene")); //2초뒤 씬전환
    }

    void OnDestroy()
    {
        transform.DOKill(); // DOTween 애니메이션 강제 종료
    }
}