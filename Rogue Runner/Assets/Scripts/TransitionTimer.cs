
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionTimer : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = 30f;

    
    private float timer;
 


  

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
        if(timer > delayBeforeLoading)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
          
    }
}
