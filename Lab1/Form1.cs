using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab1
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataAdapter restaurantAdapter;
        SqlDataAdapter cookAdapter;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=GLADYS\\SQLEXPRESS;Initial Catalog=RestaurantChain;Integrated Security=True");
            ds = new DataSet();

            restaurantAdapter = new SqlDataAdapter("SELECT * FROM Restaurant", conn);

            restaurantAdapter.InsertCommand = new SqlCommand("INSERT INTO Restaurant VALUES (@id, @Name, @Location)", conn);
            restaurantAdapter.InsertCommand.Parameters.Add("@id", SqlDbType.Int, 4, "id");
            restaurantAdapter.InsertCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name");
            restaurantAdapter.InsertCommand.Parameters.Add("@Location", SqlDbType.NVarChar, 50, "Location");

            restaurantAdapter.UpdateCommand = new SqlCommand("UPDATE Restaurant SET Name = @Name, Location = @Location WHERE id = @id", conn);
            restaurantAdapter.UpdateCommand.Parameters.Add("@id", SqlDbType.Int, 4, "id");
            restaurantAdapter.UpdateCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name");
            restaurantAdapter.UpdateCommand.Parameters.Add("@Location", SqlDbType.NVarChar, 50, "Location");

            restaurantAdapter.DeleteCommand = new SqlCommand("DELETE FROM Restaurant WHERE id=@id", conn);
            restaurantAdapter.DeleteCommand.Parameters.Add("@id", SqlDbType.Int, 4, "id");

            cookAdapter = new SqlDataAdapter("SELECT * FROM Cook", conn);

            cookAdapter.InsertCommand = new SqlCommand("INSERT INTO Cook VALUES(@id, @Name, @Specialty_id, @Position, @Awards" +
                ", @Restaurant_id)", conn);
            cookAdapter.InsertCommand.Parameters.Add("@id", SqlDbType.Int, 5, "id");
            cookAdapter.InsertCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name");
            cookAdapter.InsertCommand.Parameters.Add("@Specialty_id", SqlDbType.Int, 5, "Specialty_id");
            cookAdapter.InsertCommand.Parameters.Add("@Position", SqlDbType.NVarChar, 50, "Position");
            cookAdapter.InsertCommand.Parameters.Add("@Awards", SqlDbType.Text, 200, "Awards");
            cookAdapter.InsertCommand.Parameters.Add("@Restaurant_id", SqlDbType.Int, 5, "Restaurant_id");

            cookAdapter.UpdateCommand = new SqlCommand("UPDATE Cook SET Name = @Name, Specialty_id =@Specialty_id" +
                ", Position = @Position, Awards = @Awards, Restaurant_id = @Restaurant_id WHERE id = @id", conn);
            cookAdapter.UpdateCommand.Parameters.Add("@id", SqlDbType.Int, 5, "id");
            cookAdapter.UpdateCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name");
            cookAdapter.UpdateCommand.Parameters.Add("@Specialty_id", SqlDbType.Int, 5, "Specialty_id");
            cookAdapter.UpdateCommand.Parameters.Add("@Position", SqlDbType.NVarChar, 50, "Position");
            cookAdapter.UpdateCommand.Parameters.Add("@Awards", SqlDbType.Text, 200, "Awards");
            cookAdapter.UpdateCommand.Parameters.Add("@Restaurant_id", SqlDbType.Int, 5, "Restaurant_id");

            cookAdapter.DeleteCommand = new SqlCommand("DELETE FROM Cook WHERE id = @id", conn);
            cookAdapter.DeleteCommand.Parameters.Add("@id", SqlDbType.Int, 5, "id");
            cookAdapter.DeleteCommand.Parameters[0].SourceVersion = DataRowVersion.Original;



            restaurantAdapter.Fill(ds, "Restaurants");
            cookAdapter.Fill(ds, "Cooks");

            ds.Relations.Add("FK_Cook_Restaurant", ds.Tables["Restaurants"].Columns["id"], ds.Tables["Cooks"].Columns["Restaurant_id"]);

            BindingSource bsRests = new BindingSource(ds, "Restaurants");
            BindingSource bsCooks = new BindingSource(bsRests, "FK_Cook_Restaurant");

            restaurantsGV.DataSource = bsRests;
            cooksGV.DataSource = bsCooks;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            restaurantAdapter.Update(ds.Tables["Restaurants"]);
            cookAdapter.Update(ds.Tables["Cooks"]);
        }
    }
}
