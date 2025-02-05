using DG.Tweening;
using UnityEngine;
using TMPro;

public class TextEffect : MonoBehaviour
{
    public TextMeshProUGUI text;
    void Start()
    {
        text.DOFade(0.1f, 1f).SetLoops(-1, LoopType.Yoyo);
    }
}
