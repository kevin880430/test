using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBlink : MonoBehaviour
{
    public float speed = 1.0f;                                                      //�_�Ŏ���
    private SpriteRenderer Arrow;                                                   //SpriteRenderer���i�[����
    private float time;                                                             //���Ԏ���
    void Start()
    {
        Arrow = this.gameObject.GetComponent<SpriteRenderer>();                     //�I�u�W�F�N�g���擾����
    }


    void Update()
    {
        Arrow.color = GetAlphaColor(Arrow.color);                                   //Spriterenderer�̐F�ύX���\�b�h���Ă�
    }

    Color GetAlphaColor(Color color)
    {
        time += Time.deltaTime * 5.0f * speed;                                      //���Ԃ𑫂�
        color.a = Mathf.Sin(time);                                                  //Sin�֐��̎����ɂ��F��ύX����

        return color;                                                               //�F����ԋp
    }
}
