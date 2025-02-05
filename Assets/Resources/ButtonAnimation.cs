using UnityEngine;
using UnityEngine.UI;
using DG.Tweening; 

public class ButtonAnimation : MonoBehaviour
{
    public Button button;

    void Start()
    {
        button.onClick.AddListener(ScaleTween);
    }

    void ScaleTween()
    {
        //0.5초 마다 커졌다 작아졌다를 반복하는 애니메이션 구현
        Tween scaleTween = transform.DOScale(new Vector3(1f, 1f, 0f), 0.5f).SetRelative(true).SetLoops(-1, LoopType.Yoyo);
        //4초 뒤에 애니메이션이 멈추는 기능
        DOVirtual.DelayedCall(4f, () => scaleTween.Kill());
    }
}