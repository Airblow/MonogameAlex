using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonogameAlex
{
    public class Enemy : BaseClass
    {
        public Enemy(Texture2D texture, Vector2 position):base(texture, position){
            color = Color.Red;
        }

        public void Update(){
            position.Y ++;
        }


    }
}