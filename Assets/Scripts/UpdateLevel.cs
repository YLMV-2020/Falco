using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateLevel : MonoBehaviour
{
    public LeaveZone begin;
    public LeaveZone end;

    public static UpdateLevel sharedInstance;

    private void Awake()
    {
        sharedInstance = this;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            end.m_box.isTrigger = true;
            end.walk.SetActive(false);
        }
    }
}
