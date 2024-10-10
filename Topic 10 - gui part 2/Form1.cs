using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_10___gui_part_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Skele_Click(object sender, EventArgs e)
        {
            changeBox.Image = Properties.Resources.Skellies;
            textChange.Text = "The Skeletons is a Common card that is unlocked from the Bone Pit (Arena 2). It spawns three fast, single-target, ground-targeting, melee, ground troops with very low hitpoints and very low damage. Their deployment is in a triangle formation. They are the same as those spawned by the Witch, Tombstone, Skeleton Barrel, Skeleton Army, Graveyard, and the Super Witch. A Skeletons card costs 1 Elixir to deploy.";
        }

        private void Archie_Click(object sender, EventArgs e)
        {
            changeBox.Image = Properties.Resources.Archers;
            textChange.Text = "The Archers is a Common card that is unlocked from the Training Camp (Tutorial). It spawns two single-target, air-targeting, medium-ranged, ground troops with low hitpoints and low damage. Their deployment is in a horizontal formation. They wield bows, bear team-colored capes, and wear emerald green tunics. An Archers card costs 3 Elixir to deploy.";
        }

        private void Knight_Click(object sender, EventArgs e)
        {
            changeBox.Image = Properties.Resources.Knight;
            textChange.Text = "The Knight is a Common card that is unlocked from the Training Camp (Tutorial). It spawns a single-target, ground-targeting. melee, ground troop with high hitpoints and moderate damage. The Knight has a blond-colored mustache and eyebrows, and wears chain mail and a chestplate along with a team-colored scarf while holding a sabre. A Knight card costs 3 Elixir to deploy.";
        }

        private void lilPekka_Click(object sender, EventArgs e)
        {
            changeBox.Image = Properties.Resources.MP;
            textChange.Text = "The Mini P.E.K.K.A is a Rare card that is unlocked from the Training Camp (Tutorial). It spawns a fast, single-target, ground-targeting, melee ground troop with high hitpoints and very high damage. He is clothed in gray metal armour and wields a smaller version of the P.E.K.K.A's sword. He wears a helmet with team-colored horns and a single team-colored eye. A Mini P.E.K.K.A card costs 4 Elixir to deploy.";
        }

        private void Giant_Click(object sender, EventArgs e)
        {
            changeBox.Image = Properties.Resources.Giant;
            textChange.Text = "The Giant is a Rare card that is unlocked from the Training Camp (Tutorial). It spawns a slow, single target, building-targeting, melee, ground troop with very high hitpoints and high damage. He wears a large, brown coat made of cloth and has ginger sideburns and bushy eyebrows with blue eyes. A Giant card costs 5 Elixir to deploy.";
        }

        private void textChange_Click(object sender, EventArgs e)
        {

        }

        private void Skele_MouseHover(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
