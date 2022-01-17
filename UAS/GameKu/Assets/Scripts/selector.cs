using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selector : MonoBehaviour
{
   public GameObject drag3;
   public GameObject drag4;
   public GameObject dragon_player;
   private Vector3 CharacterPosition;
   private Vector3 OffScreen;
   private int CharacterInt = 1;
   private SpriteRenderer drag3Renderer,drag4Renderer,dragon_playerRenderer;
   private readonly string SelectedCharacter = "SelectedCharacter";

   private void Awake()
   {
       CharacterPosition = dragon_player.transform.position;
       OffScreen = drag3.transform.position;
       drag3Renderer = drag3.GetComponent<SpriteRenderer>();
       drag4Renderer = drag3.GetComponent<SpriteRenderer>();
       dragon_playerRenderer = drag3.GetComponent<SpriteRenderer>();
   }
   public void Next()
   {
       switch(CharacterInt)
       {
           case 1:
           PlayerPrefs.SetInt( SelectedCharacter,1);
           dragon_playerRenderer.enabled = false;
           dragon_player.transform.position = OffScreen;
           drag3.transform.position = CharacterPosition;
           drag3Renderer.enabled =true;
           CharacterInt++;
                break;
            case 2:
            PlayerPrefs.SetInt( SelectedCharacter,2);
            drag3Renderer.enabled = false;
           drag3.transform.position = OffScreen;
           drag4.transform.position = CharacterPosition;
           drag4Renderer.enabled =true;
           CharacterInt++;
                break;
            case 3:
            PlayerPrefs.SetInt( SelectedCharacter,3);
            drag4Renderer.enabled = false;
           drag4.transform.position = OffScreen;
           dragon_player.transform.position = CharacterPosition;
           dragon_playerRenderer.enabled =true;
           CharacterInt++;
           resetInt();
                break;
            default:
            resetInt();
                break;
       }

   }
  
   private void resetInt()
   {
       if(CharacterInt >=4 )
       {
           CharacterInt = 1;
       }
       else
       {
           CharacterInt = 4;
       }
   }

   public void ChangeScene()
   {
        SceneManager.LoadScene(1);
   }

}
