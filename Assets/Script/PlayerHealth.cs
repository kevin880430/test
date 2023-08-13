using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;                                                           //�v���C���[�ő�hp
    public int currentHealth;                                                           //�v���C���[����hp
    public Image hpBar;                                                                 //hp�o�[�̐}�`
    public GameObject CrashAnimation;                                                   //�A�j���[�V�������i�[����
    private void Start()
    {
        currentHealth = maxHealth;                                                      //�v���C���[hp������������
    }
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;                                                  //�_���[�W�󂯂���hp������    
        hpBar.fillAmount -= 0.334f;                                                     //hp�o�[����������
        if (currentHealth <= 0)                                                         //hp��0�ȉ��ɂȂ�����
        {
            Die();                                                                      //���S���\�b�h���Ă�
            Instantiate(CrashAnimation, transform.position, transform.rotation);        //���S�A�j���[�V�����𐶐�
            SceneManager.LoadScene("GameOver");                                         //GameOver�ɉ�ʑJ��
        }
    }

    private void Die()
    {
        
        Debug.Log("Player has died!");                                                  //���S���b�Z�[�W��\������
       
    }
}
