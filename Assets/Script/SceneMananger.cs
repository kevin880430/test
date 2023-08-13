using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMananger : MonoBehaviour
{
    public string titleSceneName = "Title";                                                         //�^�C�g����ʂ̖��O��t����
    public string gameOverSceneName = "GameOver";   �@                                              //GameOver��ʂ̖��O��t����
    public string clearSceneName = "GameClear";                                                     //ClearScene��ʂ̖��O��t����


    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == titleSceneName && Input.anyKeyDown)               //�^�C�g�����anyKey�Ń��C����ʑJ��
        {
            SceneManager.LoadScene("Main");
        }
        if (SceneManager.GetActiveScene().name == gameOverSceneName && Input.GetKeyDown(KeyCode.R)) //GameOver���RKey�Ń^�C�g����ʑJ��
        {
            SceneManager.LoadScene(titleSceneName);
        }
        if (SceneManager.GetActiveScene().name == clearSceneName && Input.GetKeyDown(KeyCode.R))    //Clear���RKey�Ń^�C�g����ʑJ��
        {
            {
                SceneManager.LoadScene(titleSceneName);
            }
        }
    }
}
