using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    #region Singleton
    private static PlayerStats _instance;
    public static PlayerStats Instance
    {
        get
        {
            if (_instance == null)
                Debug.Log("PlayerStats did not load correctly");

            return _instance;
        }
    }
    #endregion

    #region Fields
    int _health;
    #endregion

    #region Properties
    public int Health { get => _health; set => _health = value; }
    #endregion

    #region Constructor
    public PlayerStats()
    {
        _health = 10;
    }
    #endregion

    #region Methods
    private void Awake()
    {
        _instance = this;
    }

    public int UpdateStats(int health)
    {
        _health = health;
        return _health;
    }
    #endregion
}
