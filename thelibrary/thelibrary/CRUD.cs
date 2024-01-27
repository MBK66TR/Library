// CRUD Sınıfı
using System.Data.SQLite;
using System.Data;
using System;
using System.Windows.Forms;

public class CRUD
{
    static DataTable dt;

    public static DataTable Listele(string sql)
    {
        dt = new DataTable();

        try
        {
            if (Baglan.connection.State == ConnectionState.Closed)
                Baglan.connection.Open();

            SQLiteDataAdapter adtr = new SQLiteDataAdapter(sql, Baglan.connection);
            adtr.Fill(dt);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ana Listeleme Hatası: " + ex.Message);
        }
        finally
        {
            if (Baglan.connection.State == ConnectionState.Open)
                Baglan.connection.Close();
        }

        return dt;
    }
}

// Baglan Sınıfı
public class Baglan
{
    public static SQLiteConnection connection = new SQLiteConnection("Data source=.\\DataBase.db;Version=3");
}
