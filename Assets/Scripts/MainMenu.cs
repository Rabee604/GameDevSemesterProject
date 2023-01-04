
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private EnterGame enterGame;
    [SerializeField] private Button button1;
    public void Exit()
    {
       enterGame.SetName();
       button1.enabled = false;
      }


    public void playGame()
    {
        SceneManager.LoadScene(1);
    }
    
    
    public void playReadme()
    {
        SceneManager.LoadScene(2);
    }
    
    public void quitWinner()
    {
        SceneManager.LoadScene(0);
    }
    
    public void playReadmeWinner()
    {
        SceneManager.LoadScene(1);
    }
}
