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

namespace apared5hw6{
    public partial class ctaForm : Form{
        public ctaForm(){
            InitializeComponent();
        }

        // function to clear all labels, list boxes, and text boxes 
        private void resetObjectsAll(){
            stationsListBox.Items.Clear();
            stopsListBox.Items.Clear();
            linesListBox.Items.Clear();
            totalRidershipTextBox.Clear();
            averageRidershipTextBox.Clear();
            percentRidershipTextBox.Clear();
            weekdayTextBox.Clear();
            saturdayTextBox.Clear();
            sundayHolidayTextBox.Clear();
            handicapTextBox.Clear();
            directionOfTravelTextBox.Clear();
            locationTextBox.Clear();
            numStationsTextBox.Clear();
        }//end resetObjectsAll()

        // function to clear all labels, list boxes, and text boxes excluding the stations list box
        private void resetObjectsNotStations(){
            //stationsListBox.Items.Clear();
            stopsListBox.Items.Clear();
            linesListBox.Items.Clear();
            totalRidershipTextBox.Clear();
            averageRidershipTextBox.Clear();
            percentRidershipTextBox.Clear();
            weekdayTextBox.Clear();
            saturdayTextBox.Clear();
            sundayHolidayTextBox.Clear();
            handicapTextBox.Clear();
            directionOfTravelTextBox.Clear();
            locationTextBox.Clear();
            //numStationsTextBox.Clear();
        }//end resetObjectsNotStations()

        // function to clear all labels, list boxes, and text boxes excluding the stations and stops list box
        private void resetObjectsNotStops(){
            //stationsListBox.Items.Clear();
            //stopsListBox.Items.Clear();
            linesListBox.Items.Clear();
            //totalRidershipTextBox.Clear();
            //averageRidershipTextBox.Clear();
            //percentRidershipTextBox.Clear();
            //weekdayTextBox.Clear();
            //saturdayTextBox.Clear();
            //sundayHolidayTextBox.Clear();
            handicapTextBox.Clear();
            directionOfTravelTextBox.Clear();
            locationTextBox.Clear();
            //numStationsTextBox.Clear();
        }//end resetObjectsNotStops()

