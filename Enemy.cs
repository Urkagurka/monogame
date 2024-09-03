using System.Numerics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpDX;

namespace monogame
{
    public class Enemy : BaseClass
    {
        public Enemy(Texture2D texture, Vector2 position):base(texture, position){
        }

        public void Update(){
            position.Y--;
        }
    }
}