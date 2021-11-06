using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    string _name = "Kocko";

    int _hp;

    public Player()
    {
        _hp = PlayerStats.Instance.Health;
    }
    private void OnTriggerEnter(Collider other)
    {
        _hp -= PlayerStats.Instance.UpdateStats(3);
    }
}