        /* button "Load File"
         * Updates the "Stations" list box with names of stations in alphabetical order
         * Updates the "Stops" list box with the names of stops in alphabetical order of the selected station
         * Updates the "Number of Stations" label with updated number of stations from the database
         * */
        private void loadFile_Click(object sender, EventArgs e){
            string filename, version, connectionInfo;
            SqlConnection dataBase;

            version = "MSSQLLocalDB";
            filename = "CTA.mdf";
            //sets up a connection to the database
            connectionInfo = String.Format(@"
                            Data Source = (LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Integrated Security=True;", version, filename);

            //clear all of the objects on the form
            resetObjectsAll();

            //open the connection
            dataBase = new SqlConnection(connectionInfo);
            dataBase.Open();

            //get the whole table as a string and order it alphabetically by name
            string sortedStations = string.Format(@"
                Select      *
                From        Stations
                Order by    Name
            ");

            //create an sql command and set the connection
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dataBase;

            //create an adapter to represent the command
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();

            cmd.CommandText = sortedStations;
            adapter.Fill(dataSet);

            //populate the list box with station names
            foreach (DataRow row in dataSet.Tables["TABLE"].Rows){
                string station = string.Format("{0}",
                    Convert.ToString(row["Name"]));
                this.stationsListBox.Items.Add(station);
            }

            //get the count of number of stations as a string
            string numberOfStations = string.Format(@"
                Select  Count(*)
                From    Stations
            ");

            //update the command with the new sql string
            cmd.CommandText = numberOfStations;
            numStationsTextBox.Text += cmd.ExecuteScalar();

            //close the connection
            dataBase.Close();
        }//end loadFile_Click(...)

        /* reference to the currently selected item in the "Stations" list box
         * Update Total Rideship text box
         * Update Average Rideship text box
         * Update Percent Rideship text box
         * Update Weekday text box
         * Update Saturday text box
         * Update Sunday/Holiday text box
         * Update "Stops" list box with the names of stops for that station
        */
        private void stationsListBox_SelectedIndexChanged(object sender, EventArgs e){
            //clear objects
            resetObjectsNotStations();
            //string holding the selected item in the list box
            string selectedStation = Convert.ToString(stationsListBox.SelectedItem);
            //replace a single quote with two single quotes
            selectedStation = selectedStation.Replace("'", "''");

            string filename, version, connectionInfo;
            SqlConnection dataBase;

            version = "MSSQLLocalDB";
            filename = "CTA.mdf";
            //sets up a connection to the database
            connectionInfo = String.Format(@"
                            Data Source = (LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Integrated Security=True;", version, filename);

            //open the connection
            dataBase = new SqlConnection(connectionInfo);
            dataBase.Open();

            //get the names of the stops for the selected station in alphabetical order as a string
            string sortedStops = string.Format(@"
                Select Stops.Name
                From Stops
                Inner Join Stations
                On Stops.StationID = Stations.StationID
                Where Stations.Name = '{0}'
                Order By Stops.Name
            ", selectedStation);

            //create an sql command and set the connection
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dataBase;
            //create an adapter to represent the command
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            cmd.CommandText = sortedStops;
            adapter.Fill(dataSet);

            //populate the list box with station names
            foreach (DataRow row in dataSet.Tables["TABLE"].Rows){
                string stop = string.Format("{0}",
                    Convert.ToString(row["Name"]));
                this.stopsListBox.Items.Add(stop);
            }

            //total ridership
            //get the sum of the daily totals for the selected station as a string
            string totalRidership = string.Format(@"
                Select Sum(DailyTotal)
                From Riderships
                Inner Join Stations
                On Riderships.StationID = Stations.StationID
                Where Stations.Name = '{0}'
            ", selectedStation);
            cmd.CommandText = totalRidership;
            //used for percent
            Int64 totalCurrent = Convert.ToInt64(cmd.ExecuteScalar());
            totalRidershipTextBox.Text += cmd.ExecuteScalar();

            //average ridership
            //get the daily average of the riderships
            string averageRidership = string.Format(@"
                Select AVG(DailyTotal)
                From Riderships
                Inner Join Stations
                On Riderships.StationID = Stations.StationID
                Where Stations.Name = '{0}'
            ", selectedStation);
            cmd.CommandText = averageRidership;
            averageRidershipTextBox.Text += cmd.ExecuteScalar() + "/day";

            //percent ridership
            string totalAll = string.Format(@"
                Select Sum(Cast(DailyTotal as bigint))
                From Riderships
            ");
            cmd.CommandText = totalAll;
            percentRidershipTextBox.Text += Math.Round((Convert.ToDouble(Convert.ToInt64(totalCurrent)) / Convert.ToDouble(Convert.ToInt64(cmd.ExecuteScalar())) * 100), 2) + "%";

            //weekday
            string weekday = string.Format(@"
                Select Sum(DailyTotal)
                From Riderships
                Inner Join Stations
                On Riderships.StationID = Stations.StationID
                Where Stations.Name = '{0}'
                And TypeOfDay = 'W'
            ", selectedStation);
            cmd.CommandText = weekday;
            weekdayTextBox.Text += cmd.ExecuteScalar();

            //saturday
            string saturday = string.Format(@"
                Select Sum(DailyTotal)
                From Riderships
                Inner Join Stations
                On Riderships.StationID = Stations.StationID
                Where Stations.Name = '{0}'
                And TypeOfDay = 'A'
            ", selectedStation);
            cmd.CommandText = saturday;
            saturdayTextBox.Text += cmd.ExecuteScalar();

            //sunday holiday
            string sundayHoliday = string.Format(@"
                Select Sum(DailyTotal)
                From Riderships
                Inner Join Stations
                On Riderships.StationID = Stations.StationID
                Where Stations.Name = '{0}'
                And TypeOfDay = 'U'
            ", selectedStation);
            cmd.CommandText = sundayHoliday;
            sundayHolidayTextBox.Text += cmd.ExecuteScalar();

            dataBase.Close();
        }//end stationsListBox_SelectedIndexChanged(...)

        /* reference to the currently selected item in the "Stops" list box
         * Update Handicap text box
         * Update Direction of Travel text box
         * Update Location text box
         * Update "Lines" list box with the color of the LineID for that stop
        */
        private void stopsListBox_SelectedIndexChanged(object sender, EventArgs e){
            //clear objects
            resetObjectsNotStops();
            //string holding the selected item in the list box
            string selectedStop = Convert.ToString(stopsListBox.SelectedItem);
            //replace a single quote with two single quotes
            selectedStop = selectedStop.Replace("'", "''");

            string filename, version, connectionInfo;
            SqlConnection dataBase;

            version = "MSSQLLocalDB";
            filename = "CTA.mdf";
            //sets up a connection to the database
            connectionInfo = String.Format(@"
                            Data Source = (LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Integrated Security=True;", version, filename);

            //open the connection
            dataBase = new SqlConnection(connectionInfo);
            dataBase.Open();

            //get the boolean value of handicap accessibility for the selected stop as a string
            string handicap = string.Format(@"
                Select ADA
                From Stops
                Where Name = '{0}'
            ", selectedStop);

            //create an sql command and set the connection
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dataBase;
            //create an adapter to represent the command
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            cmd.CommandText = handicap;
            adapter.Fill(dataSet);
            if (Convert.ToBoolean(cmd.ExecuteScalar()))
                handicapTextBox.Text += "YES";
            else
                handicapTextBox.Text += "NO";

            //get the direction of travel for the selected stop as a string
            string direction = string.Format(@"
                Select Direction
                From Stops
                Where Name = '{0}'
            ", selectedStop);
            cmd.CommandText = direction;
            directionOfTravelTextBox.Text += cmd.ExecuteScalar();

            //get the latitude for the selected stop as a string
            string latitude = string.Format(@"
                Select Latitude
                From Stops
                Where Name = '{0}'
            ", selectedStop);
            cmd.CommandText = latitude;
            string latitudeString = Convert.ToString(cmd.ExecuteScalar());

            //get the longitude for the selected stop as a string
            string longitude = string.Format(@"
                Select Longitude
                From Stops
                Where Name = '{0}'
            ", selectedStop);
            cmd.CommandText = longitude;
            string longitudeString = Convert.ToString(cmd.ExecuteScalar());

            locationTextBox.Text += "(" + latitudeString + ", " + longitudeString + ")";

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = dataBase;
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            DataSet dataSet2 = new DataSet();

            string stopID = string.Format(@"
                Select StopID
                From Stops
                Where Stops.Name = '{0}'
            ", selectedStop);
            cmd.CommandText = stopID;
            string stopIDString = Convert.ToString(cmd.ExecuteScalar());

            //update the lines list box
            string lines = string.Format(@"
                Select Lines.Color
                From Lines
                Inner Join StopDetails
                On Lines.LineID = StopDetails.LineID
                Where StopDetails.StopID = '{0}'
                Order By Lines.Color
            ", stopIDString);
            cmd2.CommandText = lines;
            adapter2.Fill(dataSet2);

            //populate the list box with color names
            foreach (DataRow row in dataSet2.Tables["TABLE"].Rows){
                string color = string.Format("{0}",
                    Convert.ToString(row["Color"]));
                this.linesListBox.Items.Add(color);
            }

            dataBase.Close();
        }//end stopsListBox_SelectedIndexChanged(...)

        /* button "Top 10"
        * Updates the "Stations" list box with names of top ten stations with the most riderships
        * Updates the "Stops" list box with the names of stops in alphabetical order of the selected station
        * Updates the "Number of Stations label with updated number of stations from the database
        * */
        private void top10Button_Click(object sender, EventArgs e){
            //clear all objects
            resetObjectsAll();

            string filename, version, connectionInfo;
            SqlConnection dataBase;

            version = "MSSQLLocalDB";
            filename = "CTA.mdf";
            //sets up a connection to the database
            connectionInfo = String.Format(@"
                            Data Source = (LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Integrated Security=True;", version, filename);

            //open the connection
            dataBase = new SqlConnection(connectionInfo);
            dataBase.Open();

            //get the whole table as a string and order it alphabetically by name
            string top10 = string.Format(@"
                Select Top(10) Names.Name, ID.StationID, Sum(DailyTotal) as Total
                From Riderships as ID
                INNER JOIN Stations as Names 
                ON ID.StationID = Names.StationID
                Group by Names.Name, ID.StationID
                Order by Total DESC
            ");

            //create an sql command and set the connection
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dataBase;

            //create an adapter to represent the command
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();

            cmd.CommandText = top10;
            adapter.Fill(dataSet);

            //populate the list box with station names
            foreach (DataRow row in dataSet.Tables["TABLE"].Rows){
                string station = string.Format("{0}",
                    Convert.ToString(row["Name"]));
                this.stationsListBox.Items.Add(station);
            }

            numStationsTextBox.Text += 10;

            //close the connection
            dataBase.Close();


        }//end top10Button_Click(...)

        //button that clears all objects
        private void Reset_Click(object sender, EventArgs e){
            resetObjectsAll();
        }//end Reset_Click(...)
    }
}
