using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GameData
{
    // fields to save to Jason
    public string name;
    public Vector3 position;
}
public class JasonManager : MonoBehaviour
{
    [SerializeField]
    CharacterController cr;

    GameData gd;
    void Start()
    {
        gd = new GameData();
        gd.name = "Player";
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gd.position = cr.transform.position;

        string gd_Jason = JsonUtility.ToJson(gd);

        Debug.Log(gd_Jason);
    }
}
