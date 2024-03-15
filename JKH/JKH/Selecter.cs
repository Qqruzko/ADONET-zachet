using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JKH
{
    public partial class Selecter : Form
    {
        public Selecter(MainPanel aboba)
        {
            InitializeComponent();
            main_panel_ref = aboba;
        }
        public object main_panel_ref;

        public bool vehicle_availability_needed;
        public bool vehicle_adress_needed;
        public bool vehicle_type_needed;
        public bool vehicle_mark_needed;
        public string serial_number;

       
        public bool material_vacancy_needed;
        public bool material_mass_volume_needed;
        public string material_adress;
        public string material_name;
        private void Selecter_Load(object sender, EventArgs e)
        {

        }


        private void Select_all_vehicles_btn_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=aflubin0;Database=GKH;"))
            {




                conn.Open();
                var sql = "Select * from VEHICLES";

                //Statement 5
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);

                //Statement 6
                var dataReader = cmd.ExecuteReader();

                //Statement 7
                DataTable dt = new DataTable();
                dt.Load(dataReader);
                string[] resultArray = new string[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    resultArray[i] = string.Format("Serial:{0}, Type:{1}, Brand:{2}, Adress:{3}, Vacancy:{4}", dt.Rows[i]["serial"], dt.Rows[i]["type"], dt.Rows[i]["brand"], dt.Rows[i]["adress"], dt.Rows[i]["vacancy"] + System.Environment.NewLine);
                }
                string finalLine = "";
                for (int i = 0; i <= resultArray.Length - 1; i++)
                {
                    finalLine = finalLine + resultArray[i];
                }

                Vehicles_rich_textbox.Text = finalLine;
                //Statement 8
                conn.Close();

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

        private void Select_all_mat_bttn_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=aflubin0;Database=GKH;"))
            {




                conn.Open();
                var sql = "Select * from MATERIALS";

                //Statement 5
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);

                //Statement 6
                var dataReader = cmd.ExecuteReader();

                //Statement 7
                DataTable dt = new DataTable();
                dt.Load(dataReader);
                string[] resultArray = new string[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    resultArray[i] = string.Format("Name:{0}, Adress:{1}, Volume:{2}, Mass:{3}, Vacancy{4}", dt.Rows[i]["name"], dt.Rows[i]["adress"], dt.Rows[i]["mass_kg"], dt.Rows[i]["volume_v3"], dt.Rows[i]["vacancy"] + System.Environment.NewLine);
                }
                string finalLine = "";
                for (int i = 0; i <= resultArray.Length - 1; i++)
                {
                    finalLine = finalLine + resultArray[i];
                }

                Materials_rich_textbox.Text = finalLine;
                //Statement 8
                conn.Close();

            }
        }

        private void Vehicle_select_btn_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=aflubin0;Database=GKH;"))
            {
                string sql = "Select ";
                if (vehicle_availability_needed == true)
                {
                    sql = sql + " vacancy,";
                }
                if (vehicle_adress_needed == true)
                {
                    sql = sql + " adress,";
                }
                if (vehicle_type_needed == true)
                {
                    sql = sql + " type,";
                }
                if (vehicle_mark_needed == true)
                {
                    sql = sql + " brand,";
                }
                sql = sql.Remove(sql.Length - 1);
                sql = sql + $" from VEHICLES where serial = '{serial_number}'";

                MessageBox.Show(sql);



                conn.Open();


                //Statement 5
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);

                //Statement 6
                var dataReader = cmd.ExecuteReader();

                //Statement 7
                DataTable dt = new DataTable();
                dt.Load(dataReader);
                string[] resultArray = new string[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    if (dt.Columns.Contains("type"))
                    {
                        resultArray[i] = resultArray[i] + dt.Rows[i]["type"];
                    }
                    if (dt.Columns.Contains("brand"))
                    {
                        resultArray[i] = resultArray[i] + dt.Rows[i]["brand"];
                    }
                    if (dt.Columns.Contains("vacancy"))
                    {
                        resultArray[i] = resultArray[i] + dt.Rows[i]["vacancy"];
                    }
                    if (dt.Columns.Contains("adress"))
                    {
                        resultArray[i] = resultArray[i] + dt.Rows[i]["adress"];
                    }
                    resultArray[i] = resultArray[i] + System.Environment.NewLine;

                }
                string finalLine = "";
                for (int i = 0; i <= resultArray.Length - 1; i++)
                {
                    finalLine = finalLine + resultArray[i];
                }

                Vehicles_rich_textbox.Text = finalLine;
                //Statement 8
                conn.Close();

            }
        }

        private void vehicle_type_check_CheckedChanged(object sender, EventArgs e)
        {
            if (vehicle_type_check.Checked == true)
            {
                vehicle_type_needed = true;
            }
            else
                vehicle_type_needed = false;
        }

        private void vehicle_mark_check_CheckedChanged(object sender, EventArgs e)
        {
            if (vehicle_mark_check.Checked == true)
            {
                vehicle_mark_needed = true;
            }
            else
                vehicle_mark_needed = false;
        }
        private void vehicle_availability_check_CheckedChanged(object sender, EventArgs e)
        {
            if (vehicle_availability_check.Checked == true)
            {
                vehicle_availability_needed = true;
            }
            else
                vehicle_availability_needed = false;
        }

        private void vehicle_adress_check_CheckedChanged(object sender, EventArgs e)
        {
            if (vehicle_adress_check.Checked == true)
            {
                vehicle_adress_needed = true;
            }
            else
                vehicle_adress_needed = false;
        }

        private void Serial_number_textbox_TextChanged(object sender, EventArgs e)
        {
            serial_number = Serial_number_textbox.Text.ToString();
        }

        private void material_mass_volume_check_CheckedChanged(object sender, EventArgs e)
        {
            if (material_mass_volume_check.Checked == true)
            {
                material_mass_volume_needed = true;
            }
            else
                material_mass_volume_needed = false;
        }

       

        private void mat_name_TextChanged(object sender, EventArgs e)
        {
            material_name = mat_name_box.Text.ToString();
        }
        private void material_mass_vacancy_check_CheckedChanged(object sender, EventArgs e)
        {
            if (material_vacancy_check.Checked == true)
            {
                material_vacancy_needed = true;
            }
            else
                material_vacancy_needed = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=aflubin0;Database=GKH;"))
            {
               
                string sql = "Select ";
                
                if (vehicle_type_needed == true)
                {
                    sql = sql + " type,";
                }
                if (vehicle_mark_needed == true)
                {
                    sql = sql + " brand,";
                }
                if (vehicle_adress_needed == true)
                {
                    sql = sql + " adress,";
                }
                if (vehicle_availability_needed == true)
                {
                    sql = sql + " vacancy,";
                }

                sql = sql.Remove(sql.Length - 1);
                sql = sql + $" from vehicles where serial = '{serial_number}';";

                MessageBox.Show(sql);



                conn.Open();


                //Statement 5
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);

                //Statement 6
                var dataReader = cmd.ExecuteReader();

                //Statement 7
                DataTable dt = new DataTable();
                dt.Load(dataReader);
                string[] resultArray = new string[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {


        
                    if (dt.Columns.Contains("type"))
                    {
                        resultArray[i] = resultArray[i] + dt.Rows[i]["type"];
                    }
                    if (dt.Columns.Contains("brand"))
                    {
                        resultArray[i] = resultArray[i] + dt.Rows[i]["brand"];
                    }
                    if (dt.Columns.Contains("adress"))
                    {
                        resultArray[i] = resultArray[i] + dt.Rows[i]["adress"];
                    }
                    if (dt.Columns.Contains("vacancy"))
                    {
                        resultArray[i] = resultArray[i] + dt.Rows[i]["vacancy"];
                    }
                    resultArray[i] = resultArray[i] + System.Environment.NewLine;

                }
                string finalLine = "";
                for (int i = 0; i <= resultArray.Length - 1; i++)
                {
                    finalLine = finalLine + resultArray[i];
                }

                Vehicles_rich_textbox.Text = finalLine;
                //Statement 8
                conn.Close();
            }
        }

        private void Selecter_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainPanel panel = (MainPanel)main_panel_ref;
            panel.alt1 = null;
        }

        private void mat_adress_box_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=aflubin0;Database=GKH;"))
            {




                conn.Open();
                var sql = $"Select * from MATERIALS where name = '{material_name}';";

                //Statement 5
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);

                //Statement 6
                var dataReader = cmd.ExecuteReader();


                mat_adress_box.Items.Clear();
                //Statement 7
                DataTable dt = new DataTable();
                dt.Load(dataReader);
                string[] resultArray = new string[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    mat_adress_box.Items.Insert(i, string.Format("{0}", dt.Rows[i]["adress"]));
                }



                //Statement 8
                conn.Close();

            }
        }

        private void mat_adress_box_SelectedValueChanged(object sender, EventArgs e)
        {
            material_adress = mat_adress_box.Text.ToString();
        }

        private void Materials_Select_bttn(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=aflubin0;Database=GKH;"))
            {

                string sql = "Select ";

                
                if (material_mass_volume_needed == true)
                {
                    sql = sql + " mass_kg,";
                }
                if (material_mass_volume_needed == true)
                {
                    sql = sql + " volume_v3,";
                }
                if (material_vacancy_needed == true)
                {
                    sql = sql + " vacancy,";
                }

                sql = sql.Remove(sql.Length - 1);
                sql = sql + $" from materials where name = '{material_name}' and adress='{material_adress}';";

                MessageBox.Show(sql);



                conn.Open();


                //Statement 5
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);

                //Statement 6
                var dataReader = cmd.ExecuteReader();

                //Statement 7
                DataTable dt = new DataTable();
                dt.Load(dataReader);
                string[] resultArray = new string[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {



                    if (dt.Columns.Contains("mass_kg"))
                    {
                        resultArray[i] = resultArray[i] + dt.Rows[i]["mass_kg"];
                    }
                    if (dt.Columns.Contains("volume_v3"))
                    {
                        resultArray[i] = resultArray[i] + dt.Rows[i]["volume_v3"];
                    }
                    
                    if (dt.Columns.Contains("vacancy"))
                    {
                        resultArray[i] = resultArray[i] + dt.Rows[i]["vacancy"];
                    }
                    resultArray[i] = resultArray[i] + System.Environment.NewLine;

                }
                string finalLine = "";
                for (int i = 0; i <= resultArray.Length - 1; i++)
                {
                    finalLine = finalLine + resultArray[i];
                }

                Materials_rich_textbox.Text = finalLine;
                //Statement 8
                conn.Close();
            }
        }
    }
}
