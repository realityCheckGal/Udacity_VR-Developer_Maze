using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SignPost : MonoBehaviour
{	
	public Camera camera;

	public void ResetScene(string sceneName) 
	{
        // Reset the rotation on the camera to identity
        Camera.main.transform.rotation = Quaternion.identity;
        SceneManager.LoadScene (sceneName);
        Debug.Log("scene reset");
	}
}

