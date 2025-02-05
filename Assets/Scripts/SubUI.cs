using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubUI : MonoBehaviour
{
    public GameObject subUI;
    
    public void Continuing()
    {
        // 계속하기 기능
        subUI.SetActive(false);
    }

    private void ReStart()
    {
        // 캐릭터 능력치 장비 등등 저장하고 현재 씬 다시 실행 기능들은 게임 매니저에 구현해도 될듯
    }
    public void Toexit()
    {
        // 게임 종료
        Application.Quit();
    }
    public void Esc()
    {
        // ESC키 눌렀을때 메뉴 창 띄우기 지우기
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(subUI.activeSelf) 
                subUI.SetActive(false);
            else
                subUI.SetActive(true);
        }
    }
    void Update()
    {
        Esc();
    }
}
