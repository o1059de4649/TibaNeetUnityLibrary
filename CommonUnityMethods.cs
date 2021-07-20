using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class CommonUnityMethods : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// 一番上のトランスフォーム取得
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static Transform GetSuperParentTransform(Transform obj) {
        var res = obj;
        while (res.parent != null) {
            res = res.parent;
        }
        return res;
    }
}
