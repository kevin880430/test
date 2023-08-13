using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blinker : MonoBehaviour
{
    public float speed = 1.0f;                                                      //�_�ł̑���  
    private Text text;                                                              //�e�L�X�g�I�u�W�F�N�g��錾
    private float time;                                                             //���Ԏ���
    void Start()
    {
        text = this.gameObject.GetComponent<Text>();                                //�e�L�X�g�I�u�W�F�N�g���擾
    }

    
    void Update()
    {
        text.color = GetAlphaColor(text.color);                                     //�e�L�X�g�̐F��ύX���\�b�h���Ă�
    }

    Color GetAlphaColor(Color color)                                                //�F�ύX���\�b�h
    {
        time += Time.deltaTime * 5.0f * speed;                                      //���ԗ���̃X�s�[�h
        color.a = Mathf.Sin(time);                                                  //Sin�֐��ŐF��ύX����

        return color;                                                               //�F����ԋp
    }
}