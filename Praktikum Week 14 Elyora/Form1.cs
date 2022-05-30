using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Praktikum_Week_14_Elyora
{
    public partial class FormTim : Form
    {
        public FormTim()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        //DataTable dtTypePemain = new DataTable();
        int PosisiNow = 0;
        DataTable dtTeam = new DataTable();
        DataTable dtNamahTim = new DataTable();
        DataTable dtManager = new DataTable();
        DataTable dtStadium = new DataTable();
        DataTable datagridd = new DataTable();
        DataTable topgoal = new DataTable();
        DataTable worst = new DataTable();
        DataTable buatdgv = new DataTable();


        private void FormTim_Load(object sender, EventArgs e)
        {

            sqlQuery = "SELECT t.team_name as `Nama Tim`, concat(m.manager_name, '(', n.nation, ')') as `Nama Man`, p.player_name, t.team_id as `team_id` , concat(t.home_stadium, ',', t.city, '(', t.capacity, ')') FROM team t, manager m, player p, nationality n WHERE m.manager_id = t.manager_id and t.captain_id = p.player_id And t.team_id = p.team_id and n.nationality_id = m.nationality_id  ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
            IsiDataPemain(0);

            sqlQuery = "SELECT t.team_name as `Team`, p.team_id as `Tim id` from player p, team t where p.team_id = t.team_id group by t.team_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtNamahTim);

            sqlQuery = "select m.manager_name as `Nama Manager` from manager m";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtManager);



        }

        public void IsiDataPemain(int Posisi)
        {
            lblNamaTim.Text = dtTeam.Rows[Posisi][0].ToString();
            lblManager.Text = dtTeam.Rows[Posisi][1].ToString();
            lblStadium.Text = dtTeam.Rows[Posisi][4].ToString();

            sqlQuery = "SELECT concat(p.player_name, ' ', sum(dm.type = 'GO' OR dm.type = 'GP'), '(', sum(dm.type = 'GP'),')') FROM dmatch dm, player p " + 
                "WHERE p.team_id = '" + dtTeam.Rows[Posisi]["team_id"] + "' and (dm.type = 'GO' OR dm.type = 'GP') and dm.player_id = p.player_id GROUP BY dm.player_id order by 1 desc";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(topgoal);
            lblTop.Text = topgoal.Rows[Posisi][0].ToString();
            
            sqlQuery = "select p.player_name as `Player`, kuning.kuning2 as `Yellow Card`, merah.merah2 as `Red Card` from player p, (select d.player_id as `ID`, sum(if(d.type = 'CY', 1, 0)) as kuning2, sum(if(d.type = 'CY', 1, 0)) as poin from dmatch d group by 1) `kuning`, (select d.player_id as `ID`, sum(if(d.type = 'CR', 1, 0)) as merah2, sum(if(d.type = 'CR', 3, 0)) as poin from dmatch d group by 1) merah where p.player_id = kuning.ID and kuning.ID = merah.ID and p.team_id = '" + dtTeam.Rows[Posisi]["team_id"] + "' order by 2 desc;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(worst);
            lblWorst.Text = worst.Rows[Posisi][0] + ", " + worst.Rows[Posisi][1] + " Yellow Card and " + worst.Rows[Posisi][2] + " Red Card";

            //sqlQuery = "select m.match_date as 'Tanggal Pertandingan',(select team.team_name from team where team.team_id = m.team_home) as 'Team Home', (select team.team_name from team where team.team_id = m.`team_away`) as 'Team Away', if (goal_home is null or goal_away is null, 'Belum Selesai', from match m where m.team_home = 'a001' or m.team_away = 'a001' order by m.`match_date`; ";
            //sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            //sqlAdapter = new MySqlDataAdapter(sqlCommand);
            //sqlAdapter.Fill(buatdgv);
            //dgvMatch.DataSource = buatdgv;

            PosisiNow = Posisi;
        }


        private void btnbackbnyk_Click(object sender, EventArgs e)
        {
            IsiDataPemain(0);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            if (PosisiNow > 0)
            {
                PosisiNow--;
                IsiDataPemain(PosisiNow);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (PosisiNow < dtTeam.Rows.Count - 1)
            {
                PosisiNow++;
                IsiDataPemain(PosisiNow);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Terakhir");
            }

        }

        private void btnnextbnyk_Click(object sender, EventArgs e)
        {
            IsiDataPemain(dtTeam.Rows.Count - 1);
        }
    }
}
