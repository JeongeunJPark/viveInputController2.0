using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class viveInput : MonoBehaviour
{
    //활성화 할 액션 셋
    public SteamVR_ActionSet _default;

    //터치패드 눌림
    public SteamVR_Action_Boolean teleportPushed = null;
    
    //터치패드 터치 위치
    public SteamVR_Action_Vector2 touchpadPosition = null;

    private void Awake()
    {
       //텔레포트(트랙패드 누름) 와 터치(트랙패드 터치)를 연동
        teleportPushed = SteamVR_Actions._default.Teleport;
        touchpadPosition = SteamVR_Actions._default.touchpadTouch;
       
    }

    private void Start()
    {
        //디폴트 액션 세트를 액티베이트
        _default.Activate(SteamVR_Input_Sources.Any, 0, true);

    }


    // Update is called once per frame
    void Update()
    {
        //만약 트랙패드를 누르면
        if (teleportPushed.stateDown)
        {
            //오브젝트 상호작용
        }
    }
}
