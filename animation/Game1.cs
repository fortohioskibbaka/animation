using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace animation
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D graytex;
        Rectangle graytexRect;
        Vector2 greytribbleSpeed;
        Rectangle window;
        Texture2D tribblebrown;
        Rectangle browntexrect;
        Vector2 browntribblespeed;

        
        public Game1()
        {

            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;



        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            graytexRect= new Rectangle(300,10,100,100);
            browntexrect = new Rectangle(200, 10, 100, 50);
            window = new Rectangle(0, 0, 800, 600);
            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferHeight = window.Height;
            _graphics.ApplyChanges();
            greytribbleSpeed = new Vector2(2, 2);
            browntribblespeed = new Vector2(5, 5);

            

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            graytex = Content.Load<Texture2D>("tribblegrey");
            tribblebrown = Content.Load<Texture2D>("tribblebrown");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            graytexRect.X += (int) greytribbleSpeed.X;
            graytexRect.Y += (int) greytribbleSpeed.Y;


            if (graytexRect.Right > window.Width || graytexRect.Left<0)
                greytribbleSpeed.X *= -1;
            


            
            if (graytexRect.Bottom > window.Height|| graytexRect.Bottom < 0)
                greytribbleSpeed.Y *= -1;

            browntexrect.X += (int)browntribblespeed.X;
            browntexrect.Y += (int)browntribblespeed.Y;

            if (browntexrect.Right > window.Width || browntexrect.Left < 0)
                browntribblespeed.X *= -1;


            if (browntexrect.Bottom > window.Height || browntexrect.Bottom < 0)
                browntribblespeed.Y *= -1;


            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();

            _spriteBatch.Draw(graytex,graytexRect, Color.White);
            _spriteBatch.Draw(tribblebrown, browntexrect, Color.White);

            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
