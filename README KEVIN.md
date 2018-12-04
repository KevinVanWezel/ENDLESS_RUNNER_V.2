void Update()
   {
        GameObject[] achtergronden = GameObject.FindGameObjectsWithTag("Background");
        currentBackground = achtergronden[achtergronden.Length - 1];
        Vector2 position = new Vector2(currentBackground.transform.position.x + max.x * 2 - 0.05f, 0);
        if (currentBackground.GetComponent<SpriteRenderer>().bounds.min.x >= min.x - 0.5 && currentBackground.GetComponent<SpriteRenderer>().bounds.min.x <= min.x + 0.5)
        {
            Instantiate(Background, position, BackgroundSpawnplace.rotation);
        }
   }

hier word de bewegende achtergrond aangemaakt en bepaalt waarneer er een nieuwe word gemaakt

_________________________________________________________________