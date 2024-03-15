using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JKH
{
    public partial class Alterator : Form
    {
        public Alterator(MainPanel aboba)
        {
            InitializeComponent();
            main_panel_ref = aboba;
        }
        public object main_panel_ref;

        public string vehicle_adress;
        public string vehicle_serial;
        public string vehicle_type;
        public string vehicle_brand;
        public bool vehicle_vacancy;

        public string material_adress;
        public string material_name;
        public string material_mass;
        public string material_volume;
        public bool material_vacancy;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void del_button_vehicle_Click(object sender, EventArgs e)
        {
            if (del_serial_vehicle.Text == "")
            {
                MessageBox.Show("Empty serial");
            }
            else
            {
                string vehicle_serial = del_serial_vehicle.Text.ToString();
                using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=aflubin0;Database=GKH;"))
                {




                    conn.Open();
                    var sql = $"Select * from VEHICLES where serial='{vehicle_serial}';";

                    //Statement 5
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);

                    //Statement 6
                    var dataReader = cmd.ExecuteReader();

                    //Statement 7
                    DataTable dt = new DataTable();
                    dt.Load(dataReader);
                    
                    if (dt.Rows.Count==0)
                    {
                        MessageBox.Show("No vehicle");
                    }
                    else
                    {
                        ExecuteQuery($"DELETE FROM vehicles WHERE serial = '{vehicle_serial}';");
                        
                    }
                        


                    conn.Close();

                }
            }
            
            
        }
        static int ExecuteQuery(string query)
        {
            var con = new NpgsqlConnection(
     connectionString: "Server=localhost;Port=5432;User Id=postgres;Password=aflubin0;Database=GKH;");
            con.Open();
            try
            {
                using (NpgsqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;
                    int result = cmd.ExecuteNonQuery();
                    return result;
                }
            }

            catch (Exception b)
            {
                throw new Exception("Error connecting to the database", b);

            }
        }

        private void Alterator_Load(object sender, EventArgs e)
        {



        }
        //????
        private void adress_box_MouseClick(object sender, MouseEventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=aflubin0;Database=GKH;"))
            {




                conn.Open();
                var sql = $"Select * from MATERIALS where name = '{material_name}';";

                //Statement 5
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);

                //Statement 6
                var dataReader = cmd.ExecuteReader();


                adress_box.Items.Clear();
                //Statement 7
                DataTable dt = new DataTable();
                dt.Load(dataReader);
                string[] resultArray = new string[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    adress_box.Items.Insert(i, string.Format("{0}", dt.Rows[i]["adress"]));
                }



                //Statement 8
                conn.Close();

            }
        }

        private void vehicle_add_vacancy_box_CheckedChanged(object sender, EventArgs e)
        {
            if (vehicle_add_vacancy_box.Checked == true)
            {
                vehicle_vacancy = true;
            }
            else
                vehicle_vacancy = false;
        }

        private void vehicle_add_adress_box_TextChanged(object sender, EventArgs e)
        {
            vehicle_adress = vehicle_add_adress_box.Text.ToString();
        }

        private void vehicle_add_type_box_TextChanged(object sender, EventArgs e)
        {
            vehicle_type = vehicle_add_type_box.Text.ToString();
        }

        private void vehicle_add_brand_box_TextChanged(object sender, EventArgs e)
        {
            vehicle_brand = vehicle_add_brand_box.Text.ToString();
        }

        private void vehicle_add_serial_box_TextChanged(object sender, EventArgs e)
        {
            vehicle_serial = vehicle_add_serial_box.Text.ToString();
        }

        private void vehicle_add_bttn_Click(object sender, EventArgs e)
        {
            if (vehicle_add_serial_box.Text == "")
            {
                MessageBox.Show("No vehicle serial");
            }
            else
                using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=aflubin0;Database=GKH;"))
                {



                    
                    conn.Open();
                    var sql = $"INSERT INTO Vehicles (type,brand,adress,serial,vacancy) VALUES ('{vehicle_type}','{vehicle_brand}','{vehicle_adress}','{vehicle_serial}',{vehicle_vacancy});";


                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                    cmd.CommandText = sql;
                    MessageBox.Show(sql);
                    ExecuteQuery(sql);



                    conn.Close();

                }
           
        }

        private void alt_vehicle_select_textbox_TextChanged(object sender, EventArgs e)
        {
            vehicle_serial = alt_vehicle_serial_textbox.Text.ToString();
            Serial_label.Text= alt_vehicle_serial_textbox.Text.ToString(); 
        }

        private void alt_vehicle_select_bttn_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=aflubin0;Database=GKH;"))
            {




                conn.Open();
                var sql = $"Select * from vehicles where serial = '{vehicle_serial}';";

              
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);

                
                var dataReader = cmd.ExecuteReader();

               
                DataTable dt = new DataTable();
                dt.Load(dataReader);
                alt_vehicle_adress_textbox.Text = dt.Rows[0]["adress"].ToString();
                

                alt_vehicle_brand_textbox.Text = dt.Rows[0]["brand"].ToString();
              
                alt_vehicle_type_textbox.Text = dt.Rows[0]["type"].ToString();
                

                alt_vehicle_vacancy_checkbox.Checked= Boolean.Parse(dt.Rows[0]["vacancy"].ToString());
                
                conn.Close();
            }
        }

        private void vehicle_alt_button_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=aflubin0;Database=GKH;"))
            {

                vehicle_adress = alt_vehicle_adress_textbox.Text.ToString();
                vehicle_brand = alt_vehicle_brand_textbox.Text.ToString();
                vehicle_type = alt_vehicle_type_textbox.Text.ToString();
                vehicle_vacancy = Convert.ToBoolean(alt_vehicle_vacancy_checkbox.CheckState);


                conn.Open();
                var sql = $"update vehicles set type = '{vehicle_type}', brand = '{vehicle_brand}', adress = '{vehicle_adress}', vacancy = {vehicle_vacancy} where serial = '{vehicle_serial}'; ";
                MessageBox.Show(sql);

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                ExecuteQuery(sql);


                conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (material_adress == "" || material_name == "")
            {
                MessageBox.Show("Empty adress or material name");
            }
            else

            {
                string vehicle_serial = del_serial_vehicle.Text.ToString();
                using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=aflubin0;Database=GKH;"))
                {




                    conn.Open();
                    var sql = $"Select * from materials where name='{material_name}' and adress='{material_adress}';";

                    //Statement 5
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);

                    //Statement 6
                    var dataReader = cmd.ExecuteReader();

                    //Statement 7
                    DataTable dt = new DataTable();
                    dt.Load(dataReader);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No material");
                    }
                    else
                    {
                        ExecuteQuery($"DELETE FROM materials WHERE name = '{material_name}' and adress ='{material_adress}';");

                    }



                    conn.Close();

                }


            }
            
        }

        private void Material_name_box_TextChanged(object sender, EventArgs e)
        {
            material_name = Material_name_box.Text.ToString();
        }

        private void adress_box_SelectedValueChanged(object sender, EventArgs e)
        {
            material_adress=adress_box.Text.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=aflubin0;Database=GKH;"))
                {
                if (material_add_serial_box.Text == "")
                {
                    MessageBox.Show("Empty material name");
                }
                else
            if (material_add_mass_box.Text == "")
                {
                    material_mass = "0";
                }
                if (material_add_volume_box.Text == "")
                {
                    material_volume = "0";
                }



                conn.Open();
                    var sql = $"INSERT INTO materials (name,adress,mass_kg,volume_v3,vacancy) VALUES ('{material_name}','{material_adress}','{material_mass}','{material_volume}',{material_vacancy});";


                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                    cmd.CommandText = sql;
                    MessageBox.Show(sql);
                    ExecuteQuery(sql);



                    conn.Close();

                }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            material_adress = material_add_adress_box.Text.ToString();
        }

        private void material_add_mass_box_TextChanged(object sender, EventArgs e)
        {
            material_mass = material_add_mass_box.Text.ToString();
        }

        private void material_add_volume_box_TextChanged(object sender, EventArgs e)
        {
            material_volume = material_add_volume_box.Text.ToString();
        }

        private void material_vacancy_checkbox_CheckedChanged(object sender, EventArgs e)
        {

            material_vacancy = Convert.ToBoolean(material_vacancy_checkbox.CheckState);
        }

        private void material_add_serial_box_TextChanged(object sender, EventArgs e)
        {
            material_name = material_add_serial_box.Text.ToString();
        }

        private void Alterator_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainPanel panel = (MainPanel)main_panel_ref;
            panel.alt1 = null;
        }

        private void alt_material_adress_combobox_Click(object sender, EventArgs e)
        {

        }

        private void alt_material_adress_combobox_MouseClick(object sender, MouseEventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=aflubin0;Database=GKH;"))
            {




                conn.Open();
                var sql = $"Select * from MATERIALS where name = '{material_name}';";

                //Statement 5
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);

                //Statement 6
                var dataReader = cmd.ExecuteReader();


                alt_material_adress_combobox.Items.Clear();
                //Statement 7
                DataTable dt = new DataTable();
                dt.Load(dataReader);
                string[] resultArray = new string[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    alt_material_adress_combobox.Items.Insert(i, string.Format("{0}", dt.Rows[i]["adress"]));
                }



                //Statement 8
                conn.Close();

            }
        }

        private void alt_material_adress_combobox_SelectedValueChanged(object sender, EventArgs e)
        {
            material_adress = alt_material_adress_combobox.Text.ToString();
        }

        private void alt_material_name_textbox_TextChanged(object sender, EventArgs e)
        {
            material_name = alt_material_name_textbox.Text.ToString();
        }

        private void alt_material_adress_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void alt_select_material_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=aflubin0;Database=GKH;"))
            {




                conn.Open();
                var sql = $"Select * from materials where name='{material_name}' and adress='{material_adress}';"; ;


                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);


                var dataReader = cmd.ExecuteReader();


                DataTable dt = new DataTable();
                dt.Load(dataReader);

                alt_material_mass_textbox.Text = dt.Rows[0]["mass_kg"].ToString();


                alt_material_volume_textbox.Text = dt.Rows[0]["volume_v3"].ToString();

                


                alt_material_vacancy_checkbox.Checked = Boolean.Parse(dt.Rows[0]["vacancy"].ToString());

                conn.Close();
            }
        }

        private void alt_material_mass_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void alter_material_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=aflubin0;Database=GKH;"))
            {

                
                material_volume = alt_material_volume_textbox.Text.ToString();
                material_mass = alt_material_mass_textbox.Text.ToString();
                material_vacancy = Convert.ToBoolean(alt_material_vacancy_checkbox.CheckState);


                conn.Open();
                var sql = $"update materials set  mass_kg = '{material_mass}', volume_v3 = '{material_volume}', vacancy = {material_vacancy} where name = '{material_name}' and adress ='{material_adress}'; ";
                MessageBox.Show(sql);

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                ExecuteQuery(sql);


                conn.Close();
            }
        }
    }
}
