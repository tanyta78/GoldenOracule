using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace SuperAdventure
{
    public partial class GoldenOracleAdventure : Form
    {
        private Player _player;

        public GoldenOracleAdventure()
        {
            InitializeComponent();

            Location location =new Location(1,"Home","This is your house");
            

            _player=new Player(10,10,20,0,1);

           
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperiance.Text = _player.ExperiancePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }

        private void GoldenOracleAdventure_Load(object sender, EventArgs e)
        {

        }

        
    }
}
