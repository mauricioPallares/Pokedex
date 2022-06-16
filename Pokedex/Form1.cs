using Pokedex.Controles;
using Pokedex.Properties;
using System.Reflection;

namespace Pokedex
{
    public partial class Form1 : Form
    {
        Pokemon pokemon = new Pokemon();
        

        public Form1()
        {
            InitializeComponent();
        

        }

        private async Task Read(string idPokemon)
        {

            using var client = new HttpClient();
            var response = await client.GetStringAsync($"https://pokeapi.co/api/v2/pokemon/{idPokemon}");
            pokemon = Pokemon.FromJson(response);

            
        }

       

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(txtSearchPokemon.Text == String.Empty))
                {
                    await Read(txtSearchPokemon.Text);

                    abilitiesPanel.Controls.Clear();
                    listMoves.Items.Clear();
                    statsPanel.Controls.Clear();
                    TypeElementPanel.Controls.Clear();

                    loadPokemon(pokemon);
                }
                else
                {
                    throw new Exception("texto de busqueda vacio");
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se ha encontrado un error\n" + ex.Message.ToString());
            }
            
        }

        public void loadPokemon(Pokemon pokemon)
        {
            lblName.Text = pokemon.Name.ToString();
            
            lblWeight.Text = pokemon.Weight.ToString();
            lblHeight.Text = pokemon.Height.ToString();
            lblExperience.Text = pokemon.BaseExperience.ToString().ToUpper();

            mainImage.Load(pokemon.Sprites.Other.OfficialArtwork.FrontDefault.ToString());
            frontImage.Load(pokemon.Sprites.FrontDefault.ToString());
            backImage.Load(pokemon.Sprites.BackDefault.ToString());
            
            
            foreach (Move item in pokemon.Moves)
            {
                listMoves.Items.Add(item.MoveMove.Name.ToString());
            }

            
            foreach (Ability item in pokemon.Abilities)
            {
                Label label = new Label();

                label.Text = item.AbilityAbility.Name.ToString();
                label.Size = new Size((int)abilitiesPanel.Width - 10, 30);
                abilitiesPanel.Controls.Add(label);
            }

            foreach (TypeElement item in pokemon.Types)
            {
                PictureBox pictureBox = new PictureBox();

                pictureBox.Image = setImageType(item.Type.Name.ToString());
                pictureBox.Refresh();
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Size = new Size(100,100);

                TypeElementPanel.Controls.Add(pictureBox);

            }

            

            
            foreach (Stat item in pokemon.Stats)
            {
                Label label = new Label();
                
                label.Size = new Size(170, 31);
                label.TextAlign = ContentAlignment.MiddleRight;
                label.Text = translateTexType(item.StatStat.Name.ToString());
                statsPanel.Controls.Add(label);

                MyProgressBAr bar = new MyProgressBAr();
                bar.Size = new Size(290,28);
                bar.MaxValue = 200;
                bar.Value = item.BaseStat;
                statsPanel.Controls.Add(bar);

            }

        



           
        }

        public Image setImageType(string type) => type switch
        {
            "bug" => Resources.bug,
            "dark" => Resources.dark,
            "dragon" => Resources.dragon,
            "electric" => Resources.electric,
            "fairy" => Resources.fairy,
            "fighting" => Resources.fighting,
            "fire" => Resources.fire,
            "flying" => Resources.flying,
            "ghost" => Resources.ghost,
            "grass" => Resources.grass,
            "ground" => Resources.ground,
            "ice" => Resources.ice,
            "normal" => Resources.normal,
            "poison" => Resources.poison,
            "psychic" => Resources.psychic,
            "rock" => Resources.rock,
            "steel" => Resources.steel,
            "water" => Resources.water,
            _ => Resources.buscar,

        };

        public string translateTexType(string statsName) => statsName switch
        {
            "hp" => "PODER",
            "attack" => "ATAQUE",
            "defense" => "DEFENSA",
            "special-attack" => "ATAQUE ESPECIAL",
            "special-defense" => "DEFENSA ESPECIAL",
            "speed" => "VELOCIDAD",
            _ => "ERROR"

        };
    }
}