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
        Texture2D triblecream;
        Vector2 creamspeed;
        Rectangle creamtexrect;
        Texture2D tribbleorange;
        Vector2 orangespeed;
        Rectangle orangetexrect;
        Color backColor;

        

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
            creamtexrect = new Rectangle(275,56,100,70);
            window = new Rectangle(0, 0, 800, 600);
            orangetexrect = new Rectangle(300, 10, 100, 100);
            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferHeight = window.Height;
          
            greytribbleSpeed = new Vector2(6, 8);
            browntribblespeed = new Vector2(5, 5);
            creamspeed = new Vector2(6, 10);
            orangespeed = new Vector2(11, 10);


            backColor = Color.Aqua;
           
            _graphics.ApplyChanges();


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            graytex = Content.Load<Texture2D>("tribblegrey");
            tribblebrown = Content.Load<Texture2D>("tribblebrown");
            triblecream = Content.Load<Texture2D>("tribblecream");
            tribbleorange = Content.Load < Texture2D>("tribbleorange");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            graytexRect.X += (int)greytribbleSpeed.X;
            graytexRect.Y += (int)greytribbleSpeed.Y;


            if (graytexRect.Right > window.Width || graytexRect.Left < 0)
            {
                greytribbleSpeed.X *= -1;

                backColor = Color.Red;

            }
               
            
           if (graytexRect.Bottom > window.Height|| graytexRect.Top < 0)
            {

                greytribbleSpeed.Y *= -1;

                backColor = Color.GreenYellow;
            }
               

            browntexrect.X += (int)browntribblespeed.X;
            browntexrect.Y += (int)browntribblespeed.Y;

            if (browntexrect.Right > window.Width || browntexrect.Left < 0)
            {

                browntribblespeed.X *= -1;
                backColor = Color.MediumPurple;
            }

               


            if (browntexrect.Bottom > window.Height || browntexrect.Top < 0)
            {

                browntribblespeed.Y *= -1;

                backColor = Color.HotPink;
            }
               
            creamtexrect.X += (int)creamspeed.X;
            creamtexrect.Y += (int)creamspeed.Y;


            if (creamtexrect.Right > window.Width || creamtexrect.Left < 0)
            {

                creamspeed.X *= -1;

                backColor = Color.BlanchedAlmond;
            }
               


            if (creamtexrect.Bottom > window.Height || creamtexrect.Top < 0)
            {

                creamspeed.Y *= -1;
                backColor = Color.Black;
            }
                

            orangetexrect.X += (int)orangespeed.X;
            orangetexrect.Y += (int)orangespeed.Y;



            if (orangetexrect.Right > window.Width ||orangetexrect.Left < 0)
            {


                orangespeed.X *= -1;
                backColor = Color.Transparent;
            }
              


            if (orangetexrect.Bottom > window.Height || orangetexrect.Top < 0)
                orangespeed.Y *= -1;


            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(backColor);
            _spriteBatch.Begin();

            _spriteBatch.Draw(graytex,graytexRect, Color.White);
            _spriteBatch.Draw(tribblebrown, browntexrect, Color.White);
            _spriteBatch.Draw(triblecream, creamtexrect, Color.White);
            _spriteBatch.Draw(tribbleorange, orangetexrect, Color.White);

            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
