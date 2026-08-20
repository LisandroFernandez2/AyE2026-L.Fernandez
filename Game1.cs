using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Project1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D TexturaFrenteBulbasur;
        Sprite SpriteFrenteBulbasur;
        Texture2D TexturaDetrasBulbasur;
        Sprite SpriteDetrasBulbasur;
       
        Texture2D TexturaFrentePikachu;
        Sprite SpriteFrentePikachu;
        Texture2D TexturaDetrasPikachu;
        Sprite SpriteDetrasPikachu;

        Texture2D TexturaFrenteCharmander;
        Sprite SpriteFrenteCharmander;
        Texture2D TexturaDetrasCharmander;
        Sprite SpriteDetrasCharmander;

        Texture2D TexturaFrenteCharizard;
        Sprite SpriteFrenteCharizard;
        Texture2D TexturaDetrasCharizard;
        Sprite SpriteDetrasCharizard;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
             _spriteBatch = new SpriteBatch(GraphicsDevice);
            TexturaFrenteBulbasur = Content.Load<Texture2D>("Bulbasurfrente");
            SpriteFrenteBulbasur = new Sprite(TexturaFrenteBulbasur, Vector2.Zero);
            TexturaDetrasBulbasur = Content.Load<Texture2D>("Bulbasurdetras");
            SpriteDetrasBulbasur = new Sprite(TexturaDetrasBulbasur, Vector2.Zero);
          
            TexturaFrentePikachu = Content.Load<Texture2D>("Pikachufrente");
            SpriteFrentePikachu = new Sprite(TexturaFrentePikachu, Vector2.Zero);
            TexturaDetrasPikachu = Content.Load<Texture2D>("Pikachudetras");
            SpriteDetrasPikachu = new Sprite(TexturaDetrasPikachu, Vector2.Zero);

            TexturaFrenteCharmander = Content.Load<Texture2D>("Charmanderfrente");
            SpriteFrenteCharmander = new Sprite(TexturaFrenteCharmander, Vector2.Zero);
            TexturaDetrasCharmander = Content.Load<Texture2D>("Charmanderdetras");
            SpriteDetrasCharmander = new Sprite(TexturaDetrasCharmander, Vector2.Zero);

            TexturaFrenteCharizard = Content.Load<Texture2D>("Charizardfrente");
            SpriteFrenteCharizard = new Sprite(TexturaFrenteCharizard, Vector2.Zero);
            TexturaDetrasCharizard = Content.Load<Texture2D>("CharizardDetras");
            SpriteDetrasCharizard = new Sprite(TexturaDetrasCharizard, Vector2.Zero);
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin(samplerState: SamplerState.PointClamp);
            Rectangle MostrarFrentePokemon;
            Rectangle MostrarDetrasPokemon;
            int MoverPosicion = 100;
            Pokemon[] equipo1 = new Pokemon[]
           {
                new Pokemon("Bulbasur",10,100,101,23,23,23,34,243,SpriteFrenteBulbasur,SpriteDetrasBulbasur),
                new Pokemon("Pikachu",10,100,101,23,23,23,24,254,SpriteFrentePikachu,SpriteDetrasPikachu),
                new Pokemon("Charmander",10,100,101,23,23,23,24,256,SpriteFrenteCharmander,SpriteDetrasCharmander),
                new Pokemon("Charizard",10,100,101,23,23,23,24,234,SpriteFrenteCharizard,SpriteDetrasCharizard),

           };
            Entrenador Ash = new Entrenador("Ash", 500, equipo1);
            for (int i = 0; i < 4; i++)
            {
               
                MostrarFrentePokemon = new Rectangle(MoverPosicion, 100, 200, 200);
                MostrarDetrasPokemon = new Rectangle(MoverPosicion, 200, 200, 200);
                MoverPosicion += 100;
                _spriteBatch.Draw(Ash.equipo[i].frente.texture, MostrarFrentePokemon, Color.White);
                _spriteBatch.Draw(Ash.equipo[i].detras.texture, MostrarDetrasPokemon, Color.White);

            }
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
