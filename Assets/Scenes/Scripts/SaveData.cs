using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    [Serializable]
    public class PlayerInfo
    {
        public string pseudo = "Sora";
        public PlayerStats stats;
    }

    [Serializable]
    public class PlayerStats
    {

    }

}
