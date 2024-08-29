using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonogameAlex
{
    public class Player
    {
        Vector2 position = new Vector2(400,240);
        Texture2D texture;

        public Player(Texture2D texture){
            this.texture = texture;
        }

        public void Update(){
            KeyboardState kState = Keyboard.GetState();
        if(kState.IsKeyDown(Keys.W))
        {
            position.Y -= 1;

        }
        if(kState.IsKeyDown(Keys.W) && kState.IsKeyDown(Keys.LeftShift))
        {
            position.Y -= 2;

        }

        if(kState.IsKeyDown(Keys.S))
        {
            position.Y += 1;

        }
        if(kState.IsKeyDown(Keys.S) && kState.IsKeyDown(Keys.LeftShift))
        {
            position.Y += 2;

        }

        if(kState.IsKeyDown(Keys.A))
        {
            position.X -= 1;

        }
        if(kState.IsKeyDown(Keys.A) && kState.IsKeyDown(Keys.LeftShift))
        {
            position.X -= 2;

        }

        if(kState.IsKeyDown(Keys.D))
        {
            position.X += 1;

        }
        if(kState.IsKeyDown(Keys.D) && kState.IsKeyDown(Keys.LeftShift))
        {
            position.X += 2;

        }

        }

        public void Draw(SpriteBatch spriteBatch){
        Rectangle playerRectangle = new Rectangle((int)position.X, (int)position.Y,100,100);
        spriteBatch.Draw(texture, position, Color.Green);
    }
    }

}