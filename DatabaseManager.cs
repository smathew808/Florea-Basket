using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CS325_broadSword_flowerProject
{
    internal static class DatabaseManager
    {
        static private List<Flower> tempFlowerDB = new List<Flower>();
        //static private List<User> userList = new List<User>();
        static private string connString = @"Data Source =(localDB)\MSSQLLocalDB;" +
                                           @"AttachDbFilename = |DataDirectory|\flower_database.mdf;" +
                                           "Integrated Security = True;" +
                                           "Connect Timeout = 30";

        static private string andrewsSpecialConnectionString = @"Data Source =(localDB)\MSSQLLocalDB;" +
                                                               @"AttachDbFilename = |DataDirectory|\flower_database.mdf;" +
                                                               "Integrated Security = True;" +
                                                               "Connect Timeout = 30;" +
                                                               "MultipleActiveResultSets = True;";

        public static bool storeFlowerInDB(Flower flower)
        //This is Cheryl code, it does basically nothing.
        {
            using (SqlConnection conn = new SqlConnection())
            {
                bool flowerDup = false;
                bool duplicate = false;
                int BotIdToBeAdded = -1;
                int FlowerId = -1;
                int PhotoNoteId = -1;
                int HistoId = -1;
                string botanicalFamily;

                conn.ConnectionString = @"Data Source =(localDB)\MSSQLLocalDB;" +
                                        @"AttachDbFilename = |DataDirectory|\flower_database.mdf;" +
                                        "Integrated Security = True;" +
                                        "Connect Timeout = 30";
                conn.Open();

                //Finds the English_Name and Latin_Name to check for duplicates with the flower recieved
                SqlCommand cmd = new SqlCommand("SELECT English_Name, Latin_Name FROM Flower WHERE English_Name ='" + flower.getEnglishName() + "' AND Latin_Name = '" + flower.getLatinName() + "'", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if ((flower.getEnglishName() == reader[0].ToString().Trim()) && (flower.getLatinName() == reader[1].ToString().Trim()))
                        {
                            flowerDup = true;
                        }
                    }
                    reader.Close();
                }

                //Stop and return Duplicate found
                if (flowerDup == true)
                {
                    conn.Close();
                    return false;
                }

                //Check if the flower already has it's botanical family in the database
                cmd = new SqlCommand("SELECT Botanical_Family FROM Botanical_Families", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        botanicalFamily = reader[0].ToString().Trim();

                        if (flower.getBotanicalFamily().Equals(botanicalFamily))
                        {
                            duplicate = true;
                        }
                    }
                    reader.Close();
                }

                //If not duplicate, add it and get it's ID
                if (!duplicate)
                {
                    cmd = new SqlCommand("INSERT INTO Botanical_Families (Botanical_Family) VALUES (@param1)", conn);
                    cmd.Parameters.AddWithValue("@param1", flower.getBotanicalFamily());

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    cmd = new SqlCommand("SELECT BotId FROM Botanical_Families WHERE Botanical_Family = '" + flower.getBotanicalFamily() + "'", conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BotIdToBeAdded = (int)reader[0];
                        }
                        reader.Close();
                    }
                }
                //If so, just get it's ID
                else
                {
                    cmd = new SqlCommand("SELECT BotId FROM Botanical_Families WHERE Botanical_Family ='" + flower.getBotanicalFamily() + "'", conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BotIdToBeAdded = (int)reader[0];
                        }
                        reader.Close();
                    }
                }

                //Insert the flower names and ID for botanical family
                cmd = new SqlCommand("INSERT INTO Flower (English_Name, Latin_Name, Botanical_Key) VALUES (@param1, @param2, @param3)", conn);
                Console.Out.WriteLine(flower.getEnglishName());
                Console.Out.WriteLine(flower.getLatinName());
                cmd.Parameters.AddWithValue("@param1", flower.getEnglishName());
                cmd.Parameters.AddWithValue("@param2", flower.getLatinName());
                cmd.Parameters.AddWithValue("@param3", BotIdToBeAdded);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                //Get the flower's ID
                cmd = new SqlCommand("SELECT Id FROM Flower WHERE English_Name = '" + flower.getEnglishName() + "' AND Latin_Name = '" + flower.getLatinName() + "'", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        FlowerId = (int)reader[0];
                    }
                    reader.Close();
                }



               
                for (int i = 0; i < flower.pictureList.Count; i++)
                {

                    //add a histogram(binList) into the database
                    //the histogram will have its own auto generated ID
                    

                    //insert command to get into the correct table
                    cmd = new SqlCommand("INSERT INTO Histogram (red_0, green_0, blue_0, red_1, green_1, blue_1, red_2, green_2, blue_2, red_3, green_3, blue_3) VALUES (@param1, @param2, @param3, @param4, @param5, @param6, @param7, @param8, @param9, @param10, @param11, @param12)", conn);


                        //each param will contain a value for a index in the binList
                        //each set of three lines of code are values that correspond to a bin

                        //for example params 1 - 3 correspond the the Red, Green, and Blue values for the bin 0 - 63
                        //the reason why that the values for the indexes are hard coded is because there are 0 values in the binList array
                        //that represent spaces in the gui histogram for visual clarity

                        cmd.Parameters.AddWithValue("@param1", flower.pictureList[i].getBinList()[1]);
                        cmd.Parameters.AddWithValue("@param2", flower.pictureList[i].getBinList()[2]);
                        cmd.Parameters.AddWithValue("@param3", flower.pictureList[i].getBinList()[3]);

                        cmd.Parameters.AddWithValue("@param4", flower.pictureList[i].getBinList()[5]);
                        cmd.Parameters.AddWithValue("@param5", flower.pictureList[i].getBinList()[6]);
                        cmd.Parameters.AddWithValue("@param6", flower.pictureList[i].getBinList()[7]);

                        cmd.Parameters.AddWithValue("@param7", flower.pictureList[i].getBinList()[9]);
                        cmd.Parameters.AddWithValue("@param8", flower.pictureList[i].getBinList()[10]);
                        cmd.Parameters.AddWithValue("@param9", flower.pictureList[i].getBinList()[11]);

                        cmd.Parameters.AddWithValue("@param10", flower.pictureList[i].getBinList()[13]);
                        cmd.Parameters.AddWithValue("@param11", flower.pictureList[i].getBinList()[14]);
                        cmd.Parameters.AddWithValue("@param12", flower.pictureList[i].getBinList()[15]);

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    //grab the histoId from the histogram table
                    cmd = new SqlCommand("SELECT histoId from Histogram", conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {   //assign the histoId to a variable
                            HistoId = (int)reader[0];
                        }
                        reader.Close();
                    }
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    //add the histo id from the Histogram table to the Histo_Id in the Photo table
                    //cmd = new SqlCommand("INSERT INTO Photo (Histo_Id) VALUES (@param3)", conn);
                    
                    //cmd.ExecuteNonQuery();
                   // cmd.Parameters.Clear();

                    //Add the picture, select the Note ID generated with the picture and
                    //add the picture notes with the Note ID generated.
                    cmd = new SqlCommand("INSERT INTO Photo (Photo_Id, Photo, Histo_Id) VALUES (@param1, @param2, @param4)", conn);
                    cmd.Parameters.AddWithValue("@param1", FlowerId);
                    cmd.Parameters.AddWithValue("@param2", flower.pictureList[i].getPath());
                    cmd.Parameters.AddWithValue("@param4", HistoId);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    

                    cmd = new SqlCommand("SELECT Note_Id FROM Photo WHERE Photo_Id = '" + FlowerId + "' AND Photo = '" + flower.pictureList[i].getPath() + "'", conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PhotoNoteId = (int)reader[0];
                        }
                        reader.Close();
                    }
                    cmd.Parameters.Clear();

                    cmd = new SqlCommand("INSERT INTO Photo_Notes (Note_Id, Photo_Note, Date_Added, Photographer, Location) VALUES (@param1, @param2, @param3, @param4, @param5)", conn);
                    cmd.Parameters.AddWithValue("@param1", PhotoNoteId);
                    cmd.Parameters.AddWithValue("@param2", flower.pictureList[i].getNote());
                    //When inserting, and getting for all dates/times, get and store in this format
                    cmd.Parameters.AddWithValue("@param3", flower.pictureList[i].getTimeDate().ToString("MM/dd/yyyy HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@param4", flower.pictureList[i].getPhotographer());
                    cmd.Parameters.AddWithValue("@param5", flower.pictureList[i].getLocation());
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }

                //Add flower note
                cmd = new SqlCommand("INSERT INTO Notes (Flower_Notes, Date_Added) VALUES (@param1, @param2)", conn);
                cmd.Parameters.AddWithValue("@param1", flower.getNote().getNote());
                cmd.Parameters.AddWithValue("@param2", flower.getNote().getTimeDate().ToString("MM/dd/yyyy HH:mm:ss"));
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                conn.Close();
            }
            return true;
        }

        public static List<Flower> getFlowersFromDB()
        {
            int HistoId = -1;

            List<Flower> flowers = new List<Flower>();

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = @"Data Source =(localDB)\MSSQLLocalDB;" +
                                        @"AttachDbFilename = |DataDirectory|\flower_database.mdf;" +
                                        "Integrated Security = True;" +
                                        "Connect Timeout = 30;" +
                                        "MultipleActiveResultSets = True;";
                conn.Open();

                //Select all columns from all rows (Get all the data from the Flower table)
                SqlCommand cmd = new SqlCommand("SELECT * FROM Flower", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    //For each flower...
                    while (reader.Read())
                    {
                        //Get flower note
                        Note note = new Note(new DateTime(), "");
                        Flower flower = new Flower("", "", "", note);
                        SqlCommand cmdNote = new SqlCommand("SELECT Flower_Notes, Date_Added FROM Notes WHERE Note_Id = '" + (int)reader[0] + "'", conn);
                        using (SqlDataReader readerNote = cmdNote.ExecuteReader())
                        {
                            while (readerNote.Read())
                            {
                                note = new Note(DateTime.ParseExact((string)readerNote[1], "MM/dd/yyyy HH:mm:ss", null), readerNote[0].ToString().Trim());
                            }
                            readerNote.Close();
                        }

                        //Get botanical family
                        SqlCommand cmdBot = new SqlCommand("SELECT Botanical_Family FROM Botanical_Families WHERE BotID = '" + (int)reader[3] + "'", conn);
                        using (SqlDataReader readerBot = cmdBot.ExecuteReader())
                        {
                            while (readerBot.Read())
                            {
                                flower = new Flower((string)reader[2].ToString().Trim(), (string)reader[1].ToString().Trim(), (string)readerBot[0].ToString().Trim(), note);
                                flower.setID((int)reader[0]);
                            }
                            readerBot.Close();
                        }

                        //Get picture(s)
                        SqlCommand cmdPhoto = new SqlCommand("SELECT Photo, Note_Id FROM Photo WHERE Photo_Id = '" + (int)reader[0] + "'", conn);
                        using (SqlDataReader readerPhoto = cmdPhoto.ExecuteReader())
                        {
                            while (readerPhoto.Read())
                            {
                                //Get associated picture note and create the picture object
                                SqlCommand cmdPhotoNote = new SqlCommand("SELECT Photo_Note, Date_Added, Photographer, Location FROM Photo_Notes WHERE Note_Id = '" + (int)readerPhoto[1] + "'", conn);
                                using (SqlDataReader readerPhotoNote = cmdPhotoNote.ExecuteReader())
                                {
                                    while (readerPhotoNote.Read())
                                    {
                                        Picture picture = new Picture(DateTime.ParseExact((string)readerPhotoNote[1], "MM/dd/yyyy HH:mm:ss", null), readerPhotoNote[2].ToString().Trim(), readerPhotoNote[3].ToString().Trim(),
                                            readerPhotoNote[0].ToString().Trim(), readerPhoto[0].ToString().Trim());

                                        flower.pictureList.Add(picture);
                                    }
                                    readerPhotoNote.Close();
                                }
                            }
                            readerPhoto.Close();
                        }
                        flowers.Add(flower);
                    }
                    reader.Close();
                }
                conn.Close();
            }

            return flowers;
        }

        public static void modifyFlower(Flower flower)
        {
            int HistoId = -1;

            using (SqlConnection conn = new SqlConnection())
            {
                int BotId = -1;

                conn.ConnectionString = @"Data Source =(localDB)\MSSQLLocalDB;" +
                                        @"AttachDbFilename = |DataDirectory|\flower_database.mdf;" +
                                        "Integrated Security = True;" +
                                        "Connect Timeout = 30;" +
                                        "MultipleActiveResultSets = True;";
                conn.Open();

                //Check for if the new botanical family already exists, if so, get ID
                SqlCommand cmd = new SqlCommand("SELECT BotId FROM Botanical_families WHERE Botanical_Family = '" + flower.getBotanicalFamily() + "'", conn);
                cmd.Connection = conn;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        BotId = (int)reader[0];
                    }
                    reader.Close();
                }
                cmd.Parameters.Clear();

                //If not insert, and get ID
                if (BotId < 0)
                {
                    cmd = new SqlCommand("INSERT INTO Botanical_Families (Botanical_Family) VALUES (@param1)", conn);
                    cmd.Parameters.AddWithValue("@param1", flower.getBotanicalFamily());

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    cmd = new SqlCommand("SELECT BotId FROM Botanical_families WHERE Botanical_Family = '" + flower.getBotanicalFamily() + "'", conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BotId = (int)reader[0];
                        }
                        reader.Close();
                    }
                    cmd.Parameters.Clear();
                }

                //Update flower
                cmd = new SqlCommand("UPDATE Flower SET English_Name = @param1, Latin_Name = @param2, Botanical_Key = @param3 WHERE Id = '" + flower.getID() + "'", conn);
                cmd.Parameters.AddWithValue("@param1", flower.getEnglishName());
                cmd.Parameters.AddWithValue("@param2", flower.getLatinName());
                cmd.Parameters.AddWithValue("@param3", BotId);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                //Get the picture and picture note ID from the database and check if exists in new flower
                cmd = new SqlCommand("SELECT Photo, Note_Id FROM Photo WHERE Photo_Id = '" + flower.getID() + "'", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bool check = false;

                        for (int i = 0; i < flower.pictureList.Count; i++)
                        {
                            if (reader[0].ToString().Trim() == flower.pictureList[i].getPath())
                            {
                                check = true;
                            }
                        }

                        //If picture not found in new flower, delete it and it's note
                        if (!check)
                        {
                            SqlCommand cmdDelete = new SqlCommand("Delete FROM Photo_Notes WHERE Note_Id = '" + reader[1] + "'", conn);
                            cmdDelete.ExecuteNonQuery();

                            cmdDelete = new SqlCommand("DELETE FROM Photo WHERE Photo = '" + reader[0] + "'", conn);
                            cmdDelete.ExecuteNonQuery();
                        }
                    }
                    reader.Close();
                }
                cmd.Parameters.Clear();

                //Go though new pictures and check if they exist in the database
                for (int i = 0; i < flower.pictureList.Count; i++)
                {
                    bool check = false;
                    int noteID = -1;
                    cmd = new SqlCommand("SELECT Photo, Note_Id FROM Photo WHERE Photo_Id = '" + flower.getID() + "'", conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (flower.pictureList[i].getPath() == reader[0].ToString().Trim())
                            {
                                check = true;
                            }

                            noteID = (int)reader[1];
                        }
                        reader.Close();
                    }

                    //if it doesn't exist, add it and it's note
                    if (!check)
                    {
                        //add a histogram(binList) into the database
                        //the histogram will have its own auto generated ID


                        //insert command to get into the correct table
                        cmd = new SqlCommand("INSERT INTO Histogram (red_0, green_0, blue_0, red_1, green_1, blue_1, red_2, green_2, blue_2, red_3, green_3, blue_3) VALUES (@param1, @param2, @param3, @param4, @param5, @param6, @param7, @param8, @param9, @param10, @param11, @param12)", conn);


                        //each param will contain a value for a index in the binList
                        //each set of three lines of code are values that correspond to a bin

                        //for example params 1 - 3 correspond the the Red, Green, and Blue values for the bin 0 - 63
                        //the reason why that the values for the indexes are hard coded is because there are 0 values in the binList array
                        //that represent spaces in the gui histogram for visual clarity

                        cmd.Parameters.AddWithValue("@param1", flower.pictureList[i].getBinList()[1]);
                        cmd.Parameters.AddWithValue("@param2", flower.pictureList[i].getBinList()[2]);
                        cmd.Parameters.AddWithValue("@param3", flower.pictureList[i].getBinList()[3]);

                        cmd.Parameters.AddWithValue("@param4", flower.pictureList[i].getBinList()[5]);
                        cmd.Parameters.AddWithValue("@param5", flower.pictureList[i].getBinList()[6]);
                        cmd.Parameters.AddWithValue("@param6", flower.pictureList[i].getBinList()[7]);

                        cmd.Parameters.AddWithValue("@param7", flower.pictureList[i].getBinList()[9]);
                        cmd.Parameters.AddWithValue("@param8", flower.pictureList[i].getBinList()[10]);
                        cmd.Parameters.AddWithValue("@param9", flower.pictureList[i].getBinList()[11]);

                        cmd.Parameters.AddWithValue("@param10", flower.pictureList[i].getBinList()[13]);
                        cmd.Parameters.AddWithValue("@param11", flower.pictureList[i].getBinList()[14]);
                        cmd.Parameters.AddWithValue("@param12", flower.pictureList[i].getBinList()[15]);

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                        //grab the histoId from the histogram table
                        cmd = new SqlCommand("SELECT histoId from Histogram", conn);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {   //assign the histoId to a variable
                                HistoId = (int)reader[0];
                            }
                            reader.Close();
                        }
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                        cmd = new SqlCommand("INSERT INTO Photo (Photo_Id, Photo, Histo_Id) VALUES (@param1, @param2, @param3)", conn);
                        cmd.Parameters.AddWithValue("@param1", flower.getID());
                        cmd.Parameters.AddWithValue("@param2", flower.pictureList[i].getPath());
                        cmd.Parameters.AddWithValue("@param3", HistoId);

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                        int PhotoNoteId = 0;
                        cmd = new SqlCommand("SELECT Note_Id FROM Photo WHERE Photo_Id = '" + flower.getID() + "' AND Photo = '" + flower.pictureList[i].getPath() + "'", conn);
                        using (SqlDataReader readerNote = cmd.ExecuteReader())
                        {
                            while (readerNote.Read())
                            {
                                PhotoNoteId = (int)readerNote[0];
                            }
                            readerNote.Close();
                        }
                        cmd.Parameters.Clear();
                        Console.WriteLine(PhotoNoteId);

                        Console.WriteLine(flower.getID());
                        Console.WriteLine(flower.pictureList[i].getPath());

                        cmd = new SqlCommand("INSERT INTO Photo_Notes (Note_Id, Photo_Note, Date_Added, Photographer, Location) VALUES (@param1, @param2, @param3, @param4, @param5)", conn);
                        cmd.Parameters.AddWithValue("@param1", PhotoNoteId);
                        cmd.Parameters.AddWithValue("@param2", flower.pictureList[i].getNote());
                        cmd.Parameters.AddWithValue("@param3", flower.pictureList[i].getTimeDate().ToString("MM/dd/yyyy HH:mm:ss"));
                        cmd.Parameters.AddWithValue("@param4", flower.pictureList[i].getPhotographer());
                        cmd.Parameters.AddWithValue("@param5", flower.pictureList[i].getLocation());
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    //If it does, only update it's note
                    else
                    {
                        cmd = new SqlCommand("UPDATE Photo_Notes SET Photo_Note = @param1, Date_Added = @param2, Photographer = @param3, Location = @param4 WHERE Note_Id = '" + noteID + "'", conn);
                        cmd.Parameters.AddWithValue("@param1", flower.pictureList[i].getNote());
                        cmd.Parameters.AddWithValue("@param2", flower.pictureList[i].getTimeDate().ToString("MM/dd/yyyy HH:mm:ss"));
                        cmd.Parameters.AddWithValue("@param3", flower.pictureList[i].getPhotographer());
                        cmd.Parameters.AddWithValue("@param4", flower.pictureList[i].getLocation());
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                }

                //Update flower's note
                cmd = new SqlCommand("UPDATE Notes SET Flower_Notes = @param1, Date_Added = @param2 WHERE Note_Id = '" + flower.getID() + "'", conn);
                cmd.Parameters.AddWithValue("@param1", flower.getNote().getNote());
                cmd.Parameters.AddWithValue("@param2", flower.getNote().getTimeDate().ToString("MM/dd/yyyy HH:mm:ss"));
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                conn.Close();
            }
        }

        public static void deleteFlower(Flower flower)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = @"Data Source =(localDB)\MSSQLLocalDB;" +
                                        @"AttachDbFilename = |DataDirectory|\flower_database.mdf;" +
                                        "Integrated Security = True;" +
                                        "Connect Timeout = 30;" +
                                        "MultipleActiveResultSets = True;";
                conn.Open();

                //Delete notes
                SqlCommand cmdDelete = new SqlCommand("DELETE FROM Notes WHERE Note_Id = '" + flower.getID() + "'", conn);
                cmdDelete.ExecuteNonQuery();

                //Go through each picture and delete it's note
                SqlCommand cmd = new SqlCommand("SELECT Note_Id FROM Photo WHERE Photo_Id = '" + flower.getID() + "'", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmdDelete = new SqlCommand("DELETE FROM Photo_Notes WHERE Note_Id = '" + reader[0] + "'", conn);
                        cmdDelete.ExecuteNonQuery();
                    }
                    reader.Close();
                }

                //Delete pictures
                cmdDelete = new SqlCommand("DELETE FROM Photo WHERE Photo_Id = '" + flower.getID() + "'", conn);
                cmdDelete.ExecuteNonQuery();

                //Delete flower
                cmdDelete = new SqlCommand("DELETE FROM Flower WHERE Id = '" + flower.getID() + "'", conn);
                cmdDelete.ExecuteNonQuery();

                conn.Close();
            }
        }

        private static SqlConnection InitializeConnection()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connString;

                return conn;
            }
        }

        public static bool checkUserAuth(ref User userData)
        {
            bool validUser = false;
            string user;
            String pass;
            String salt;
            String testPass;
            int id;

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connString;
                conn.Open();

                SqlCommand loginCommand = new SqlCommand("SELECT Id, user_name, password, salt FROM users", conn);
                using (SqlDataReader reader = loginCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = (int)reader[0];
                        user = reader[1].ToString().Trim();
                        pass = reader[2].ToString().Trim();
                        salt = reader[3].ToString().Trim();
                        testPass = SaltedHashbrowns.GenerateSHA256Hash(userData.getPass(), salt);

                        if (userData.getUserName().Equals(user) && testPass.Equals(pass))
                        {
                            getUserData(id, ref userData);
                            validUser = true;
                        }
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return validUser;
        }
        //****************************************************//
        //Developer: Sean Mathews*****************************//
        //****************************************************//

        //get the binList from the DB
        public static List<Tuple<int,int[]>> GetBinList()
        {
            //the list to return
            List<Tuple<int, int[]>> photoSearchList = new List<Tuple<int, int[]>>();

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connString;
                conn.Open();

               

                List<int[]> photoBinList = new List<int[]>();

                List<int> photoIdList = new List<int>();

                //going to return a list of int ids for each flower that corresponds to a flower


                //add the photo ids into one list
                SqlCommand photoCommand = new SqlCommand("SELECT Photo_Id FROM Photo", conn);
                using (SqlDataReader photoIdReader = photoCommand.ExecuteReader())
                {
                    int photoId;

                    while (photoIdReader.Read())
                    {
                        photoId = (int)photoIdReader[0];
                        photoIdList.Add(photoId);
                    }
                }

                //add the binList stuff into another list
                SqlCommand binListCommand = new SqlCommand("SELECT red_0, green_0, blue_0, red_1, green_1, blue_1, red_2, green_2, blue_2, red_3, green_3, blue_3 FROM Histogram", conn);

                using (SqlDataReader binListReader = binListCommand.ExecuteReader())
                {
                    int red0;
                    int green0;
                    int blue0;

                    int red1;
                    int green1;
                    int blue1;

                    int red2;
                    int green2;
                    int blue2;

                    int red3;
                    int green3;
                    int blue3;

                    

                    while (binListReader.Read())
                    {
                       
                        red0 = (int)binListReader[0];
                        green0 = (int)binListReader[1];
                        blue0 = (int)binListReader[2];
                        red1 = (int)binListReader[3];
                        green1 = (int)binListReader[4];
                        blue1 = (int)binListReader[5];
                        red2 = (int)binListReader[6];
                        green2 = (int)binListReader[7];
                        blue2 = (int)binListReader[8];
                        red3 = (int)binListReader[9];
                        green3 = (int)binListReader[10];
                        blue3 = (int)binListReader[11];
                       int[] currBinList = new int[17]{0, red0, green0, blue0, 0, red1, green1, blue1, 0, red2, green2, blue2, 0, red3, green3, blue3, 0};

                        photoBinList.Add(currBinList);
                       
                    }

                    for (int i = 0; i < photoBinList.Count; i++)
                    {
                        //searchListLatinName.Add(new Tuple<int, string>(1, "RoseLatinName"));
                        photoSearchList.Add(new Tuple<int, int[]>(photoIdList[i], photoBinList[i]));
                    }
                }
            }

            return photoSearchList;

        }
        //****************************************************//
        //Developer: Sean Mathews*****************************//
        //****************************************************//
        public static List<Tuple<int, string>> getEnglishNameList()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connString;
                conn.Open();

                //connection is open

                //make the list to return
                List<Tuple<int, string>> searchList = new List<Tuple<int, string>>();

                //get the sql command to select the correct table
                SqlCommand searchEnglishNameCommand = new SqlCommand("SELECT Id, English_Name FROM Flower", conn);

                //read the column and add it to the search list
                using (SqlDataReader englishNameReader = searchEnglishNameCommand.ExecuteReader())

                {
                    int flowerId;
                    string englishName;

                    while (englishNameReader.Read())
                    {
                        //fill the array

                        flowerId = (int)englishNameReader[0];
                        englishName = englishNameReader[1].ToString().Trim();

                        searchList.Add(new Tuple<int, string>(flowerId, englishName));

                    }
                }
                return searchList;
            }



        }

        //****************************************************//
        //Developer: Sean Mathews*****************************//
        //****************************************************//
        public static List<Tuple<int, string>> getLatinNameList()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connString;
                conn.Open();

                //connection is open

                //make the list to return

                List<Tuple<int, string>> searchList = new List<Tuple<int, string>>();

                //get the sql command to select the correct table
                SqlCommand searchLatinNameCommand = new SqlCommand("SELECT Id, Latin_Name FROM Flower", conn);



                //read the column and add it to the search list
                using (SqlDataReader englishLatinReader = searchLatinNameCommand.ExecuteReader())

                {
                    int flowerId;
                    string latinName;
                    while (englishLatinReader.Read())
                    {
                        //fill the array

                        flowerId = (int)englishLatinReader[0];
                        latinName = englishLatinReader[1].ToString().Trim();

                        searchList.Add(new Tuple<int, string>(flowerId, latinName));

                    }
                }
                return searchList;
            }

        }

        //****************************************************//
        //Developer: Sean Mathews*****************************//
        //****************************************************//
        public static List<int> getBotanicalFamilyList(string searchedBotanicalFamily)
        {
            //a special thing to note about this function is that the search function in the search controller
            //isnt necessary here because we just find all the flowers associated to a particular family, so this gets passed in
            //a botanical family 

            //so pass in the family, and find that specific family in the botanical family table

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connString;
                conn.Open();

                int flowerId;
                string flower;
                int botanicalKey;




                int botId;
                string botFamily;
                //connection is open

                //make the list to return

                List<int> searchList = new List<int>();
                List<Tuple<int, string>> botanicalFamilyList = new List<Tuple<int, string>>();

                //get the sql command to select the correct table
                SqlCommand searchEnglishNameCommand = new SqlCommand("SELECT * FROM Botanical_Families", conn);

                //read the column and add it to the search list
                using (SqlDataReader botFamiyReader = searchEnglishNameCommand.ExecuteReader())

                {

                    //first get the botanical family keys and families, and use those families to find how many flowers match to each family
                    while (botFamiyReader.Read())
                    {
                        //if you are the right family add it to the list

                        botId = (int)botFamiyReader[0];
                        botFamily = botFamiyReader[1].ToString().Trim();

                        if (searchedBotanicalFamily == botFamily)
                        {
                            botanicalFamilyList.Add(new Tuple<int, string>(botId, botFamily));
                        }

                        
                    }



                }

                SqlCommand flowerFinderCommand = new SqlCommand("SELECT Id, Botanical_Key FROM Flower", conn);
                using (SqlDataReader flowerReader = flowerFinderCommand.ExecuteReader())
                {

                    while (flowerReader.Read())
                    {
                        flowerId = (int)flowerReader[0];
                        botanicalKey = (int)flowerReader[1];

                        if (botanicalKey == botanicalFamilyList[0].Item1)
                        {
                            searchList.Add(flowerId);
                        }
                        
                    }



                }
                return searchList;
            }


        }
        //}




        public static List<User> getUsers()
        {
            List<User> users = new List<User>();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connString;
                conn.Open();

                SqlCommand userCommand = new SqlCommand("SELECT * FROM users", conn);
                using (SqlDataReader reader = userCommand.ExecuteReader())
                {
                    int count = 0;
                    while (reader.Read())
                    {
                        users.Add(new User());
                        users[count].setUID((int)reader[0]);
                        users[count].setFirst(reader[1].ToString().Trim());
                        users[count].setLast(reader[2].ToString().Trim());
                        users[count].setUserName(reader[3].ToString().Trim());
                        users[count].setLevel((int)reader[5]);
                        count++;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return users;
        }

        public static void getUserData(int uid, ref User userData)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connString;
                conn.Open();

                SqlCommand getUserCommand = new SqlCommand("SELECT * FROM users WHERE Id IN (" + uid + ")", conn);
                using (SqlDataReader reader = getUserCommand.ExecuteReader())
                {
                    int id = -1;
                    string first = "";
                    string last = "";
                    string userName = "";
                    int access = -1;

                    while (reader.Read())
                    {
                        id = (int)reader[0];
                        first = reader[1].ToString().Trim();
                        last = reader[2].ToString().Trim();
                        userName = reader[3].ToString().Trim();
                        access = (int)reader[5];
                    }
                    reader.Close();

                    userData.setCurrentUser(id, userName, first, last, access);
                    conn.Close();
                }
            }
        }

        public static bool inputUser(ref User userData)
        {
            bool duplicate = false;

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connString;

                conn.Open();

                SqlCommand userCommand = new SqlCommand("SELECT user_name, password FROM users", conn);
                using (SqlDataReader reader = userCommand.ExecuteReader())
                {
                    string user;
                    string pass;

                    while (reader.Read())
                    {
                        user = reader[0].ToString().Trim().ToLower();
                        pass = reader[1].ToString().Trim();

                        if (userData.getUserName().Equals(user) ||
                            userData.getPass().Equals(pass))
                        {
                            duplicate = true;
                            Console.WriteLine("DUPLICATE FOUND!");
                        }
                    }
                    reader.Close();
                }

                if (!duplicate)
                {
                    String salt = SaltedHashbrowns.CreateSalt(15);
                    String hashedPassword = SaltedHashbrowns.GenerateSHA256Hash(userData.getPass(), salt);

                    SqlCommand cmd = new SqlCommand("INSERT INTO users (first, last, user_name, password, access, salt) " +
                        "VALUES (@param1, @param2, @param3, @param4, @param5, @param6)", conn);
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@param1", userData.getFirst());
                    cmd.Parameters.AddWithValue("@param2", userData.getLast());
                    cmd.Parameters.AddWithValue("@param3", userData.getUserName());
                    cmd.Parameters.AddWithValue("@param4", hashedPassword);
                    cmd.Parameters.AddWithValue("@param5", userData.getLevel());
                    cmd.Parameters.AddWithValue("@param6", salt);

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
                
            }

        }

        internal static bool deleteUser(int id)
        {
            bool del = false;
            int test;

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connString;
                conn.Open();

                SqlCommand delCommand = new SqlCommand("DELETE FROM users WHERE Id =" + id, conn);
                test = delCommand.ExecuteNonQuery();
                if (test >= 1)
                {
                    del = true;
                }
            }
            return del;
        }

        //Database function for addBatchUsers
        internal static bool batchAddUsers(List<User> usersToAdd)
        {
            int count = 0;
            String salt;
            String hashedPass;

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connString;

                conn.Open();

                //foreach user in the usersToAdd list (Excel sheet)
                foreach (var User in usersToAdd)
                {
                    //Create salt for each user
                    salt = SaltedHashbrowns.CreateSalt(15);
                    //Create a hashed pass based on what the user wants their pass to be and a random salt.
                    hashedPass = SaltedHashbrowns.GenerateSHA256Hash(usersToAdd[count].getPass(), salt);

                    //Insert each users data into the database based on what's inside the Excel sheet.
                    SqlCommand cmd = new SqlCommand("INSERT INTO users (first, last, user_name, password, access, salt) " +
                        "VALUES (@param1, @param2, @param3, @param4, @param5, @param6)", conn);
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@param1", usersToAdd[count].getFirst());
                    cmd.Parameters.AddWithValue("@param2", usersToAdd[count].getLast());
                    cmd.Parameters.AddWithValue("@param3", usersToAdd[count].getUserName());
                    cmd.Parameters.AddWithValue("@param4", hashedPass);
                    cmd.Parameters.AddWithValue("@param5", usersToAdd[count].getLevel());
                    cmd.Parameters.AddWithValue("@param6", salt);
                    cmd.ExecuteNonQuery();
                    count++;
                }
                conn.Close();
            }
            return true;
        }

        internal static bool editUserData(ref User userData)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connString;

                conn.Open();
                String pwd = userData.getPass();

                if (pwd.Equals(""))
                {
                    SqlCommand cmd0 = new SqlCommand("UPDATE users SET first = @param1, last = @param2, user_name = @param3, access = @param5 WHERE Id = @param6", conn);
                    cmd0.Connection = conn;
                    cmd0.Parameters.AddWithValue("@param1", userData.getFirst());
                    cmd0.Parameters.AddWithValue("@param2", userData.getLast());
                    cmd0.Parameters.AddWithValue("@param3", userData.getUserName());
                    cmd0.Parameters.AddWithValue("@param5", userData.getLevel());
                    cmd0.Parameters.AddWithValue("@param6", userData.getUID());

                    cmd0.ExecuteNonQuery();
                    cmd0.Parameters.Clear();
                }
                else
                {
                    String salt = SaltedHashbrowns.CreateSalt(15);
                    String hashedPassword = SaltedHashbrowns.GenerateSHA256Hash(userData.getPass(), salt);
                    pwd = hashedPassword;

                    SqlCommand cmd = new SqlCommand("UPDATE users SET first = @param1, last = @param2, user_name = @param3, password = @param4, access = @param5, salt = @param6 WHERE Id = @param7", conn);
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@param1", userData.getFirst());
                    cmd.Parameters.AddWithValue("@param2", userData.getLast());
                    cmd.Parameters.AddWithValue("@param3", userData.getUserName());
                    cmd.Parameters.AddWithValue("@param4", pwd);
                    cmd.Parameters.AddWithValue("@param5", userData.getLevel());
                    cmd.Parameters.AddWithValue("@param6", salt);
                    cmd.Parameters.AddWithValue("@param7", userData.getUID());

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                conn.Close();
                return true;
            }
        }

        public static Flower getFlowerById(int selectedId)
        {
            Note note1 = new Note(new DateTime(), "");
            Flower flower = new Flower("","","",note1);

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = andrewsSpecialConnectionString;
                                        
                conn.Open();

                //Select all columns from all rows (Get all the data from the Flower table)
                SqlCommand cmd = new SqlCommand("SELECT * FROM Flower WHERE Id = @param1", conn);
                cmd.Parameters.AddWithValue("@param1", selectedId);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    //For each flower...
                    while (reader.Read())
                    {
                        //Get flower note
                        Note note = new Note(new DateTime(), "");
                        flower = new Flower("", "", "", note);
                        SqlCommand cmdNote = new SqlCommand("SELECT Flower_Notes, Date_Added FROM Notes WHERE Note_Id = '" + (int)reader[0] + "'", conn);
                        using (SqlDataReader readerNote = cmdNote.ExecuteReader())
                        {
                            while (readerNote.Read())
                            {
                                note = new Note(DateTime.ParseExact((string)readerNote[1], "MM/dd/yyyy HH:mm:ss", null), readerNote[0].ToString().Trim());
                            }
                            readerNote.Close();
                        }

                        //Get botanical family
                        SqlCommand cmdBot = new SqlCommand("SELECT Botanical_Family FROM Botanical_Families WHERE BotID = '" + (int)reader[3] + "'", conn);
                        using (SqlDataReader readerBot = cmdBot.ExecuteReader())
                        {
                            while (readerBot.Read())
                            {
                                flower = new Flower((string)reader[2].ToString().Trim(), (string)reader[1].ToString().Trim(), (string)readerBot[0].ToString().Trim(), note);
                                flower.setID((int)reader[0]);
                            }
                            readerBot.Close();
                        }

                        //Get picture(s)
                        SqlCommand cmdPhoto = new SqlCommand("SELECT Photo, Note_Id FROM Photo WHERE Photo_Id = '" + (int)reader[0] + "'", conn);
                        using (SqlDataReader readerPhoto = cmdPhoto.ExecuteReader())
                        {
                            while (readerPhoto.Read())
                            {
                                //Get associated picture note and create the picture object
                                SqlCommand cmdPhotoNote = new SqlCommand("SELECT Photo_Note, Date_Added, Photographer, Location FROM Photo_Notes WHERE Note_Id = '" + (int)readerPhoto[1] + "'", conn);
                                using (SqlDataReader readerPhotoNote = cmdPhotoNote.ExecuteReader())
                                {
                                    while (readerPhotoNote.Read())
                                    {
                                        Picture picture = new Picture(DateTime.ParseExact((string)readerPhotoNote[1], "MM/dd/yyyy HH:mm:ss", null), readerPhotoNote[2].ToString().Trim(), readerPhotoNote[3].ToString().Trim(),
                                            readerPhotoNote[0].ToString().Trim(), readerPhoto[0].ToString().Trim());

                                        flower.pictureList.Add(picture);
                                    }
                                    readerPhotoNote.Close();
                                }
                            }
                            readerPhoto.Close();
                        }
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return flower;
        }
    }
}


//for (int i = 0; i < userList.Count; i++)
//{
//    if ((userData.getUserName() == userList[i].getUserName()) || (userData.getPass() == userList[i].getPass()))
//    {
//        duplicate = true;
//    }
//}

//if (!duplicate)
//{
//    userList.Add(userData);

//    foreach (var User in userList)
//    {
//        Console.WriteLine(User.getFirst());
//        Console.WriteLine(User.getLast());
//        Console.WriteLine(User.getUserName());
//        Console.WriteLine(User.getPass());
//    }
//    return true;
//}
//else
//{
//    return false;
//}



