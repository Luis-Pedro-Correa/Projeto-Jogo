using SFML.Graphics;
using SFML.System;
using SFML.Window;
namespace GameSpace
{
    class Nave
    {
        public Sprite sprite;       
        public Nave () 
        {
            sprite = new Sprite();
            sprite.Texture = new Texture("Assets/imagens/navenova.png");
            sprite.Position = new Vector2f(400f,510f);
        }
    }
}