using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 0.4f);   //�A�j���V�������폜����
    }
}
