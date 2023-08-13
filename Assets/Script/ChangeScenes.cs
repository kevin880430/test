using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScenes : MonoBehaviour
{
    public string Stage2SceneName = "Stage2";                                                           //Stage2Scene�̖��O��t����
    public string MainSceneName = "Main";                                                               //MainScene�̖��O��t����
 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name==("Player")&& SceneManager.GetActiveScene().name == MainSceneName)        //�v���C���[�Ɩ��ڐG����Ǝ���Stage�ɑJ��
        {
            SceneManager.LoadScene("Stage2");
        }
        if (collision.gameObject.name == ("Player")&& SceneManager.GetActiveScene().name == Stage2SceneName)    //�v���C���[�Ɩ��ڐG����Ǝ���GameClear�ɑJ��
        {
            SceneManager.LoadScene("GameClear");
        }
    }
}
