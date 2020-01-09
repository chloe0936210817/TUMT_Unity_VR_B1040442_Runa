using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool haveKey;

    public void ThrowPickUp()
    {
        print("檢起物件");
    }

    public void ThrowDetach(GameObject obj)
    {
        print("放起物件");
        haveKey = true;
        Destroy(obj);
    }

    public void ThrowHeld()
    {
        print("拿起物件");
    }
}
