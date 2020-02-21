using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace Assignment5

{
    public partial class teamBuilder : Form
    {
        readonly static string[] events = { "Murder Mystery Weekend", "CSI Weekend", "The Great Outdoors", "The Chase", "Digital Refresh", "Action Photography", "Team Ryder Cup", "Abseiling", "War Games", "Find Wally"}; //string array for event names

        readonly static int[] eventDays = { 2, 3, 4, 6, 2, 5, 3, 2, 6, 5 }; //integer array for number of event days

        readonly static decimal[] eventFees = { 600m, 1000m, 1500m, 1800m, 599m, 999m, 619m, 499m, 1999m, 799m}; //decimal array for event registration fee

        readonly static string[] location = { "Cork", "Dublin", "Galway", "Bellmullet", "Belfast"}; //string array for locations

        readonly static decimal[] lodgoingfees = { 250m, 165m, 225m, 305m, 95m }; //decimal array for lodging fees

        readonly static string[] meal = { "Full", "Half", "Breakfast", "None"}; //string array meal types

        readonly static decimal[,] costOfLodging = {
                                                    { 1100m,930m,1050m,1210m,790m},
                                                    { 1750m,1495m,1675m,1915m,1285m},
                                                    { 2500m,2160m,2400m,2720m,1880m},
                                                    { 3300m,2790m,3150m,3630m,2370m},
                                                    { 1099m,929m,1049m,1209m,789m},
                                                    { 2249m,1824m,2124m,2524m,1474m},
                                                    { 1369m,1114m,1294m,1534m,904m},
                                                    { 999m,829m,949m,1109m,689m},
                                                    { 3499m,2989m,3349m,3829m,2569m},
                                                    { 2049m,1624m,1924m,2324m,1274m},
                                                    };                                  //2D decimal array for cost of particular event at particular location
        
        readonly static decimal[,] CostOfMeal = {
                                                { 99m,75m,24m,0m},
                                                { 149m,113m,36m,0m},
                                                { 198m,150m,48m,0m},
                                                { 297m,225m,72m,0m},
                                                { 99m,75m,24m,0m},
                                                { 248m,188m,60m,0m},
                                                { 149m,113m,36m,0m},
                                                { 99m,75m,24m,0m},
                                                { 297m,225m,72m,0m},
                                                { 248m,188m,60m,0m},
                                                };                                      //2D decimal array for places availability for particular event at particular location

        

        string eventName, locationName,mealType,transactionNumber, transactionNumber1, detailsBlock, completeBlock,totalDetailsBlock,currentDate,line;
        decimal totalCostOfLodging = 0m,theMealCost,totalcost,totalOrderCost;
        int numberOfPlaces;
        string placesPath = "Places.txt",inputPlaces;
        string formattedReportPath = "PlacesAvailableReport.txt";
        int[,] actualPlaces = new int[10, 5];
        // int[,] actualPlacesCopy = new int[10,5];
        int[,] actualPlacesCopy = new int [10,5];
        Boolean confirmClicked = false;
        string nameOfEvents = "Murder Mystery Weekend, CSI Weekend, The Great Outdoors, The Chase, Digital Refresh, Action Photography, Team Ryder Cup, Abseiling, War Games, Find Wally";
        string nameOfPlaces = "Cork, Dublin, Galway, Bellmullet, Belfast";
        string path;

        ListViewItem element = new ListViewItem(); //Listview object to display order details in listview

        Random r = new Random(); // to create random number
        int randNum;

        public static Regex re = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                                               RegexOptions.CultureInvariant | RegexOptions.Singleline); // regular expression 


        public teamBuilder()
        {
            InitializeComponent();
        }

        private void eventListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void locationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            eventListBox_SelectedIndexChanged(sender, e);
        }


        private void mealListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            eventListBox_SelectedIndexChanged(sender, e);
        }

        private void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)  //this check is to make sure that user enters only numeric values in the number of places textbox
            {
                e.Handled = true;
            }

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();

            randNum = r.Next(1000000); //generating random number
            transactionNumber = randNum.ToString("D6"); //parsing intger random number into string

            

            if (File.Exists(path)) //to check if order details file already exists
            {
                System.IO.StreamReader file = new System.IO.StreamReader(path);

                while ((line = file.ReadLine()) != null) //to check the end of file
                {
                    if (line.Contains("Transaction Number")) //to check if line contains Transaction Number
                    {
                        string fileTransactionNumbers = Regex.Match(line, @"\d+").Value; //regular expression to store only numeric value from line 
                        if (fileTransactionNumbers == transactionNumber) //to check if generated transaction number already exists in file
                        {
                            //Random r1 = new Random();
                            int randNum = r.Next(1000000);
                            transactionNumber = randNum.ToString("D6");
                        }

                    }
                    
                }
                file.Close();

                dialogResult = MessageBox.Show("Transaction Number : " + transactionNumber.ToString() + "\n" + completeBlock + "\n\nTotal Order Cost : " + totalOrderCost.ToString("C") + "\nWould you like to confirm the order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information); //to display order details

                if (dialogResult == DialogResult.Yes)
                {
                    confirmClicked = true;
                    DialogResult dialog = MessageBox.Show("Your order has been placed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog == DialogResult.OK)
                    {
                        //to hide irrelevant controls
                        detailsListView.Visible = false;
                        detailsListView.Items.Clear();
                        /*element.Remove();
                        detailsListView.Clear();*/
                        confirmButton.Visible = false;
                        oderDetailsLabel.Visible = false;

                        totalDetailsBlock = "Transaction Number : " + transactionNumber +"\n" + totalDetailsBlock +"\n"+ completeBlock; //adding complete order details in a string
                    }
                    transactionNumber = "";
                    completeBlock = "";
                }
                else
                {

                }
            }

            else
            {
                dialogResult = MessageBox.Show("Transaction Number : " + transactionNumber.ToString() + "\n" + completeBlock + "\n\nTotal Order Cost : " + totalOrderCost.ToString("C") + "\nWould you like to confirm the order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    confirmClicked = true;
                    DialogResult dialog = MessageBox.Show("Your order has been placed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog == DialogResult.OK)
                    {
                        detailsListView.Visible = false;
                        detailsListView.Items.Clear();
                        //element.Remove();
                        //detailsListView.Clear();
                        confirmButton.Visible = false;
                        oderDetailsLabel.Visible = false;

                        totalDetailsBlock = "Transaction Number : "+transactionNumber + "\n" + totalDetailsBlock +"\n"+ completeBlock;
                    }
                    transactionNumber = "";
                    completeBlock = "";
                }
                else
                {

                }
            }

        }

        private void eventListBox_Click(object sender, EventArgs e)
        {
            eventName = events[eventListBox.SelectedIndex]; //getting the event name from array

            eventNameTextBox.Text = eventName; //displaying event name in textbox
            if (locationListBox.SelectedIndex != -1 && mealListBox.SelectedIndex != -1)
            {
                //calculating lodging,meal costs based on selections
                totalCostOfLodging = costOfLodging[eventListBox.SelectedIndex, locationListBox.SelectedIndex];
                theMealCost = CostOfMeal[eventListBox.SelectedIndex, mealListBox.SelectedIndex];
                totalcost = totalCostOfLodging + theMealCost;
                totalEventPriceTextBox.Text = totalcost.ToString("C");
            }

        }

        private void locationListBox_Click(object sender, EventArgs e)
        {
            

            if (eventListBox.SelectedIndex == -1) //to check if event is selected first
            {
                MessageBox.Show("Please select Event first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                locationListBox.ClearSelected();
                
            }

            else
            {
                locationName = location[locationListBox.SelectedIndex]; //getting location name from array
                totalCostOfLodging = costOfLodging[eventListBox.SelectedIndex, locationListBox.SelectedIndex];
                totalcost = totalCostOfLodging + theMealCost;

                
                totalEventPriceTextBox.Text = totalcost.ToString("C"); //displaying location name in textbox
                locationNameTextBox.Text = locationName;
            }   
        }

        private void mealListBox_Click(object sender, EventArgs e)
        {
            mealType = meal[mealListBox.SelectedIndex];
            
            if (eventListBox.SelectedIndex == -1) //to check if event is selected first
            {
                MessageBox.Show("Please select Event first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mealListBox.ClearSelected();
            }

            else if (locationListBox.SelectedIndex == -1) //to check if location is selected first
            {  
                MessageBox.Show("Please select Location first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mealListBox.ClearSelected();
            }

            else
            {
                mealTextBox.Text = mealType; //displaying meal type in textbox
                theMealCost = CostOfMeal[eventListBox.SelectedIndex, mealListBox.SelectedIndex]; //getting the meal cost for selected event
                totalcost = totalCostOfLodging + theMealCost;
                totalEventPriceTextBox.Text = totalcost.ToString("C");
            }
            
        }

        private void bookingButton_Click(object sender, EventArgs e)
        {
            


            if (eventListBox.SelectedIndex != -1) //to check if any event is selected
            {
                if(locationListBox.SelectedIndex != -1) //to check if any location is selected
                {
                    if (!string.IsNullOrWhiteSpace(quantityTextBox.Text)) //to check if number of places textbox is not null
                    {
                        numberOfPlaces = Int32.Parse(quantityTextBox.Text);
                        if(numberOfPlaces <= 0) 
                        {
                            MessageBox.Show("Please enter valid number of places");
                            quantityTextBox.Clear();
                            quantityTextBox.Focus();
                        }
                        else if(numberOfPlaces >0 && numberOfPlaces <= actualPlacesCopy[eventListBox.SelectedIndex, locationListBox.SelectedIndex]) //to check if number of places entered is greater than 0 and less than or equal to available places
                        {
                            decimal finalCost = decimal.Parse(quantityTextBox.Text) * totalcost; //calculating final cost
                            totalOrderCost = totalOrderCost + finalCost;
                            DialogResult dialogResult = MessageBox.Show("Event Added Successfully", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //MessageBox.Show("successfull");
                            if (dialogResult == DialogResult.OK)
                            {
                                actualPlacesCopy[eventListBox.SelectedIndex, locationListBox.SelectedIndex] = actualPlacesCopy[eventListBox.SelectedIndex, locationListBox.SelectedIndex] - int.Parse(quantityTextBox.Text); //subtracting number of places entered from available places
                                quantityTextBox.Clear();


                                //adding below are the event details in listview 
                                element = new ListViewItem(eventName);
                                //element.SubItems.Add(eventName);
                                element.SubItems.Add(locationName);
                                element.SubItems.Add(mealType);
                                element.SubItems.Add(numberOfPlaces.ToString());
                                element.SubItems.Add(finalCost.ToString("C"));
                                detailsListView.Items.Add(element);
                                

                                
                                string detailsBlock = "Event Name : "+eventName +
                                                      "\nLocation : " + locationName +
                                                      "\nMeal Type : " + mealType +
                                                      "\nNumber of Places : " + numberOfPlaces +
                                                      "\nTotal Event Price : " + finalCost.ToString("C"); //storing order details in string
                                                                 
                                resetAll(); //reset the selections

                                if (!string.IsNullOrEmpty(completeBlock))
                                {
                                    completeBlock = completeBlock + "\n" + detailsBlock;  
                                }
                                else
                                {
                                    completeBlock = completeBlock + detailsBlock;
                                }
                                detailsListView.Visible = true;
                                confirmButton.Visible = true;
                                oderDetailsLabel.Visible = true;
                            }
                           
                            eventName = "";
                            locationName = "";
                            mealType = "";
                            numberOfPlaces = 0;
                            finalCost = 0m;
                            detailsBlock= "";
                        }

                        else
                        {
                            if (actualPlacesCopy[eventListBox.SelectedIndex, locationListBox.SelectedIndex] == 0)
                            {
                                MessageBox.Show("Sorry, No places are available for the event at this location.");
                                quantityTextBox.Clear();
                                quantityTextBox.Focus();
                            }
                            else
                            {
                                MessageBox.Show("only " + actualPlacesCopy[eventListBox.SelectedIndex, locationListBox.SelectedIndex] + " places are left");
                                quantityTextBox.Clear();
                                quantityTextBox.Focus();
                            }
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Please enter number of places you wish to book", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        quantityTextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please select any location", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select any event", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void resetAll() //to reset the selections
        {
            eventListBox.ClearSelected();
            locationListBox.ClearSelected();
            mealListBox.ClearSelected();
            quantityTextBox.Clear();
            eventNameTextBox.Clear();
            locationNameTextBox.Clear();
            mealTextBox.Clear();
            totalEventPriceTextBox.Clear();
        }

        public void teamBuilder_Load(object sender, EventArgs e)
        {
            detailsListView.Visible = false;
            confirmButton.Visible = false;
            oderDetailsLabel.Visible = false;


            inputPlaces = File.ReadAllText(placesPath);
            int i = 0, j = 0;
            
            foreach(var row in inputPlaces.Split('\n'))  //to read value from text file and storing it in an 2D array
            {
                if (row.Length > 0)
                {
                    j = 0;
                    foreach (var col in row.Trim().Split(','))
                    {
                        actualPlaces[i, j] = int.Parse(col.Trim());
                        j++;
                    }
                    i++;
                }
            }

            //int[,] actualPlacesCopy = actualPlaces.Clone() as int[,];
            Array.Copy(actualPlaces, 0, actualPlacesCopy, 0, actualPlaces.Length); //creating a copy of an array taken from text file
        }

        private void clearButton_Click(object sender, EventArgs e) 
        {
            resetAll(); //to clear selections and inputs
        }

        private void writeOrderDetailsFile()
        {
            if (confirmClicked)
            {
                StreamWriter outputFile;
                DateTime dateTime = DateTime.Today;
                string toDaysDate = DateTime.Today.ToString("dd-MM-yyyy");
                path = "Booking Details " + toDaysDate + ".txt"; //to write a file with todays date

                if (detailsListView.Items.Count == -1)
                {
                    this.Close();
                }
                else
                {
                    //below we are writing order details to file
                    outputFile = File.AppendText(path);
                    outputFile.WriteLine("ORDER_START");
                    //outputFile.WriteLine("Transaction Number : "+transactionNumber);
                    outputFile.WriteLine(totalDetailsBlock);
                    outputFile.WriteLine("ORDER_END");
                    outputFile.Close();
                }
            }
        }

        private void writePlacesCountFile()
        {
            StreamWriter outputFilePlaces = File.CreateText(placesPath);
            outputFilePlaces.Flush(); //to clear content in already existing file
            outputFilePlaces.Close(); 

            if (confirmClicked) //if confirm button is clicked we are writing updated available places array to a file
            {
                int row = actualPlacesCopy.GetLength(0);
                int col = actualPlacesCopy.GetLength(1);

                for (int a = 0; a < row; a++)
                {
                    for (int b = 0; b < col; b++)
                    {
                        if (b == 0)
                        {
                            outputFilePlaces = File.AppendText(placesPath);
                            outputFilePlaces.Write(actualPlacesCopy[a, b]);
                            outputFilePlaces.Close();

                        }
                        else
                        {
                            outputFilePlaces = File.AppendText(placesPath);
                            outputFilePlaces.Write("," + actualPlacesCopy[a, b]);
                            outputFilePlaces.Close();
                        }
                    }
                    outputFilePlaces = File.AppendText(placesPath);
                    outputFilePlaces.WriteLine();
                    outputFilePlaces.Close();
                }
            }


            else //to write original available places array to a file if confirm button is not clicked
            {
                int rows = actualPlaces.GetLength(0);
                int cols = actualPlaces.GetLength(1);

                for (int a = 0; a < rows; a++)
                {
                    for (int b = 0; b < cols; b++)
                    {
                        if (b == 0)
                        {
                            outputFilePlaces = File.AppendText(placesPath);
                            outputFilePlaces.Write(actualPlaces[a, b]);
                            outputFilePlaces.Close();

                        }
                        else
                        {
                            outputFilePlaces = File.AppendText(placesPath);
                            outputFilePlaces.Write("," + actualPlaces[a, b]);
                            outputFilePlaces.Close();
                        }
                    }
                    outputFilePlaces = File.AppendText(placesPath);
                    outputFilePlaces.WriteLine();
                    outputFilePlaces.Close();
                }

            }
        }

        private void writeFormattedReport()
        {
            StreamWriter outputFilePlaces = File.CreateText(formattedReportPath);
            outputFilePlaces.Flush(); //to clear content in already existing file
            outputFilePlaces.Close();

            if (confirmClicked) //if confirm button is clicked we are writing updated available places to a file
            {
                outputFilePlaces = File.AppendText(formattedReportPath);
                outputFilePlaces.WriteLine("Name of Event :- Location1 - Number of places available, Location2 - Number of places available...\n");
                outputFilePlaces.Close();
                for (int a = 0; a < 10; a++)
                {
                    outputFilePlaces = File.AppendText(formattedReportPath);
                    outputFilePlaces.Write((a + 1) + "." + events[a] + " :- ");
                    outputFilePlaces.Close();
                    for (int b = 0; b < 5; b++)
                    {
                        if (b == 0)
                        {
                            outputFilePlaces = File.AppendText(formattedReportPath);
                            outputFilePlaces.Write(location[b] + " - " + actualPlacesCopy[a, b]);
                            outputFilePlaces.Close();

                        }
                        else
                        {
                            outputFilePlaces = File.AppendText(formattedReportPath);
                            outputFilePlaces.Write(", " + location[b] + " - " + actualPlacesCopy[a, b]);
                            outputFilePlaces.Close();
                        }
                    }
                    outputFilePlaces = File.AppendText(formattedReportPath);
                    outputFilePlaces.WriteLine("\n");
                    outputFilePlaces.Close();
                }
            }

            else //writing original available places if confirm button is not clicked
            {
                outputFilePlaces = File.AppendText(formattedReportPath);
                outputFilePlaces.WriteLine("Name of Event :- Location1 - Number of places available, Location2 - Number of places available...\n");
                outputFilePlaces.Close();
                for (int a = 0; a < 10; a++)
                {
                    outputFilePlaces = File.AppendText(formattedReportPath);
                    outputFilePlaces.Write((a + 1) + "." + events[a] + " :- ");
                    outputFilePlaces.Close();
                    for (int b = 0; b < 5; b++)
                    {
                        if (b == 0)
                        {
                            outputFilePlaces = File.AppendText(formattedReportPath);
                            outputFilePlaces.Write(location[b] +" - "+ actualPlaces[a, b]);
                            outputFilePlaces.Close();

                        }
                        else
                        {
                            outputFilePlaces = File.AppendText(formattedReportPath);
                            outputFilePlaces.Write(", " + location[b] + " - " + actualPlaces[a, b]);
                            outputFilePlaces.Close();
                        }
                    }
                    outputFilePlaces = File.AppendText(formattedReportPath);
                    outputFilePlaces.WriteLine("\n");
                    outputFilePlaces.Close();
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            writeOrderDetailsFile(); //writing order details to file
            writePlacesCountFile();  //writing number of places available to file
            writeFormattedReport();  //writing formatted report of number of places available to file
            this.Close();
        }

        
    }

}
