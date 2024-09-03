using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace monogame
{
    public class BaseClass
    {
        protected Vector2 position;
        protected Texture2D texture;

        public BaseClass(Texture2D texture, Vector2 position){
            this.texture = texture;
            this.position = position;
        }

        public void Draw(SpriteBatch spriteBatch){
        Rectangle playerRectangle = new Rectangle((int)position.X,(int)position.Y,50,50);
        spriteBatch.Draw(texture, playerRectangle, Color.Red);
    } 
    }
}