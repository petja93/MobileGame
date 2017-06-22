using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour {

	/*public Image leben1;
	public Image leben2;
	public Image leben3;
	public Image tot;*/

	public Sprite sprite2;
	public Sprite sprite1;
	public Sprite sprite0;

	//public static int leben = 3;

	public Image image;

	public void setImage(int health){

		if (health == 2) {
			//GetComponent<GUITexture> ().GetComponent<GUITexture>() = leben2;
			//image.sprite = Textures.Load<Sprite> ("pngs/" + imageName) as Sprite;
			//SpriteRenderer sprite = GetComponent<SpriteRenderer>();
			//sprite = sprite2;
			image.sprite = sprite2;

		} else if (health == 1) {
			//GetComponent<GUITexture> ().GetComponent<GUITexture>() = leben1;
		} else if (health == 0) {
			//GetComponent<GUITexture> ().GetComponent<GUITexture>() = tot;
		}

		/*switch (leben) {
		case 3:
			guiTexture.guiTexture = leben3;
			break;
		case 2:
			guiTexture.guiTexture = leben2;
			break;
		case 1:
			guiTexture.guiTexture = leben1;
			break;
		case 0:
			guiTexture.guiTexture = tot;
			break;
		}*/
	}




	/*public int health = 3;
	DeathScript deathscript;
	Collider col;

    public void looseHealth(int amount)
    {
        
        health -= amount;
        if(health <=0)
        {
			deathscript.OnTriggerEnter(col);
            Time.timeScale = 0;
            //Destroy(gameObject);
        }

    }*/

    
    
	
}