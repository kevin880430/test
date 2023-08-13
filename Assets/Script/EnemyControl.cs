using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public GameObject CrashAnimation;                                                       //�ׂ����A�j���[�V�������i�[����
    public bool isPlayerMega = PlayerControl.isMega;                                        //PlayerControl����isMega�̔�����擾����
  
    void Update()
    {
        isPlayerMega = PlayerControl.isMega;                                                //isMega�̔����Ɋm�F����
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("SquarePlayer")&&isPlayerMega)                  //�ő剻���鐳���`�̃v���C���[�ƐڐG����ƒׂ����
        {
           Instantiate(CrashAnimation, transform.position, transform.rotation);             //�A�j���[�V�����𐶐�
            Destroy(this.gameObject);                                                       //�������폜����
        }
    }
}
