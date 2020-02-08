using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSprites : MonoBehaviour
{
    // liste des sprites
    public Sprite[] sprites;
    //nom du fichier dans le dossier resources
    public string resourcesName;
    //sprites actuel
    public int currentSprite = -1;

    void Start()
    {
        if (resourcesName != "")
        {
            sprites = Resources.LoadAll<Sprite>(resourcesName);
            if (currentSprite == -1)
            {
                currentSprite = Random.Range(0, sprites.Length);
            }
            else if (currentSprite > sprites.Length)
            {
                currentSprite = sprites.Length - 1;
            }
            GetComponent<SpriteRenderer>().sprite = sprites[currentSprite];
        }
    }
}
