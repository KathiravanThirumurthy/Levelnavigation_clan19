using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Levelmanager : MonoBehaviour
{
    [SerializeField]
    private Button[] _levelBtn;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<_levelBtn.Length;i++)
        {
            _levelBtn[i].onClick.AddListener(levelClick);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void levelClick()
    {
        Debug.Log("clicked");
        Debug.Log(EventSystem.current.currentSelectedGameObject.name);
        string str = EventSystem.current.currentSelectedGameObject.name;
        DontDestroyOnLoad(this.gameObject);
        SceneManager.LoadScene(str);
    }
    private void goBack()
    {
        Debug.Log("Go Back");
    }
}
